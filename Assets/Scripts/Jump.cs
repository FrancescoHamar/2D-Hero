using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Animator animator;
    public float leap = 5f;
    public GameObject player;
    public bool isGrounded = false;
 

    public void JumpFunction()
    {
        if (isGrounded == true && animator.GetBool("playerWon") == false)
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, leap), ForceMode2D.Impulse);
        }
    }


}
