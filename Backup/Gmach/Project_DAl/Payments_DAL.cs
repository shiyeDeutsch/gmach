using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Gmach
{
    class Payments_DAL
    {
        BaseDAL oBaseDAL = new BaseDAL();
        public Payments_DAL() { }
        public DataSet GetPaymentsGaneralDetails(int IDLoan)
        {
            DataSet ds = new DataSet();
            string str = @"select 
                Payments.PaymentID,
                Payments.NumOfPayment,
                Payments.PayDate,
                Payments.AmountPaid 
                from Payments 
                where Payments.LoanID=" + IDLoan.ToString();
            ds = oBaseDAL.GetData(str, "Payments");
            return ds;
        }
        public DataSet GetPaymentAllDetails(int IDPayment)
        {
            DataSet ds = new DataSet();
            string str = " EXEC sp_GetPaymentDetails " + IDPayment;
            ds = oBaseDAL.GetData(str, "Payment");
            return ds;
        }
        public void UpdatePayment(DataSet PaymentAllDetails, int AmountPaing)
        {
            string str = "UPDATE Payments set AmountPaid=AmountPaid+" + AmountPaing.ToString() +
                         ",PaydDate ='" + PaymentAllDetails.Tables[0].Rows[0]["PaydDate"] +
                         "' WHERE Payments.PaymentID=" + PaymentAllDetails.Tables[0].Rows[0]["PaymentID"];
            oBaseDAL.RunCommand(str, false);

        }
    }
}
