using System.Xml.Serialization;
using UnityEngine;

namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        public int BaseScore { get; private set; } = 0;

        public float Multiplier { get; private set; } = 1.0f;
        

        public int Calculate(int kills, int time)
        {
            if (kills == 0)
            {
                return 0;
            }
            else  
            {
                ApplyCombo(kills);
                ResetMultiplier();
                return BaseScore;
            }

        }

        public void ApplyCombo (int comboCount)
        {
            Multiplier += comboCount - 1;
        }

        public void ResetMultiplier()
        {
            if (Multiplier > 1f)
            {
                Multiplier = 1.0f;
            }
        }
    }
}
