using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class DropDown2 : MonoBehaviour
{
    private Dropdown dropDown;
    
    private void Awake()
    {
        dropDown = GetComponent<Dropdown>();
        dropDown.onValueChanged.AddListener(new UnityAction<int>(index =>
        {
            PlayerPrefs.SetInt("valueDP2", dropDown.value);
        }));
    }

    private void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("valueDP2", 0);
    }
}
