/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase con las función para que los perros avancen hacía adelante.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
