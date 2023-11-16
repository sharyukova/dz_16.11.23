using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Мышеловка : IGame
    {
        public void Play()
        {
            Console.WriteLine("Здесь принимают участие по два человека от двух команд.");
            Console.WriteLine("В костюмах мышей поочерёдно они должны миновать препятствия и попасть в большой кусок сыра, расположенный в центре арены.");
            Console.WriteLine("Там они должны взять маленький кусочек сыра и принести его в свой ящик.");
            Console.WriteLine(" Сложность в том, что на арене присутствует бык. Выигрывает команда, которая принесёт наибольшее количество сыра.");
            Console.WriteLine("");
            Console.WriteLine();
        }
    }
}
