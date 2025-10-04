using UnityEngine;

public class MovimientoCuboEjes : MonoBehaviour
{
    [SerializeField] private Vector3 posicion;
    [Header("Velocidad de movimiento")]
    public float speed = 5f;

    [Header("Velocidad de giro")]
    public float rotationSpeed = 100f;

    private Transform cubo;

    void Start()
    {
        cubo = GameObject.Find("Cube").transform;
        posicion = cubo.position;
    }

    void Update()
    {
        // Giro el cubo con el eje horizontal
        float rotacion = Input.GetAxis("Horizontal"); 
        cubo.Rotate(Vector3.up * rotacion * rotationSpeed * Time.deltaTime);

        // Avanzar hacia delante
        cubo.Translate(cubo.forward * speed * Time.deltaTime, Space.World);
    }
}
