using UnityEngine;

public class PerspectiveManager : MonoBehaviour
{
  

    [Header("Rotation Settings")]
     public Vector3 rotationAngles = new Vector3(30f, 0f, 0f); // Max rotation angles

    [Range (1,10)]
    public float rotationSpeed = 1f; // Speed of oscillation

    private Vector3 initialRotation;

    void Start()
    {
        initialRotation = transform.localEulerAngles;
    }

    void Update()
    {
        float angleX = Mathf.Sin(Time.time * rotationSpeed) * rotationAngles.x;
        float angleY = Mathf.Sin(Time.time * rotationSpeed) * rotationAngles.y;
        float angleZ = Mathf.Sin(Time.time * rotationSpeed) * rotationAngles.z;

        transform.localEulerAngles = initialRotation + new Vector3(angleX, angleY, angleZ);
    }
}


