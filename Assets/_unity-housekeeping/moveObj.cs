﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.transform.forward* Time.deltaTime/10);   
    }


}
