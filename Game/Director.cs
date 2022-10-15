using System;


namespace QuestionGame
{
    public class Director
    {
        public bool _isPlaying = true;
        public Director()
        {
        }

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void GetInputs()
        {
            Questions game = new Questions();
            game.Main();
        }

        private void DoUpdates()
        {
            null;
        }
        private void DoOutputs();
        {
            null;
        }
    }
}