using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attackers : MonoBehaviour
{
    private GameObject _currentTarget;
    private int _attackDamage;

    private void HitCurrentTarget()
    {
        if (_currentTarget)
        {
            Health health = _currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(_attackDamage);
            }
        }
    }
    public void StartAttatck(GameObject target, int damage)
    {
        _currentTarget = target;
        _attackDamage = damage;
    }
}
