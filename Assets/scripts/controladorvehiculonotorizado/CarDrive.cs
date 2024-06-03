using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
{
    [SerializeField] private Rigidbody2D RudeaAtrasRb;
    [SerializeField] private Rigidbody2D RuedaAdelnateRb;
    [SerializeField] private Rigidbody2D cocheRb;
    [SerializeField] public float velocidad = 250f;
    public float rotacionVehiculo = 100f;
    private float moveInput; 
    private void Update()
    {
        moveInput = SimpleInput.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    { 
        RuedaAdelnateRb.AddTorque(-moveInput * velocidad * Time.fixedDeltaTime);
        RudeaAtrasRb.AddTorque(-moveInput * velocidad * 4 * Time.fixedDeltaTime);
        cocheRb.AddTorque(-moveInput * velocidad * 4 * Time.fixedDeltaTime);
    }
}
