using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int mana;

        private int spellPower;

        public override void attack(GameEntity target)
        {
            // Implement attack logic for Mage
            Debug.Log("Mage attacks the target!");
        }

        public void CastSpell(GameEntity target)
        {
            // Implement spell casting logic
            Debug.Log("Mage casts a spell on the target!");
        }
    }
}
