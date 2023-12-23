using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackGround : MonoBehaviour
{
    [SerializeField] private Transform Target;
    private Vector3 LastCamPos;
    [Range(0f, 2f)]
    [SerializeField] float paralaxEffectMutipler = .5f;

    private void Start()
    {
        LastCamPos = Target.position;
    }
    void LateUpdate()
        
    {
        Vector3 deltaMovement = Target.position - LastCamPos;       
        transform.position += deltaMovement * paralaxEffectMutipler;
        LastCamPos = Target.position;
    }
}
