using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class ViewTheLoans : Form
    {
        PersonalDetails_BL oPersonalDetails_BL = new PersonalDetails_BL();
        Payments_BL oPayments_BL = new Payments_BL();
        Loans_BL oLoansBL = new Loans_BL();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        BaseDAL oDAL = new BaseDAL();
        int LoanID;
        int MemberID;
        int PaymentID;
        public ViewTheLoans(int MemberID, int LoanID)
        {
            this.MemberID = MemberID;
            this.LoanID = LoanID;
            InitializeComponent();
        }
        private void ViewTheLoans_Load(object sender, EventArgs e)
        {
            ds1.Merge(oPersonalDetails_BL.getPersonalDetails(MemberID));
            ds1.Merge(oLoansBL.getLoanDetailsQ(LoanID));
            ds1.Merge(oPayments_BL.GetPaymentsGaneralDetails(LoanID));
            textFirstName.DataBindings.Add("Text", ds1.Tables[0], "Name");
            textLastName.DataBindings.Add("Text", ds1.Tables[0], "Family");
            textFatherName.DataBindings.Add("Text", ds1.Tables[0], "FatherNeme");

            textBalance.DataBindings.Add("Text", ds1.Tables[1], "Balance");
            textLoantAmount.DataBindings.Add("Text", ds1.Tables[1], "LoanAmount");
            textNumOfPayments.DataBindings.Add("Text", ds1.Tables[1], "NumOfPayments");
            textLoanDate.DataBindings.Add("Text", ds1.Tables[1], "LoanDate");


            dataGridViewPayments.DataSource = ds1.Tables[2];
            // Get current Rowposition
            CurrencyManager cm1 = (CurrencyManager)this.BindingContext[ds1, "Members"];
            CurrencyManager cm2 = (CurrencyManager)this.BindingContext[ds1, "Loans"];

            cm1.Position = 1;
            cm2.Position = 1;
        }
        private void dataGridViewPayments_DoubleClick_1(object sender, EventArgs e)
        {
            PaymentID = (int.Parse(GrigSrevises.getCellDataFromDateGridViwe(dataGridViewPayments, 0)));
            frmPaments fp = new frmPaments(LoanID,PaymentID, ref dataGridViewPayments);
            fp.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
