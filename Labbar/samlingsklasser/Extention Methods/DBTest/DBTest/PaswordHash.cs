using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Security;

namespace DBTest
{
    public class PaswordHash
    {
        public string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            Byte[] buff = new byte[16];
            rng.GetBytes(buff);
            string salt = Convert.ToBase64String(buff);
            return salt;
        }

        public string GeneratePaswordHash(string password, string salt)
        {
            string passSalt = String.Concat(password, salt);
            string hashedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(passSalt, "sha1");

            return hashedpassword;
          
        }

        public bool ValidatePassword(string password)
        {
            string saltFromDB ="";
            string hashFromDb ="";

            string passSalt = String.Concat(password, saltFromDB);
            string hashedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(passSalt, "sha1");

            if(hashFromDb == hashedpassword)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}