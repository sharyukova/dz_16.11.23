using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team Russia = new Team("Russia");
            Russia.PlayGame(new Горка());
            Team France = new Team("France");
            France.PlayGame(new В_мире_животных());
            Team China = new Team("China");
            China.PlayGame(new Почтальоны());
            Team Kazakhstan = new Team("Kazakhstan");
            Kazakhstan.PlayGame(new Море());
            Kazakhstan.PlayGame(new Мышеловка());
        }
    }
}