using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Weapon : Equipment
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int extraDamage;
        
        private float criticalChance;

        public override void Equip(Hero hero)
        {
            // Implement equip logic for Weapon
            Debug.Log("Weapon equipped by the hero!");
        }

        public void Polish()
        {
            // Implement polish logic for Weapon
            Debug.Log("Weapon polished!");
        }
       
    }
}
