using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMovement : MonoBehaviour
{

    public Animator animator;
    public Animator winAnimator;
    public GameObject player;
    bool LeftDown = false;
    bool RightDown = false;
    public float speed = 10f;


    void Update()
    {
        if (RightDown == true)
        {
            moveRight();
        }

        if (LeftDown == true)
        {
            moveLeft();
        }

        


    }

    public void leftDown()
    {
        LeftDown = true;
    }

    public void leftUp()
    {
        LeftDown = false;
        animator.SetFloat("Speed", 0);
    }

    public void rightDown()
    {
        RightDown = true;
    }

    public void rightUp()
    {
        RightDown = false;
        animator.SetFloat("Speed", 0);
    }




        public void moveLeft()
    {
        if (animator.GetBool("isDead") == false && winAnimator.GetBool("playerWon") == false)
        {
            Vector3 movement = new Vector3(-1f, 0f, 0f);
            player.transform.position += movement * Time.deltaTime * speed;
            player.transform.rotation = Quaternion.Euler(0, 180f, 0);
            animator.SetFloat("Speed", 1);
        }

    }

    public void moveRight()
    {
        if (animator.GetBool("isDead") == false && winAnimator.GetBool("playerWon") == false)
        {
            Vector3 movement = new Vector3(1f, 0f, 0f);
            player.transform.position += movement * Time.deltaTime * speed;
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetFloat("Speed", 1);
        }
    }

}
