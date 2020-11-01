using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName= "Nuevo Sword", menuName = "Inventario/Sword")]

public class Sword : Item
{
   public float damage = 30f;
   public float velocity = .4f;



    public override void Use()
    {
        base.Use();

        Debug.Log("Se dio un espadazo con "+damage+" de daño a una velocidad de "+velocity+" Segundos.");
    }
}
