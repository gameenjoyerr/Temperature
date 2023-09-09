using System.Collections;
using System.Collecions.Generic;
using UnityEngine;
using UnityEngine.UI
    using TMPro;
public class TemperatureUI : MonoBehaviour
    public Temperature temperature;
public TextMeshProUGUI temperatureText;
void Update()
    float roundTemperature = Mathf.Round(Temperature.temperatureCurrent * 10.0f) * 0.1f;
temperatureText.text=roundTemperature.ToString();