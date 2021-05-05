using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    //Script that rotate my pick-up objects
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * 3);
    }
}
