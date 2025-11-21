using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EBS_RN
{
    public class EncryptFiles
    {
        public byte[] RC2Encrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // Key for RC2 is between 8 and 128 bytes
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV for RC2 is 8 bytes

                using (RC2CryptoServiceProvider rc2Alg = new RC2CryptoServiceProvider())
                {
                    rc2Alg.Key = keyBytes;
                    rc2Alg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, rc2Alg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Encryption error: " + ex.Message);
            }
        }

        public byte[] RC2Decrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // Key for RC2 is between 8 and 128 bytes
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV for RC2 is 8 bytes

                using (RC2CryptoServiceProvider rc2Alg = new RC2CryptoServiceProvider())
                {
                    rc2Alg.Key = keyBytes;
                    rc2Alg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, rc2Alg.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Decryption error: " + ex.Message);
            }
        }

        public byte[] TripleDESEncrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // 3DES key is 24 bytes
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV for 3DES is 8 bytes

                using (TripleDESCryptoServiceProvider desAlg = new TripleDESCryptoServiceProvider())
                {
                    desAlg.Key = keyBytes;
                    desAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, desAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Encryption error: " + ex.Message);
            }
        }

        public byte[] TripleDESDecrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // 3DES key is 24 bytes
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV for 3DES is 8 bytes

                using (TripleDESCryptoServiceProvider desAlg = new TripleDESCryptoServiceProvider())
                {
                    desAlg.Key = keyBytes;
                    desAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, desAlg.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Decryption error: " + ex.Message);
            }
        }

        public byte[] AESEncrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey);
                byte[] ivBytes = GetBytesFromString(iv, codIV);

                using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Encryption error: " + ex.Message);
            }
        }

        public byte[] AESDecrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey);
                byte[] ivBytes = GetBytesFromString(iv, codIV);

                using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
                {
                    aesAlg.Key = keyBytes;
                    aesAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, aesAlg.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Decryption error: " + ex.Message);
            }
        }

        public byte[] DESEncrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // Chave DES tem 8 bytes (64 bits)
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV também tem 8 bytes

                using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
                {
                    desAlg.Key = keyBytes;
                    desAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, desAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Encryption error: " + ex.Message);
            }
        }

        public byte[] DESDecrypt(byte[] inputBytes, string key, string iv, string codKey, string codIV)
        {
            try
            {
                byte[] keyBytes = GetBytesFromString(key, codKey); // Chave DES tem 8 bytes (64 bits)
                byte[] ivBytes = GetBytesFromString(iv, codIV); // IV também tem 8 bytes

                using (DESCryptoServiceProvider desAlg = new DESCryptoServiceProvider())
                {
                    desAlg.Key = keyBytes;
                    desAlg.IV = ivBytes;

                    using (MemoryStream outputStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(outputStream, desAlg.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }
                        return outputStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Decryption error: " + ex.Message);
            }
        }

        private byte[] GetBytesFromString(string input, string cod)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(input));

            byte[] bytes;
            switch (cod)
            {
                case "ASCII":
                    bytes = Encoding.ASCII.GetBytes(input);
                    break;
                case "ANSI":
                    bytes = Encoding.Default.GetBytes(input);
                    break;
                case "UTF-7":
                    bytes = Encoding.UTF7.GetBytes(input);
                    break;
                case "UTF-8":
                    bytes = Encoding.UTF8.GetBytes(input);
                    break;
                case "UTF-32":
                    bytes = Encoding.UTF32.GetBytes(input);
                    break;
                case "Unicode (Little Endian)":
                    bytes = Encoding.Unicode.GetBytes(input);
                    break;
                case "Unicode (Big Endian)":
                    bytes = Encoding.BigEndianUnicode.GetBytes(input);
                    break;
                default:
                    throw new ArgumentException("Invalid encoding specified");
            }
            return bytes;
        }

        /*Variação

        private byte[] GetBytesFromString(string input, string cod, int length)
       {
           if (string.IsNullOrEmpty(input))
               throw new ArgumentNullException(nameof(input));

           byte[] bytes;
           switch (cod)
           {
               case "ASCII":
                   bytes = Encoding.ASCII.GetBytes(input);
                   break;
               case "ANSI":
                   bytes = Encoding.Default.GetBytes(input);
                   break;
               case "UTF-7":
                   bytes = Encoding.UTF7.GetBytes(input);
                   break;
               case "UTF-8":
                   bytes = Encoding.UTF8.GetBytes(input);
                   break;
               case "UTF-32":
                   bytes = Encoding.UTF32.GetBytes(input);
                   break;
               case "Unicode (Little Endian)":
                   bytes = Encoding.Unicode.GetBytes(input);
                   break;
               case "Unicode (Big Endian)":
                   bytes = Encoding.BigEndianUnicode.GetBytes(input);
                   break;
               default:
                   throw new ArgumentException("Invalid encoding specified");
           }

           // Se o tamanho dos bytes for menor do que o tamanho especificado, preencha com zeros
           if (bytes.Length < length)
           {
               byte[] paddedBytes = new byte[length];
               Array.Copy(bytes, 0, paddedBytes, 0, bytes.Length);
               bytes = paddedBytes;
           }

           return bytes;
       }*/


    }
}