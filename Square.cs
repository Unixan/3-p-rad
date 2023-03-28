namespace _3_på_rad
{
    internal class Square
    {
        private int _occupied;

        public Square()
        {
            _occupied = 0;
        }
        public bool Unchecked()
        {
            return _occupied == 0;
        }

        public bool Player()
        {
            return _occupied == 1;
        }
    }
}
