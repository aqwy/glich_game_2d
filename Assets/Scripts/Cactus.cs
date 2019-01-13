using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public float range = 3f;

    private Shooter _shooting;
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void serchTarget()
    {
        Transform nearEnemy = null;
        float nearEnemyDist = Mathf.Infinity;
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Attackers"))
        {
            float currDist = Vector2.Distance(transform.position, enemy.transform.position);
            if (currDist < nearEnemyDist && currDist <= range)
            {
                nearEnemy = enemy.transform;
                nearEnemyDist = currDist;
            }
        }
        if (nearEnemy != null)
        {
            Debug.Log("find target");
            _animator.SetBool("CactusGoesAttack", true);
            _shooting.startSooting();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
