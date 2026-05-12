using TMPro;

namespace App.Scripts.Scenes.GameScene.SelectMonth.UI
{
    public class SelectYearFoldout
    {
        private readonly TMP_Dropdown _dropdown;

        public SelectYearFoldout(TMP_Dropdown dropdown)
        {
            _dropdown = dropdown;
        }
        public void Prepare(int minYear, int maxYear)
        {
            _dropdown.ClearOptions();
            
            for (int year = minYear; year <= maxYear; year++)
            {
                _dropdown.options.Add(new TMP_Dropdown.OptionData(year.ToString()));
            }
        }

        public int GetYear()
        {
            return int.Parse(_dropdown.options[_dropdown.value].text);
        }
    }
}