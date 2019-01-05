using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject shellPrefab;
    public Transform spawnShellPosition;
    public void startSooting()
    {
        GameObject shell = Instantiate(shellPrefab);
        shell.transform.position = spawnShellPosition.position;
    }
}
