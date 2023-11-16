using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Горка : IGame
    {
        public void Play()
        {
            Console.WriteLine("В финальном конкурсе «Горки» трём представителям от каждой команды нужно с помощью шеста подняться на вершину горки.");
            Console.WriteLine("Благодаря очкам, заработанным в прошлых конкурсах, стартуют участники с разных позиций.");
            Console.WriteLine("Представители команды, которые придут первыми, принесут победу всей своей команде в игре.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
