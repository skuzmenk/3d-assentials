using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real seconds a full day lasts")]
    public float dayLength = 120f; // тривалість дня в секундах

    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = 360f / dayLength;
    }

    void Update()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}