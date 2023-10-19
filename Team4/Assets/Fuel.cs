using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelConsumption : MonoBehaviour
{
    public int fuel;

   
    public void MovementCost()
    {
        fuel--;
    }

    public void UseConsumable ()
    {
        fuel = 10;
    }

    public void HitByEnemy()
    {
        fuel = fuel - 5;
    }
}
