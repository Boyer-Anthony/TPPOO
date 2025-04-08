using UnityEngine;

namespace TP2_Heritage
{
    public class Skeleton : Enemy
    {

        #region Constructeur
        
        // Constructeur vide
        public Skeleton()
        {
            Health = 80;
            Damage = 15;
            Speed = 3f;
            DetectionRange = 12f;

        }

        public Skeleton(int health, int  damage, float speed, float detectionRange)
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
            Skeleton skeleton = new Skeleton();
            
        }

        protected override void Update()
        {
            
            if (Vector3.Distance(transform.position, Player.position) < DetectionRange)
            {
                Vector3 direction = (Player.position - transform.position).normalized;
                transform.position += direction * Speed * Time.deltaTime;
            }
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
            Destroy(gameObject);
        }
        
        void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.CompareTag("Player")) {
                PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();
                if (player != null) {
                    player.TakeDamage(Damage);
                }
            }
        }
    }
}