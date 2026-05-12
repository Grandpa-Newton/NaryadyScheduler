using App.Scripts.Modules.StateMachine;

namespace App.Scripts.Scenes.GameScene.StateMachine
{
    public interface IStateMachineController
    {
        public void ChangeState<T>() where T : IState;
    }
}