using App.Scripts.Modules.StateMachine;
using Cysharp.Threading.Tasks;

namespace App.Scripts.Scenes.GameScene.StateMachine.States
{
    public class MenuState : IState
    {
        public UniTask Enter()
        {
            return UniTask.CompletedTask;
        }

        public UniTask Exit()
        {
            return UniTask.CompletedTask;
        }

        public void Update()
        {
            //TODO: тут будет menucontroller, который управляет вкладками, и тут он апдэйтится (для, например, отслеживания кликов и свайпов вкладок
        }
    }
}