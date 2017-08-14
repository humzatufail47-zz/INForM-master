using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace INForM
{
    public class PasswordHashing
    {
        public static String HashesPassword(String Pass)
        {
            byte[] PassInBytes = Encoding.ASCII.GetBytes(Pass);
            MD5 md5 = MD5.Create();
            byte[] HassPass = md5.ComputeHash(PassInBytes);
            StringBuilder FinalPass = new StringBuilder();
            for (int i = 0; i < HassPass.Length; i++)
            {
                FinalPass.Append(HassPass[i].ToString("X2"));
            }
            return FinalPass.ToString();
        }
    }
}