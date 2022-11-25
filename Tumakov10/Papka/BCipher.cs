using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10.Papka
{
    internal class BCipher:Alphabet, ICipher
    {
        public void encode(string text)
        {
            var letterQty = AlphabetConvers1.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = AlphabetConvers1.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + 1) % letterQty;
                    retVal += AlphabetConvers1[codeIndex];
                }
            }
            Console.WriteLine(retVal);
            return;

        }
        public void decode(string text)
        {
            var letterQty = AlphabetConvers1.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = AlphabetConvers1.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index - 1) % letterQty;
                    retVal += AlphabetConvers1[codeIndex];
                }
            }
            Console.WriteLine(retVal);
            return;
        }
    }
}
