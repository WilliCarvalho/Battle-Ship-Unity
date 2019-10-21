using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ExitGameplay()
    {
        Application.LoadLevel("MenuScene");
    }

    public void ActivePanel(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void TurnOffMenu(GameObject menu)
    {
        menu.SetActive(false);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
