using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIJuego : MonoBehaviour
{

    public Text textoPuntajeActual;

    private GameObject controladorJuego;
    private ControladorJuego controladorJuegoScript;

    private int puntajeActualUI;

    // Start is called before the first frame update
    void Start()
    {

        controladorJuego = GameObject.Find("ControladorJuego");
        controladorJuegoScript = controladorJuego.GetComponent<ControladorJuego>();
        puntajeActualUI = controladorJuegoScript.contadorPuntos;

        textoPuntajeActual.text = puntajeActualUI.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        puntajeActualUI = controladorJuegoScript.contadorPuntos;
        textoPuntajeActual.text = puntajeActualUI.ToString();
    }
}
