using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform _folowPos;
    [Range(0,20)]
    [SerializeField] private float _ofsetX = 0;
    [Range(0, 20)]
    [SerializeField] private float _ofsetY = 0;

    private void Update()
    {
       
        transform.position = new Vector3(_folowPos.position.x + _ofsetX,_ofsetY, 0);
    }
}
