using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;


using System.Globalization;
using System.Runtime.Serialization;

namespace Gmach
{

    public delegate void MyDEl(string E_H);
    public partial class ControlerDate : UserControl
    {
        string str;
        frmCalendar oFrmCalendar;
        public ControlerDate()
        {

            InitializeComponent();
        }
        private void btnOpenDate_Click(object sender, EventArgs e)
        {
            try
            {
                oFrmCalendar = new frmCalendar( txtData, GetLocation());
                oFrmCalendar.Show();
            }
            catch (InalidDateException wsa)
            {
                MessageBox.Show("תאריך לא חוקי");
                txtData.Text = DateTime.Now.ToShortDateString();
            }
        }
        private void ControlerDate_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }
        private Point GetLocation()
        {
            Point p = new Point();
            Point PS = this.PointToScreen(p);
            return PS;
        }
        public DateTime GetDate
        {
            get
            {
                DateTime DateTime1 = oFrmCalendar.GetDate; //SetTime(txtData.Text);
                string s = DateTime1.Date.ToShortDateString();
                return DateTime1;
               
            }
            //set
            //{
            //    DateTime DateTime2=new DateTime();
            //    DateTime2.Add(TimeSpan.Parse(Convert.ToString(value)));
            //}
        }
        //private DateTime SetTime(string str)
        //{
        //    int index = 0;
        //    int[] Date = new int[3];

        //    for (int i = 0; i < txtData.Text.Length; i += 3)
        //    {

        //        Date[index] = int.Parse(str.Substring(i, 2));
        //        index++;
        //    }
        //    DateTime DateTime1 = new DateTime(Date[2], Date[0], Date[1]);

        //    return DateTime1;
        //}
        
        
        public string TextDate
        {

            set
            {
                txtData.Text = value;
            }
            get
            {
                return txtData.Text;
            }
        }

        private void txtData_Validated(object sender, EventArgs e)
        {
            try
            {
                oFrmCalendar = new frmCalendar(txtData, GetLocation());
                oFrmCalendar.SetDate();
            }
            catch (InalidDateException wsa)
            {
                MessageBox.Show("תאריך לא חוקי");
                txtData.Text = DateTime.Now.ToShortDateString();
            }
        }
        //public DateTime GetDate1
        //{
        //    get { DateTime dt = new DateTime(); dt.Date; }

        //}
    }
}
