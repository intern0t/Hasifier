using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hasifer
{
    class Identification
    {
        public static string IdentifyHash(string hash)
        {
            string toReturn = string.Empty;

            if (hash.Length.Equals(32))
            {
                toReturn = "MD5";
            }
            else
            {
                int length = hash.Length;
                if (length.Equals(40))
                {
                    toReturn = "SHA-1, MySQL5";
                }
                else
                {
                    length = hash.Length;
                    if (length.Equals(13))
                    {
                        toReturn = "DES (Unix)";
                    }
                    else
                    {
                        length = hash.Length;
                        if (length.Equals(16))
                        {
                            toReturn = "MySQL, DES (Oracle)";
                        }
                        else
                        {
                            length = hash.Length;
                            if (length.Equals(41) & hash.StartsWith("*"))
                            {
                                toReturn = "MySQL5";
                            }
                            else
                            {
                                length = hash.Length;
                                if (length.Equals(64))
                                {
                                    toReturn = "SHA-256";
                                }
                                else
                                {
                                    length = hash.Length;
                                    if (length.Equals(96))
                                    {
                                        toReturn = "SHA-384";
                                    }
                                    else
                                    {
                                        length = hash.Length;
                                        if (length.Equals(128))
                                        {
                                            toReturn = "SHA-512";
                                        }
                                        else
                                        {
                                            int num1 = hash.StartsWith("$1$") ? 1 : 0;
                                            length = hash.Length;
                                            int num2 = length.Equals(34) ? 1 : 0;
                                            if ((num1 & num2) != 0)
                                            {
                                                toReturn = "MD5 (Unix)";
                                            }
                                            else
                                            {
                                                int num3 = hash.StartsWith("$apr1$") ? 1 : 0;
                                                length = hash.Length;
                                                int num4 = length.Equals(37) ? 1 : 0;
                                                if ((num3 & num4) != 0)
                                                {
                                                    toReturn = "MD5 (APR)";
                                                }
                                                else
                                                {
                                                    int num5 = hash.StartsWith("$H$") ? 1 : 0;
                                                    length = hash.Length;
                                                    int num6 = length.Equals(34) ? 1 : 0;
                                                    if ((num5 & num6) != 0)
                                                    {
                                                        toReturn = "MD5 (phpBB3)";
                                                    }
                                                    else
                                                    {
                                                        int num7 = hash.StartsWith("$P$") ? 1 : 0;
                                                        length = hash.Length;
                                                        int num8 = length.Equals(34) ? 1 : 0;
                                                        if ((num7 & num8) != 0)
                                                        {
                                                            toReturn = "MD5 (Wordpress)";
                                                        }
                                                        else
                                                        {
                                                            int num9 = hash.StartsWith("$5$") ? 1 : 0;
                                                            length = hash.Length;
                                                            int num10 = length.Equals(39) ? 1 : 0;
                                                            if ((num9 & num10) != 0)
                                                            {
                                                                toReturn = "SHA-256 (Unix)";
                                                            }
                                                            else
                                                            {
                                                                int num11 = hash.StartsWith("$6$") ? 1 : 0;
                                                                length = hash.Length;
                                                                int num12 = length.Equals(39) ? 1 : 0;
                                                                if ((num11 & num12) != 0)
                                                                {
                                                                    toReturn = "SHA-512 (Unix)";
                                                                }
                                                                else
                                                                {
                                                                    length = hash.Length;
                                                                    if (length.Equals(24) & hash.EndsWith("=="))
                                                                    {
                                                                        toReturn = "MD5 (Base-64)";
                                                                    }
                                                                    else
                                                                    {
                                                                        length = hash.Length;
                                                                        if (length.Equals(28) & hash.EndsWith("="))
                                                                        {
                                                                            toReturn = "SHA-1 (Base-64)";
                                                                        }
                                                                        else
                                                                        {
                                                                            length = hash.Length;
                                                                            if (length.Equals(40) & hash.EndsWith("=="))
                                                                            {
                                                                                toReturn = "SHA-224 (Base-64)";
                                                                            }
                                                                            else
                                                                            {
                                                                                length = hash.Length;
                                                                                if (length.Equals(88) & hash.EndsWith("=="))
                                                                                {
                                                                                    toReturn = "SHA-512 (Base-64)";
                                                                                }
                                                                                else
                                                                                {
                                                                                    length = hash.Length;
                                                                                    if (length.Equals(44) & hash.EndsWith("="))
                                                                                        toReturn = "SHA-256 (Base-64)";
                                                                                    else
                                                                                        toReturn = "Invalid Input/ Unidentified";
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return toReturn;
        }
    }
}
