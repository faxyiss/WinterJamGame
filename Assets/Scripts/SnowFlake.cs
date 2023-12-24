using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFlake : MonoBehaviour
{
    [SerializeField] private float angularSpeed;
    private void Update()
    {
        transform.Rotate(Vector3.up, angularSpeed/100);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.FindWithTag("GM").GetComponent<GM>().AddScore();
            Destroy(gameObject);
        }
    }
}
