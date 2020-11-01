using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName= "Nuevo PotionHealth", menuName = "Inventario/Potion Health")]

public class PotionHealth : Item
{
    public float pointsHealth = 40f;

    public override void Use()
    {
        base.Use();
        Debug.Log("La pocima de vida curo "+pointsHealth+" puntos.");
    }
}
