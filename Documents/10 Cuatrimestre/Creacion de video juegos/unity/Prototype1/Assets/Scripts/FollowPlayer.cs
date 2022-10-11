/*
 * Autor: Carolina Ramos Velazquez
 * Fecha: 05/10/2022
 * Descripci�n: Clase con la funci�n para controlar el movimiento y la posici�n de la c�mara.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-1, 5, -6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
