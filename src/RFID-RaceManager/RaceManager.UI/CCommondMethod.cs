using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaceManager.UI
{
    class CCommondMethod
    {
        /// <summary>
        /// Character string turn to hexadecimal array, and character strings separated by spaces.
        /// </summary>
        /// <param name="strHexValue"></param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string strHexValue)
        {
            string[] strAryHex = strHexValue.Split(' ');
            byte[] btAryHex = new byte[strAryHex.Length];

            try
            {
                int nIndex = 0;
                foreach (string strTemp in strAryHex)
                {
                    btAryHex[nIndex] = Convert.ToByte(strTemp, 16);
                    nIndex++;
                }
            }
            catch (System.Exception ex)
            {
            	
            }

            return btAryHex;
        }

        /// <summary>
        /// Character array turn to hexadecimal array
        /// </summary>
        /// <param name="strAryHex"></param>
        /// <param name="nLen"></param>
        /// <returns></returns>
        public static byte[] StringArrayToByteArray(string[] strAryHex, int nLen)
        {
            if (strAryHex.Length < nLen)
            {
                nLen = strAryHex.Length;
            }

            byte[] btAryHex = new byte[nLen];

            try
            {
                int nIndex = 0;
                foreach (string strTemp in strAryHex)
                {
                    btAryHex[nIndex] = Convert.ToByte(strTemp, 16);
                    nIndex++;
                }
            }
            catch (System.Exception ex)
            {
            	
            }

            return btAryHex;
        }

        /// <summary>
        /// Hexadecimal character array turn to character strings
        /// </summary>
        /// <param name="btAryHex"></param>
        /// <param name="nIndex"></param>
        /// <param name="nLen"></param>
        /// <returns></returns>
        public static string ByteArrayToString(byte[] btAryHex, int nIndex, int nLen)
        {
            if (nIndex + nLen > btAryHex.Length)
            {
                nLen = btAryHex.Length - nIndex;
            }

            string strResult = string.Empty;

            for (int nloop = nIndex; nloop < nIndex + nLen; nloop++ )
            {
                string strTemp = string.Format(" {0:X2}", btAryHex[nloop]);

                strResult += strTemp;
            }

            return strResult;
        }

        /// <summary>
        /// Intercept character strings accord to specified length and archive as character array, and spaces ignored.
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="nLength"></param>
        /// <returns></returns>
        public static string[] StringToStringArray(string strValue, int nLength)
        {
            string[] strAryResult = null;

            if (!string.IsNullOrEmpty(strValue))
            {
                System.Collections.ArrayList strListResult = new System.Collections.ArrayList();
                string strTemp = string.Empty;
                int nTemp = 0;

                for (int nloop = 0; nloop < strValue.Length; nloop++ )
                {
                    if (strValue[nloop] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        nTemp++;

                        //Check intercepted characters whether in the range A~F、0~9 range, exit directly if not.
                        System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^(([A-F])*(\d)*)$");
                        if (!reg.IsMatch(strValue.Substring(nloop, 1)))
                        {
                            return strAryResult;
                        }

                        strTemp += strValue.Substring(nloop, 1);

                        //Determine whether achieve to the intercepted length.
                        if ((nTemp == nLength) || (nloop == strValue.Length - 1 && !string.IsNullOrEmpty(strTemp)))
                        {
                            strListResult.Add(strTemp);
                            nTemp = 0;
                            strTemp = string.Empty;
                        }
                    }
                }

                if (strListResult.Count > 0)
                {
                    strAryResult = new string[strListResult.Count];
                    strListResult.CopyTo(strAryResult);
                }
            }

            return strAryResult;
        }

        public static string FormatErrorCode(byte btErrorCode)
        {
            string strErrorCode = "";
            switch (btErrorCode)
            {
                case 0x10:
                    strErrorCode = "Command succeeded";
                    break;
                case 0x11:
                    strErrorCode = "Command failed";
                    break;
                case 0x20:
                    strErrorCode = "CPU reset error";
                    break;
                case 0x21:
                    strErrorCode = "Turn on CW error";
                    break;
                case 0x22:
                    strErrorCode = "Antenna is missing";
                    break;
                case 0x23:
                    strErrorCode = "Write flash error";
                    break;
                case 0x24:
                    strErrorCode = "Read flash error";
                    break;
                case 0x25:
                    strErrorCode = "Set output power error";
                    break;
                case 0x31:
                    strErrorCode = "Error occurred during inventory";
                    break;
                case 0x32:
                    strErrorCode = "Error occurred during read";
                    break;
                case 0x33:
                    strErrorCode = "Error occurred during write";
                    break;
                case 0x34:
                    strErrorCode = "Error occurred during lock";
                    break;
                case 0x35:
                    strErrorCode = "Error occurred during kill";
                    break;
                case 0x36:
                    strErrorCode = "There is no tag to be operated";
                    break;
                case 0x37:
                    strErrorCode = "Tag Inventoried but access failed";
                    break;
                case 0x38:
                    strErrorCode = "Buffer is empty";
                    break;
                case 0x40:
                    strErrorCode = "Access failed or wrong password";
                    break;
                case 0x41:
                    strErrorCode = "Invalid parameter";
                    break;
                case 0x42:
                    strErrorCode = "WordCnt is too long";
                    break;
                case 0x43:
                    strErrorCode = "MemBank out of range";
                    break;
                case 0x44:
                    strErrorCode = "Lock region out of range";
                    break;
                case 0x45:
                    strErrorCode = "LockType out of range";
                    break;
                case 0x46:
                    strErrorCode = "Invalid reader address";
                    break;
                case 0x47:
                    strErrorCode = "AntennaID out of range";
                    break;
                case 0x48:
                    strErrorCode = "Output power out of range";
                    break;
                case 0x49:
                    strErrorCode = "Frequency region out of range";
                    break;
                case 0x4A:
                    strErrorCode = "Baud rate out of range";
                    break;
                case 0x4B:
                    strErrorCode = "Buzzer behavior out of range";
                    break;
                case 0x4C:
                    strErrorCode = "EPC match is too long";
                    break;
                case 0x4D:
                    strErrorCode = "EPC match length wrong";
                    break;
                case 0x4E:
                    strErrorCode = "Invalid EPC match mode";
                    break;
                case 0x4F:
                    strErrorCode = "Invalid frequency range";
                    break;
                case 0x50:
                    strErrorCode = "Failed to receive RN16 from tag";
                    break;
                case 0x51:
                    strErrorCode = "Invalid DRM mode";
                    break;
                case 0x52:
                    strErrorCode = "PLL can not lock";
                    break;
                case 0x53:
                    strErrorCode = "No response from RF chip";
                    break;
                case 0x54:
                    strErrorCode = "Can't achieve desired output power level";
                    break;
                case 0x55:
                    strErrorCode = "Can't authenticate firmware copyright";
                    break;
                case 0x56:
                    strErrorCode = "Spectrum regulation wrong";
                    break;
                case 0x57:
                    strErrorCode = "Output power is too low";
                    break;
                case 0xFF:
                    strErrorCode = "Unknown error";
                    break;

                default:
                    break;
            }

            return strErrorCode;
        }
    }    
}
