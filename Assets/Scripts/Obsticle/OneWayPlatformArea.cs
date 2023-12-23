using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatformArea : MonoBehaviour
{
    [SerializeField] private float closeTimer  = 3f;
    [SerializeField] private float openTimer = 30f;
    [SerializeField] private Collider2D col;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private bool isDisable = false;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") & !isDisable)
        {
            StartCoroutine(DisablePlatform());
            
        }
    }

     IEnumerator DisablePlatform()
    {        
        isDisable = true;       
        yield return new WaitForSeconds(closeTimer);
        spriteRenderer.color = Color.grey ;
        col.enabled = false;
        gameObject.layer = LayerMask.NameToLayer("Default");
        col.gameObject.layer = LayerMask.NameToLayer("Default");
        
        StartCoroutine(OpenPlatform());
    }

    IEnumerator OpenPlatform()
    {
        
        yield return new WaitForSeconds(openTimer);
        spriteRenderer.color = new Color(255, 255, 255, 255);
        col.enabled = true;
        col.gameObject.layer = LayerMask.NameToLayer("Floor");
        gameObject.layer = LayerMask.NameToLayer("Floor");
        isDisable = false;        
    }
}
