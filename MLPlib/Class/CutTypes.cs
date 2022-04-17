using System;
using System.Data;

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

        public int CreateCutType()
        {
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            int result = (int)cutTypesAdapter.SPInsertCutType(this.CutName);

            return result;
        }

        public int UpdateCutType()
        {
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            int result = (int)cutTypesAdapter.SPUpdateCutType(this.IDCutType,this.CutName);

            return result;
        }

        public int DeleteCutType()
        {
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            int result = (int)cutTypesAdapter.SPDeleteCutType(this.IDCutType);

            return result;
        }

        public int RestoreCutType()
        {
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            int result = (int)cutTypesAdapter.SPRestoreCutType(this.IDCutType);

            return result;
        }

        public DataTable GetCutTypes()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesTableAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            cutTypesTableAdapter.GetCutTypes(sistemaMLPDataSet.CutTypes);
            return sistemaMLPDataSet.CutTypes;
        }

        public DataTable GetDeletedCutTypes()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CutTypesTableAdapter cutTypesTableAdapter = new SistemaMLPDataSetTableAdapters.CutTypesTableAdapter();

            cutTypesTableAdapter.GetDeletedCutTypes(sistemaMLPDataSet.CutTypes);
            return sistemaMLPDataSet.CutTypes;
        }
    }
}
