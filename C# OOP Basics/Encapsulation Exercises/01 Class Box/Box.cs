namespace ClassBox
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double SurfaceArea()
        {
            return 2 * (this.length * this.width + this.width * this.height + this.length * this.height);
        }

        public double LateralSurface()
        {
            return 2 * (this.width * this.height + this.length * this.height);
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}