using App.Scripts.Features.AppInitialize.Settings;
using UnityEngine;
using Zenject;

namespace App.Scripts.Features.AppInitialize.Services
{
    public class AppSetupService : IInitializable
    {
        private readonly AppSetupSettings _settings;

        public AppSetupService(AppSetupSettings settings)
        {
            _settings = settings;
        }
        
        public void Initialize()
        {
            Application.targetFrameRate = _settings.targetFrameRate;
            Input.multiTouchEnabled = _settings.isMultiTouchEnabled;
        }
    }
}