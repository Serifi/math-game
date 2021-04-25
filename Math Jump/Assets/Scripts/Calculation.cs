using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Calculation : MonoBehaviour
{
    public Text calculationT;
    public Text result1;
    public Text result2;
    public Text result3;
    public Text result4;
    private int no1;
    private int no2;
    private char op;

    void Update()
    {
        if (Transmitter.isStartedT)
        {
            no1 = Random.Range(1, 100);
            no2 = Random.Range(1, 100);
            op = Transmitter.operatorT;
            calculationT.text = no1.ToString() + " " + op + " " + no2.ToString();
        }
    }
} 