using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITime : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeTxt;


    // Update is called once per frame
    void Update()
    {
        timeTxt.text = DateTime.Now.ToString(" HH:mm:ss");
    }
}
