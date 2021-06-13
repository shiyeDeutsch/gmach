using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Gmach
{
    class PersonalDetails_DAL
    {
        BaseDAL oBaseDAL = new BaseDAL();
        public DataSet getPersonalDetails(int IDMember)
        {
            DataSet ds = new DataSet();
            string PersonalDetails = @"SELECT 
                                            MemberID,
                                            Members.Name,
                                            Members.Family,
                                            Members.IdNum,
                                            Members.FatherNeme,
                                            Members.BirthDate,
                                            Members.City,
                                            Members.Address,
                                            Members.Tel1,       
                                            Members.EmailAddress
                                        FROM Members  
                                        WHERE Members.MemberID=" + IDMember;
            return oBaseDAL.GetData(PersonalDetails, "Members");

        }
        public DataSet getPersonalDetails1(int IDMember)
        {
            DataSet ds = new DataSet();
            string PersonalDetails = @"SELECT 
                                             MemberID,
                                            [FullName]= Members.Name+' '+ Members.Family, 
                                            Members.IdNum,
                                            Members.FatherNeme,
                                            Members.BirthDate,
                                            Members.City,
                                            Members.Address,
                                            Members.EmailAddress,
                                            Members.Tel1
                                        FROM Members  
                                        WHERE Members.MemberID=" + IDMember;
            return oBaseDAL.GetData(PersonalDetails, "Members");

        }
    }
}
