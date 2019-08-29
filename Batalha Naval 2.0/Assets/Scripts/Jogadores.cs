using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogadores : MonoBehaviour
{

    public static int jogadorAtual;
    public GameObject agua;

    void Start()
    {
        jogadorAtual = 1;
    }


    void Update()
    {

        print(jogadorAtual);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hit))
            {

                GameObject o = hit.collider.gameObject;

                if (jogadorAtual == 1 && o.gameObject.tag == "Tabuleiro1")
                {
                    Destruir(o);
                    jogadorAtual = 2;
                }
                else if(jogadorAtual == 2 && o.gameObject.tag == "Tabuleiro2")
                {
                    Destruir(o);
                    jogadorAtual = 1;
                }   
            
            }
        }
    }

    void Destruir(GameObject ob)
    {
        Instantiate(agua, ob.transform.position, ob.transform.rotation);
        Destroy(ob.gameObject);
    }

}
