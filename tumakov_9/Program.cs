using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки\r\nшифрования строк. В интерфейсе объявляются два метода encode() и decode(), которые\r\nиспользуются для шифрования и дешифрования строк, соответственно. Создать класс\r\nACipher, реализующий интерфейс ICipher. Класс шифрует строку посредством сдвига\r\nкаждого символа на одну «алфавитную» позицию выше. Например, в результате такого\r\nсдвига буква А становится буквой Б. Создать класс BCipher, реализующий интерфейс\r\nICipher. Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й\r\nпозиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца\r\nалфавита. Например, буква В заменяется на букву Э. Написать программу,\r\nдемонстрирующую функционирование классов.");
            Console.WriteLine();
            string str = "CdefgH";
            string strInСyrillic = "Привет";
            Console.WriteLine(str);
            ACipher aCipher = new ACipher();
            Console.WriteLine(aCipher.Encode(str) + "\n");
            Console.WriteLine(strInСyrillic);
            Console.WriteLine(aCipher.Encode(strInСyrillic) + "\n");

            Console.WriteLine(str);
            BCipher bCipher = new BCipher();
            Console.WriteLine(bCipher.Decode(str));
            Console.WriteLine(strInСyrillic);
            Console.WriteLine(bCipher.Decode(strInСyrillic) + "\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
