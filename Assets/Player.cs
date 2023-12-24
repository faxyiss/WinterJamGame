using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] static PlayerMovementController pmc;
    [SerializeField] static PlayerAnimation pa;
    [SerializeField] static Rigidbody2D rb;

    static public void Death(){
        pa.DeathAnim();
        rb.velocity = Vector3.zero;
        pmc.enabled = false;
    }
}
