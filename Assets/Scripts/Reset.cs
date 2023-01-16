using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public GameObject player;

    public Grounded groundedScript;

    public Messenger messenger;

    public int levelNumber;

    void Start()
    {
        groundedScript = GameObject.Find("Player").GetComponent<Grounded>();
        messenger = GameObject.Find("Messenger").GetComponent<Messenger>();
    }

    public void restart()
    {
        groundedScript.menuAnimator.SetBool("isDead", false);
        groundedScript.animator.SetBool("isDead", false);
        player.transform.position = groundedScript.originalPos;
    }

    public void toMainMenu()
    {
        groundedScript.menuAnimator.SetBool("isDead", false);
        groundedScript.animator.SetBool("isDead", false);
        player.transform.position = groundedScript.originalPos;
        SceneManager.LoadScene(0);
    }

    public void toLevelMenu()
    {
        groundedScript.menuAnimator.SetBool("isDead", false);
        groundedScript.animator.SetBool("isDead", false);
        player.transform.position = groundedScript.originalPos;
        if (messenger.currentLevel < 12)
        {
            SceneManager.LoadScene(1);
        }
        else if (messenger.currentLevel < 23)
        {
            SceneManager.LoadScene(12);
        }
        else
        {
            SceneManager.LoadScene(23);
        }
    }



}
