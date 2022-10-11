/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase con las funciones para controlar las acciones del jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float tiempoEspera = 1;
    private float tiempoSiguienteDisparo;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSiguienteDisparo)
        {
            tiempoSiguienteDisparo = Time.time + tiempoEspera;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
