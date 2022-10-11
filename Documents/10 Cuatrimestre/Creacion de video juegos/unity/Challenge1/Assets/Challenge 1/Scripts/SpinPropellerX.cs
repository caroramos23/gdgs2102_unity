/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 05/10/2022
 *Descripción: Clase con las funciones para controlar la rotación de la hélice del avión.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speedRotation = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speedRotation);
    }
}
