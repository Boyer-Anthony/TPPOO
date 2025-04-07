using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterGood : MonoBehaviour
{
    // Toutes les données sont publiques et peuvent être modifiées n'importe où

    [SerializeField] private string playerName;
    [SerializeField] private int health;
    [SerializeField] private int maxHealth;
    [SerializeField] private int moveSpeed;
    [SerializeField] private bool isInvincible;


    // Accesseur
    public string PlayerName
    {
        get { return playerName; }
        set { this.playerName = value; }
    }

    /*public string getPlayerName()
    {
        return playerName;
    }
    public void setPlayerName(string playerName)
    {
        this.playerName = playerName;
    }*/

    public int Health
    {
        get { return health; }
        private set { health = Mathf.Clamp(value, 0, maxHealth); }
    }

    public int MoveSpeed
    {
        get { return moveSpeed; }
        private set { moveSpeed = Mathf.Clamp(value, 0, 10); }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set { this.maxHealth = value; }
    }


    public int getMaxHealth()
    {
        return maxHealth;
    }

    public void setMaxHealth(int maxPointDeVie)
    {
        this.maxHealth = maxPointDeVie;
    }

   

    void Start()
    {
        Player playerCharacter = new Player();

    }

    void Update()
    {
        switch (health)
        {
            case  <= 0:

                Debug.Log("Player is dead");
                break;

            case  >=150 :

                Debug.Log("PV MAX");
                break;
        }

        // Limiter la vitesse du joueur entre 0 et 10
        moveSpeed = Mathf.Clamp(moveSpeed, 0, 10);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        
    }

    public void MovePlayer()
    {
        switch (moveSpeed)
        {
            case <=0 :

                this.moveSpeed = 0;
                break;

            case >= 10:
                this.moveSpeed = 10;
                break;

        }
    }

    public void Invincible()
    {
       
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health < 0)
        {

        } 
    }

    public void GainGold(int amount)
    {

    }
}
