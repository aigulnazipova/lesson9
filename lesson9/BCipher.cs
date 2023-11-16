using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    public class BCipher : ICipher
    {
        /// <summary>
        /// Данный метод реализовывает шифрование строки.
        /// </summary>
        public string Encode(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = (char)('А' + 'Я' - chars[i]);
                }
            }
            return new string(chars);
        }

        /// <summary>
        /// Данный метод реализовывает дешифровку строки.
        /// </summary>
        public string Decode(string s)
        {
            return Encode(s);
        }
    }
}
