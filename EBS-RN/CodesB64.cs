using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS_RN
{
    // (@thiagosousa81) Essa classe é um registro antigo de começo do aprendizado sobre codificação de dados
    // (@thiagosousa81) Foi criada para uma das primeiras versões aplicativo do Encryption's Builder Studio
    // (@thiagosousa81) Aqui ela não será utilizada mais, mas está mantida no repositório como uma relíquia antiga
    // (@thiagosousa81) Acredito que ela não vai aumentar o tamanho final do aplicativo 😅
    public class CodesB64
    {
        #region Morse
        public string EncriptMoorse(string text)
        {//https://pt.wikipedia.org/wiki/C%C3%B3digo_Morse#C%C3%B3digo_Morse_internacional_moderno
            string textEncripted = text
            #region Alfabeto
                .Replace("A", "{●–}").Replace("a", "[●–]").Replace("B", "{–●●●}").Replace("b", "[–●●●]")
                .Replace("C", "{–●–●}").Replace("c", "[–●–●]").Replace("D", "{–●●}").Replace("d", "[–●●]").Replace("E", "{●}").Replace("e", "[●]")
                .Replace("F", "{●●–●}").Replace("f", "[●●–●]").Replace("G", "{––●}").Replace("g", "[––●]").Replace("H", "{●●●●}").Replace("h", "[●●●●]")
                .Replace("I", "{●●}").Replace("i", "[●●]").Replace("J", "{●–––}").Replace("j", "[●–––]").Replace("K", "{–●–}").Replace("k", "[–●–]")
                .Replace("L", "{●–●●}").Replace("l", "[●–●●]").Replace("M", "{––}").Replace("m", "[––]").Replace("N", "{–●}").Replace("n", "[–●]")
                .Replace("O", "{–––}").Replace("o", "[–––]").Replace("P", "{●––●}").Replace("p", "[●––●]").Replace("Q", "{––●–}").Replace("q", "[––●–]")
                .Replace("R", "{●–●}").Replace("r", "[●–●]").Replace("S", "{●●●}").Replace("s", "[●●●]").Replace("T", "{–}").Replace("t", "[–]")
                .Replace("U", "{●●–}").Replace("u", "[●●–]").Replace("V", "{●●●–}").Replace("v", "[●●●–]").Replace("W", "{●––}").Replace("w", "[●––]")
                .Replace("X", "{–●●–}").Replace("x", "[–●●–]").Replace("Y", "{–●––}").Replace("y", "[–●––]").Replace("Z", "{––●●}").Replace("z", "[––●●]")
            #endregion
            #region Numeros
                .Replace("0", " ––––– ").Replace("1", " ●–––– ").Replace("2", " ●●––– ").Replace("3", " ●●●–– ").Replace("4", " ●●●●– ").Replace("5", " ●●●●● ")
                .Replace("6", " –●●●● ").Replace("7", " ––●●● ").Replace("8", " –––●● ").Replace("9", " ––––● ")
            #endregion
            #region Símbolos
                .Replace(".", " ●–●–●– ").Replace(",", " ––●●–– ").Replace("?", " ●●––●● ").Replace("'", " ●––––● ").Replace("!", " –●–●–– ").Replace("/", " –●●–● ")
                .Replace("(", " –●––● ").Replace(")", " –●––●– ").Replace("&", " ●–●●● ").Replace(":", " –––●●● ").Replace(";", " –●–●–● ").Replace("=", " –●●●– ")
                .Replace("-", " –●●●●– ").Replace("_", " ●●––●– ").Replace(Convert.ToString('"'), " ●–●●–● ").Replace("$", " ●●●–●●– ").Replace("@", " ●––●–● ");
            #endregion
            return textEncripted;
        }
        public string DescriptMoorse(string textEncripted)
        {
            string textDescripted = textEncripted
            #region Alfabeto
                .Replace("{●–}", "A").Replace("[●–]", "a").Replace("{–●●●}", "B").Replace("[–●●●]", "b")
                .Replace("{–●–●}", "C").Replace("[–●–●]", "c").Replace("{–●●}", "D").Replace("[–●●]", "d").Replace("{●}", "E").Replace("[●]", "e")
                .Replace("{●●–●}", "F").Replace("[●●–●]", "f").Replace("{––●}", "G").Replace("[––●]", "g").Replace("{●●●●}", "H").Replace("[●●●●]", "h")
                .Replace("{●●}", "I").Replace("[●●]", "i").Replace("{●–––}", "J").Replace("[●–––]", "j").Replace("{–●–}", "K").Replace("[–●–]", "k")
                .Replace("{●–●●}", "L").Replace("[●–●●]", "l").Replace("{––}", "M").Replace("[––]", "m").Replace("{–●}", "N").Replace("[–●]", "n")
                .Replace("{–––}", "O").Replace("[–––]", "o").Replace("{●––●}", "P").Replace("[●––●]", "p").Replace("{––●–}", "Q").Replace("[––●–]", "q")
                .Replace("{●–●}", "R").Replace("[●–●]", "r").Replace("{●●●}", "S").Replace("[●●●]", "s").Replace("{–}", "T").Replace("[–]", "t")
                .Replace("{●●–}", "U").Replace("[●●–]", "u").Replace("{●●●–}", "V").Replace("[●●●–]", "v").Replace("{●––}", "W").Replace("[●––]", "w")
                .Replace("{–●●–}", "X").Replace("[–●●–]", "x").Replace("{–●––}", "Y").Replace("[–●––]", "y").Replace("{––●●}", "Z").Replace("[––●●]", "z")
            #endregion
            #region Numeros
                .Replace(" ––––– ", "0").Replace(" ●–––– ", "1").Replace(" ●●––– ", "2").Replace(" ●●●–– ", "3").Replace(" ●●●●– ", "4").Replace(" ●●●●● ", "5")
                .Replace(" –●●●● ", "6").Replace(" ––●●● ", "7").Replace(" –––●● ", "8").Replace(" ––––● ", "9")
            #endregion
            #region Símbolos
                .Replace(" ●–●–●– ", ".").Replace(" ––●●–– ", ",").Replace(" ●●––●● ", "?").Replace(" ●––––● ", "'").Replace(" –●–●–– ", "!").Replace(" –●●–● ", "/")
                .Replace(" –●––● ", "(").Replace(" –●––●– ", ")").Replace(" ●–●●● ", "&").Replace(" –––●●● ", ":").Replace(" –●–●–● ", ";").Replace(" –●●●– ", "=")
                .Replace(" –●●●●– ", "-").Replace(" ●●––●– ", "_").Replace(" ●–●●–● ", Convert.ToString('"')).Replace(" ●●●–●●– ", "$").Replace(" ●––●–● ", "@");
            #endregion
            return textDescripted;
        }
        #endregion
        #region ASCII
        public string CodASCII(string text)
        {
            try
            {
                byte[] btext = Encoding.ASCII.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        public string DecodASCII(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.ASCII.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        #endregion
        #region ANSI
        public string CodANSI(string text)
        {
            try
            {
                byte[] btext = Encoding.Default.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodANSI(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.Default.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF7
        public string CodUTF7(string text)
        {
            try
            {
                byte[] btext = Encoding.UTF7.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodUTF7(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.UTF7.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF8
        public string CodUTF8(string text)
        {
            try
            {
                byte[] btext = Encoding.UTF8.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodUTF8(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.UTF8.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF32
        public string CodUTF32(string text)
        {
            try
            {
                byte[] btext = Encoding.UTF32.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodUTF32(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.UTF32.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Unicode (Little-Endian)
        public string CodUnicode(string text)
        {
            try
            {
                byte[] btext = Encoding.Unicode.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodUnicode(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.Unicode.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Unicode (Big-Endian)
        public string CodBigEndianUnicode(string text)
        {
            try
            {
                byte[] btext = Encoding.BigEndianUnicode.GetBytes(text);
                return Convert.ToBase64String(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DecodBigEndianUnicode(string text)
        {
            try
            {
                byte[] btext = Convert.FromBase64String(text);
                return Encoding.BigEndianUnicode.GetString(btext);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
