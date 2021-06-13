using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class CreateMembers : Form
    {
        BaseDAL oDal = new BaseDAL();
        DataSet ds;
        public CreateMembers()
        {
            InitializeComponent();
        }
        
        protected void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool flag=true;
            if (textBoxName.Text == "" & flag)
            {
                MessageBox.Show("נא למלאות שם פרטי");
                flag = false;
            }


            if (textBoxFamily.Text == "" & flag)
            {
                flag = false;
                MessageBox.Show(" נא למלאות שם משפחה");
            }


            if (textBoxFtherName.Text == "" & flag)
            {
                MessageBox.Show("נא למלאות שם האב");
                flag = false;
            }


            if (textBoxIdNum.Text == "" & flag)
            {
                MessageBox.Show("נא למלאות מספר זהות");
                flag = false;
            }


            if (textBoxCity.Text == "" & flag)
            {
                MessageBox.Show("נא למלאות עיר");
                flag = false;
            }


            if (textBoxAddress.Text == "" & flag)
                
            {
                MessageBox.Show("נא למלאות רחוב");
                flag = false;
            }


            if (textBoxTell1.Text == "" & flag)
            {
                MessageBox.Show("נא למלאות טלפון");
                flag = false;
            } 

            if(flag)
            {
                textBoxName.Text = isTheTextCorrect(textBoxName.Text);
                string Sql = "insert into Members(Name,Family,FatherNeme,IdNum, City ,Address,ZipCode,Tel1,Tel2,EmailAddress)values('" + textBoxName.Text + "','" + textBoxFamily.Text + "','" + textBoxFtherName.Text + "','" + textBoxIdNum.Text + "','" + textBoxCity.Text + "','" + textBoxAddress.Text + "','" + textBoxZipCode.Text + "','" + textBoxTell1.Text + "','" + textBoxTell2.Text + "','" + textBoxEmailAddress.Text + "')";
                oDal.RunCommand(Sql, false);
                this.Close();
            }
        }
        private void CreateMembers_Load(object sender, EventArgs e)
        {
            textBoxName.DataBindings.Add("Text", "sd", "Name");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string isTheTextCorrect(string str)
        {
            string string1 = str;
           string1= string1.Replace("'", "''");
            return
                string1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}