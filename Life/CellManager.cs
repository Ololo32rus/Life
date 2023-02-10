using Life;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal class CellManager
    {
        private Random rnd;
        private int minX, minY, maxX, maxY;
        private Life.Cell[] cells;

        public CellManager(int minX, int maxX, int minY, int maxY, int countCells)
        {
            this.rnd = new Random();
            this.minX = minX;
            this.minY = minY;
            this.maxX = maxX;
            this.maxY = maxY;
            this.cells = new Life.Cell[countCells];

            InitCells();
        }

        private void InitCells()
        {
            char[] looks = new[] { '$', '@' };

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = new Life.Cell(
                rnd.Next(minX, maxX + 1),
                rnd.Next(minY, maxY + 1),
                (ConsoleColor)rnd.Next(10,11+1),
                rnd.Next(-1, 1 + 1),
                looks[rnd.Next(0, looks.Length)],
                rnd.Next(1, 100 + 1)
                );
            }
        }
        private void DrawCell()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].Draw();
            }
        }

        private void MoveCells()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i].Move();
                if (cells[i].X > maxX)
                {
                    cells[i].X = minX;
                }
                else if (cells[i].Y > maxY)
                {
                    cells[i].Y = minY;
                }
                else if (cells[i].X < minX)
                {
                    cells[i].X = maxX;
                }
                else if (cells[i].Y < minY)
                {
                    cells[i].Y = maxY;
                }
            }
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                MoveCells();
                DrawCell();
                Thread.Sleep(300);
            }
        }

    }
}
