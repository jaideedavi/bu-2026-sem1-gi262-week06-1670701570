using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Equipment : Weapon
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int durability;

        protected bool isEquipped;

        public virtual void Equip(Hero hero)
        {
            // Implement equip logic
            isEquipped = true;
            Debug.Log("Equipment equipped by character!");
        }

        public virtual void Use(Hero hero)
        {
            // Implement use logic for Equipment
            Debug.Log("Equipment used by character!");
        }
    }
}
