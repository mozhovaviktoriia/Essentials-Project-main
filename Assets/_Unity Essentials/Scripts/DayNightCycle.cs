using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The time in seconds it takes for a full day to pass (1 full rotation of the light)
    [Tooltip("Time in seconds for one full day cycle.")]
    public float secondsPerDay = 60f;

    // Speed at which the light rotates (calculated from secondsPerDay)
    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on secondsPerDay
        rotationSpeed = 360f / secondsPerDay;
    }

    void Update()
    {
        // Rotate the light around the X axis (simulating the sun's movement)
        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
