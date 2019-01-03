using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [Range(-1, 1f)] public float EnemySpeed;
    void Update()
    {
        transform.Translate(Vector3.left * EnemySpeed * Time.deltaTime);
    }
    public void SetEnemySpeed(float speed)
    {
        EnemySpeed = speed;
    }
}
