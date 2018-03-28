using API_Persistance.Data;
using API_Persistance.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API_Persistance
{
    public class VisitService
    {
        private const string initVector = "pemgail9uzpgzl88";
        private const int keysize = 256;

        public virtual IEnumerable<Visit> GetVisits()
        {
            var result = DataBaseService.DataBase.Visits;

            return result;
        }

        public virtual bool SetVisit(string commercial, string content, Visit visit)
        {
            var result = DecryptString(content, commercial);

            ProductVisit visitProduct = JsonConvert.DeserializeObject<ProductVisit>(result);

            if (visitProduct != null)
            {
                visit.products = new List<ProductVisit>
                {
                    new ProductVisit
                    {
                        name = visitProduct.name,
                        price = visitProduct.price,
                        facets = visitProduct.facets,
                        rack = visitProduct.rack,
                        missing = visitProduct.missing
                    }
                };
                return true;
            }
            else
                return false;
        }

        public static string DecryptString(string cipherText, string passPhrase)
        {
            byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
            byte[] keyBytes = password.GetBytes(keysize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
    }
}
