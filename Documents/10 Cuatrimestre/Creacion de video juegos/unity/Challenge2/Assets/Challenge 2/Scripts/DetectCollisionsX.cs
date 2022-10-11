/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase con las función para detectar la interacción que se produce cuando dos objetos chocan.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
