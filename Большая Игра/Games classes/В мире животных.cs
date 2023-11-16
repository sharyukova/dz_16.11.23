using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    public class В_мире_животных : IGame
    {
        public void Play()
        {
            // я не нашла правила игры "Рыбалка", поэтому создала эту
            Console.WriteLine("«Бегемоты» на велосипедах должны довезти «жирафов» до мостика, где «жирафы» должны достать слюнявчики, подвешенные над вращающимися кругами, и усесться на скользком бревне. ");
            Console.WriteLine("Конкурс на выбывание. Кто последний – тот и проиграл.");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
