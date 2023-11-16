using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov_9
{
    public class ACipher : ICipher
    {
        public string Encode(string str)
        {
            Console.WriteLine("происходит процесс сдвига буквы алфавита...");
            Console.WriteLine("Замечание! Буква 'ё' в методе не реализуется, вы её не можете использовать");
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    // латиница
                    if (((int)chars[i] >= 65 && (int)chars[i] <= 90) || ((int)chars[i] >= 97 && (int)chars[i] <= 122))
                    {
                        if (char.IsUpper(chars[i]))
                        {
                            chars[i] = (char)(((int)chars[i] - 65 + 1) % 26 + 65); // сдвиг на одну позицию, если это заглавная буква
                                                                                   // используем '%26',
                                                                                   // чтобы не возникало ситуаций с буквой 'Z'
                        }
                        else
                        {
                            chars[i] = (char)(((int)chars[i] - 97 + 1) % 26 + 97); // сдвиг на одну позицию, если это прописная буква
                        }
                    }
                    // кириллица
                    if (IsInRange(chars[i], 'А', 'Я'))
                    {
                        chars[i]++;
                    }
                    else if (IsInRange(chars[i], 'а', 'я'))
                    {
                        chars[i]++;
                    }
                }
            }
            return new string(chars);
        }
        public string Decode(string str)
        {
            return Encode(str);
        }
        private bool IsInRange(char symbol, char start, char end)
        {
            return symbol >= start && symbol <= end;
        }
    }
}
