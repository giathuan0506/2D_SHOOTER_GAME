using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour {

    public TurretAI turret;
    public bool isLeft = false; // Kiem tra nguoi choi dung ben phai hay trai


    private void Awake()
    {
        turret = gameObject.GetComponentInParent<TurretAI>();

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (isLeft)
                turret.Attack(false);

            else
                turret.Attack(true);


        }
    }
}
