using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal class Cell
    {
        private int x, y;
        private ConsoleColor color;
        private char look;
        private int hp;
        private int gender;

        public Cell()
        {
            x = y = 0;
            color = ConsoleColor.Red;
            look = '*';
            hp = 100;
        }

        public Cell(int x, int y, int hp, int gender)
        {
            this.x = x;
            this.y = y;
            this.gender = gender;
            this.color = gender == 0 ? ConsoleColor.Red : ConsoleColor.Blue;
            this.look = gender == 0 ? '@' : '$';
            this.hp = hp;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(look);
        }

        public int Move()
        {
            Random rnd = new Random();
            int move = rnd.Next(0, 3 + 1);

            switch (move)
            {
                case 0:
                    {
                        this.Y++;
                        break;
                    }
                case 1:
                    {
                        this.Y--;
                        break;
                    }
                case 2:
                    {
                        this.X++;
                        break;
                    }
                case 3:
                    {
                        this.Y++;
                        break;
                    }
            }
            return move;
        }


        /* public int CurrentMoveX()
           { 
           int currentMoveX = rnd.Next(-1, 1 + 1);
               return currentMoveX;
           }
           public int CurrentMoveY()
           {
               int currentMoveY = rnd.Next(-1, 1 + 1);
               return currentMoveY;
           }
        */
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
        public int X
        {
            set { x = value; }
            get { return x; }
        }


    }
}
