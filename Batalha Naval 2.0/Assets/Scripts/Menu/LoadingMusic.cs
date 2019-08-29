using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingMusic : MonoBehaviour
{

    private AudioSource MusicSource;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        MusicSource = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        MusicSource.volume = PlayerPrefs.GetFloat("music");
    }

}
