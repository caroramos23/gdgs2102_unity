/*
 *Autor: Carolina Ramos Velázquez
 *Fecha: 06/10/2022
 *Descripción: Clase con las funciones para controlar el lanzamiento de pelotas.
 */using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int pelota = Random.Range(0, 3);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[pelota].transform.rotation);
        startDelay = Random.Range(1, 5);
        Invoke("SpawnRandomBall", startDelay);
    }

}
