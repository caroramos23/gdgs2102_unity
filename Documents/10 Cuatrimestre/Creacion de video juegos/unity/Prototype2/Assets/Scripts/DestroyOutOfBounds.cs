/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase con la función para destruir aquellos objetos que salen del área de juego.
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
