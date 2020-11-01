using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "Nuevo PotionMana", menuName = "Inventario/Potion Mana")]

public class PotionMana : Item
{
    public float pointsMana = 40f;

    public override void Use()
    {
        base.Use();
        Debug.Log("La pocima de mana restauro "+pointsMana+" puntos.");

    }
}
