using UnityEngine;

public class Traslacion : MonoBehaviour
{
    [SerializeField] private Transform objectToMove;
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] public HolaMundoUI HolaMundoUI;

    private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        if(moveDirection != Vector3.zero)
        {
            objectToMove.position += moveDirection * moveSpeed * Time.deltaTime;
            UpdatePositionText();
        }

    }

    public void StartMoveXPositive() { moveDirection = Vector3.right; }
    public void StartMoveXNegative() { moveDirection = Vector3.left; }
    public void StartMoveYPositive() { moveDirection = Vector3.up; }
    public void StartMoveYNegative() { moveDirection = Vector3.down; }
    public void StartMoveZPositive() { moveDirection = Vector3.forward; }
    public void StartMoveZNegative() { moveDirection = Vector3.back; }

    public void StopMove()
    {
        moveDirection = Vector3.zero;
    }

    // Update is called once per frame
    void UpdatePositionText()
    {
        HolaMundoUI.ChangeTextHW($"Posición: X {objectToMove.position.x:F2}, Y {objectToMove.position.y:F2}, Z {objectToMove.position.z:F2}");
    }
}
