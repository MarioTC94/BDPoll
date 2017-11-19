using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
   public static class Encrypt {
        // Metodos de Encriptación
        public static byte[] HashPassword(string pass, string salt) { 
            var combinedPassword = String.Concat(pass, salt);            
            var sha256 = new SHA256Managed();
            var bytes = UTF8Encoding.UTF8.GetBytes(combinedPassword);
            var hash = sha256.ComputeHash(bytes);
            return hash;
        }

        public static byte[] GetRandomSalt(Int32 size = 32) {
            var random = new RNGCryptoServiceProvider();
            var salt = new Byte[size];
            random.GetBytes(salt);
            return salt;

        }
        public static bool Compare(byte[] hash1, byte[] hash2) {
            return Encoding.UTF8.GetString(hash1) == Encoding.UTF8.GetString(hash2);
        }
    }
}
