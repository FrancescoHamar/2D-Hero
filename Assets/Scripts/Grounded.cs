using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    public GameObject jumpButton;
    public Animator animator;
    public Vector3 originalPos;
    public Animator menuAnimator;

    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    void Update()
    {
        if (animator.GetBool("isDead") == true)
        {
            menuAnimator.SetBool("isDead", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            jumpButton.GetComponent<Jump>().isGrounded = true;
            animator.SetBool("isJumping", false);
        }

        if (collision.collider.tag == "Spikes")
        {
            animator.SetBool("isDead", true);
            Debug.Log("Player is Dead");
        }
        if (collision.collider.tag == "TpSpikes")
        {
            gameObject.transform.position = originalPos;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            jumpButton.GetComponent<Jump>().isGrounded = false;
            animator.SetBool("isJumping", true);
        }
    }

}

