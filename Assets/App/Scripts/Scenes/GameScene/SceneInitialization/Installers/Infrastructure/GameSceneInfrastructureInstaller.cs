using App.Scripts.Scenes.GameScene.SceneInitialization.Installers.Infrastructure.StateMachine;
using Zenject;

namespace App.Scripts.Scenes.GameScene.SceneInitialization.Installers.Infrastructure
{
    public class GameSceneInfrastructureInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            StateMachineInstaller.Install(Container);
        }
    }
}