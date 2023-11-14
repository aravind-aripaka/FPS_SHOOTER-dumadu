using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{
    public float DamageAmount = 5f;
    public float TargetDistance;
    public float AllowedRange = 15f;
    public EnemyScript enemy;
    public RaycastHit hit;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, AllowedRange))
            {
                TargetDistance = hit.distance;
                if(TargetDistance < AllowedRange)   
                {
                    enemy.deductPoints(DamageAmount);
                    Debug.Log("Damage");
                }
            }
        }
    }
}
