using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text problemText;                // text that displays the maths problem
    public Text[] answersTexts;             // array of the 4 answers texts



    // instance
    public static UI instance;

    void Awake ()
    {
        // set instance to be this script
        instance = this;
    }
    


    // sets the ship UI to display the new problem
    public void SetProblemText (Problem problem)
    {
        string operatorText = "";

        // convert the problem operator from an enum to an actual text symbol
        switch(problem.operation)
        {
            case MathsOperation.Addition: operatorText = " + "; break;
            case MathsOperation.Subtraction: operatorText = " - "; break;
            case MathsOperation.Multiplication: operatorText = " x "; break;
            case MathsOperation.Division: operatorText = " ÷ "; break;
        }

        // set the problem text to display the problem
        problemText.text = problem.firstNumber + operatorText + problem.secondNumber;

        // set the answers texts to display the correct and incorrect answers
        for(int index = 0; index < answersTexts.Length; ++index)
        {
            answersTexts[index].text = problem.answers[index].ToString();
        }
    }


}