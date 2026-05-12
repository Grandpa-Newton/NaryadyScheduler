using App.Scripts.Features.AppInitialize.Services;
using App.Scripts.Features.AppInitialize.Settings;
using UnityEngine;
using Zenject;

namespace App.Scripts.Features.AppInitialize.Installers
{
    public class AppSetupInstaller : MonoInstaller
    {
        [SerializeField] private AppSetupSettings appSetupSettings;

        public override void InstallBindings()
        {
            Container.Bind<IInitializable>().To<AppSetupService>().AsSingle().WithArguments(appSetupSettings);
        }
    }
}