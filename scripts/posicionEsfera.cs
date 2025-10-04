using UnityEngine;

public class posicionEsfera : MonoBehaviour
{
    [Header("Posición de la esfera")]
    [SerializeField] private Vector3 posicion;
    private Transform esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        esfera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        posicion = esfera.position;
    }
        
}
