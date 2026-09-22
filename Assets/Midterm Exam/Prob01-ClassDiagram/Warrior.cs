using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int shieldDfefense;

        private float rage;

        public override void attack(GameEntity target)
        {
            // Implement attack logic for Warrior
            Debug.Log("Warrior attacks the target!");
        }

        public void ShieldBash(GameEntity target)
        {
            // Implement shield bash logic
            Debug.Log("Warrior performs a shield bash!");
        }
    }
}
