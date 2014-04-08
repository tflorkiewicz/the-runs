using UnityEngine;
using System.Collections;

public class FoodItem : MonoBehaviour {

    public float Calories = 0f;
    public float NutritionalValue = 0f;

    private GameManager _gameManager;

    void Start()
    {
        _gameManager = (GameManager)Camera.main.GetComponent("GameManager");
    }

    void OnTriggerEnter()
    {
        Debug.Log("Consuming " + this.gameObject.name);

        Debug.Log("Calories " + Calories);
        _gameManager.Energy += (Calories / _gameManager.DailyCalories) * 100f;
        
        Debug.Log("NutritionalValue  " + NutritionalValue);
        _gameManager.Fitness += NutritionalValue;
        
        Destroy(gameObject);
    }
}
