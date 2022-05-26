using System;
using System.Security.Cryptography;
using System.Text;

namespace Domain
{
    public class Hash
    {
        private const int SaltSize = 32;

        /// <summary>
        /// Génère le sel sous forme d'une clé
        /// </summary>
        /// <returns></returns>

        public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[SaltSize];
                rng.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        /// <summary>
        /// hache le mot de passe 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static byte[] ComputeHMAC_SHA256(byte[] data, byte[] salt)
        {
            using (var hmac = new HMACSHA256(salt))
            {
                return hmac.ComputeHash(data);
            }
        }
        /// <summary>
        /// Fournit le mot de passe haché
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <returns></returns>

        public static byte[] PasswordHashe(String password, byte[] salt)

        {
            byte[] pwdHash = null;
            pwdHash = ComputeHMAC_SHA256(Encoding.UTF8.GetBytes(password), salt);
            return pwdHash;

        }

        /// <summary>
        /// Vérifie le mot de passe
        /// On passe un mot de passe en clair et la clé 
        /// </summary>
        /// <param name="salt"></param>
        /// <param name="pwd"></param>
        /// <param name="pwdh"></param>
        /// <returns></returns>

        public static Boolean VerifyPassword(byte[] salt, String pwd, byte[] pwdh)
        {

            byte[] pwdHash = PasswordHashe(pwd, salt);
            int i = 0;
            bool egal = true;
            while (i < pwdHash.Length && egal)
            {
                if (pwdHash[i] != pwdh[i])
                    egal = false;
                i++;

            }
            return egal;
        }

        /// <summary>
        ///  Cette méthode transforme une chaîne de caractère en bytes
        /// </summary>

        public static byte[] transformeEnBytes(string maChaine)
        {
            byte[] bytes = Convert.FromBase64String(maChaine);

            return bytes;

        }

        /// <summary>
        ///  Cette méthode transforme une tableau bytes  en chaîne
        /// </summary>

        public static String BytesToString(byte[] monByte)
        {

            string str = Convert.ToBase64String(monByte);
            return str;
        }
    }
}