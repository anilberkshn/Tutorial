using System.Drawing;

namespace Tutorial
{
    public struct HwStructPoint
    {
        public int _x;
        public int _y;

        public HwStructPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static bool operator ==(HwStructPoint p1, HwStructPoint p2)
        {
            return p1._x != p2._x && p1._y != p2._y;
        }
        public static bool operator !=(HwStructPoint p1, HwStructPoint p2)
        {
            return p1._x != p2._x && p1._y != p2._y;
        }

        public override bool Equals(object? obj)
        {
            return obj is HwStructPoint p && this._x ==p._x && this._y == p._y;
        }

        public override int GetHashCode()
        {
            return (_x, _y).GetHashCode();
        }
        
    }
}