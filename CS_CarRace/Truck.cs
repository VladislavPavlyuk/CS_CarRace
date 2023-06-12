
using Delegate;
using System.Diagnostics;

namespace CS_CarRace
{
    public class Truck : Car
    {
        public int _speed, _x = 1, _y = 2;

        public int Speed
        { 
            set => _speed = value;

            get => _speed; 
        }

        public int X
        {
            set => _x = value;

            get => _x;
        }

        public int Y
        {
            set => _y = value;

            get => _y;
        }

        public override void Drive() 
        {
            if (X < 100)
            {
                Speed = (int)(Start?.Invoke());
                X += Speed;
            }
            else
            {
                Finish?.Invoke();
                X = Speed;
            }
            Print(X,Y);
        }


        public override void Print(int _x, int _y)
        {

            Console.SetCursorPosition(_x, _y);
            Console.Write(" ================\\");
                Console.SetCursorPosition(_x, _y++);
            Console.Write(" |----------||@  \\   ___");
            Console.SetCursorPosition(_x, _y++);
            Console.Write(" | ____|_____|||_/_\\_|___|_");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("<|  ___\\   ||     | ____  |");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("<| /    |___||_____|/    | |");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("||/  O  |__________/  O  |_||");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("  \\___ / TRUCK     \\___/");           

        }

        public event CarRaceStateHandler Start;
        public event CarRaceStateHandler Finish;
    }
}
