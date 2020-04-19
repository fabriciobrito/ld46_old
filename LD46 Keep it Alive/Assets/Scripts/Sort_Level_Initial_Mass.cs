﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort_Level_Initial_Mass : MonoBehaviour
{
    public GameObject initialRock;
    public GameObject[] rocks;

    // Start is called before the first frame update
    void Start()
    {
        int sum = Random.Range(8, 15);
        initialRock.GetComponent<Rock_Mass>().mass = (float)sum;

        int mass_A = Random.Range(1, 8);
        int mass_B = sum - mass_A;
        int mass_C = Random.Range(1, 8);

        int index = Random.Range(0, rocks.Length);

        rocks[index].GetComponent<Rock_Mass>().mass = mass_A;
        index += index == 2 ? -2 : 1;
        rocks[index].GetComponent<Rock_Mass>().mass = mass_B;
        index += index == 2 ? -2 : 1;
        rocks[index].GetComponent<Rock_Mass>().mass = mass_C;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}