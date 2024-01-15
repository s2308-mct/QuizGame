using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer : MonoBehaviour
{
    public Text ans;
    private void Start()
    {
        ans.text = csvReader.answer;
    }
}