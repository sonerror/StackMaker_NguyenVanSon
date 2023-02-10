using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefeshGame : MonoBehaviour
{
    public GameController controller;

    private void Start()
    {
        controller = GameObject.FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            controller.ResetGame();
        }
    }
}