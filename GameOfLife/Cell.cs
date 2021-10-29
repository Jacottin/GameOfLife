namespace GameOfLife
{
    public class Cell
    {
        private bool _isAlive;
        private bool _nextState;
        
        public bool isAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public bool nextState
        {
            get { return _nextState; }
            set { _nextState = value; }
        }


        public bool Cell(bool state)
        {
            isAlive = false;
            return state;
        }

        public void ComeAlive()
        {
            nextState = true;
        }

        public void PassAway()
        {
            nextState = false;
        }

        public void Update()
        {
            isAlive = nextState;
        }
    }
}