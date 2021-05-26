using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            //If no saved data from previous game sessions, 
            //the muted is set to false and music will play
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }


    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }

    }


    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
        //If muted = 1, muted is set to "true"
        //If muted = 0, muted is set to "false"

    }

    private void Save()
    {
        //PlayerPrefs, is used to store and access player preference between game sessions

        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
        //If muted = true, we will save it as 1
        //If muted = false, we will save it as as 0
    }
}
