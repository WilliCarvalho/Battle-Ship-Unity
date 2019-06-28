using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionMenu;
    public GameObject Credit;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        OptionMenu.SetActive(false);
        Credit.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Application.LoadLevel("GamePlay");
    }

    public void ExitGame()
    {
        GameController.ExitGame();
    }
}
