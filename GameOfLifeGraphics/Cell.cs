namespace GameOfLifeGraphics
{
    public class Cell
    {
        public bool IsAlive { get; private set; }
        private bool _nextState;

        public Cell(bool state)
        {
            IsAlive = state;
        }

        public void ComeAlive()
        {
            _nextState = true;
        }

        public void PassAway()
        {
            _nextState = false;
        }

        public void Update()
        {
            IsAlive = _nextState;
        }
    }
}