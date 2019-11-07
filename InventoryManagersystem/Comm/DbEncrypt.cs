using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace Comm
{
    public class DbEncrypt
    {
        /// <summary>
        /// MD5 加密静态方法
        /// </summary>
        /// <param name="EncryptString">待加密的密文</param>
        /// <returns>returns</returns>
        public static string MD5Encrypt(string EncryptString)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw (new Exception("密文不得为空"));
            }

            MD5 myClassMD5 = new MD5CryptoServiceProvider();

            string mystrEncrypt = string.Empty;
            try
            {
                mystrEncrypt = BitConverter.ToString(myClassMD5.ComputeHash(Encoding.Default.GetBytes(EncryptString))).Replace("-", string.Empty);
            }
            catch (ArgumentException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myClassMD5.Clear(); }

            return mystrEncrypt;
        }

        /// <summary>
        /// DES 加密(数据加密标准，速度较快，适用于加密大量数据的场合)
        /// </summary>
        /// <param name="EncryptString">待加密的密文</param>
        /// <param name="EncryptKey">加密的密钥</param>
        /// <returns>returns</returns>
        public static string DESEncrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(EncryptKey)) { throw (new Exception("密钥不得为空")); }

            if (EncryptKey.Length != 8) { throw (new Exception("密钥必须为8位")); }

            byte[] mybtIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

            string mystrEncrypt = string.Empty;

            DESCryptoServiceProvider myDESProvider = new DESCryptoServiceProvider();

            try
            {
                byte[] mybtEncryptString = Encoding.Default.GetBytes(EncryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycstream = new CryptoStream(mystream, myDESProvider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey), mybtIV), CryptoStreamMode.Write);

                mycstream.Write(mybtEncryptString, 0, mybtEncryptString.Length);

                mycstream.FlushFinalBlock();

                mystrEncrypt = Convert.ToBase64String(mystream.ToArray());

                mystream.Close(); mystream.Dispose();

                mycstream.Close(); mycstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myDESProvider.Clear(); }

            return mystrEncrypt;
        }

        /// <summary>
        /// DES 解密(数据加密标准，速度较快，适用于加密大量数据的场合)
        /// </summary>
        /// <param name="DecryptString">待解密的密文</param>
        /// <param name="DecryptKey">解密的密钥</param>
        /// <returns>returns</returns>
        public static string DESDecrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(DecryptKey)) { throw (new Exception("密钥不得为空")); }


            if (DecryptKey.Length != 8) { throw (new Exception("密钥必须为8位")); }

            byte[] mybtIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

            string mystrDecrypt = string.Empty;

            DESCryptoServiceProvider myDESProvider = new DESCryptoServiceProvider();

            try
            {
                byte[] mybtDecryptString = Convert.FromBase64String(DecryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycstream = new CryptoStream(mystream, myDESProvider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey), mybtIV), CryptoStreamMode.Write);

                mycstream.Write(mybtDecryptString, 0, mybtDecryptString.Length);

                mycstream.FlushFinalBlock();

                mystrDecrypt = Encoding.Default.GetString(mystream.ToArray());

                mystream.Close(); mystream.Dispose();

                mycstream.Close(); mycstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myDESProvider.Clear(); }

            return mystrDecrypt;
        }

        /// <summary>
        /// RC2 加密(用变长密钥对大量数据进行加密)
        /// </summary>
        /// <param name="EncryptString">待加密密文</param>
        /// <param name="EncryptKey">加密密钥</param>
        /// <returns>returns</returns>
        public static string RC2Encrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(EncryptKey)) { throw (new Exception("密钥不得为空")); }

            if (EncryptKey.Length < 5 || EncryptKey.Length > 16) { throw (new Exception("密钥必须为5-16位")); }

            string mystrEncrypt = string.Empty;

            byte[] mybtIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

            RC2CryptoServiceProvider myRC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] mybtEncryptString = Encoding.Default.GetBytes(EncryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycstream = new CryptoStream(mystream, myRC2Provider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey), mybtIV), CryptoStreamMode.Write);

                mycstream.Write(mybtEncryptString, 0, mybtEncryptString.Length);

                mycstream.FlushFinalBlock();

                mystrEncrypt = Convert.ToBase64String(mystream.ToArray());

                mystream.Close(); mystream.Dispose();

                mycstream.Close(); mycstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myRC2Provider.Clear(); }

            return mystrEncrypt;
        }

        /// <summary>
        /// RC2 解密(用变长密钥对大量数据进行加密)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey">解密密钥</param>
        /// <returns>returns</returns>
        public static string RC2Decrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(DecryptKey)) { throw (new Exception("密钥不得为空")); }

            if (DecryptKey.Length < 5 || DecryptKey.Length > 16) { throw (new Exception("密钥必须为5-16位")); }

            byte[] mybtIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

            string mystrDecrypt = string.Empty;

            RC2CryptoServiceProvider myRC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] mybtDecryptString = Convert.FromBase64String(DecryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycstream = new CryptoStream(mystream, myRC2Provider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey), mybtIV), CryptoStreamMode.Write);

                mycstream.Write(mybtDecryptString, 0, mybtDecryptString.Length);

                mycstream.FlushFinalBlock();

                mystrDecrypt = Encoding.Default.GetString(mystream.ToArray());

                mystream.Close(); mystream.Dispose();

                mycstream.Close(); mycstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myRC2Provider.Clear(); }

            return mystrDecrypt;
        }

        /// <summary>
        /// 3DES 加密(基于DES，对一块数据用三个不同的密钥进行三次加密，强度更高)
        /// </summary>
        /// <param name="EncryptString">芜湖德豪润达ITDept</param>
        /// <param name="EncryptKey1">密钥一</param>
        /// <param name="EncryptKey2">密钥二</param>
        /// <param name="EncryptKey3">密钥三</param>
        /// <returns>returns</returns>
        public static string DES3Encrypt(string EncryptString, string EncryptKey1, string EncryptKey2, string EncryptKey3)
        {
            string mystrEncrypt = string.Empty;

            try
            {
                mystrEncrypt = DESEncrypt(EncryptString, EncryptKey3);

                mystrEncrypt = DESEncrypt(mystrEncrypt, EncryptKey2);

                mystrEncrypt = DESEncrypt(mystrEncrypt, EncryptKey1);
            }
            catch (Exception ex) { throw ex; }

            return mystrEncrypt;
        }

        /// <summary>
        /// 3DES 解密(基于DES，对一块数据用三个不同的密钥进行三次加密，强度更高)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey1">密钥一</param>
        /// <param name="DecryptKey2">密钥二</param>
        /// <param name="DecryptKey3">密钥三</param>
        /// <returns>returns</returns>
        public static string DES3Decrypt(string DecryptString, string DecryptKey1, string DecryptKey2, string DecryptKey3)
        {
            string mystrDecrypt = string.Empty;

            try
            {
                mystrDecrypt = DESDecrypt(DecryptString, DecryptKey1);

                mystrDecrypt = DESDecrypt(mystrDecrypt, DecryptKey2);

                mystrDecrypt = DESDecrypt(mystrDecrypt, DecryptKey3);
            }
            catch (Exception ex) { throw ex; }

            return mystrDecrypt;
        }

        /// <summary>
        /// AES 加密(高级加密标准，是下一代的加密算法标准，速度快，安全级别高，目前 AES 标准的一个实现是 Rijndael 算法)
        /// </summary>
        /// <param name="EncryptString">待加密密文</param>
        /// <param name="EncryptKey">加密密钥</param>
        /// <returns></returns>
        public static string AESEncrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(EncryptKey)) { throw (new Exception("密钥不得为空")); }

            string mystrEncrypt = string.Empty;

            byte[] mybtIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");

            Rijndael myAESProvider = Rijndael.Create();

            try
            {
                byte[] mybtEncryptString = Encoding.Default.GetBytes(EncryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycsstream = new CryptoStream(mystream, myAESProvider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey), mybtIV), CryptoStreamMode.Write);

                mycsstream.Write(mybtEncryptString, 0, mybtEncryptString.Length); mycsstream.FlushFinalBlock();

                mystrEncrypt = Convert.ToBase64String(mystream.ToArray());

                mystream.Close(); mystream.Dispose();

                mycsstream.Close(); mycsstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myAESProvider.Clear(); }

            return mystrEncrypt;
        }

        /// <summary>
        /// AES 解密(高级加密标准，是下一代的加密算法标准，速度快，安全级别高，目前 AES 标准的一个实现是 Rijndael 算法)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey">解密密钥</param>
        /// <returns></returns>
        public static string AESDecrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString)) { throw (new Exception("密文不得为空")); }

            if (string.IsNullOrEmpty(DecryptKey)) { throw (new Exception("密钥不得为空")); }

            string mystrDecrypt = string.Empty;

            byte[] mybtIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");

            Rijndael myAESProvider = Rijndael.Create();

            try
            {
                byte[] mybtDecryptString = Convert.FromBase64String(DecryptString);

                MemoryStream mystream = new MemoryStream();

                CryptoStream mycsstream = new CryptoStream(mystream, myAESProvider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey), mybtIV), CryptoStreamMode.Write);

                mycsstream.Write(mybtDecryptString, 0, mybtDecryptString.Length); mycsstream.FlushFinalBlock();

                mystrDecrypt = Encoding.Default.GetString(mystream.ToArray());
                mystream.Close(); mystream.Dispose();

                mycsstream.Close(); mycsstream.Dispose();
            }
            catch (IOException ex) { throw ex; }
            catch (CryptographicException ex) { throw ex; }
            catch (ArgumentException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { myAESProvider.Clear(); }

            return mystrDecrypt;
        }

    }
}
