using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuelosMovil : MonoBehaviour
{
    public Transform[] puntoMovimineto;
    public float velocidadMovimiento;
    private int siguienteplatafomra = 1;
    private bool ordenplataformas = true;
    private void Update()
    {

        if (ordenplataformas && siguienteplatafomra + 1 >= puntoMovimineto.Length)
        {
            ordenplataformas = false;
        }
        if (!ordenplataformas && siguienteplatafomra <= 0)
        {
            ordenplataformas = true;
        }

        if (Vector2.Distance(transform.position, puntoMovimineto[siguienteplatafomra].position) <0.1f)
        {
            if (ordenplataformas)
            {
                siguienteplatafomra += 1;
            }
            else
            {
                siguienteplatafomra -= 1;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, puntoMovimineto[siguienteplatafomra].position, velocidadMovimiento * Time.deltaTime);
    }
}
