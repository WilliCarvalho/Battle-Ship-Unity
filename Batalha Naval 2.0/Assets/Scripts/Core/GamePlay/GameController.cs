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

        public static void ExitGame()
        {
            Application.Quit();
        }
}
