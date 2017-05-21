using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script avoid my particles to be destroyed when changing scenes 

public class ParticlesSystem : MonoBehaviour
{
  
    private static ParticlesSystem dust;

    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (dust == null)
        {
            dust = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

}
