using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType(typeof(GameManager)) as GameManager;

            return instance;
        }
        set
        {
            instance = value;
        }
    }
    private static GameManager instance;

    public Action recogerMoneda;
    public CurrentsCoins currentsCoins;
    public AudioSource audioSource;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject finalCanvas;
    public LevelData levelData;

    private float timeCounter;

    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        currentsCoins.currentsCoins = 0;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        timeCounter += Time.deltaTime;
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 

    public void SaveLevelData()
    {
        if(levelData.bestTime < timeCounter)
        {
            levelData.bestTime = timeCounter;
        }

        if(levelData.colectedCoins < currentsCoins.currentsCoins)
        {
            levelData.colectedCoins = currentsCoins.currentsCoins;
        }

        levelData.isComplete = true;

        currentsCoins.totalCoins += currentsCoins.currentsCoins;

        ManagerGuardo.Instance.Save();
    }

}

