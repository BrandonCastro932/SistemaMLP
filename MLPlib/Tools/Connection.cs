using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPlib.Tools
{
    class Connection
    {
        String CnnStr { get; set; }

        public List<SqlParameter> Parameters = new List<SqlParameter>();
        public int DMLUpdateDeleteInsert(String SPName)
        {
            int Return = 0;

            using (SqlConnection Cnn = new SqlConnection(CnnStr))

            {
                SqlCommand cmd = new SqlCommand(SPName, Cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }

                Cnn.Open();

                //Si el comando a ejecutar en un DML (update, Insert o delete) 
                //establecer SET NOCOUNT OFF; en el SP 

                Return = cmd.ExecuteNonQuery();
            }

            return Return;
        }

        public DataTable DMLSelect(String SPName, bool LoadSchemaTable = false)
        {
            DataTable Return = new DataTable();

            using (SqlConnection Cnn = new SqlConnection(CnnStr))
            {
                SqlCommand Cmd = new SqlCommand(SPName, Cnn);
                Cmd.CommandType = CommandType.StoredProcedure;
                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        Cmd.Parameters.Add(item);
                    }
                }
                SqlDataAdapter Adapter = new SqlDataAdapter(Cmd);

                if (LoadSchemaTable)
                {
                    Adapter.FillSchema(Return, SchemaType.Source);
                }
                else
                {
                    Adapter.Fill(Return);
                }
            }
            return Return;
        }

        public Object DMLEscalarReturn(String SPName)
        {
            Object Return = null;
            using (SqlConnection Cnn = new SqlConnection(CnnStr))

            {
                SqlCommand Cmd = new SqlCommand(SPName, Cnn);
                Cmd.CommandType = CommandType.StoredProcedure;

                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        Cmd.Parameters.Add(item);
                    }
                }
                Cnn.Open();
                Return = Cmd.ExecuteScalar();
            }

            return Return;
        }

        public Connection()
        {
            this.CnnStr = ConfigurationManager.ConnectionStrings["CNNSTR"].ToString();
        }


    }
}

