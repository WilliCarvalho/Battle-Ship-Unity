using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject SeaTile;
    public GameObject WaterHit;
    public string Tile;

    
    private int BoardSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        Tile = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        Ray Click = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Waterhit;
        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(Click, out Waterhit))
            {
                Tile = Waterhit.collider.gameObject.name;
                

                if (gameObject.name == Tile)
                {
                    
                    Instantiate(WaterHit, transform.position, SeaTile.transform.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }
}
