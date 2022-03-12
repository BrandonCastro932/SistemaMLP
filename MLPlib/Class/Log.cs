using System;
using System.Data;

namespace MLPlib.Class
{
    public class Log
    {
        public int IDLog { get; set; }
        public int IDUser { get; set; }
        public string LogMsg { get; set; }
        public DateTime RegDate { get; set; }

        public Log()
        {
        }

        public DataTable GetLog()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.LogTableAdapter logTableAdapter = new SistemaMLPDataSetTableAdapters.LogTableAdapter();

            logTableAdapter.Fill(sistemaMLPDataSet.Log);
            return sistemaMLPDataSet.Log;
        }

    }
}