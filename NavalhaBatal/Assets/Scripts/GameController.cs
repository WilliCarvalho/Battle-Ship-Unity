using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] sea;

    public Sprite SeaSprite;
    private int BoardSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject o in sea)
        {
            o.GetComponent<SpriteRenderer>().sprite = SeaSprite;
            o.gameObject.name = BoardSize.ToString();
            BoardSize++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
