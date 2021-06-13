using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class memberLeble : Form
    {
        public memberLeble(int IDMember)
        {
            this.IDMember = IDMember;
            InitializeComponent();
        }
        
        int IDMember;
        DataSet ds = new DataSet();
        PersonalDetails_BL oPersonalDetails_BL = new PersonalDetails_BL();
        Loans_BL oLoans_BL = new Loans_BL();
        Payments_BL oPayments_BL = new Payments_BL();
        private void memberLeble_Load(object sender, EventArgs e)
        {
            ds.Merge(oPersonalDetails_BL.getPersonalDetails1(IDMember));
            txtFullName.DataBindings.Add("Text",ds.Tables[0],"FullName");
        }
    }
}