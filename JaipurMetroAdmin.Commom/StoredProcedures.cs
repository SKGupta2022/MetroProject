using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Commom
{
    public class StoredProcedures
    {
        #region"store procedure declaration"
        public static string LoginVerify = "[dbo].[SP_LoginVerify]";
        public static string Post_Customer = "[dbo].[SP_Customer_Post]";
        public static string Get_Customer = "[dbo].[SP_Customer_Get]";
        public static string AddNewCard = "[dbo].[SP_AddNewCard]";
        public static string CardDetails = "[dbo].[SP_CardDetails]";
        public static string AddRecharge = "[dbo].[SP_AddRechargeDetails]";
        public static string ResponseTransaction = "[dbo].[SP_ResponseTransaction]";
        public static string SaveRequestTransaction = "[dbo].[SP_RequestTransaction]";
        public static string Role = "[dbo].[SP_Role]";
        public static string Post_Employee = "[dbo].[SP_Employee_Post]";
        public static string Get_Employee = "[dbo].[SP_Employee_Get]";
        #endregion
    }
}
