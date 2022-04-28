using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace MLPlib.Class
{
    /// <summary>
    /// Al usar los datasets, toda la conexión a la base de datos se hace de forma automática por el .NET
    /// Simplemente de configurar los procedimientos almacenados a usar por cada tabla y usarlos como un método.
    /// </summary>
    public class User
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public DateTime RegDate { get; set; }
        public bool Active { get; set; }


        public User()
        {

        }

        public int CreateUser()
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPInsertUser(this.Username, EncriptarEnUnSentido(this.Pin));

            return result;
        }

        public int UpdateUser(string NewPin)
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPUpdateUser(this.IDUser, EncriptarEnUnSentido(this.Pin), EncriptarEnUnSentido(NewPin));

            return result;
        }

        public int DeleteUser()
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPDeleteUser(this.IDUser);

            return result;
        }

        public int RestoreUser()
        {
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            int result = (int)userTableAdapter.SPRestoreUser(this.IDUser);

            return result;
        }

        public DataTable LoginUser()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();

            DataTable data = new DataTable();
            userTableAdapter.LoginBy(sistemaMLPDataSet.User, EncriptarEnUnSentido(this.Pin));
            return sistemaMLPDataSet.User;
        }

        public DataTable GetUsers(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();


            userTableAdapter.FillByUsers(sistemaMLPDataSet.User,filter);
            return sistemaMLPDataSet.User;

        }
        public DataTable GetDeletedUsers(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.UserTableAdapter userTableAdapter = new SistemaMLPDataSetTableAdapters.UserTableAdapter();


            userTableAdapter.FillByDeleted(sistemaMLPDataSet.User, filter);
            return sistemaMLPDataSet.User;

        }

        //Cambiar a su propia clase
        public string EncriptarEnUnSentido(string Entrada)
        {

            SHA256CryptoServiceProvider ProveedorCrypto = new SHA256CryptoServiceProvider();

            //Descompone la cadenaDeEntrada en Bytes
            byte[] BytesDeEntrada = Encoding.UTF8.GetBytes(Entrada);

            //Usando los bytes de la cadena de entrada crea el Hash
            byte[] BytesConHash = ProveedorCrypto.ComputeHash(BytesDeEntrada);

            StringBuilder Resultado = new StringBuilder();

            //el for recorre cada byte del Hash y lo agrega a una cadena (stringbuilder)
            for (int i = 0; i < BytesConHash.Length; i++)
                Resultado.Append(BytesConHash[i].ToString("x2").ToLower());
            // el x2 lo que hace es poner los caracteres hexadecimales con cierto formato.

            return Resultado.ToString();

        }

    }
}
