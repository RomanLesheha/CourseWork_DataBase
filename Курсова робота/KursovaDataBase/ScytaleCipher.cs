using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaDataBase
{
    public class ScytaleCipher
    {
        /// <summary>
        /// Шифрування паролю шифром Давньої Спарти
        /// </summary>
        /// <param name="text">Текст,який хочете зашифрувати</param>
        /// <param name="diametr">Діаметр циліндра шифруванняя</param>
        /// <returns></returns>
        static public string Encrypt(string text, int diametr)
        {
            var k = text.Length % diametr;
            if (k > 0)
            {
                //доповнюємо рядок пробілами
                text += new string(' ', diametr - k);
            }

            var column = text.Length / diametr;
            var result = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < diametr; j++)
                {
                    result += text[i + column * j].ToString();
                }
            }

            return result;
        }
        /// <summary>
        /// Розшифровування паролю
        /// </summary>
        /// <param name="text"></param>
        /// <param name="diametr"></param>
        /// <returns></returns>
        static public string Decrypt(string text, int diametr)
        {
            var column = text.Length / diametr;
            var symbols = new char[text.Length];
            int index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < diametr; j++)
                {
                    symbols[i + column * j] = text[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }
    }
}
