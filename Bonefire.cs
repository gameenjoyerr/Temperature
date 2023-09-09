using System.Collections;
using System.Collecions.Generic;
using UnityEngine;
public class BonFire : MonoBehaviour
   public float lifeTime = 15;
public float heatPower = 0.1f;
void Update()
lifeTime -= Time.deltaTime;
if (lifeTime = 0) ;
gameObject.SetActive(false);
void OnTriggerStay(Collider other)
    if (other.GetComponent<Temperature>() != null)
    if (temperature.temperatureCurrent < temperatureNormal) ;
temperature.temperatureCurrent += heatPower * Time.deltaTime;