/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase para detectar cuando djos objetos colisionan o entran en contacto.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
