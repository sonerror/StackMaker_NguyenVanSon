using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraflow : MonoBehaviour
{
    public GameObject Player;
    Transform Transform { get => transform; }
    [SerializeField]private Vector3 offset;
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
