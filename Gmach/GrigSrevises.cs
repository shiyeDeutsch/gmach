using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace Gmach
{
    class GrigSrevises
    {
      public static string getCellDataFromDateGridViwe(DataGridView dgv,int cell)
      {

          DataRow dr;
          DataRowView drv = (DataRowView)dgv.SelectedRows[cell].DataBoundItem;
          dr = drv.Row;
          string str = (dr[0].ToString());

          return str;
      }

    }
}
