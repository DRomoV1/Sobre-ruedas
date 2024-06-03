using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogerFuel : MonoBehaviour
{
    public AudioClip audioConvustible;
    public AudioSource ConvustibleAudido;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ConvustibleAudido.PlayOneShot(audioConvustible, 1);
            FuelController.instance.FillFuel();
            Destroy(gameObject);
        }
    }
}
