using UnityEngine;

public class moverCubo : MonoBehaviour
    
{
    [Header("Posicion del Cubo")]
    [SerializeField] public Vector3 posicion;
    [Header("Direccion de movimiento")]
    [SerializeField] public Vector3 moveDirection;
    [Header("Velocidad de movimiento")]
    [SerializeField] public float speed = 2f;

    [Header("¿Mover en coordenadas locales?")]
    public bool usarLocal = false;  // permite cambiar entre local/world
    private Transform cubo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.Find("Cube").GetComponent<Transform>();
        // Pongo el cubo en una posicon y = 0
        cubo.position = new Vector3(cubo.position.x, 3, cubo.position.z);
        posicion = cubo.position;
    }


    // Update is called once per frame
    void Update()
    {
        Space referencia = usarLocal ? Space.Self : Space.World;

        cubo.Translate(moveDirection * speed * Time.deltaTime, referencia);
        posicion = cubo.position;
    }
}
