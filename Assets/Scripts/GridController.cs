using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public GameObject SeaTile;
    public GameObject WaterHit;
    public GameObject P1TCanvas;

    public string Tile;
    public string Grid;

    
    private int BoardSize = 1;

    //Start is called before the first frame update
    void Start()
    {
        P1TCanvas.SetActive(false);
        Tile = gameObject.name;
    }

    //Update is called once per frame
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
                    if(Grid == "Grid1")
                    {
                        StartCoroutine(PlayerTurn());
                        Instantiate(WaterHit, transform.position, SeaTile.transform.rotation);
                        //
                    }
                    
                }
            }
        }
    }


    IEnumerator PlayerTurn()
    {
        yield return new WaitForSeconds(1.0f);
        P1TCanvas.SetActive(true);
        Destroy(gameObject);
    }

    public void SetCanvasOff()
    {
        P1TCanvas.SetActive(false);
    }
}
