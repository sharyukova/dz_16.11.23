using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Почтальоны : IGame
    {
        public void Play()
        {
            Console.WriteLine("Игрокам необходимо перенести чемоданы с одного конца арены на другой.");
            Console.WriteLine("Сложность в том что по арене бегает бык, а чемоданы имеют вес несоответствующий размерам (маленький чемодан может весить порядка 30 кг, а огромный с виду чемодан — всего лишь 1 кг).");
            Console.WriteLine(" Победу в этом конкурсе одерживает та команда, которая перенесёт наибольшее количество чемоданов.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
