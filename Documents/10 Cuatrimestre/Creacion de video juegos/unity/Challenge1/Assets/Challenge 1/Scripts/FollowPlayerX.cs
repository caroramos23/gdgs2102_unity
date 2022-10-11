/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 05/10/2022
 *Descripción: Clase con las funciones para controlar la posición y movimientos de la cámara para que siga al jugador.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset =  new Vector3(19, 3, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
