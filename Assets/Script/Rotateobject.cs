using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Transform objectToRotate;
    [SerializeField] private float rotationSpeed = 100f; // Velocidad de rotación
    [SerializeField] private bool clockwise = true; // Dirección de rotación (true = horario, false = antihorario)
    [SerializeField] public HolaMundoUI HolaMundoUIScript;

    private bool isRotating = false; // Controla si el objeto está rotando

    void Update()
    {
        if (isRotating)
        {
            float direction = clockwise ? 1f : -1f; // Define el sentido de la rotación
            objectToRotate.Rotate(Vector3.up * rotationSpeed * direction * Time.deltaTime);
            Debug.Log("Rotando " + objectToRotate.name);
        }
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating; // Activa o desactiva la rotación
        if (HolaMundoUIScript != null)
        {
            if (isRotating)
            {
                HolaMundoUIScript.ChangeTextHW("Rotando Objeto");
            }
            else
            {
                HolaMundoUIScript.ChangeTextHW("Rotación detenida");
            }
        }
    }
}
