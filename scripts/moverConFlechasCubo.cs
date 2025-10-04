using UnityEngine;

public class moverConFlechasCubo : MonoBehaviour
{
    [Header("Velocidad de movimiento")]
    public float speed = 2f;
    [SerializeField] private Vector3 posicion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform cubo = GameObject.Find("Cube").gameObject.GetComponent<Transform>();
        cubo.position = new Vector3(cubo.position.x, cubo.position.y, cubo.position.z);
        posicion = cubo.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        posicion = transform.position;
        
    }
}
