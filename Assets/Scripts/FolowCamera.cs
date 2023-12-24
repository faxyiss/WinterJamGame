using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCamera : MonoBehaviour
{
    [SerializeField] private Transform TransformPlayer;
    void Update()
    {
       transform.position = TransformPlayer.position;
    }
}
