using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionMenu;
    public GameObject Credit;

    void Start()
    {
        MainMenu.SetActive(true);
        OptionMenu.SetActive(false);
        Credit.SetActive(false);
    }
    void Update()
    {
        
    }

    public void Quitgame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void Nextscene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
