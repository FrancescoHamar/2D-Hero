using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsMenu : MonoBehaviour
{
    public Animator animator;
    
    public void OpenOptions()
    {
        animator.SetBool("mainOptions", true);

    }

    public void CloseOptions()
    {
        animator.SetBool("mainOptions", false);
    }


}
