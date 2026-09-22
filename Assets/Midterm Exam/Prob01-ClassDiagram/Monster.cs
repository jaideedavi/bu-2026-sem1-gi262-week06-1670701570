using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int baseDamage;

        protected int aggroRange;

        public override void attack(GameEntity target)
        {
            // Implement attack logic for Monster
            Debug.Log("Monster attacks the target!");
        }

        protected virtual void Roar()
        {
            // Implement roar logic
            Debug.Log("Monster roars!");
        }
    }
}
