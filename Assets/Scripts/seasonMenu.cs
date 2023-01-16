using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seasonMenu : MonoBehaviour
{
    public Animator animator;

    public void openSeasons()
    {
        animator.SetBool("playPlayed", true);
    }

    public void closeSeasons()
    {
        animator.SetBool("playPlayed", false);
    }

    public void loadSpring()
    {
        SceneManager.LoadScene(1);
    }
    public void loadAutumn()
    {
        SceneManager.LoadScene(12);
    }
    public void loadWinter()
    {
        SceneManager.LoadScene(23);
    }

}
