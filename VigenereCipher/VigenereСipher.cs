using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VigenereSolution
{
    public class VigenereСipher
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string letters;
        int maxSymbols;

        public VigenereСipher(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
            maxSymbols = letters.Length;
        }

        private char GetRepeatKey(int index, string password)
        {
            int localKeyIndex = index % password.Length;
            return password[localKeyIndex];
        }

        public string Encrypt(string source, string key)
        {
            int offset = 0;
            key = key.ToUpper();
            source = source.ToUpper();
            StringBuilder resultEncrypt = new StringBuilder();

            for (int i = 0; i < source.Length; i++)
            {
                int letterIndex = letters.IndexOf(source[i]);                

                if (letterIndex < 0)
                {
                    resultEncrypt.Append(source[i].ToString());
                    offset++;
                }
                else
                {
                    int keyIndex = letters.IndexOf(GetRepeatKey(i - offset, key));
                    resultEncrypt.Append(letters[(maxSymbols + letterIndex + keyIndex) % maxSymbols].ToString());
                }                
            }

            return resultEncrypt.ToString();
        }

        public string Dencrypt(string encrypted, string key)
        {
            int offset = 0;
            key = key.ToUpper();
            encrypted = encrypted.ToUpper();
            StringBuilder resultDencrypt = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                int letterIndex = letters.IndexOf(encrypted[i]);                

                if (letterIndex < 0)
                {
                    resultDencrypt.Append(encrypted[i].ToString());
                    offset++;
                }
                else
                {
                    int keyIndex = letters.IndexOf(GetRepeatKey(i - offset, key));
                    resultDencrypt.Append(letters[(maxSymbols + letterIndex - keyIndex) % maxSymbols].ToString());
                }
            }

            return resultDencrypt.ToString();
        }
    }
}
