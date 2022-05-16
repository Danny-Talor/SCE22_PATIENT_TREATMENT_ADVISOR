using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PATIENT_TREATMENT_ADVISOR
{
    internal class Encryptonator
    {
        public static string MD5Hash(string text)
        {
            MD5 md5 = MD5.Create();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            if(md5.Hash != null)
            {
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(result[i].ToString("x2"));
                }

                return strBuilder.ToString();
            }
            else
            {
                return text;
            }
            
        }
    }
}
