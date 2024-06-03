using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerteCabeza : MonoBehaviour
{

    public LayerMask sueloLayer; 
    public GameObject canvaGameOver; 
    public GameManager gamemanager;
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, 2f, sueloLayer);

        if (hit.collider != null)
        {
            gamemanager.GameOver();
        }
    }
}
