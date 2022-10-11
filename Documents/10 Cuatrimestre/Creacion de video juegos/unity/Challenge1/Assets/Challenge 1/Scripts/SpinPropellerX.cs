/*
 *Autor: Carolina Ramos Vel�zquez
 *Fecha: 05/10/2022
 *Descripci�n: Clase con las funciones para controlar la rotaci�n de la h�lice del avi�n.
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
