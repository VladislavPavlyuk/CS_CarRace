

using Delegate;

namespace CS_CarRace
{
    public class Sedan : Car
    {

        public int _speed, _x = 1, _y = 22;

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
            Console.Write("             ________");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("    _ -_-  _/\\_____\\__");
            Console.SetCursorPosition(_x, _y++);
            Console.Write(" _ -_-__  / ,-. -|-  ,-.`-.");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("    _ -_- `( o )----( o )-'");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("           `-'      `-'");
            Console.SetCursorPosition(_x, _y++);
            Console.Write("           sedan            ");
        }
        public event CarRaceStateHandler Start;
        public event CarRaceStateHandler Finish;
    }
}
