using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Main : MonoBehaviour 
{
	// Use this for initialization
    //private void Start() 
    //{
    //    Média(2,4,6);
    //    Média(6,7,9);
    //    Média(6,16,20);
    //}

    //private int Soma3(int a, int b, int c)
    //{
    //    return a + b + c;
    //}

    //private void Média(int a, int b, int c)
    //{
    //    int result = Soma3(a, b, c);
    //    Debug.Log(result / 3);
    //}

    public int a = 1;
    public int b = 8;
    public int c = -9;

    private void Start()
    {
        Bhaskara(a, b, c);
    }

    private double Valores(double a, double b, double c)
    {
        return Math.Pow(b, 2) - (4 * a * c);
    }

    private void Bhaskara(double a, double b, double c)
    {
        double delta = Valores(a, b, c);
        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Debug.Log(x1 + ", " + x2);
    }
}
