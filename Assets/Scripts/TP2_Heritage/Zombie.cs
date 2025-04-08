using UnityEngine;

namespace TP2_Heritage
{
    public class Zombie : Enemy
    {
        
        #region Constructeur

        // Constructeur vide
        public Zombie()
        {
            Health = 100;
            Damage = 15;
            Speed = 2f;
            DetectionRange = 10f;
            GiveXP = 150;
        }

        public Zombie(int health, int damage, float speed, float detectionRange)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            DetectionRange = detectionRange;
        }

        #endregion

        protected override void Start() 
        {
            base.Start();
            
        }
        
        protected override void Update() 
        {
            base.Update();
        }
        
        public void TakeDamage(int amount) 
        {
            Health -= amount;
            if (Health <= 0) 
            {
                Die();
            }
        }
        
        private void Die() 
        {
            //PlayerCharacterGood player = gameObject.GetComponent<PlayerCharacterGood>();
           // playerChara = gameObject.GetComponent<PlayerCharacterGood>();
            PlayerChara.GainXp(GiveXP);
            Destroy(gameObject);
        }
        
        void OnCollisionEnter(Collision collision) 
        {
            if (collision.gameObject.CompareTag("Player")) 
            {
                PlayerCharacterGood player = collision.gameObject.GetComponent<PlayerCharacterGood>();   
                if (player != null) 
                {
                    player.TakeDamage(Damage);
                   
                }
            }
            
        }

       
    }
}