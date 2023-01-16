using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinCollector : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D coinRigidbody;
    public Collider2D coinCollider;
    public static float Points = 0;
    public TextMeshProUGUI coinAmount;

    // Update is called once per frame
    void Update()
    {
        coinAmount.text = "x " + Points.ToString();


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Object.Destroy(coinRigidbody);
            Object.Destroy(coinCollider);
            animator.SetBool("Collected", true);
            Points = Points + 1;
        }
    }


}
