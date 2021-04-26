using System;
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
    private int result;
    private int no1;
    private int no2;
    private string op;

    void Update()
    {
        if (Transmitter.isStartedT)
        {
            no1 = Random.Range(1, 100);
            no2 = Random.Range(1, 100);
            op = PlayerPrefs.GetString("operator");
            calculationT.text = no1.ToString() + " " + op + " " + no2.ToString();

            switch (op)
            {
                case "+":
                    result = no1 + no2;
                    break;
                case "-":
                    result = no1 - no2;
                    break;
                case "*":
                    result = no1 * no2;
                    break;
                case "/":
                    result = no1 / no2;
                    break;
            }

            switch (Random.Range(1, 5))
            {
                case 1:
                    result1.text = result.ToString();
                    result2.text = Random.Range(result - 10, result + 10).ToString();
                    result3.text = Random.Range(result - 10, result + 10).ToString();
                    result4.text = Random.Range(result - 10, result + 10).ToString();
                    break;
                case 2:
                    result1.text = Random.Range(result - 10, result + 10).ToString();
                    result2.text = result.ToString();
                    result3.text = Random.Range(result - 10, result + 10).ToString();
                    result4.text = Random.Range(result - 10, result + 10).ToString();
                    break;
                case 3:
                    result1.text = Random.Range(result - 10, result + 10).ToString();
                    result2.text = Random.Range(result - 10, result + 10).ToString();
                    result3.text = result.ToString();
                    result4.text = Random.Range(result - 10, result + 10).ToString();
                    break;
                case 4:
                    result1.text = Random.Range(result - 10, result + 10).ToString();
                    result2.text = Random.Range(result - 10, result + 10).ToString();
                    result3.text = Random.Range(result - 10, result + 10).ToString();
                    result4.text = result.ToString();
                    break;
            }
        }
    }
} 