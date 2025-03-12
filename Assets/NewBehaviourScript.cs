using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnTriggerEnter2D");
        // gameObject.SetActive(false);
        // gameObject.SetActive(false);
        // 隱藏物件
        // col.gameObject.SetActive(false);

        GameObject qrCode = GameObject.Find("QRCode");
        qrCode.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"OnCollisionEnter2D");
        col.gameObject.SetActive(false);
    }
}