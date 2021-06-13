using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gmach
{
    public partial class frmCalendar : Form
    {
        public event EventHandler MyEvent;
        Point point;
        TextBox tb;
        public frmCalendar( TextBox textBox, Point point)
        {
            this.point = point;
            tb = textBox;
            SetLocation();
            InitializeComponent();
        }
        private void frmCalnter_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetLocation()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.SetDesktopLocation(this.point.X - 5, this.point.Y + 20);
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (MyEvent != null)
                MyEvent(this, EventArgs.Empty);

            tb.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Close();
        }
        public DateTime GetDate
        {
            get
            {
                return monthCalendar1.SelectionStart;
            }
        }
        private void frmCalendar_Load(object sender, EventArgs e)
        {

            SetDate();
        }
        public void SetDate()
        {
            if (tb.Text.Length != 10)
            {
                throw new InalidDateException(tb.Text);
            }

            if (Convert.ToInt16(tb.Text.Substring(0, 4)) <= 2099 & Convert.ToInt16(tb.Text.Substring(5, 2)) <=12 
                & (Convert.ToInt16(tb.Text.Substring(8, 2)) <=31))
            {
                monthCalendar1.SetDate(Convert.ToDateTime(tb.Text));
            }
            else
            {
                throw new InalidDateException(tb.Text);
            }
        }
    }
    public class InalidDateException : ApplicationException
    {
        string date;
        public InalidDateException(string date)
        {
            this.date = date;
        }
        public string Gdate
        {
            get
            {
                return date;
            }
        }
    }
}