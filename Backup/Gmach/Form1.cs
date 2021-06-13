using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class Form1 : Form
    {
        BaseDAL oDAL = new BaseDAL();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            froLogIn fli = new froLogIn();
            fli.ShowDialog();
            if (!fli.GetIsLogIn())
                this.Close();
        }
        private void Members_Click(object sender, EventArgs e)
        {
        
        }
        private void createAMember_Click(object sender, EventArgs e)
        {
            Form createAMember = new CreateMembers();
            createAMember.Show();
        }
        public void Payments_Click(object sender, EventArgs e)
        {
            CreateALoans createLoans = new CreateALoans();
            createLoans.Show();
        }
       
        private void Tracking_Click(object sender, EventArgs e)
        {
            frmLoans oFrmLoans = new frmLoans();
            oFrmLoans.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports frmReports1 = new frmReports();
            frmReports1.Show();
        }

        
    }
}