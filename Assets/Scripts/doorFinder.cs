using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class doorFinder : MonoBehaviour
{
    public Button startButton;
    public int level;



    // Start is called before the first frame update
    void Start()
    {
        startButton.interactable = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            startButton.interactable = true;
            level = Convert.ToInt32(collision.gameObject.name);
            Debug.Log(level);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            startButton.interactable = false;
        }
    }


}
