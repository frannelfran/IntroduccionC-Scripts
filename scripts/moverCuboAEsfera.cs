using UnityEngine;

public class moverCuboAEsfera : MonoBehaviour
{
    [Header("Posiciones de la esfera y el cubo")]
    [SerializeField] private Vector3 posicionEsfera;
    [SerializeField] private Vector3 posicionCubo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform esfera = GameObject.Find("Sphere").gameObject.GetComponent<Transform>();
        Transform cubo = GameObject.Find("Cube").gameObject.GetComponent<Transform>();
        posicionEsfera = esfera.position;
        posicionCubo = cubo.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 direccion = posicionEsfera - posicionCubo;
            direccion.Normalize();
            transform.Translate(direccion * 2f * Time.deltaTime);
            // Mantengo la y constante y el resto lo muevo
            posicionCubo.x += direccion.x * 2f * Time.deltaTime;
            posicionCubo.z += direccion.z * 2f * Time.deltaTime;
        }
    }
}
