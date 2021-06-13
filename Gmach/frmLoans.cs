using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class frmLoans : Form
    {
        BaseDAL oDAL = new BaseDAL();
        DataTable DTLoans = new DataTable();
        public frmLoans()
        {
            InitializeComponent();
        }
        private void frmLoans_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds = oDAL.GetData
                    (@"SELECT 
                             Loans.LoanId,
                             'שם מלוה'=Members.Name+' '+Members.Family,
                             'תאריך הלואה'=Loans.LoanDate,
                             'סכום הלואה'=loans.LoanAmount,
                             'יתרה לתשלום'=Loans.Balance,
                             Members.MemberID
                             from Loans 
                             left join Members on Loans.MemberID=Members.MemberID");
            DTLoans = ds.Tables[0];
            dgvLoans.DataSource = DTLoans;
            clsUtils.SetGridColNa(dgvLoans, 0);
            clsUtils.SetGridColNa(dgvLoans, 5);
            dgvLoans.Refresh();
        }
        private void dgvLoans_DoubleClick(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataRow dr;
            DataRowView drv = (DataRowView)dgvLoans.SelectedRows[0].DataBoundItem;
            dr = drv.Row;
            int LoanID = int.Parse(dr[0].ToString());
            int MemberID = int.Parse(dr[5].ToString());
            ViewTheLoans viewTheLoans = new ViewTheLoans(MemberID, LoanID);
            viewTheLoans.Show();
        }
        private void textSirech_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLoans.Rows.Count; i++)
            {
                if (textSirech.Text != DTLoans.Rows[i][1].ToString().Substring(0, textSirech.Text.Length))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvLoans.DataSource];
                    currencyManager1.SuspendBinding();
                    clsUtils.SetGridRowsNa(dgvLoans, i);
                    currencyManager1.ResumeBinding();
                    dgvLoans.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvLoans.DataSource];
                    currencyManager1.SuspendBinding();
                    clsUtils.SetGridRowsPo(dgvLoans, i);
                    currencyManager1.ResumeBinding();
                    dgvLoans.Visible = true;
                }
            }
        }
        private void checkBoxActiveLoans_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActiveLoans.Checked)
            {
                for (int i = 0; i < dgvLoans.Rows.Count; i++)
                    if (DTLoans.Rows[i][4].ToString() == "0")
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvLoans.DataSource];
                        currencyManager1.SuspendBinding();
                        clsUtils.SetGridRowsNa(dgvLoans, i);
                        currencyManager1.ResumeBinding();
                        dgvLoans.Visible = true;
                    }
            }
            else
            {
                for (int i = 0; i < dgvLoans.Rows.Count; i++)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvLoans.DataSource];
                    currencyManager1.SuspendBinding();
                    clsUtils.SetGridRowsPo(dgvLoans, i);
                    currencyManager1.ResumeBinding();
                    dgvLoans.Visible = true;
                }
            }
        }
    }
}