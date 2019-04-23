using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private Vector3 startPos1;
    private Vector3 startPos2;
    private Vector3 startPos3;

    private GameObject T1;
    private GameObject T2;
    private GameObject T3;
    // Start is called before the first frame update
    void Start()
    {
        T1 = GameObject.Find("Target_1");
        T2 = GameObject.Find("Target_2");
        T3 = GameObject.Find("Target_3");

        startPos1 = T1.transform.position;
        startPos2 = T2.transform.position;
        startPos3 = T3.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Poition le dice que posición debe tener 
        if(T1 != null)
            T1.transform.position = startPos1 + new Vector3(0, Mathf.Sin(Time.time)*2, 0);

        if (T2 != null)
            T2.transform.position = startPos2 + new Vector3(Mathf.Sin(Time.time) * 2, 0, 0);

        if (T3 != null)
            T3.transform.position = startPos3 + new Vector3(Mathf.Cos(Time.time) * 2, Mathf.Sin(Time.time) * 2, 0);
    }
}
