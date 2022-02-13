using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public static Pool instance = new Pool();

    public static Pool Instance { get; private set; }
    private void Awake()
    {
        
    }
}
