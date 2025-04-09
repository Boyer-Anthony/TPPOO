using System.Collections.Generic;
using UnityEngine;

namespace TP3_Polymorphisme
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField]
        private Weapon currentWeapon;
        [SerializeField]
        private List<Weapon> equipement = new List<Weapon>();

        [Header("Arme")]
        Weapon sword = new Sword();
        Weapon bow = new Bow();
        Weapon wand = new Wand();

        public Weapon CurrentWeapon { get => currentWeapon; set => currentWeapon = value; }
        public List<Weapon> Equipement { get => equipement; set => equipement = value; }
        public Weapon Sword { get => sword; set => sword = value; }
        public Weapon Bow { get => bow; set => bow = value; }
        public Weapon Wand { get => wand; set => wand = value; }

        private void Start()
        {
            equipement.Add(Sword);
            equipement.Add(Wand);
            equipement.Add(Bow);


        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                SwitchWeapon(Sword);
                
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                
                SwitchWeapon(Wand);
                
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
               
                SwitchWeapon(Bow);
            }
            
        }

        public void Attack()
        {
            #region Commentaire
            /*if (currentWeapon == "sword")
            {
                // Logique d'attaque à l'épée
                Debug.Log("Swinging sword");
                // Animation, effets sonores, etc.
                
                // Détection des ennemis à proximité
                Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2f);
                foreach (var hitCollider in hitColliders)
                {
                    Enemy enemy = hitCollider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(25);
                    }
                }
            }
            else if (currentWeapon == "bow")
            {
                // Logique d'attaque à l'arc
                Debug.Log("Firing arrow");
                
                // Création d'une flèche
                GameObject arrowPrefab = Resources.Load<GameObject>("Arrow");
                if (arrowPrefab != null)
                {
                    GameObject arrow = Instantiate(arrowPrefab, transform.position + transform.forward, Quaternion.identity);
                    Rigidbody rb = arrow.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.velocity = transform.forward * 20f;
                    }
                }
            }
            else if (currentWeapon == "wand")
            {
                // Logique d'attaque à la baguette
                Debug.Log("Casting spell");
                
                // Vérifier si le joueur a assez de mana
                PlayerCharacter player = GetComponent<PlayerCharacter>();
                if (player != null && player.SpendMana(15f))
                {
                    // Création d'un projectile magique
                    GameObject spellPrefab = Resources.Load<GameObject>("Spell");
                    if (spellPrefab != null)
                    {
                        GameObject spell = Instantiate(spellPrefab, transform.position + transform.forward, Quaternion.identity);
                        spell.GetComponent<Rigidbody>().velocity = transform.forward * 15f;
                    }
                }
                else
                {
                    Debug.Log("Not enough mana!");
                }
            }*/
            #endregion

        }

        public void SwitchWeapon(Weapon weaponName)
        {
            CurrentWeapon = weaponName;
            
           /* sword.SetActive(CurrentWeapon == "sword");
            bow.SetActive(CurrentWeapon == "bow");
            wand.SetActive(CurrentWeapon == "wand");*/
            
            Debug.Log("Switched to " + CurrentWeapon.Name);
        }
    }
}