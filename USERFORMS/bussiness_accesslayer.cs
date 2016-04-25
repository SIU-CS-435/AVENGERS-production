using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace atm
{
    class bussiness_accesslayer
    {
        public static  void LogErrorFile(string er)
        {
            FileStream fs = new FileStream("E:\\log.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(er);
            sw.Close();
            fs.Close();
               

        }

        static  DataTable dt = new DataTable();
        public static int null_validation(string s)
        {
            if (s == "")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    public static int tbpass_Validating(string pass)
        {
            int flag = 0, flag1 = 0, flag2 = 0;
            string number = "0123456789";
            string spcl_charater = "~!@#$%^&*";
            string alphabets = "qwertyuiopasdfghjklzxcvbnm";
            foreach (char c in pass.ToCharArray())
            {
                if (number.Contains(c))
                {
                    flag = 1;
                }
                else if (spcl_charater.Contains(c))
                {
                    flag1 = 1;
                }
                else if (alphabets.Contains(Char.ToLower(c)))
                {
                    flag2 = 1;
                }
            }
            if (flag == 1 && flag1 == 1 && flag2 == 1)
            {  
              return 0;
            }
            else
            { 
                return 1;
            }
        }

    public static int tbemail_Validating(string email)
    {
        if (Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
        {
            string q = "SELECT EMAIL FROM CUSTOMER_INFO WHERE EMAIL='" + email + "'";
            dt = dataaccess_layer.GetRecords(q);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return 2;
            }
        }
        else
        { 
            return  1;
        }
    }

    public static int name_validation(string name)
    {
        int flag = 0, flag1 = 0;
        string number = "0123456789";
        string spcl_charater = "~!@#$%^&*";
        foreach (char c in name.ToCharArray())
        {
            if (number.Contains(c))
            {
                flag = 1;
            }
            else if (spcl_charater.Contains(c))
            {
                flag1 = 1;
            }
        }
        if (flag == 1 || flag1 == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static int phone_validation(string phone)
    {
        string number = "0123456789";
        int flag = 0;
        if (phone.Length == 10)
        {
            foreach (char c in phone.ToCharArray())
            {
                if (number.Contains(c))
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                    break;
                }  
            }
        }
        else
        {
            flag=2;
        }
        if (flag == 1)
        {
            return 0;
        }
        else if (flag == 0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
  
        public static int ssn_validation(string ssno)
        {
             string q = "SELECT SSN_NO FROM CUSTOMER_INFO WHERE SSN_NO='" + ssno + "'";
             dt = dataaccess_layer.GetRecords(q);
             if (dt.Rows.Count == 0)
             {
                 return 0;
             }
             else
             {
                 return 1;
             }
    }

    public static int txtseats_Validating(string seats)
    {
        string number = "0123456789";
        int flag=0;
        foreach(char c in seats)
        {
            if(number.Contains(c))
            {
            flag=0;
            }
            else 
            {   
                flag=1;
                break;
            }
        }
        if (flag == 0)
        {
            int n = Convert.ToInt16(seats);
            if (n > 20 || n < 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 2;
        }
    }
    public static int jour_date(DateTime d)
    {
        if (d < DateTime.Now.Date)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static string Encrypt(string clearText)
    {
        string EncryptionKey = "avengers";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }
    public static string Decrypt(string cipherText)
    {
        string EncryptionKey = "avengers";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
  }
}
