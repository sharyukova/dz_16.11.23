using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Пляж : IGame
    {
        public void Play()
        {
            Console.WriteLine("Всего в конкурсе участвуют 7 атлетов.");
            Console.WriteLine("Задача команды по-одному спуститься на резиновой лодке в бассейн с водой и вместе с этой лодкой забраться на островок, причём, только первый участник имеет право держаться за трос в середине острова.");
            Console.WriteLine("Главная особенность в том, что с каждым прибывшим участником устоять на шатком острове становится всё сложнее.");
            Console.WriteLine("Победа присуждается той команде, у которой все 7 участников с лодками окажутся на острове за минимальное время.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
