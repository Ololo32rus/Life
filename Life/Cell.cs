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
        private int speed;
        private char look;
        private int hp;
        private Random rnd;


        public Cell()
        {
            x = y = 0;
            color = ConsoleColor.Red;
            speed = 1;
            look = '*';
            hp = 100;
        }

        public Cell(int x, int y, ConsoleColor color, int speed, char look, int hp)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.speed = speed;
            this.look = look;
            this.hp = hp;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(look);
        }

        public void Move()
        {
            x += speed;
            y += speed;
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
