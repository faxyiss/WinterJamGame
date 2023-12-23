using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackGround : MonoBehaviour
{
    [SerializeField] private Transform Target;
    private Vector3 LastCamPos;
    [Range(0f, 1f)]
    [SerializeField] float paralaxEffectMutipler = .5f;
    private float textureUnitsizeX;

    private void Start()
    {
        LastCamPos = Target.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitsizeX = texture.width / sprite.pixelsPerUnit;
    }
    void LateUpdate()
        
    {
        Vector3 deltaMovement = Target.position - LastCamPos;       
        transform.position += deltaMovement * paralaxEffectMutipler;
        LastCamPos = Target.position;

        if(Mathf.Abs(Target.position.x - transform.position.x)>= textureUnitsizeX)
        {
            float OffsetPosX = (Target.position.x - transform.position.x) % textureUnitsizeX;
            transform.position = new(Target.position.x + OffsetPosX, transform.position.y);
        }
    }
}
