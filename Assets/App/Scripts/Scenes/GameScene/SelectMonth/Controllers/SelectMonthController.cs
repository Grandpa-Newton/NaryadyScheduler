using App.Scripts.Scenes.GameScene.SelectMonth.UI;
using App.Scripts.Scenes.GameScene.Settings;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace App.Scripts.Scenes.GameScene.SelectMonth.Controllers
{
    public class SelectMonthController : ISelectMonthController
    {
        private readonly Button _selectMonthButton;
        private readonly CanvasGroup _panel;
        private readonly SelectMonthSettings _selectMonthSettings;
        private readonly SelectMonthFoldout _monthFoldout;
        private readonly SelectYearFoldout _yearFoldout;

        public SelectMonthController(CanvasGroup panel, Button selectMonthButton, SelectMonthFoldout monthFoldout,
            SelectYearFoldout yearFoldout, SelectMonthSettings selectMonthSettings)
        {
            _panel = panel;
            _monthFoldout = monthFoldout;
            _yearFoldout = yearFoldout;
            _selectMonthButton = selectMonthButton;
            _selectMonthSettings = selectMonthSettings;
        }

        public async UniTask ShowSelectMonthPanel()
        {
            _monthFoldout.PrepareFoldout(_selectMonthSettings.monthsNames);
            _yearFoldout.Prepare(_selectMonthSettings.minYear, _selectMonthSettings.maxYear);
            await _panel.DOFade(1f, _selectMonthSettings.panelShowDuration);
            _selectMonthButton.onClick.AddListener(OnClickSelectButton);
        }

        public async UniTask HideSelectMonthPanel()
        {
            _selectMonthButton.onClick.RemoveListener(OnClickSelectButton);
            await _panel.DOFade(0f, _selectMonthSettings.panelShowDuration);
        }

        private void OnClickSelectButton()
        {
            var month = _monthFoldout.GetMonthId();
            var year = _yearFoldout.GetYear();
            Debug.Log($"[month] month = {month}, year = {year}");
            //_stateMachineController.ChangeStateByType<MenuState>(); //TODO: куда-то это все нужно вынести
        }
        
        
    }
}