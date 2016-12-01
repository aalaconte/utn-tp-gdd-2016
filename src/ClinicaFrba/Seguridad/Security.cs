using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Seguridad
{
    class Security
    {
        public static String encrypt(String password)
        {
            byte[] data = Encoding.GetEncoding(1252).GetBytes(password);
            var sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(data);
            return Encoding.GetEncoding(1252).GetString(hash);
        }

    }
}
