namespace App.Scripts.Modules.StateMachine
{
    public class StateMachine : IStateMachine
    {
        private IState _currentState;
        
        public void ChangeState(IState newState)
        {
            if (_currentState == newState || _currentState == null)
            {
                return;
            }
            
            _currentState?.Exit();
            _currentState = newState;
            newState.Enter();
        }

        public void Update()
        {
            _currentState?.Update();
        }
    }
}