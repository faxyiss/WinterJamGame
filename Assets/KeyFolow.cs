using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFolow : MonoBehaviour
{
    Transform TargetPos;
    private float Speed = 10;
    bool  FolowPlayer;
    private void Start()
    {
        TargetPos = GameObject.FindWithTag("FolowKey").GetComponent<Transform>();
    }
    private void Update()
    {
        if (FolowPlayer)
        {
            
            transform.position = Vector3.Lerp(transform.position, TargetPos.position, Speed * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FolowPlayer = true;
        }
    }
}
