using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Clic sinistro del mouse
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Box"))
                {
                    MoveTo(hit.collider.transform.position);
                }
            }
        }
    }

    private void MoveTo(Vector3 targetPosition)
    {
        transform.position = targetPosition;
    }
}