using UnityEngine;

public class moverConTeclasEsfera : MonoBehaviour
{
    [Header("Velocidad de movimiento")]
    public float speed = 2f;
    [SerializeField] private Vector3 posicion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform esfera = GameObject.Find("Sphere").gameObject.GetComponent<Transform>();
        esfera.position = new Vector3(esfera.position.x, esfera.position.y, esfera.position.z);
        posicion = esfera.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        posicion = transform.position;
    }
}
