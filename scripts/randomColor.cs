using UnityEngine;

public class RandomColor : MonoBehaviour
{
    private Renderer objectRenderer;
    public int framesInterval = 120;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener el componente Renderer del objeto
        objectRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        float[] vectorColor = {r, g, b};
        // Verificar si tenemos un renderer y si han pasado 120 frames (cada 2 segundos aproximadamente a 60fps)
        if (objectRenderer != null && Time.frameCount % framesInterval == 0)
        {
            int index = Random.Range(0, 3);
            for (int i = 0; i < 3; i++) {
                if (i == index) {
                    vectorColor[i] = Random.Range(0f, 1f);
                }
            }
            
            // Crear el color y aplicarlo al material
            Color randomColor = new Color(r, g, b);
            objectRenderer.material.color = randomColor;
        }
    }
}
