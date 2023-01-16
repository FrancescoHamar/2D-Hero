using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitting : MonoBehaviour
{
    public Animator animator;


    void Update()
    {

        
    }

    public void OpenQuit()
    {
        animator.SetBool("quitting", true);
    }

    public void CloseQuit()
    {
        animator.SetBool("quitting", false);
    }

    public void QuitApp()
    {
       
        if (UnityEditor.EditorApplication.isPlaying == true)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }

        Application.Quit();

    }

}
