using App.Scripts.Scenes.GameScene.SelectMonth.Controllers;
using App.Scripts.Scenes.GameScene.SelectMonth.UI;
using App.Scripts.Scenes.GameScene.Settings;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace App.Scripts.Scenes.GameScene.SelectMonth.Installers
{
    public class SelectMonthInstaller : MonoInstaller
    {
        [SerializeField] private SelectMonthSettings selectMonthSettings;
        [SerializeField] private TMP_Dropdown monthDropdown;
        [SerializeField] private TMP_Dropdown yearDropdown;
        [SerializeField] private Button selectMonthButton;
        [SerializeField] private CanvasGroup panel;

        public override void InstallBindings()
        {
            Container.Bind<SelectMonthFoldout>().ToSelf().AsSingle().WithArguments(monthDropdown);
            Container.Bind<SelectYearFoldout>().ToSelf().AsSingle().WithArguments(yearDropdown);

            Container.Bind<ISelectMonthController>().To<SelectMonthController>().AsSingle()
                .WithArguments(selectMonthButton, panel, selectMonthSettings);
        }
    }
}