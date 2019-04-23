using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego : MonoBehaviour
{

    public int contadorPuntos;
    // Start is called before the first frame update
    void Start()
    {
        contadorPuntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        ////Version 2
        ////Camera.main es la caamara que es est[a utilizando en este momento
        
        //El Raycast sale del centro de la cámara
        Ray myRay = Camera.main.ViewportPointToRay(new Vector3 (0.5f,0.5f,0));
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Silueta")
                {
                    Debug.DrawRay(transform.position, hitInfo.point, Color.green);
                    contadorPuntos += 1;

                    Debug.Log(hitInfo.collider.gameObject.name);

                    Destroy(hitInfo.collider.gameObject);
                }

            }
        }

    }
}
