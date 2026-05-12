using Cysharp.Threading.Tasks;

namespace App.Scripts.Modules.StateMachine
{
    public interface IState
    {
        UniTask Enter();
        UniTask Exit();
        void Update();
    }
}