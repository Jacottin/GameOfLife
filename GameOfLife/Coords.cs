namespace GameOfLife
{
    public struct Coords
    {
        private int _x { get; set; }
        private int _y { get; set; }

        public Coords(int X, int Y)
        {
            _x = 0;
            _y = 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}