using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int currentExp;
        
        private int gold;

        public override void attack(GameEntity target)
        {
            // Implement attack logic for Hero
            Debug.Log("Hero attacks the target!");
        }

        public void CollectGold(int amount)
        {
            gold += amount;
        }
        
        protected override void levelUp()
        {
            // Implement level up logic for Hero
            base.levelUp();
            Debug.Log("Hero leveled up!");
        }
    }
}
