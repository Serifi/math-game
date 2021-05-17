using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Problem[] problems;      // list of all problems
    public int curProblem;          // current problem the player needs to solve
    public float timePerProblem;    // time allowed to answer each problem

    public float remainingTime;     // time remaining for the current problem


    // instance
    public static GameManager instance;

    void Awake ()
    {
        // set instance to this script.
        instance = this;
    }

    void Start ()
    {
        // set the initial problem
        SetProblem(0);
    }

    void Update ()
    {
        remainingTime -= Time.deltaTime;

        // has the remaining time ran out?
        if(remainingTime <= 0.0f)
        {
            
        }
    }

    // called when the player enters a tube
    public void OnPlayerEnterTube (int tube)
    {
        // did they enter the correct tube?
        if (tube == problems[curProblem].correctTube)
            CorrectAnswer();
        else
            IncorrectAnswer();
    }

    // called when the player enters the correct tube
    void CorrectAnswer()
    {
        // is this the last problem?
        if (problems.Length - 1 == curProblem)
            return;
        else
            SetProblem(curProblem + 1);
    }

    // called when the player enters the incorrect tube
    void IncorrectAnswer ()
    {
        ProblemTube.Destroy(this);
    }

    // sets the current problem
    void SetProblem (int problem)
    {
        curProblem = problem;
        UI.instance.SetProblemText(problems[curProblem]);
        remainingTime = timePerProblem;
    }

}