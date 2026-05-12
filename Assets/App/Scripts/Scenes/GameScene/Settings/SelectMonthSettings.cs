using UnityEngine;

namespace App.Scripts.Scenes.GameScene.Settings
{
    [CreateAssetMenu(fileName = "selectMonthSettings", menuName = "App/Program/Select Month Settings")]
    public class SelectMonthSettings : ScriptableObject
    {
        public float panelShowDuration = 0.5f;
        public int minYear = 2026;
        public int maxYear = 2100;

        public string[] monthsNames =
        {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
        };
    }
}