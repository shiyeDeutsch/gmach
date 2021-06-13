using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class CreateALoans : Form
    {
        public CreateALoans()
        {
            InitializeComponent();
        }
        DataTable dtTemp = new DataTable();
        int LoanReasonID = 0;
        BaseDAL oDAL = new BaseDAL();
        System.Drawing.Size size = new Size();
        System.Drawing.Size size1 = new Size();
        DataTable dt = new DataTable();
        private static double GetNumOfOnePayment(double LoanAmount, double NumMonthPayments)
        {
            double NomOfOnePayment = Math.Round((LoanAmount / NumMonthPayments), 2);

            return NomOfOnePayment;
        }
        private void CreateALoans_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            ds = oDAL.GetData("select * from LoanReasons");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                combLoanReasons.Items.Add(ds.Tables[0].Rows[i][1]);
            string Sql = "select " +
                "[שם]=Name+' '+Family," +
                "[שם האב]=FatherNeme," +
                "[מ.זהות]=IdNum," +
                "[כתובת]=City+Address," +
                "[טלפון]=Tel1" +
               " from Members";
            ds1 = oDAL.GetData(Sql);
            dataGridMembers.DataSource = ds1.Tables[0];
            dataGridMembers.Columns[2].Visible = false;
        }
        private void combLoanReasons_Validated(object sender, EventArgs e)
        {

            LoanReasonID = combLoanReasons.SelectedIndex + 1;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textIdNum.Text != "")
            {
                if (textAmountOfOnePayment.Text != "")
                {
                    DataSet ds = new DataSet();
                    DataSet ds1 = new DataSet();

                    ds = oDAL.GetData("select MemberID from Members where IdNum='" + textIdNum.Text + "'");
                    if (ds.Tables[0].Rows.Count < 1)
                        MessageBox.Show("לא נמצא חבר קיים");
                    else
                    {

                        string loantSqlString = "insert into Loans"
                            + "(MemberID,LoanDate,LoanAmount,NumOfPayments, Payments,LoanReason,Balance)values("
                            + ds.Tables[0].Rows[0]["MemberID"]
                            + ",'" + dateLoant.GetDate.ToShortDateString()
                            + "'," + textLoantAmount.Text + ","
                            + textNumOfPayments.Text
                            + "," + textAmountOfOnePayment.Text
                            + "," + LoanReasonID.ToString() +
                            "," + textLoantAmount.Text + ")";

                        int loantId = oDAL.RunCommandWithID(loantSqlString, false);
                        int NumOfPayments = int.Parse(textNumOfPayments.Text.ToString());
                        for (int i = 0; i < NumOfPayments; i++)
                        {
                            string paymentsSqlString = "insert into Payments" +
                             "(LoanID,PayDate,AmountPaid,IsPaid" +
                             ",NumOfPayment,PaydDate,PaymentAmount" +
                             ")values(" +
                                   loantId +
                                   ",'" + dateOfFirstPayment.GetDate.AddMonths(i).Date +
                                   "','0.00'" +
                                   ",0," +
                                   (i + 1) +
                                   ",null," +
                                   textAmountOfOnePayment.Text + ")";
                            oDAL.RunCommand(paymentsSqlString, false);
                        }
                        for (int i = 0; i < dgvSelectedHarivem.Rows.Count; i++)
                        {
                            string hrivimSqlstr = "insert into Harivem values (" + loantId.ToString() + "," + dgvSelectedHarivem.Rows[i].Cells[3].Value + ")";
                            oDAL.RunCommand(hrivimSqlstr, false);
                        }
                        this.Close();
                    }
                }


                else
                {
                    MessageBox.Show("נא למלאות סכום הלואה");
                }
            }
            else
            {
                MessageBox.Show("נא לבחור חבר");
            }
        }
        private void textLoantAmount_TextChanged(object sender, EventArgs e)
        {
            double f1;
            double f2;
            if (textLoantAmount.Text == "")
                textAmountOfOnePayment.Text = "";
            if (textNumOfPayments.Text != "" && textLoantAmount.Text != "")
            {
                f1 = double.Parse(textLoantAmount.Text.ToString());
                f2 = double.Parse(textNumOfPayments.Text.ToString());
                textAmountOfOnePayment.Text = (GetNumOfOnePayment(f1, f2).ToString());
            }
        }
        private void textNumOfPayments_TextChanged(object sender, EventArgs e)
        {
            if (textNumOfPayments.Text == "")
                textAmountOfOnePayment.Text = "";
            double f1;
            double f2;
            if (textNumOfPayments.Text != "" && textLoantAmount.Text != "")
            {
                f1 = double.Parse(textLoantAmount.Text.ToString());
                f2 = double.Parse(textNumOfPayments.Text.ToString());
                textAmountOfOnePayment.Text = (GetNumOfOnePayment(f1, f2).ToString());
            }
        }
        //private void textSearch_TextChanged(object sender, EventArgs e)
        //{

        //DataGridViewDataErrorContexts Contexts = new DataGridViewDataErrorContexts();
        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //{

        //    if (dataGridView1[1, i].GetEditedFormattedValue(i, Contexts).ToString().Length >= textSearch.Text.Length)
        //    {
        //        if (dataGridView1[1, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textSearch.Text.Length) != textSearch.Text)
        //        {
        //            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
        //            currencyManager1.SuspendBinding();
        //            dataGridView1.Rows[i].Visible = false;
        //            currencyManager1.ResumeBinding();
        //        }
        //        if (dataGridView1[1, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textSearch.Text.Length) == textSearch.Text)
        //        {
        //            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
        //            currencyManager1.SuspendBinding();
        //            dataGridView1.Rows[i].Visible = true;
        //            currencyManager1.ResumeBinding();
        //        }
        //    }

        //  }
        //  }
        //private void tabPage2_Enter(object sender, EventArgs e)
        //{

        //    DataSet ds = new DataSet();
        //    DataTable dt1 = new DataTable();
        //    DataTable dt = new DataTable();
        //    ds = oDAL.GetData("Select שם =Name+' '+Family, [שם האב]=FatherNeme, כתובת=City + ' '+Members.Address,[מספר חבר]=Members.MemberID from  Members ");
        //    dataGridView1.DataSource = ds.Tables[0];
        //    dt = ds.Tables[0];
        //    //DataGridViewColumn[] dc1; ;
        //    //dc1 = new DataGridViewColumn();
        //    //dc1[]
        //    //  dataGridView1.Columns.CopyTo(dc1,1);
        //    //dgvSelectedHarivem.Columns.Add(dc); //(dataGridView1.Columns[0].ge);//., ds.Tables[0].Columns[1], ds.Tables[0].Columns[2], ds.Tables[0].Columns[3]);
        //    // dt = ds.Tables[0];
        //    dt1 = dt.Clone();
        //    dtTemp = dt.Clone();
        //    dgvSelectedHarivem.DataSource = dt1;
        //}
        private void textSearchMembers_TextChanged(object sender, EventArgs e)
        {

            if (textSearchMembers.Text != "")
            {
                size.Height = 335;
                size.Width = 467;
                groupBox3.Size = size;

            }

            if (textSearchMembers.Text == "")
            {
                size1.Height = 151;
                size1.Width = 467;
                groupBox3.Size = size1;
                dataGridMembers.Visible = false;
            }
            DataGridViewDataErrorContexts Contexts = new DataGridViewDataErrorContexts();
            for (int i = 0; i < dataGridMembers.Rows.Count; i++)
            {

                if (dataGridMembers[0, i].GetEditedFormattedValue(i, Contexts).ToString().Length >= textSearchMembers.Text.Length)
                {
                    if (dataGridMembers[0, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textSearchMembers.Text.Length) != textSearchMembers.Text)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridMembers.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridMembers.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                        dataGridMembers.Visible = true;
                    }
                    if (dataGridMembers[0, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textSearchMembers.Text.Length) == textSearchMembers.Text)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridMembers.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridMembers.Rows[i].Visible = true;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
        }
        private void dataGridMembers_DoubleClick(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataRow dr;
            DataRowView drv = (DataRowView)dataGridMembers.SelectedRows[0].DataBoundItem;
            dr = drv.Row;
            textName.Text = dr[0].ToString();
            textFatherName.Text = dr[1].ToString();
            textIdNum.Text = Text = dr[2].ToString();
            textSearchMembers.Text = "";
        }
        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < dataGridView1.Columns.Count; i++)
        //    {
        //        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
        //        {
        //            dtTemp.Rows.Add(dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value);
        //            dgvSelectedHarivem.DataSource = dtTemp;
        //        }
        //    }

        //}
        private void btnHrivim_Click(object sender, EventArgs e)
        {
            formHarivem formHarivem = new formHarivem(ref  dgvSelectedHarivem);
            formHarivem.Show();
        }
        private void btnMembresList_Click(object sender, EventArgs e)
        {
            frmMemberList o_frmMemberList = new frmMemberList();
            o_frmMemberList.Show();
        }
    }
}