using UnityEngine;

public class Rotate_UI : MonoBehaviour
{
    public float rotationSpeed = 60.0f; // Speed of rotation in degrees per second

    private void Update()
    {
        // Rotate the UI element around the Z-axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
