using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov_9
{
    public class BCipher : ICipher
    {
        public string Decode(string str)
        {
            Console.WriteLine("происходит замена...");
            Console.WriteLine("Замечание! Буква 'ё' в методе не реализуется, вы её не можете использовать");
            char[] Chars = str.ToCharArray();
            for (int i = 0; i < Chars.Length; i++)
            {
                if ((char.IsLetter(Chars[i])))
                {
                    if (((int)Chars[i] >= 65 && (int)Chars[i] <= 90) || ((int)Chars[i] >= 97 && (int)Chars[i] <= 122))
                    {
                        if (char.IsUpper(Chars[i]))
                        {
                            Chars[i] = (char)(90 - ((int)Chars[i] - 65)); // замена заглавной буквы
                        }
                        else
                        {
                            Chars[i] = (char)(122 - ((int)Chars[i] - 97)); // замена прописной буквы
                        }
                    }
                    if (IsInRange(Chars[i], 'А', 'Я'))
                    {
                        Chars[i] = (char)('А' + ('Я' - Chars[i]));
                    }
                    else if (IsInRange(Chars[i], 'а', 'я'))
                    {
                        Chars[i] = (char)('а' + ('я' - Chars[i]));
                    }
                }
            }
            return new string((Chars));
        }
        public string Encode(string str)
        {
            return Decode(str);
        }
        private bool IsInRange(char symbol, char start, char end)
        {
            return symbol >= start && symbol <= end;
        }
    }
}
