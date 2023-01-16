using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public Animator animator;

 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            animator.SetBool("playerWon", true);
            Debug.Log("Player Won");
        }
    }
}
