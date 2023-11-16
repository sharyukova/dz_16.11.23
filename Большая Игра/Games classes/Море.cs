using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Море : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игроки из двух команд находятся под полотнищем, ударяют по нему ногами.");
            Console.WriteLine("А игроки других команд должны пройти по полотну пронеся как можно больше воды в вёдрах.");
            Console.WriteLine("Полотнище будет двигаться не только благодаря усилиям снизу лежащих игроков, но будет влажным и мыльным.");
            Console.WriteLine("Побеждает команда, которая соберёт больше воды.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
