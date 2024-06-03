using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public static FuelController instance;

    [SerializeField] private Image fuelImage;
    //[SerializeField, Range(10f, 5f)]//
    private float fuelDrainSpeed = 3f;
    [SerializeField] private float maxFuel = 0.1f;
    [SerializeField] private Gradient fuelgradient;

    private float currentFuelAmount;
    public GameManager gamemanager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        currentFuelAmount = maxFuel;
        UpdateUI();
    }

    void Update()
    {
        currentFuelAmount -= Time.deltaTime * fuelDrainSpeed;
        UpdateUI();
        if (currentFuelAmount <= 0f)
        {
            gamemanager.GameOver();
        }
    }
    private void UpdateUI()
    {
        fuelImage.fillAmount = (currentFuelAmount / maxFuel);
        fuelImage.color = fuelgradient.Evaluate(fuelImage.fillAmount);
    }
    public void FillFuel()
    {
        currentFuelAmount = maxFuel;
        UpdateUI();
    }
}
