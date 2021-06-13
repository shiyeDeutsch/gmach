using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class froLogIn : Form
    {

        bool IsLogIn;
        BaseDAL oDAL = new BaseDAL();
        public froLogIn( )
        {
               
            InitializeComponent();
        }
        private void froLogIn_Load(object sender, EventArgs e)
        {

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataSet ds = new DataSet();
            ds = oDAL.GetData("SELECT * FROM Users");
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[0][1].ToString() == textUserName.Text.ToString())
                {
                    if (dt.Rows[0][2].ToString() == textPassword.Text.ToString())
                    {
                        IsLogIn = true;
                        this.Close();
                    }
                }
                
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            IsLogIn = false;
            this.Close();
           
        }
        public  bool GetIsLogIn()
        {
            return IsLogIn;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            IsLogIn = true;
        }
        private void controlerDate1_testEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlerDate1_MyEvevt(object sender, EventArgs e)
        {
          
        }    
    }
}