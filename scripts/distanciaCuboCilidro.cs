using UnityEngine;

public class distanciaCuboCilidro : MonoBehaviour
{
    private Transform cubo;
    private Transform cilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.Find("Cube").GetComponent<Transform>();
        cilindro = GameObject.Find("Cylinder").GetComponent<Transform>();
        Debug.Log("Distancia al cubo: " + Vector3.Distance(transform.position, cubo.position));
        Debug.Log("Distancia al cilindro: " + Vector3.Distance(transform.position, cilindro.position));
    }

    // Update is called once per frame
    void Update()
    {
    }
}
