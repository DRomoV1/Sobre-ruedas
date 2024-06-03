using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorSonido : MonoBehaviour
{
    public static controladorSonido Instance;
    public AudioSource audioSource;
    public AudioClip clipCoins;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        GameManager.Instance.recogerMoneda += CoinPickSound;
    }

    private void OnDisable()
    {
        GameManager.Instance.recogerMoneda -= CoinPickSound;
    }

    public void EjecutarSonido(AudioClip sonido)
    {
        audioSource.PlayOneShot(sonido);
    }

    // Update is called once per frame
    public void PausaMusica()
    {
        audioSource.Stop();
    }
    public void CoinPickSound()
    {
        audioSource.PlayOneShot(clipCoins, 0.3f);
    }
}
