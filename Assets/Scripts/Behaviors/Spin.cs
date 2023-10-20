using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 spinVector;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinVector * Time.timeScale);
    }
}
