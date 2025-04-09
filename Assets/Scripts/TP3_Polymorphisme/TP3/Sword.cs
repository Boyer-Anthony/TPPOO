using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    // Constructeur
    public Sword() { Name = "Bow"; }

    public override void Attack()
    {
        Debug.Log("Attaque avec un Sword");
    }
}
