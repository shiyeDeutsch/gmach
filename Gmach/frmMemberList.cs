using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class frmMemberList : Form
    {
        BaseDAL oDAL = new BaseDAL();
        public frmMemberList()
        {
            InitializeComponent();
        }

        private void frmMemberList_Load(object sender, EventArgs e)
        {
            
            DataSet ds1 = oDAL.GetData("EXEC MY_PROCEDURE ");
            dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}