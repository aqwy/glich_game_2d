﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour
{
    public int foxAttackPower = 10;

    private Animator _foxAnim;
    private Attackers _attack;
    void Start()
    {
        _foxAnim = GetComponent<Animator>();
        _attack = GetComponent<Attackers>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (!obj.GetComponent<Deffenders>())
        {
            return;
        }

        if (obj.GetComponent<StoneController>())
        {
            _foxAnim.SetTrigger("FoxGoesJump");
        }
        else
        {
            _attack.StartAttatck(obj, foxAttackPower);
            _foxAnim.SetBool("FoxGoesAtack", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _foxAnim.SetBool("FoxGoesAtack", false);
    }
}
