

namespace CS_CarRace
{
    public abstract class Car
    {
        public int _speed, _x, _y;

        public int Speed;

        public abstract void Drive();

        public abstract void Print(int _x,int _y);
    }
}
