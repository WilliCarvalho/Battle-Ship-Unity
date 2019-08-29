using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour
{
    public void Musicget(float vol)
    {
        PlayerPrefs.SetFloat("music", vol);
        Debug.Log(PlayerPrefs.GetFloat("music").ToString());
    }

    public void FXget(float vol)
    {
        PlayerPrefs.SetFloat("FX", vol);
        Debug.Log(PlayerPrefs.GetFloat("FX").ToString());
    }
}
