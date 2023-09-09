using System.Collections;
using System.Collecions.Generic;
using UnityEngine;
public class Temperature : MonoBehaviour
    public Health health;
public int PLayerDamage = 2
    public float temperatureCurrent = 36.6f;
public float temperatureNormal = 36.6f;
public float temperatureCritical = 34f;
public float freezeSpeed = 0.05f;
public float freezeDamageTime = 1;
public float freezeDamageDelay = 2;
void Update()
    temperatureCurrent -= freezeSpeed * Time.deltaTime;
if (temperatureCurrent <= temperatureCritical)
    health.TakeDamage(playerDamage);