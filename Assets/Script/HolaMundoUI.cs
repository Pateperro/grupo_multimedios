using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HolaMundoUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private Button Button;
    void Start()
    {
        if (Button != null)
        {
            Button.onClick.AddListener(() => ChangeTextHW("Hola Mundo!!"));
        }
    }

    public void ChangeTextHW(string newText)
    {
        if(textMeshPro != null)
        {
            textMeshPro.text = newText;
        }
    }
}
