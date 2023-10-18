using UnityEngine;

public class Occupier : MonoBehaviour
{
    private Transform currentSquare; // Riferimento alla casella attuale

    private void Start()
    {
        SetSquareBeneathAsOccupied();
    }

    public void MoveTo(Vector3 newPosition)
    {
        FreeCurrentSquare();
        transform.position = newPosition;
        SetSquareBeneathAsOccupied();
    }

    private void FreeCurrentSquare()
    {
        if (currentSquare)
        {
            SquareStatus cubeStatus = currentSquare.GetComponent<SquareStatus>();
            if (cubeStatus)
            {
                cubeStatus.isOccupied = false;
            }
            currentSquare = null;
        }
    }

    private void SetSquareBeneathAsOccupied()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            if (hit.collider.CompareTag("Square"))
            {
                currentSquare = hit.collider.transform;
                SquareStatus cubeStatus = hit.collider.GetComponent<SquareStatus>();
                if (cubeStatus)
                {
                    cubeStatus.isOccupied = true;
                }
            }
        }
    }
}
