﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kodgry : MonoBehaviour
{
    int min;
    int max;
    int guess;
    void Start()
    {
        min = 1;
        max = 1000;
        guess = (min + max) / 2;
        Debug.Log("Witaj w grze Number Wizard");
        print($"<color=green> Wymysl liczbe w glowie z przedzialu od </Color>" + min + "<color=green> do </Color>" + max);
        Debug.Log($"<color=green> Komputer bedzie pytal czy twoja liczba jest mniejsza lub wieksza od  { guess } ? </Color>");
        print("<color=yellow> Jesli nacisniesz gorna strzalke to liczba jest wieksza, dolna strzalke liczba jest mniejsza, enter to twoja liczba </Color>");
        max = max + 1;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("<color=red> Czy twoja liczba jest mniejsza lub wieksza od </Color>" + guess + "<color=red> ? </Color>");
            

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("<color=red> Czy twoja liczba jest mniejsza lub wieksza od </Color>" + guess + "<color=red> ? </Color>");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Zwyciezam");
            
          


        }
        // poprawic buga z wybieraniem liczby 1000 
        // sprobowac samodzielnie zamienic kolory komunikatow w konsoli 
        // dac uzytkownikowi mozliwosc w wybraniu przedzialu liczb (min i max)
        // Od razu po zakonczeniu jednej rozgrywki chcielibysmy restartowac nasza gre i uruchamiac ja na nowo (SceneManagement)
    }
}

