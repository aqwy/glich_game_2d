using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject shellPrefab;
    public Transform spawnShellPosition;

    private GameObject _projectileParent;
    private void Start()
    {
        _projectileParent = GameObject.Find("Projectile");
        if (!_projectileParent)
        {
            _projectileParent = new GameObject("Projectile");
        }
    }
    public void startSooting()
    {
        GameObject shell = Instantiate(shellPrefab);
        shell.transform.parent = _projectileParent.transform;
        shell.transform.position = spawnShellPosition.position;
    }
}
