using App.Scripts.Modules.StateMachine;
using App.Scripts.Scenes.GameScene.StateMachine.States;
using Zenject;

namespace App.Scripts.Scenes.GameScene.SceneInitialization.Installers.Infrastructure.StateMachine
{
    public class GameSceneStatesInstaller : Installer<GameSceneStatesInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IState>().To<MenuState>().AsSingle();
        }
    }
}