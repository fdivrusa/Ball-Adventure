using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevelsClone : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        //I don't want LevelsSound in menu, so I destroy it
        DestroyObject(GameObject.Find("LevelSound"));
    }

}
