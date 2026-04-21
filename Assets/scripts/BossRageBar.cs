using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class BossRageBar : MonoBehaviour
{
    Slider slider;
    void Start(){
    }
    void Update(){
        slider.value = Globals.BossRage;
    }
}
