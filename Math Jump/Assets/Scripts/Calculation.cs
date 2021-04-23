using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Calculation : MonoBehaviour
{
    public Text calculationText;
    public char operatorC = '+';
    public GameObject cntrlr;

    void Start()
    {
        
    }
    
    void Update()
    {
        Controller controller = cntrlr.GetComponent<Controller>();
        if (controller.isStarted)
        {
            calculationText.text = Random.Range(1, 100).ToString() + " " + operatorC + " " + Random.Range(1, 100).ToString();
        }
    }
} 