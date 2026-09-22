using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public string CharacterName;

        protected float moveSpeed;

        private int level;

        public virtual void attack( GameEntity target)
        {
            
        }

        protected virtual void levelUp()
        {
            level++;
        }

    }
}
