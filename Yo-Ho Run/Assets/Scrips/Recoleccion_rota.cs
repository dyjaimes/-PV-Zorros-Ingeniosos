using UnityEngine;

public class Recoleccion_rota : MonoBehaviour
{
    public float rotationSpeed = 100f;  // Velocidad de rotaci�n

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

    }
}