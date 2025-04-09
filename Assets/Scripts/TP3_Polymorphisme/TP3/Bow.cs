using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Weapon
{
    // Constructeur
    public Bow() { Name = "Bow"; }

    public override void Attack()
    {
        Debug.Log("Attaque avec un Bow");
    }
}
