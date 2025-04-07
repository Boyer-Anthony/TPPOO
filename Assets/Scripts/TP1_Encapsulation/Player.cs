using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player 
{
    // Attribut
    private int ID;
    private string playerName;
    private int health;
    private int maxHealth;
    private float moveSpeed;
    private bool isInvincible;

    // Accesseur
    #region Accesseur ID
    public int getId()
    {
        return ID;
    }

    public void setId(int Id)
    {
        this.ID = Id;
    }
    #endregion
    #region PointDeVie
    public int getHealth()
    {
        return health;
    }

    public void setHealth(int pointDeVie)
    {
        this.health = pointDeVie;

    }
    #endregion
    #region MaxPointDeVie
    public int getMaxHealth()
    {
        return maxHealth;
    }

    public void setMaxHealth(int maxPointDeVie)
    {
        this .maxHealth = maxPointDeVie;
    }
    #endregion
    #region MoveSpeed
    public float getMoveSpeed()
    {
        return moveSpeed;
    }

    public void setMoveSpeed(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }
    #endregion
    #region Invincible
    public bool getInvincible()
    {
        return isInvincible;
    }

    public void setInvincible(bool isInvincible)
    {
        this.isInvincible = isInvincible;
    }
    #endregion
    public string Name
    {
        get { return playerName; }
        set { this.playerName = value; }
    }
  



}
