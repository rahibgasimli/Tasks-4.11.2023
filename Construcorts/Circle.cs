namespace Construcorts
{
    class Circle
    {
        public double Radius;

        public double CalculateArea()
        {
            //return 2* Math.PI * Radius * Radius;
            return 2 * Math.PI * Math.Pow(Radius, 2);
        }

    }
}

