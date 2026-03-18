using UnityEngine;
// Assets/Scripts/Core/Player.cs
namespace SpaceDefender.Core
{
    public class Player
    {
        public int Health { get; private set; } = 100;
        public int Lives { get; private set; } = 3;
        public int Score { get; private set; } = 0;
        public bool IsAlive => Health > 0 && Lives > 0;

        public void TakeDamage(int amount)
        {
            // TODO : implementer la logique
            // RAPPEL : Health ne peut pas etre negatif
            if (amount <= 0)
            {
                return;
            }
            else if (amount > Health)
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
        public void AddScore(int points) { /* TODO */ }
        public void LoseLife() 
        {
            /* TODO */
            Lives -= 1;
        }
    }
}
