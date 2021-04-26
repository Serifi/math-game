using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class DropDown : MonoBehaviour
{
    private Dropdown dropDown;
    
    private void Awake()
    {
        dropDown = GetComponent<Dropdown>();
        dropDown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt("valueDP", dropDown.value);
        }));
    }

    private void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("valueDP", 0);
    }
}