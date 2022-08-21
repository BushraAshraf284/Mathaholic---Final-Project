﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Problemhangman
{
    public float firstNumber;           // first number in the problem
    public float secondNumber;          // second number in the problem
    public float thirdNumber;           // third number in the problem
    public string expression;           // algebric expression in the problem
  //  public MathsOperation operation;    // operator between the two numbers
    public float[] answers;             // array of all possible answers including the correct one

    [Range(0, 3)]
    public int correctTube;             // index of the correct tube
}

//public enum MathsOperation
/*{
    Addition,
    Subtraction,
    Multiplication,
    Division
}*/