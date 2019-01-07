using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public int shellDamage;

    private GameObject _targetAtackers;
    private Health _targetHealth;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _targetAtackers = collision.gameObject;
        _targetHealth = _targetAtackers.GetComponent<Health>();
        if (!_targetAtackers.GetComponent<Attackers>())
        {
            return;
        }
        else if (_targetHealth)
        {
            _targetHealth.DealDamage(shellDamage);
            Destroy(gameObject);
        }
    }
}
