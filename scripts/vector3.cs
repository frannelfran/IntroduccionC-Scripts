using UnityEngine;

public class vector3 : MonoBehaviour
{
    [Header("Vectores de Entrada")]
    public Vector3 v1 = new Vector3(1.0f, 0.0f, 1.0f);
    public Vector3 v2 = new Vector3(0.0f, 1.0f, 0.0f);

    [Header("Resultados")]
    [SerializeField] private float magnitudV1;
    [SerializeField] private float magnitudV2;
    [SerializeField] private float angulo;
    [SerializeField] private float distancia;
    [SerializeField] private string vectorMasGrande;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalcularResultados();
    }
    
    void CalcularResultados()
    {
        // Calculo las magnitudes
        magnitudV1 = v1.magnitude;
        magnitudV2 = v2.magnitude;
        
        // Calculo el ángulo entre los vectores
        angulo = Vector3.Angle(v1, v2);
        
        // Calculo la distancia
        distancia = Vector3.Distance(v1, v2);
        
        // Determino cuál vector es más grande
        if (v1.sqrMagnitude > v2.sqrMagnitude)
        {
            vectorMasGrande = "v1 es mas grande que v2";
        } 
        else if (v1.sqrMagnitude < v2.sqrMagnitude)
        {
            vectorMasGrande = "v2 es mas grande que v1";
        } 
        else
        {
            vectorMasGrande = "Los vectores son iguales";
        }
        
        // Muestro la información en la consola también
        Debug.Log("Magnitud de v1: " + magnitudV1);
        Debug.Log("Magnitud de v2: " + magnitudV2);
        Debug.Log("Angulo entre v1 y v2: " + angulo);
        Debug.Log("Distancia entre v1 y v2: " + distancia);
        Debug.Log(vectorMasGrande);
    }

    void Update()
    {
        CalcularResultados();
    }
    

    void OnValidate()
    {
        if (Application.isPlaying)
        {
            CalcularResultados();
        }
    }
}
