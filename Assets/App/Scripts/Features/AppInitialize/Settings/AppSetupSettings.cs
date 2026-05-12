using UnityEngine;

namespace App.Scripts.Features.AppInitialize.Settings
{
    [CreateAssetMenu(fileName = "appSetupSettings", menuName = "App/App Setup/Settings")]
    public class AppSetupSettings : ScriptableObject
    {
        public int targetFrameRate = 60;
        public bool isMultiTouchEnabled = false;
    }
}