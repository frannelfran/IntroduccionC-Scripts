using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Transform cubo;
    private Transform esfera;
    public float speedRotacion = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = GameObject.Find("Cube").GetComponent<Transform>();
        esfera = GameObject.Find("Sphere").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Hago que el cubo rote hacia la esfera
        cubo.LookAt(esfera);
    }
}
