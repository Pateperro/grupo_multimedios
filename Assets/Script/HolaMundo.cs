using UnityEngine;


public class HolaMundo : MonoBehaviour
{


    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Hola Mundo");
        }
    }
}
