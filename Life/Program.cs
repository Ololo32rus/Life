/* Жизнь. Клетка (x,y) - пол м/ж, движение клеток. Если м столкнулось с ж = новая клетка. если одинакового
пола умирает та у который жизней меньше(та которая выйграла ее хп + половина от той которая погибла) */

using Life;
using System.Drawing;
using System;
using System.Threading;

namespace Life
{

    class Program
    {
        static void Main(string[] args)
        {
            CellManager manager = new CellManager(
                3, Console.WindowWidth - 3, //x
                0, Console.WindowHeight - 1, //y
               15
                );

            manager.Run();

            Console.ReadKey();
        }
    }
}
