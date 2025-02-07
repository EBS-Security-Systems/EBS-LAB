using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS_RN
{
    public class Bools
    {
        #region Métodos Booleanos
        #region Condicional DEC
        private string GetDecimal(bool v128 = false, bool v64 = false, bool v32 = false, bool v16 = false, bool v8 = false, bool v4 = false, bool v2 = false, bool v1 = false)
        {
            int valueBooleanDEC = 0;
            if (v128 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 128;
            }
            if (v64 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 64;
            }
            if (v32 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 32;
            }
            if (v16 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 16;
            }
            if (v8 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 8;
            }
            if (v4 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 4;
            }
            if (v2 == true)
            {
                valueBooleanDEC = valueBooleanDEC + 2;
            }
            if (v1 == true)
            {
                valueBooleanDEC++;
            }
            return valueBooleanDEC.ToString();
        }
        #endregion
        #region Condicional HEX
        private string GetHexadecimal(bool v128 = false, bool v64 = false, bool v32 = false, bool v16 = false, bool v8 = false, bool v4 = false, bool v2 = false, bool v1 = false)
        {
            int Hex1 = 0, Hex2 = 0;
            if (v1 == true)
            {
                Hex2 = Hex2 + 1;
            }
            if (v2 == true)
            {
                Hex2 = Hex2 + 2;
            }
            if (v4 == true)
            {
                Hex2 = Hex2 + 4;
            }
            if (v8 == true)
            {
                Hex2 = Hex2 + 8;
            }
            if (v16 == true)
            {
                Hex1 = Hex1 + 1;
            }
            if (v32 == true)
            {
                Hex1 = Hex1 + 2;
            }
            if (v64 == true)
            {
                Hex1 = Hex1 + 4;
            }
            if (v128 == true)
            {
                Hex1 = Hex1 + 8;
            }
            string StrHex1 = "", StrHex2 = "";
            if (Hex2 > 9)
            {
                if (Hex2 == 10)
                {
                    StrHex2 = "A";
                }
                else
                    if (Hex2 == 11)
                {
                    StrHex2 = "B";
                }
                else
                    if (Hex2 == 12)
                {
                    StrHex2 = "C";
                }
                else
                    if (Hex2 == 13)
                {
                    StrHex2 = "D";
                }
                else
                    if (Hex2 == 14)
                {
                    StrHex2 = "E";
                }
                else
                    if (Hex2 == 15)
                {
                    StrHex2 = "F";
                }
            }
            else
            {
                StrHex2 = Hex2.ToString();
            }
            if (Hex1 > 9)
            {
                if (Hex1 == 10)
                {
                    StrHex1 = "A";
                }
                else
                    if (Hex1 == 11)
                {
                    StrHex1 = "B";
                }
                else
                    if (Hex1 == 12)
                {
                    StrHex1 = "C";
                }
                else
                    if (Hex1 == 13)
                {
                    StrHex1 = "D";
                }
                else
                    if (Hex1 == 14)
                {
                    StrHex1 = "E";
                }
                else
                    if (Hex1 == 15)
                {
                    StrHex1 = "F";
                }
            }
            else
            {
                StrHex1 = Hex1.ToString();
            }
            return StrHex1 + StrHex2;
        }
        #endregion
        #region Condicional OCT
        private string GetOctal(bool v128 = false, bool v64 = false, bool v32 = false, bool v16 = false, bool v8 = false, bool v4 = false, bool v2 = false, bool v1 = false)
        {
            int OCT1 = 0, OCT2 = 0, OCT3 = 0;
            if (v1 == true)
            {
                OCT1 = OCT1 + 1;
            }
            if (v2 == true)
            {
                OCT1 = OCT1 + 2;
            }
            if (v4 == true)
            {
                OCT1 = OCT1 + 4;
            }
            if (v8 == true)
            {
                OCT2 = OCT2 + 1;
            }
            if (v16 == true)
            {
                OCT2 = OCT2 + 2;
            }
            if (v32 == true)
            {
                OCT2 = OCT2 + 4;
            }
            if (v64 == true)
            {
                OCT3 = OCT3 + 1;
            }
            if (v128 == true)
            {
                OCT3 = OCT3 + 2;
            }
            return OCT3.ToString() + OCT2.ToString() + OCT1.ToString();
        }
        #endregion
        #region Condicional BIN
        private byte[] GetBIN(int num)
        {
            byte[] binary = {0, 0, 0, 0, 0, 0, 0, 0};
            double value = 128;
            for (int i = 0; i < binary.Length; i++)
            {                
                if (num >= value)
                {
                    binary[i] = 1;
                }
                value = value / 2;
            }
            
            return binary;
        }


        #endregion

        #region Álgebra booleana
       /*private int GetNot(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                byte[] binary = GetBIN(array[i]);
            }

            return binary;
        }*/
        #endregion
        private void GetValuesBoolean(bool v128 = false, bool v64 = false, bool v32 = false, bool v16 = false, bool v8 = false, bool v4 = false, bool v2 = false, bool v1 = false)
        {
            string valueBooleanDEC = GetDecimal(v128, v64, v32, v16, v8, v4, v2, v1);
            string valueBooleanHEX = GetHexadecimal(v128, v64, v32, v16, v8, v4, v2, v1);
            string valueBooleanOCT = GetOctal(v128, v64, v32, v16, v8, v4, v2, v1);
        }

        #endregion


        /*private byte[] NOT(byte[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetNot(array);
            }

            return;
        }*/
        byte[] returno; //Essa variável não consegue criar mais vetores para a comunicação com os outros métodos
        public string AND(string txt1, string txt2)
        {
            if (txt1.Length == txt2.Length)
            {
                byte[] array1 = Encoding.UTF8.GetBytes(txt1);
                byte[] array2 = Encoding.UTF8.GetBytes(txt2);
                
                for (int i = 0; i < array1.Length; i++)
                {
                    returno[i] = Convert.ToByte(bAND(Convert.ToInt32(array1[i]), Convert.ToInt32(array2[i])));
                }
                return Encoding.UTF8.GetString(returno);
            }
            return "ERRO";
        }

        private int bAND(int num1, int num2)
        {
            byte[] binary1 = GetBIN(num1);
            byte[] bynary2 = GetBIN(num2);//erro aqui no GetBIN
            byte[] returno = {0, 0, 0, 0, 0, 0, 0, 0};
            for (int i = 0; i < 7; i++)
            {
                if (binary1[i] == 1 && bynary2[i] == 1)
                {
                    returno[i] = 1;
                }
                else
                {
                    returno[i] = 0;
                }
            }
            int saida = 0, index = 128;
            for (int i = 0; i < 7; i++)
            {
                if (returno[i] == 1)
                {
                    saida = saida + index;
                }
                index = index / 2;
            }
            return saida;
        }
    }
}
