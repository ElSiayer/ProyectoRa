﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collition){
        if (!collition.gameObject.name.Equals("Terrain")){
            this.gameObject.GetComponent<Animator>().SetTrigger("Muerte");
        }        
    }
}
