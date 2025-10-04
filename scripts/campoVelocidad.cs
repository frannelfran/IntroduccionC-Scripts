using UnityEngine;
using UnityEngine.InputSystem; // Necesario para el nuevo Input System

public class CampoVelocidad : MonoBehaviour
{
    public int velocidad = 10;
    Transform cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.Find("Cube").GetComponent<Transform>();
        Vector3 posicion = cubo.position;

    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float resultado = 0f;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            resultado = velocidad * vertical;
            Debug.Log("Flecha Arriba → " + resultado);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            resultado = velocidad * vertical;
            Debug.Log("Flecha Abajo → " + resultado);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            resultado = velocidad * horizontal;
            Debug.Log("Flecha Izquierda → " + resultado);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            resultado = velocidad * horizontal;
            Debug.Log("Flecha Derecha → " + resultado);
        }
    }
}