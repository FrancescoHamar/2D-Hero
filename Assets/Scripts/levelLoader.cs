using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    public doorFinder doorFinder;

    public Messenger messenger;

    void Start()
    {
        doorFinder = GameObject.Find("Player").GetComponent<doorFinder>();
        messenger = GameObject.Find("Messenger").GetComponent<Messenger>();
    }




    public void loadLevels()
    {
        doorFinder.level++;
        Debug.Log("I'm about to load level" + doorFinder.level);
        messenger.currentLevel = doorFinder.level;
        SceneManager.LoadScene(doorFinder.level);
    }
    
    public void loadHome()
    {
        SceneManager.LoadScene(0);
    }








}
