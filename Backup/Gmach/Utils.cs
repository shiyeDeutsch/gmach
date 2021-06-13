using System;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;

namespace Gmach
{
    public enum Status { Empty = 0, Add = 1, Edit }
    public class clsUtils
    {
        public clsUtils()
        {
        }
        public static String GetFilesDir(String strDir)
        {
            String strRootDir = Application.StartupPath;

            if (strDir.Trim().Length > 0)
                strDir += "\\";

            if (strRootDir.EndsWith("bin"))
            {
                return System.IO.Directory.GetParent(strRootDir).FullName + "\\" + strDir;
            }
            else
            {
                strRootDir = System.IO.Directory.GetParent(strRootDir).FullName;
                return System.IO.Directory.GetParent(strRootDir).FullName + "\\" + strDir;
            }

        }
        public static String GetFilesDir()
        {
            String strRootDir = Application.StartupPath;
            if (strRootDir.EndsWith("bin"))
            {
                return System.IO.Directory.GetParent(strRootDir).FullName + "\\";
            }
            else
            {
                strRootDir = System.IO.Directory.GetParent(strRootDir).FullName;
                return System.IO.Directory.GetParent(strRootDir).FullName + "\\";
            }

        }
        public static void SetColumnsUnvisible(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.Visible = false;
                col.DisplayIndex = 0;
                col.Frozen = false;
            }
        }
        public static void SetGridColumn(DataGridView dgv,
                                         string ID,
                                         string headerText,
                                         int displayIndex,
                                         bool Editable)
        {
            dgv.Columns[ID].Visible = true;
            dgv.Columns[ID].HeaderText = headerText;
            dgv.Columns[ID].DisplayIndex = displayIndex - 1;
            dgv.Columns[ID].ReadOnly = !Editable;
        }
        //public static void RemoveAllColumns(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn col in dgv.Columns)
        //    {
        //        dgv.Columns.Clear();
        //    }
        //}
        public static void SetGridColumn(DataGridView dgv,
                                        string ID,
                                        string headerText,
                                        int displayIndex,
                                        bool Editable,
                                        bool Freez,
                                        int Width)
        {
            dgv.Columns[ID].MinimumWidth = Width;
            dgv.Columns[ID].Width = Width;
            dgv.Columns[ID].Visible = true;
            dgv.Columns[ID].Frozen = Freez;
            dgv.Columns[ID].HeaderText = headerText;
            dgv.Columns[ID].DisplayIndex = displayIndex - 1;
            dgv.Columns[ID].ReadOnly = !Editable;
        }
        public static void SetGridColumn(DataGridView dgv,
                                         string ID,
                                         string headerText,
                                         int displayIndex,
                                         bool Editable,
                                         bool Freez)
        {
            dgv.Columns[ID].Visible = true;
            dgv.Columns[ID].Frozen = Freez;
            dgv.Columns[ID].HeaderText = headerText;
            dgv.Columns[ID].DisplayIndex = displayIndex - 1;
            dgv.Columns[ID].ReadOnly = !Editable;

        }
        public static void SetGridColumn(DataGridView dgv,
                                         string ID,
                                         string headerText,
                                         int displayIndex,
                                         bool Editable,
                                         int Width)
        {
            dgv.Columns[ID].Visible = true;
            dgv.Columns[ID].HeaderText = headerText;
            dgv.Columns[ID].DisplayIndex = displayIndex - 1;
            dgv.Columns[ID].ReadOnly = !Editable;
            dgv.Columns[ID].MinimumWidth = Width;
            dgv.Columns[ID].Width = Width;
        }
        public static void ShowColIndex(DataGridView dgv,
                                         string ID)
        {
            Console.WriteLine(dgv.Columns[ID].DisplayIndex + " - " + dgv.Columns[ID].HeaderText);
        }
        public static string[] GetProperties(string Class)
        {
            Type t = Type.GetType(Class);
            //MethodInfo[] mi;
            //EventInfo[] ei;
            PropertyInfo[] pi;
            //ConstructorInfo[] ci;
            //FieldInfo[] fi;

            //fi = t.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            pi = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            string[] s = new string[pi.Length];

            ArrayList al = new ArrayList();
            for (int i = 0; i < pi.Length; i++)
            {
                s[i] = pi[i].Name;
                al.Add(s[i]);
            }
            //al.Add(s2);
            //al.Add(s3);
            //al.Add(s4);
            return s;
        }
        public static double GetGridTotals(DataGridView dgv, string ColNo, string FilterColNo, string Filter)
        {
            double Total = 0;

            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                if (dgv[FilterColNo, i].Value.ToString() == Filter)
                {
                    Total += Convert.ToDouble(dgv[ColNo, i].Value.ToString());
                }
            }
            return Total;
        }
        public static object cvtNull(object o)
        {
            if (!(Convert.IsDBNull(o)))
            {
                return System.Convert.ToString(o);
            }
            else
            {
                return "";
            }

        }
        public static void SetGridColumn(DataGridView dgv,
                                         int ID
                                         )
        {

            dgv.Columns[ID].Visible = false;

        }
        public static void SetGridRowsNa(DataGridView dgv, int ID)
        {

            dgv.Rows[ID].Visible = false;
        }
        public static void SetGridRowsPo(DataGridView dgv, int ID)
        {
            dgv.Rows[ID].Visible = true;
        }
        public static void SetGridColPo(DataGridView dgv, int ID)
        {
            dgv.Columns[ID].Visible = true;
        }
        public static void SetGridColNa(DataGridView dgv, int ID)
        {
            dgv.Columns[ID].Visible = false;
        }
        public static void AddAColBtn(DataGridView dgv, string name, int position, string headerText)
        {
            DataGridViewColumn dgvCol = new DataGridViewButtonColumn();
            dgv.Columns.Insert(position-1,dgvCol);
            dgv.Columns[position-1].Name = name;
            dgv.Columns[position - 1].HeaderText = headerText;
        }
        public static void AddAColCom(DataGridView dgv, string name, int position, string headerText,string[]items)
        {
            DataGridViewColumn dgvCol = new DataGridViewComboBoxColumn();
            dgv.Columns.Insert(position - 1, dgvCol);
            dgv.Columns[position - 1].Name = name;
            dgv.Columns[position - 1].HeaderText = headerText;
            for (int i = 0; i < items.Length;i++)
                ((DataGridViewComboBoxColumn)dgv.Columns[position - 1]).Items.Add(items[i]);
        }
    }
}
