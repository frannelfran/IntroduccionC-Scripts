using UnityEngine;
using UnityEngine.InputSystem; // Necesario para el nuevo Input System
using System.Linq; // Necesario para usar Select()

public class MoverAPosicion : MonoBehaviour
{
    private Vector3[] marcadores;
    private int indice = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Buscar todos los GameObjects con tag "Marcador" y obtener sus posiciones
        GameObject[] objetosMarcadores = GameObject.FindGameObjectsWithTag("marcador");
        marcadores = objetosMarcadores.Select(m => m.transform.position).ToArray();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marcadores == null || marcadores.Length == 0) return;

        // Usar el nuevo Input System para detectar la barra espaciadora
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Vector3 posicionActual = transform.position;
            Vector3 posicionMarcador = marcadores[indice];
            
            // Calculo la distancia de la esfera hacia el marcador
            float distancia = Vector3.Distance(posicionActual, posicionMarcador);
            
            // Calculo la dirección hacia el marcador
            Vector3 direccion = (posicionMarcador - posicionActual).normalized;
            
            // Muevo la esfera dicha distancia en la dirección del marcador
            transform.position = posicionActual + (direccion * distancia);
            
            // Incremento el indice y miro si se llegó al final
            indice = (indice + 1) % marcadores.Length;
        }
    }
}
