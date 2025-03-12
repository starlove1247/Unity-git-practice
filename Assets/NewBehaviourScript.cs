using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // gameObject.SetActive(false);
        Debug.Log("OnTriggerEnter2D");
        gameObject.SetActive(false);
        col.gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"OnCollisionEnter2D");
        col.gameObject.SetActive(false);
    }
}