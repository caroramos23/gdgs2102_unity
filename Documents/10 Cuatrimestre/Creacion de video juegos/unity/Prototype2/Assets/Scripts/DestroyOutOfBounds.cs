/*
 *Autor: Carolina Ramos Vel�zquez
 *Fecha: 06/10/2022
 *Descripci�n: Clase con la funci�n para destruir aquellos objetos que salen del �rea de juego.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 25;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}
