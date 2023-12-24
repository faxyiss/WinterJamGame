using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovementController pmc;
    [SerializeField] PlayerAnimation pa;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GM gm;

    public void Death(){
        pa.DeathAnim();
        rb.velocity = Vector3.zero;
        pmc.enabled = false;
    }
    public void DeathAnimFinished()
    {
        gm.endGame();
    }
}
