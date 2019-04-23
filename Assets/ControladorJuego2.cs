using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego2 : MonoBehaviour
{

    //La clase controlador Juego2 lo que hace es que no debemos colocar en cada objeto 
    //qué debe suceder con los raycast, si no, el mismo raycast devuelve el objeto que fue detectado

    private Rigidbody rb;
    public float force = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
        {
            //Con esta línea el Raycast devuelve el RigidBody al que se aplicó la fuerza
            hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.yellow;

            ////Con esta línea el Raycast devuelve el RigidBody al que se aplicó la fuerza
            //rb = hitInfo.collider.gameObject.GetComponent<Rigidbody>();
            //rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
        }

    }

    private void OnMouseDown()
    {

        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo))
        {
            //Prueba para ver si destruye la pelota
            //Destroy(hitInfo.collider.gameObject);
            Debug.Log(hitInfo.collider.gameObject.name);

            //Con esta línea el Raycast devuelve el RigidBody al que se aplicó la fuerza
            rb = hitInfo.collider.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
        }
    }
}
