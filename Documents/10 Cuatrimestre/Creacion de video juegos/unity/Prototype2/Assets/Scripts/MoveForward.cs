/*
 *Autor: Carolina Ramos Vel�zquez
 *Fecha: 06/10/2022
 *Descripci�n: Clase con las funci�n para mover hacia adelante los objetos.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
