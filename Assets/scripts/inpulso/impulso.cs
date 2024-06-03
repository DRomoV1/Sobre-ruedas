using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulso : MonoBehaviour
{
    public Vector3 direccion;
    public float fuerza = 7f;
    public Rigidbody2D PlayerRB;
    public float parar = 0.1f;

    public AudioClip audiosprint;
    public AudioSource sprintAudido;
    public void Start()
    {
        PlayerRB = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<Rigidbody2D>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            sprintAudido.PlayOneShot(audiosprint, 1);
            PlayerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
            PlayerRB.AddForce(direccion * fuerza);
            Invoke("reiniciarRueda", parar);
        }
       
    }
    public void reiniciarRueda()
    {
        PlayerRB.constraints = RigidbodyConstraints2D.None;
    }
}
