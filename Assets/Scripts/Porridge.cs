using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
     [SerializeField] private float temperature;

    private void Start()
    {
        temperature = 100;
    }

    private void Update()
    {
        temperature = temperature - Time.deltaTime;

        if (temperature > 70)
        {
            Debug.Log("Player says:" + "The temperature is too hot at " + (int)temperature);
        }
        else if (temperature < 40)
        {
            Debug.Log("the temperature is too cold at " + (int)temperature);
        }
        else
        {
            Debug.Log("the temperature is just right at " + (int)temperature);
        }
    }
}
