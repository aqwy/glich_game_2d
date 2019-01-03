using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attackers : MonoBehaviour
{
    private GameObject _currentTarget;
    public void HitCurrentTarget(int damage)
    {
        Debug.Log(name + " caused damage: " + damage);
    }
    public void StartAttatck(GameObject target)
    {
        _currentTarget = target;
    }
}
