using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Gmach
{
    class Loans_BL
    {

        private Loans_DAL oLoans_DAL = new Loans_DAL();

        
        public DataSet getLoanDetailsQ(int IDLoan)
        {
            return oLoans_DAL.getLoanDetailsQ(IDLoan);
        }
        public void UpdateLoansBalance(DataSet LoansDetails)
        {
            oLoans_DAL.UpdateLoansBalance(LoansDetails);

        }
    }
}
