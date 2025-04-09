using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon 
{
    protected string name;

    public string Name { get => name; set => name = value; }


    public virtual void Attack()
    {
        Debug.Log("Attaque avec une Weapon");
    }
}
