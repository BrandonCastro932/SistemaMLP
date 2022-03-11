using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPlib.Class
{
    public class CutTypes
    {
        public int IDCutType { get; set; }
        public string CutName { get; set; }
        public DateTime RegDate { get; set; }

        public CutTypes()
        {

        }

        public DataTable GetCutTypes()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesTableAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            cutTypesTableAdapter.Fill(sistemaMLPDataSet.CutTypes);
            return sistemaMLPDataSet.CutTypes;
        }
    }
}
