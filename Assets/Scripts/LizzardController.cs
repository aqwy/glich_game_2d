using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizzardController : MonoBehaviour
{
    public int lizzardAttackPower = 10;

    private Animator _lizzardAnim;
    private Attackers _attack;
    void Start()
    {
        _lizzardAnim = GetComponent<Animator>();
        _attack = GetComponent<Attackers>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (!obj.GetComponent<Deffenders>())
        {
            return;
        }

        _attack.StartAttatck(obj, lizzardAttackPower);
        _lizzardAnim.SetBool("LizardGoesAttack", true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Deffenders>())
        {
            _lizzardAnim.SetBool("LizardGoesAttack", false);
        }
    }
}
