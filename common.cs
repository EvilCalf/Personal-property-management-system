using System;
using System.Security.Cryptography;

namespace 个人财产管理系统
{
    class Common
    {
        Database db = new Database ( );
        //生成md5加密后的字符串
        public string Md5 ( string pwd )
        {
            string returnPwd = "";
            MD5 md5 = MD5.Create ( );
            byte [] bytes = System.Text.Encoding.UTF8.GetBytes ( pwd );
            bytes = md5.ComputeHash ( bytes );
            md5.Clear ( );
            for (int i = 0 ; i < bytes.Length ; i++)
            {
                returnPwd += Convert.ToString ( bytes [i] , 16 ).PadLeft ( 2 , '0' );
            }
            return returnPwd.PadLeft ( 32 , '0' );
        }
    }
   
}
