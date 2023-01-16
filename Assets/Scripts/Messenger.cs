using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Messenger : MonoBehaviour
{
    public int currentLevel;
    public float audioSlider = 0.7f;
    public bool touch = false;
    public bool controls = true;

    public optionControls optionControls;

    public static Messenger Instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Debug.Log("poopy!");
            DestroyImmediate(gameObject);
        }
        optionControls = GameObject.Find("AudioCtrl").GetComponent<optionControls>();
    }

    public void OnLevelWasLoaded(int level)
    {

        if (level == 0)
        {
            optionControls = GameObject.Find("AudioCtrl").GetComponent<optionControls>();
            optionControls.slider.SetValueWithoutNotify(audioSlider);
            Debug.Log("Main Menu is loaded. Script int is: " + audioSlider + "Slider is:" + optionControls.slider.value + "Volume is: " + AudioListener.volume);
            if (controls == true)
            {
                optionControls.controlsSwitch.isOn = true;
                optionControls.touchSwitch.isOn = false;
            }
            else
            {
                optionControls.controlsSwitch.isOn = false;
                optionControls.touchSwitch.isOn = true;
            }
        }
        Debug.Log("level has loaded and value is " + audioSlider + ". Object name is: " + gameObject.name);
        AudioListener.volume = audioSlider;
        Debug.Log("VOLUME IS: " + AudioListener.volume);
    }

}
