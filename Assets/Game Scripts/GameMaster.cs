﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Manager;
    void Start()
    {
        Instantiate(Manager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MasterLogs(){
        
    }
}
