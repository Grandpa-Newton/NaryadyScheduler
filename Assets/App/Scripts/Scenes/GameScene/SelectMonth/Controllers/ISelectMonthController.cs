using Cysharp.Threading.Tasks;

namespace App.Scripts.Scenes.GameScene.SelectMonth.Controllers
{
    public interface ISelectMonthController
    {
        UniTask ShowSelectMonthPanel();
        UniTask HideSelectMonthPanel();
    }
}