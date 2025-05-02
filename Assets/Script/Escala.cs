using UnityEngine;

public class Escala : MonoBehaviour
{
    [SerializeField] public  HolaMundoUI holaMundoUI;
    [SerializeField] private Transform ObjectToScale;
    [SerializeField] private float scaleSpeed = 0.1f; // velocidad de escalado
    [SerializeField] private float minScale = 0.005f; // valor minimo de escala

    private string ScaleText = "Escalado a: ";
    private string WarningText = "No se puede hacer más pequeño";
    void Start()
    {
        holaMundoUI.ChangeTextHW("Empty");
    }

    // Update is called once per frame
    public void ScaleUp()
    {
        ObjectToScale.localScale += Vector3.one * scaleSpeed;
        holaMundoUI.ChangeTextHW(ScaleText + ObjectToScale.localScale.x.ToString("F2"));
        // muestra el valor de escala con dos valores decimales
    }

    public void ScaleDown()
    {
        if(ObjectToScale.localScale.x > minScale)
        {
            ObjectToScale.localScale -= Vector3.one * scaleSpeed;
            holaMundoUI.ChangeTextHW(ScaleText + ObjectToScale.localScale.x.ToString("F2"));
        }
        else
        {
            holaMundoUI.ChangeTextHW(WarningText);
        }
    }

}
