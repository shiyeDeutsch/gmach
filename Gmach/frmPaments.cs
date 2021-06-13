using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class frmPaments : Form
    {
        CurrencyManager cm1;
        DataSet ds;// = new DataSet();
        DataGridView dg;
        Payments_BL oPayments_BL = new Payments_BL();
        Loans_BL oLoans_BL = new Loans_BL();
        int PaymentId;
        int LoanID;
        public frmPaments(int LoanID, int PaymentId, ref DataGridView dg)
        {
            this.dg = dg;
            this.LoanID = LoanID;
            this.PaymentId = PaymentId;
            InitializeComponent();
        }
        private void frmPaments_Load(object sender, EventArgs e)
        {
            ds = oPayments_BL.GetPaymentAllDetails(PaymentId);

            textNumOfPament.DataBindings.Add("Text", ds.Tables[0], "NumOfPayment");
            textGeneralAmountToPay.DataBindings.Add("Text", ds.Tables[0], "PaymentAmount");
            textAmountPaing.DataBindings.Add("Text", ds.Tables[0], "AmountPaid");
            textBalanceToPay.DataBindings.Add("Text", ds.Tables[0], "BalanceToPay");
            controlerDate1.DataBindings.Add("TextDate", ds.Tables[0], "PaydDate");


            cm1 = (CurrencyManager)this.BindingContext[ds];
            cm1.Position = 1;
           

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            oPayments_BL.UpdatePayment(ds, Convert.ToInt16(textAmountPaing.Text));
            oLoans_BL.UpdateLoansBalance(ds);
            dg.DataSource = oLoans_BL.getLoanDetailsQ(LoanID);
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            textBalanceToPay.ReadOnly = false;
        }
    }
}