using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        // TODO: Implement fields and methods according to Class Diagram
        public string id;
        private Vector3 position;

        protected int Health;

        public virtual void update()
        {
            
        }

        public virtual void takeDamage(int damage)
        {
            Health -= damage;
        }

        private void move(Vector3 newPosition)
        {
            position = newPosition;
        }
    }
}
