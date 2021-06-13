using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace Gmach
{
    class Loans_DAL
    {
        BaseDAL oBaseDAL = new BaseDAL();
        public Loans_DAL() { }
        public DataSet getLoanDetailsQ(int IDLoan)
        {
            string LoanDetailsQ = @"SELECT 
                                    Loans.LoanID,
                                    Loans.LoanDate,
                                    Loans.LoanAmount,
                                    Loans.NumOfPayments,
                                    Loans.Balance 
                                    FROM Loans where Loans.LoanID=" + IDLoan;
            return oBaseDAL.GetData(LoanDetailsQ, "Loans");
        }
        public void UpdateLoansBalance(DataSet LoansDetails)
        {
           string str=" update Loans set Balance=Balance-"+
                           LoansDetails.Tables[0].Rows[0]["BalanceToPay"];
           oBaseDAL.RunCommand(str, false);

        }
        
    }
}
