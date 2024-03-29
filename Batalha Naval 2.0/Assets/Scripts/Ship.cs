﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //Gameplay Script
    public GameObject[] ship;
    public Sprite[] DownSide;
    

    public Sprite WhenSunk;

    private int ShipSize;
    public string ShipSizeTile;

    private GameObject ShipSizeTileSprite;
    private int TotalHit;
    
    // Start is called before the first frame update
    void Start()
    {
        //Ship setup
        ShipSize = 0;

        foreach (GameObject o in ship)
        {            
            o.gameObject.name = ShipSize.ToString();
            ShipSize++;
        }


    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //when you miss or hit the Ship
        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out hit))
            {
                ShipSizeTile = hit.collider.gameObject.name;
                ShipSizeTileSprite = hit.collider.gameObject;
                print("vc deu hit");

                for(int i = 0; i <= ShipSize; i++)
                {
                    print("o tamano do navio eh" + ShipSize);

                    if (ShipSizeTile == i.ToString())
                    {
                        //attempt to make a dynamic sprite renderer
                        foreach (GameObject o in ship)
                        {               
                            ShipSizeTileSprite.GetComponent<SpriteRenderer>().sprite = DownSide[int.Parse(ShipSizeTile)];                            
                        }

                        

                        print("vc deu " + TotalHit);
                        TotalHit++;

                        if (TotalHit == ShipSize)
                        {

                            StartCoroutine(Destruction());
                            print("vc destruiu o Navio");
                        }

                       
                    }

                    
                } 


            }
        }
    }

    public IEnumerator Destruction()
    {
        
        ///pergunter pro Rodrigo se tem como setar o ship para aparecer fogo em todos os tiles
        ///ou fazer usando foreach
        for(int i=0; i < ship.Length; i++)
        {
            yield return new WaitForSeconds(0.5f);
            ship[i].GetComponent<SpriteRenderer>().sprite = WhenSunk;
        }
        //ship[TotalHit].
        // Destroy(gameObject);
    }



}
