using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownHandler : MonoBehaviour
{
    private char operatorC = '+';
    
    public void HandleInputData(int value)
    {
        switch (value)
        {
            case 0:
                operatorC = '+';
                break;
            case 1:
                operatorC = '-';
                break;
            case 2:
                operatorC = '*';
                break;
            case 3:
                operatorC = '/';
                break;
        }
        
        PlayerPrefs.SetString("operator", operatorC.ToString());
    }
}
