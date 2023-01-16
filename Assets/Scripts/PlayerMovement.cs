using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    float firstTouch = 0;
    public Transform player;
    public float speed = 8.2f;
    public Animator animator;
    public Animator winAnimator;
    public bool buttons = true;

    public Messenger messenger;

    public Button rightBtn;
    public Button leftBtn;
    public Button jumpBtn;


    // Start is called before the first frame update
    void Start()
    {
        messenger = GameObject.Find("Messenger").GetComponent<Messenger>();
        buttons = messenger.controls;
        Debug.Log(buttons);
        if (buttons == false)
        {
            rightBtn.gameObject.SetActive(false);
            leftBtn.gameObject.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (buttons == false)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        firstTouch = touch.position.x;
                        if (firstTouch > Screen.width / 2 && winAnimator.GetBool("playerWon") == false)
                        {
                            animator.SetFloat("Speed", 8.2f);
                        }
                        return;

                    case TouchPhase.Moved:

                        if (winAnimator.GetBool("playerWon") == true)
                        {
                            animator.SetFloat("Speed", 0);
                            return;
                        }

                        Touch CurrentTouch = Input.GetTouch(0);
                        float currentTouch = CurrentTouch.position.x;

                        if (firstTouch > Screen.width / 2 && currentTouch > Screen.width / 3)
                        {
                            if (firstTouch > currentTouch)
                            {
                                Debug.Log("Moving left");
                                moveLeft();

                                return;
                            }

                            if (firstTouch < currentTouch)
                            {
                                Debug.Log("Moving right");
                                moveRight();
                                return;
                            }
                            return;
                        }
                        return;

                    case TouchPhase.Stationary:

                        if (winAnimator.GetBool("playerWon") == true)
                        {
                            animator.SetFloat("Speed", 0);
                            return;
                        }

                        Touch CurrentTouch1 = Input.GetTouch(0);
                        float currentTouch1 = CurrentTouch1.position.x;

                        if (firstTouch > Screen.width / 2 && currentTouch1 > Screen.width / 3)
                        {
                            if (firstTouch > currentTouch1)
                            {
                                Debug.Log("Moving left");
                                moveLeft();

                                return;
                            }

                            if (firstTouch < currentTouch1)
                            {
                                Debug.Log("Moving right");
                                moveRight();
                                return;
                            }
                            return;
                        }
                        return;

                    case TouchPhase.Ended:
                        currentTouch = 0;
                        animator.SetFloat("Speed", 0);
                        return;
                }





            }
        }


    }


    void moveLeft()
    {
        if (animator.GetBool("isDead") == false &&  winAnimator.GetBool("playerWon") == false)
        {
            Vector3 movement = new Vector3(-3f, 0f, 0f);
            transform.position += movement * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }

    }

    void moveRight()
    {
        if (animator.GetBool("isDead") == false && winAnimator.GetBool("playerWon") == false)
        {
            Vector3 movement = new Vector3(3f, 0f, 0f);
            transform.position += movement * Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
