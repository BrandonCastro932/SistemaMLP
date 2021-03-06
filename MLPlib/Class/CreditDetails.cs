using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;

namespace MLPlib.Class
{
    public class CreditDetails
    {
        public int IDCreditDetails { get; set; }
        public int IDReceipt { get; set; }
        public Decimal PreviousAmount { get; set; }
        public Decimal ActualAmount { get; set; }
        public Decimal NextAmount { get; set; }
        public DateTime RegDate { get; set; }

        public CreditDetails()
        {
            RegDate = DateTime.Now;
        }

        public int CreateCreditDetail()
        {
            SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter creditDetailAdapter = new SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter();

            int result = (int)creditDetailAdapter.SPInsertCreditDetail(this.IDReceipt, this.PreviousAmount, this.ActualAmount, this.NextAmount, this.RegDate);

            return result;
        }

        public decimal GetCreditsTotal()
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter creditDetailAdapter = new SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter();

            decimal i = Convert.ToDecimal(creditDetailAdapter.SPGetCreditsTotal());

            return i;
        }

        public DataTable GetCredits(string filter = "")
        {
            SistemaMLPDataSet sistemaMLPDataSet = new SistemaMLPDataSet();
            SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter creditDetailAdapter = new SistemaMLPDataSetTableAdapters.CreditDetailsTableAdapter();

            creditDetailAdapter.FillByCredit(sistemaMLPDataSet.CreditDetails, filter);
            return sistemaMLPDataSet.CreditDetails;
        }

        public ReportDocument PrintCredit(ReportDocument repo)
        {
            ReportDocument r = repo;
            Crystal crystal = new Crystal(r);
            DataTable data = new DataTable();
            CreditPayments creditPayments = new CreditPayments();
            creditPayments.IDCreditDetail = this.IDCreditDetails;

            data = creditPayments.PrintCredit();


            if (data != null && data.Rows.Count > 0)
            {
                crystal.Data = data;
                r = crystal.GenerateReport();
            }

            return r;
        }
    }
}