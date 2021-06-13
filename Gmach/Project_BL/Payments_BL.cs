using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Gmach
{
    class Payments_BL
    {
        Payments_DAL oPayments_DAL = new Payments_DAL();
        public Payments_BL() { }
        public DataSet GetPaymentsGaneralDetails(int IDLoan)
        {
            DataSet ds = new DataSet();
            ds = oPayments_DAL.GetPaymentsGaneralDetails(IDLoan);
            return ds;
        }
        public DataSet GetPaymentAllDetails(int IDPayment)
        {
            DataSet ds = new DataSet();
            ds = oPayments_DAL.GetPaymentAllDetails(IDPayment);
            return ds;
        }
        public bool UpdatePayment(DataSet PaymentAllDetails, int AmountPaing)
        {
            if (PaymentAllDetails.Tables[0].Rows[0]["PaydDate"].ToString() != "" & AmountPaing > 0)
            {
                oPayments_DAL.UpdatePayment(PaymentAllDetails, AmountPaing);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
