using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionControls : MonoBehaviour
{
    public Slider slider;

    public Messenger messenger;

    public Toggle controlsSwitch;
    public Toggle touchSwitch;


    // Start is called before the first frame update
    void Start()
    {
        messenger = GameObject.Find("Messenger").GetComponent<Messenger>();

    }

    public void audioControl()
    {
        messenger.audioSlider = slider.value;
        AudioListener.volume = messenger.audioSlider;
        Debug.Log(AudioListener.volume);
    }

    public void mute()
    {
        slider.SetValueWithoutNotify(0);
        messenger.audioSlider = slider.value;
        AudioListener.volume = messenger.audioSlider;
        Debug.Log(AudioListener.volume);
    }

    public void full()
    {
        slider.SetValueWithoutNotify(1);
        messenger.audioSlider = slider.value;
        AudioListener.volume = messenger.audioSlider;
        Debug.Log(AudioListener.volume);
    }

    public void controlsOn()
    {
        messenger.controls = true;
        messenger.touch = false;
        Debug.Log("Controls are on");
    }

    public void touchOn()
    {
        messenger.controls = false;
        messenger.touch = true;
        Debug.Log("Controls are off");
    }
}
