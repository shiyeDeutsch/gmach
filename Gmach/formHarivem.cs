using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class formHarivem : Form
    {
        DataGridView dataGridView = new DataGridView();
        DataTable selectedHrivim = new DataTable();
        DataTable dt = new DataTable();
        BaseDAL oDAL = new BaseDAL();
        public formHarivem(ref  DataGridView DataGridView1)
        {

            dataGridView = DataGridView1;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formHarivem_Load(object sender, EventArgs e)
        {
            DataGridViewColumn dataGridView2 = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(dataGridView2);
            dataGridView1.Columns[0].Name = "choose";
            dataGridView1.Columns[0].HeaderText = "בחר ערב";

            DataSet ds = new DataSet();
            ds = oDAL.GetData("Select שם =Name+' '+Family, [שם האב]=FatherNeme, כתובת=City + ' '+Members.Address,[מספר חבר]=Members.MemberID from  Members ");
            dataGridView1.DataSource = ds.Tables[0];
            selectedHrivim = ds.Tables[0].Clone();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridViewDataErrorContexts Contexts = new DataGridViewDataErrorContexts();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {

                if (dataGridView1[0, i].GetEditedFormattedValue(i, Contexts).ToString().Length >= textBox1.Text.Length)
                {
                    if (dataGridView1[0, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textBox1.Text.Length) != textBox1.Text)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    if (dataGridView1[0, i].GetEditedFormattedValue(i, Contexts).ToString().Substring(0, textBox1.Text.Length) == textBox1.Text)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = true;
                        currencyManager1.ResumeBinding();
                    }
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[0, i].GetEditedFormattedValue(i, 0).Equals(Boolean.Parse("true")))
                    selectedHrivim.Rows.Add(dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value);
            }

            dataGridView.DataSource = selectedHrivim;
            this.Close();
        }

        public DataTable GetChecked()
        {
            return selectedHrivim;

        }
    }
}