using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDamagable : MonoBehaviour, IDamagable {

    public float health = 10.0f;

    public float ApplyDamage(float damageApplied)
    {
        health -= damageApplied;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        return damageApplied;
    }
}
