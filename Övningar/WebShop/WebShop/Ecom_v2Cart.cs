
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebShop
{
    public class Ecom_v2Cart
    {

        public int CustomerID;
        public string CustomerName;
        public string CustomerEmailID;
        public string CustomerPhoneNo;
        public string CustomerAddress;
        public string CustomerPassword;
        public string SearchText;

        public Ecom_v2Cart() { }

        internal DataTable Register()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = DataAccess.AddParamater("@CustomerName", CustomerName, System.Data.SqlDbType.VarChar, 100);
            parameters[1] = DataAccess.AddParamater("@CustomerEmailID", CustomerEmailID, System.Data.SqlDbType.VarChar, 100);
            parameters[2] = DataAccess.AddParamater("@CustomerPhoneNo", CustomerPhoneNo, System.Data.SqlDbType.VarChar, 10);
            parameters[3] = DataAccess.AddParamater("@CustomerAddress", CustomerAddress, System.Data.SqlDbType.VarChar, 500);
            parameters[4] = DataAccess.AddParamater("@CustomerPassword", CustomerPassword, System.Data.SqlDbType.VarChar, 100);

            DataTable dt = DataAccess.ExecuteDTByProcedure("SP_Register", parameters);

            return dt;
        }

        internal DataTable Login()
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = DataAccess.AddParamater("@CustomerEmailID", CustomerEmailID, System.Data.SqlDbType.VarChar, 100);
            parameters[1] = DataAccess.AddParamater("@CustomerPassword", CustomerPassword, System.Data.SqlDbType.VarChar, 100);

            DataTable dt = DataAccess.ExecuteDTByProcedure("SP_Login", parameters);

            return dt;
        }

        internal DataTable GetCustomerInfo()
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = DataAccess.AddParamater("@CustomerID", CustomerID, System.Data.SqlDbType.Int, 100);

            DataTable dt = DataAccess.ExecuteDTByProcedure("SP_GetCustomerInfo", parameters);

            return dt;
        }

        internal DataTable UpdateProfile()
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = DataAccess.AddParamater("@CustomerID", CustomerID, System.Data.SqlDbType.Int, 10);
            parameters[1] = DataAccess.AddParamater("@CustomerEmailID", CustomerEmailID, System.Data.SqlDbType.VarChar, 100);
            parameters[2] = DataAccess.AddParamater("@CustomerPhoneNo", CustomerPhoneNo, System.Data.SqlDbType.VarChar, 10);
            parameters[3] = DataAccess.AddParamater("@CustomerAddress", CustomerAddress, System.Data.SqlDbType.VarChar, 500);
            parameters[4] = DataAccess.AddParamater("@CustomerPassword", CustomerPassword, System.Data.SqlDbType.VarChar, 100);

            DataTable dt = DataAccess.ExecuteDTByProcedure("SP_UpdateProfile", parameters);

            return dt;
        }

    }
}