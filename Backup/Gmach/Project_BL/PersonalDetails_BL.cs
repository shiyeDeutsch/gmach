using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Gmach
{
    class PersonalDetails_BL
    {
        PersonalDetails_DAL oPersonalDetails_DAL = new PersonalDetails_DAL();
        public DataSet getPersonalDetails(int IDMember)
        {
            return oPersonalDetails_DAL.getPersonalDetails(IDMember);
        }
        public DataSet getPersonalDetails1(int IDMember)
        {
            return oPersonalDetails_DAL.getPersonalDetails1(IDMember);
        }
    }
}
