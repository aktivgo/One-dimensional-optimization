namespace One_dimensional_optimization.Tools
{
    public class Point
    {
        private double x;
        private string description = "";

        public Point(double x)
        {
            this.x = x;
        }

        public Point(double x, string description)
        {
            this.x = x;
            this.description = description;
        }
    }
}