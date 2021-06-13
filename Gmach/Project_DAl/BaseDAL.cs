using System;
using System.Data;
using System.Configuration;

using System.Data.SqlClient;
using System.IO;

namespace Gmach
{
    public  class BaseDAL
    {
        private String ConnectionString = "";
        public BaseDAL()
        {


            ConnectionString = "data source=DESKTOP-N301H5G;initial catalog=Gmach;user=sa;pwd=qwer1234;persist security info=True;MultipleActiveResultSets=true";
         //   ConnectionString = "data source=<ComputerName>;initial catalog=<DB Name>;user=sa;pwd=<Password>;persist security info=True;MultipleActiveResultSets=true

        }

        public String RunCommand(string sCommand, bool isLog)
        {
            try
            {

                if (isLog)
                    WriteErrorLog(sCommand + "\r\n" + "\r\n");

                SqlConnection oCnn = new SqlConnection(ConnectionString);

                SqlDataAdapter oDataAdapter = new SqlDataAdapter(sCommand, oCnn);
                SqlCommand oCommand = new SqlCommand(sCommand, oCnn);
                oCnn.Open();
                oCommand.ExecuteNonQuery();
                oCnn.Close();
                return "OK";
            }
            catch (Exception e)
            {

                WriteErrorLog(sCommand + "\r\n" + e.Message.ToString() + "\r\n" + "\r\n");

                return e.Message.ToString();
            }
        }

        public int RunCommandWithID(string sCommand, bool isLog)
        {
            try
            {
                sCommand += " SET @newId = SCOPE_IDENTITY();";
                SqlConnection oCnn = new SqlConnection(ConnectionString);

                if (isLog)
                    WriteErrorLog(sCommand);

                SqlDataAdapter oDataAdapter = new SqlDataAdapter(sCommand, oCnn);
                SqlCommand oCommand = new SqlCommand(sCommand, oCnn);
                oCommand.Parameters.Add("@newId", SqlDbType.Int).Direction = ParameterDirection.Output;


                oCnn.Open();
                oCommand.ExecuteNonQuery();
                oCnn.Close();

                WriteErrorLog(oCommand.Parameters["@newId"].Value + "\r\n" + "\r\n");


                return (int)oCommand.Parameters["@newId"].Value;

            }
            catch (Exception e)
            {

                WriteErrorLog(sCommand + "\r\n" + e.Message.ToString() + "\r\n" + "\r\n");

                return -1;
            }
        }

        public void WriteErrorLog(string Error)
        {

            TextWriter tw = new StreamWriter("C:\\Error.Log", true);

            // write a line of text to the file
            tw.WriteLine(DateTime.Now.ToString() + "   " + Error);

            // close the stream
            tw.Close();
        }
        public DataSet GetData(String Sql)
        { 
            return GetData(Sql, "Table");
        }


        public DataSet GetData(String Sql,String TableName )
        {
            SqlConnection oCnn = new SqlConnection(ConnectionString);
            oCnn.Open();
            SqlDataAdapter oDataAdapter = new SqlDataAdapter(Sql, oCnn);
            DataSet ds = new DataSet();
            {
                oDataAdapter.Fill(ds, TableName);
                oCnn.Close();
            }
            return ds;
        }
    }
}