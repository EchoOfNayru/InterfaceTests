using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMe : MonoBehaviour {

    IDamagable damageThis;

    float damagePerSecond = 2.0f;

    void Start()
    {
        damageThis = GetComponent<IDamagable>();
    }

    void Update()
    {
        damageThis.ApplyDamage(damagePerSecond * Time.deltaTime);
    }
}
