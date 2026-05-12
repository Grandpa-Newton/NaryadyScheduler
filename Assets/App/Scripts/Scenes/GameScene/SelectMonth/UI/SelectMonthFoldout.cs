using TMPro;

namespace App.Scripts.Scenes.GameScene.SelectMonth.UI
{
    public class SelectMonthFoldout
    {
        private readonly TMP_Dropdown _dropdown;

        public SelectMonthFoldout(TMP_Dropdown dropdown)
        {
            _dropdown = dropdown;
        }
        public void PrepareFoldout(string[] monthNames)
        {
            _dropdown.ClearOptions();

            foreach (var monthName in monthNames)
            {
                _dropdown.options.Add(new TMP_Dropdown.OptionData(monthName));
            }
        }

        public int GetMonthId()
        {
            return _dropdown.value + 1;
        }
    }
}