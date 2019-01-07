using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAndSpawn : MonoBehaviour
{
    public Camera myCamera;

    private GameObject _defendersParent;
    private void Start()
    {
        _defendersParent = GameObject.Find("Defenders");
        if (!_defendersParent)
        {
            _defendersParent = new GameObject("Defenders");
        }
    }
    private void OnMouseDown()
    {
        Vector2 rawPos = FindCurrentWorldPoint();
        Vector2 roundToGrid = RoundedToGrid(rawPos);
        GameObject defender = SelectDefendersPanel._selected;
        GameObject newDefender = Instantiate(defender, roundToGrid, Quaternion.identity);
        newDefender.transform.parent = _defendersParent.transform;
    }
    private Vector2 RoundedToGrid(Vector2 point)
    {
        float newX = Mathf.RoundToInt(point.x);
        float newY = Mathf.RoundToInt(point.y);
        return new Vector2(newX, newY);
    }
    private Vector2 FindCurrentWorldPoint()
    {
        float findX = Input.mousePosition.x;
        float findY = Input.mousePosition.y;

        Vector2 newPos = new Vector2(findX, findY);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(newPos);
        return worldPos;
    }
}
