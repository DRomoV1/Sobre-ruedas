using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioDeNivel : MonoBehaviour
{
    public GameObject MenuNivel;
    //public GameObject canvaGameOver;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MenuNivel.SetActive(true);
            Time.timeScale = 0.05f;
            GameManager.Instance.SaveLevelData();
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
