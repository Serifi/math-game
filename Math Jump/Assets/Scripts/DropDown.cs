using UnityEngine;

public class DropDown : MonoBehaviour
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
            default:
                operatorC = '+';
                break;
        }
        Transmitter.operatorT = operatorC;
    }
}