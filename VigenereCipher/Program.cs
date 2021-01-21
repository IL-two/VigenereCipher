using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereСipher vigenere = new VigenereСipher();
            string inputText = "wikiHow is the best";
            string inputKey = "LIME";

            //VigenereСipher vigenere = new VigenereСipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            //string inputKey = "ключ";
            //string inputText = "Мама мыла раму!";

            string result = vigenere.Encrypt(inputText, inputKey);
            Console.WriteLine(result);
            result = vigenere.Dencrypt(result, inputKey);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
