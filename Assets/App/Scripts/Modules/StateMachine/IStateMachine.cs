namespace App.Scripts.Modules.StateMachine
{
    public interface IStateMachine
    {
        void ChangeState(IState newState);

        void Update();
    }
}