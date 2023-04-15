using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _4_praktinis_3rd_App
{
    internal class CrptEngine
    {

        public static String verificationEngine(String text, BigInteger e, BigInteger n)
        {
            string decryptedText = "";
            try
            {
                string[] nums = text.Split(' ');

                for (int i = 0; i < nums.Length; i++)
                {
                    BigInteger dec = BigInteger.ModPow(BigInteger.Parse(nums[i]), e, n);
                    decryptedText += (char)dec;
                }
            }
            catch(System.OverflowException)
            {
                decryptedText = text;
            }
            return decryptedText;
        }


    }
}
