using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject qrCode;

    public GameObject qrCode2;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name);
        // gameObject.SetActive(false);
        // 隱藏物件
        // col.gameObject.SetActive(false);
        // GameObject qrCode = GameObject.Find("QRCode");
        // gameObject.SetActive(false);

        qrCode.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        qrCode.SetActive(false);
        Debug.Log($"OnCollisionEnter2D");
        col.gameObject.SetActive(false);
    }
}