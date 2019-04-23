using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public float speed = 1;

    private Rigidbody rb;

    public float force = 10;

    //public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0, 0, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Este mensaje lo muestra una vez por cada update
        //Debug.Log("Yay");
        //Vector3 newPos = transform.position;
        //newPos.x += Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        //newPos.z += Input.GetAxis("Vertical")*Time.deltaTime*speed;

        //transform.position = newPos;

        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0,
        //                        Input.GetAxis("Vertical") * Time.deltaTime * speed);

        //Cambia el color de la pelota
        //RaycastHit hitInfo;

        //if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 1))
        //{
        //    GetComponent<MeshRenderer>().material.color = Color.green;
        //}


        ////Cambiamos el color del plano
        //RaycastHit hitInfo;

        //if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 1))
        //{
            
        //    if(hitInfo.collider.gameObject.CompareTag("Plano"))
        //        hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.green;
        //}

        //Debug.DrawRay(transform.position, Vector3.down*2,Color.green);

        //if (Input.GetButtonDown("Jump"))
        //{
        //    Jump();
        //}


    }

    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal")*force,0,Input.GetAxis("Vertical")*force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Plano")
        //{
        //    Destroy(gameObject);
        //}

        //Destruye el cubo al tocar el plano con la esfera
        //if(collision.gameObject.tag == "Plano")
        //{
        //    if (cubo)
        //    {
        //        Destroy(cubo);
        //    }
        //}

        
    }

    private void OnTriggerStay(Collider other)
    {
        transform.localScale += Vector3.one * 4 * Time.deltaTime;
    }

    //Esto salta
    public void Jump()
    {
        //rb = GetComponent<Rigidbody>();
        if (Mathf.Abs(rb.velocity.y) < 0.005f)
        {
            rb.AddForce(0, force, 0, ForceMode.Impulse);
        }
    }


    private void OnMouseDown()
    {
        //Destruye la esfera
        //Destroy(gameObject);

        //Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hitInfo;

        //if(Physics.Raycast(myRay,out hitInfo))
        //{
        //    rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
        //}
    }
}
