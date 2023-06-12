
using Delegate;

namespace CS_CarRace
{
    public class Roadster : Car
    {

        public int _speed, _x = 1, _y = 32;

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
            Print(X, Y);
        }

        public override void Print(int _x, int _y)
        {

            Console.SetCursorPosition(_x, _y);
            Console.Write("_    __");
            Console.SetCursorPosition(_x, _y++);
            Console.Write(" --          ~( @\\ \\");
                Console.SetCursorPosition(_x, _y++);
            Console.Write("-- -   _________]_[__/_>________");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("      /  ____\\ <>     |  ____ \\");
                Console.SetCursorPosition(_x, _y++);
            Console.Write("    =\\_/ __\\_\\______|_/ __ \\_D");
            Console.SetCursorPosition(_x, _y++);
            Console.Write(" ________(__)_____________(__)____");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("             roadster       ");
;
        }

        public event CarRaceStateHandler Start;
        public event CarRaceStateHandler Finish;
    }
}
