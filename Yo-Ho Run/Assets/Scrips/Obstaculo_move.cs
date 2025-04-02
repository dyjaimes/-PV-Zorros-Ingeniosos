using UnityEngine;

public class Obstaculo_mov: MonoBehaviour
{
    public float speed = 1f;  // Velocidad del objeto
    private float destroyZ = -10f; // Posici�n donde se destruir� el objeto
    private Renderer objRenderer;
    private Renderer[] renderers; // Arreglo de Renderers


    void Start()
    {
        // La posici�n de eliminaci�n depende de la direcci�n de la c�mara
        destroyZ = Camera.main.transform.position.z - 2f; // Un poco m�s atr�s de la c�mara
                                                          // Obtener todos los renderers dentro del objeto y sus hijos
        renderers = GetComponentsInChildren<Renderer>();

        // Ocultar todos los renderers al inicio
        SetRenderersVisible(false);

        // Obtener el Renderer del objeto
        objRenderer = GetComponent<Renderer>();

        // Asegurar que el objeto est� oculto al inicio
        objRenderer.enabled = false;
    }

    void Update()
    {
        
        // Mueve el objeto hacia la c�mara en el eje Z
        transform.position += Vector3.back * speed * Time.deltaTime;

        // Si el objeto pasa la c�mara, se destruye
        if (transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }


        if (transform.position.z <= 350.9f)
        {
            objRenderer.enabled = true;
        }
    }


    // M�todo para activar/desactivar todos los renderers
    void SetRenderersVisible(bool state)
    {
        foreach (Renderer r in renderers)
        {
            r.enabled = state;
        }
    }


}
