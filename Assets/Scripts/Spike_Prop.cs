using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Prop : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindWithTag("GM").GetComponent<GM>().DeathPlayer();
        }
    }
}
