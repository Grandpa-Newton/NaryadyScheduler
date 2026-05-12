using App.Scripts.Modules.StateMachine;
using App.Scripts.Scenes.GameScene.StateMachine;
using Zenject;

namespace App.Scripts.Scenes.GameScene.SceneInitialization.Installers.Infrastructure.StateMachine
{
    public class StateMachineInstaller : Installer<StateMachineInstaller>
    {
        public override void InstallBindings()
        {
            GameSceneStatesInstaller.Install(Container);
            Container.Bind<IStateMachine>().To<Modules.StateMachine.StateMachine>().AsSingle();
            Container.Bind(typeof(IStateMachineController), typeof(IInitializable)).To<StateMachineController>()
                .AsSingle();
        }
    }
}