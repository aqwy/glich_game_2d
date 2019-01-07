using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDefendersPanel : MonoBehaviour
{
    public GameObject defenderPrefab;
    public static GameObject _selected;

    private SelectDefendersPanel[] _itemsArray;   
    private void Start()
    {
        _itemsArray = FindObjectsOfType<SelectDefendersPanel>();
    }
    private void OnMouseDown()
    {
        foreach (SelectDefendersPanel item in _itemsArray)
        {
            item.GetComponent<SpriteRenderer>().color = Color.black;
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        _selected = defenderPrefab;
    }
}
