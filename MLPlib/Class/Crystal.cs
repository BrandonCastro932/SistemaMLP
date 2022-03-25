using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPlib.Class
{
    public class Crystal
    {
        public ReportDocument Report { get; set; }
        public DataTable Data { get; set; }

        public Crystal(ReportDocument pRpt)
        {
            Report = pRpt;
        }

        public Crystal()
        {
        }

        public ReportDocument GenerateReport()
        {
            if (Data.Rows.Count > 0)
            {
                Report.SetDataSource(Data);

                return Report;
            }
            else
            {
                return null;
            }
        }
    }
}
