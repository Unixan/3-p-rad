namespace _3_på_rad
{
    internal class Square
    {
        private int _content;
        
        public bool IsEmpty()
        {
            return _content == 0;
        }

        public bool Player()
        {
            return _content == 1;
        }

        public void Mark(bool isPlayer1)
        {
            if (IsEmpty())
            {
                _content = isPlayer1 ? 1 : 2;
            }
        }
    }
}
