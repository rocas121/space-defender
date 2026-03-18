using UnityEngine;

namespace SpaceDefender.Core
{
    public class Enemy
    {
        public int Health { get; private set; } = 100;
        public bool IsAlive => Health > 0 ;

        public void TakeDamage(int amount)
        {

            if (amount <= 0)
            {
                Debug.LogWarning("TakeDamage amount is not positive.");
                return;
            }
            else if(amount > Health)
            {
                Health = 0;
                return;
            }
                Health -= amount;
        }

        public void Heal(int amount) {
            /* TODO : Health max = 100 */

            if (Health < 100)
            {

                if ((Health + amount) > 100)
                {
                    Health = 100;
                } else {
                    Health += amount;
                }
            }

        }

        public int GetReward()
        {
            if (!IsAlive)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }
    }
}
