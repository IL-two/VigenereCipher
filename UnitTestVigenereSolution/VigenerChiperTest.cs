using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VigenereSolution;

namespace UnitTestVigenereSolution
{
    [TestClass]
    public class VigenerChiperTest
    {
        [TestMethod]
        public void RussianTestEncrypt()
        {
            VigenereСipher vigenereСipher = new VigenereСipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            string key = "ключ";
            string text = "Мама мыла раму!";

            string expected = "ЧЛКЧ ЧЖЙЧ ЫЛКК!";

            string result = vigenereСipher.Encrypt(text, key);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RussianDencrypt()
        {
            VigenereСipher vigenereСipher = new VigenereСipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            string key = "ключ";
            string text = "ЧЛКЧ ЧЖЙЧ ЫЛКК!";

            string expected = "МАМА МЫЛА РАМУ!";

            string result = vigenereСipher.Dencrypt(text, key);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EnglishTestEncrypt()
        {
            VigenereСipher vigenere = new VigenereСipher();
            string text = "wikiHow is the best";
            string key = "LIME";

            string expected = "HQWMSWI MD BTI MMEX";

            string result = vigenere.Encrypt(text, key);

            Assert.AreEqual(expected, result);            
        }

        [TestMethod]
        public void EnglishTestDencrypt()
        {
            VigenereСipher vigenere = new VigenereСipher();
            string text = "HQWMSWI MD BTI MMEX";
            string key = "LIME";

            string expected = "WIKIHOW IS THE BEST";

            string result = vigenere.Dencrypt(text, key);

            Assert.AreEqual(expected, result);
        }
    }
}
