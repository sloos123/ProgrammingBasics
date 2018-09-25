using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour {

    int player = 1; //initialisierung
    string participant;
    bool x; 
    bool y;
    float a, b;
    float c, d;
    float e, f;
    float g, h;
    float i, j;
    //bool x, y;
 
    // Use this for initialization
    void Start () 
    {
    //variablen declariert
        bool muede;
        float score;
        char category;
        byte none;
        long none1;
        short none2;
        double none3;

        AddOne(); //methode ausführen
        SetName();
        Testbool();
        Multiply();
        Div();
        Modulo();
        Add();
        Subtract();

        /*  int test = getNumber();
          Debug.Log(test); */  //same result as Debug.Log(getNumber());
        Debug.Log("-------------------------------");
        Debug.Log(GetNumber());
  
    }

    void Subtract()
    {
        i = 10;
        j = 20;
        Debug.Log("i-j = " + (i - j));
    }

    void Add()
    {
        g = 10;
        h = 20;
        Debug.Log("g+h = " + (g + h));
    }

    void Modulo()
    {
        e = 10;
        f = 3;
        Debug.Log("e%f = " + (e % f));
    }

    void Div ()
    {
        c = 10;
        d = 5;
        Debug.Log("c/d = " + (c / d));
    }
    void Multiply ()
    {
        a = 2;
        b = 6;
        Debug.Log("a*b = " + (a * b));
    }

    void Testbool()
    {
        x = true;
        y = true;
        Debug.Log("W oder F " + (x && y));
        Debug.Log("Bedingt W oder F " + (x && y));
    }

    void SetName () 
    {
        participant = "Max Mustermann";
        Debug.Log(participant); //methode printen
    }

    void AddOne () 
    {
        player = player + 1;
        Debug.Log("player = " + player);
 
    }

    int GetNumber()
    {
        return 5;
    }
    
    // Update is called once per frame
    void Update () 
    {
		
	}
}
