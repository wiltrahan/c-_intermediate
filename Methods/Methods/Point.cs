using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x; //10
            this.Y = y; //20
        }

        public void Move(int x, int y)
        {
            this.X = x; //40
            this.Y = y; //60
        }

        public void Move(Point newLocation)
        {
            if(newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            Move(newLocation.X, newLocation.Y);
        }
    }
}