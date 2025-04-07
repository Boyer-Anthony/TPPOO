using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerCharacterGood : MonoBehaviour
{
    // Toutes les données sont publiques et peuvent être modifiées n'importe où

    [SerializeField] private string playerName;
    [SerializeField] private int moveSpeed;
    [SerializeField] private int turnSpeed;
    [SerializeField] private bool isInvincible;
    [SerializeField] private int gold = 0;

    [Header("VIE")]
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    [Header(" XP & LEVEL")]
    [SerializeField] private int currentXP;
    [SerializeField] private int level;
    [SerializeField] private int xpToNextlevel;

    [Header(" Statistique")]
    [SerializeField] private int Force;
    [SerializeField] private int Agile;
    

    #region Getteur & Setteur
    // Accesseur
    public string PlayerName
    {
        get { return playerName; }
        set { this.playerName = value; }
    }


    public int CurrentHealth
    {
        get { return currentHealth; }
        private set { currentHealth = Mathf.Clamp(value, 0, maxHealth); }
    }

    public int MoveSpeed
    {
        get { return moveSpeed; }
        private set { moveSpeed = Mathf.Clamp(value, 0, 10); }
    }

    public int TurnSpeed
    {
        get { return turnSpeed; }
        private set { turnSpeed = Mathf.Clamp(value, 0, 20); }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set { this.maxHealth = value; }
    }

    public int Gold
    {
        get { return gold; }
        set { gold = Mathf.Clamp(value, 0, int.MaxValue); }
    }

    public bool Invincible
    {
        get { return isInvincible; }
        set { this.isInvincible = value; }
    }

    public int CurrentXP { get { return currentXP; } }             //
    public int Level { get { return level; } }                   // === > propriétés en lecture seule(read-only) depuis l’extérieur. ne peut pas les modifier directement de l’extérieur du script.
    public int XPToNextlevel { get { return xpToNextlevel; } } //



    #endregion

    void Update()
    {
        MovementPlayer();
        RecoveryHealth();

    }

    void Start()
    {
        currentHealth = 150;
        maxHealth = 150;

        currentXP = 0;
        xpToNextlevel = 100;
        level = 0;

        SpeedTurn(100);
        SpeedMove(15);
        GainXp(428);
        
        
    }

    public void MovementPlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;


        transform.Translate(Vector3.forward * moveZ);
        transform.Rotate(Vector3.up * moveX);


        /*Vector3 move = new Vector3(moveX, 0, moveZ) * moveSpeed;
        transform.Translate(move * Time.deltaTime);*/

    }

    public void SpeedMove(int amount)
    {
        moveSpeed += amount;

        switch (moveSpeed)
        {
            case <= 0 : 
                Debug.Log("MoveSpeed à 0");
                moveSpeed = 0;
                break;

            case >= 10 :
                moveSpeed = 10;
                break;
        }

    }

    public void SpeedTurn(int amount)
    {
        turnSpeed += amount;
    }


    public void TakeDamage(int damage)
    {
        // Si on est invincible on sort de cette fonction.
        if (isInvincible) return;

        currentHealth -= damage;

        switch (currentHealth)
        {
            case <= 0:
                Debug.Log("Player is dead");
                currentHealth = 0;
                break;

        }

    }

    public void RecoveryHealth()
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += 2;
            Debug.Log("Régénération: " + CurrentHealth + "/" + maxHealth);
        }
    }

    public void GainXp(int amount)
    {
        currentXP += amount;

        while (currentXP >= xpToNextlevel)
        {
            currentXP -= xpToNextlevel;
            LevelUp();
        }

        switch (currentXP)
        {
            case <= 0:

                currentXP = 0;
                break;
        }
    }

    public void LevelUp()
    {
        level++;
        xpToNextlevel += 100; // Augmentation du coup en xp
        Debug.Log($" XP : {currentXP}/{XPToNextlevel} Level {level}"); 
        Statistique();
    }

    public void Statistique()
    {
        Force = 2 + level * 2;
        Agile = 2 + level * 1;
    }

    public void GainGold(int amount)
    {
        gold += amount;

        switch (gold)
        {
            case <= 0:
                Debug.Log("0");
                gold = 0;
                break;

            case int.MaxValue:
                gold = int.MaxValue;
                break;
        }

    }

    public void LoseGold(int amount)
    {
        gold -= amount;

        switch (gold)
        {
            case <= 0 :

                gold = 0;
                break;
        }

    }


}
