using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float health = 10f;
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        } 
    }
    public void deductPoints(float DamageAmount)
    {
        health -= DamageAmount;
    }
}
