using App.Scripts.Modules.StateMachine;
using App.Scripts.Scenes.GameScene.SelectMonth.Controllers;
using Cysharp.Threading.Tasks;

namespace App.Scripts.Scenes.GameScene.StateMachine.States
{
    public class SelectMonthState : IState
    {
        private readonly ISelectMonthController _selectMonthController;

        public SelectMonthState(ISelectMonthController selectMonthController)
        {
            _selectMonthController = selectMonthController;
        }

        public UniTask Enter()
        {
            return _selectMonthController.ShowSelectMonthPanel();
        }

        public UniTask Exit()
        {
            return _selectMonthController.HideSelectMonthPanel();
        }

        public void Update()
        {
            
        }
    }
}