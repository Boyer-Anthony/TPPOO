using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : Weapon
{
    // Constructeur
    public Wand() { Name = "Wand"; }

    public override void Attack()
    {
        Debug.Log("Attaque avec un Wand");
    }
}
