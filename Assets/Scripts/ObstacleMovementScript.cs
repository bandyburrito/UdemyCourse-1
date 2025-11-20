using UnityEngine;

public class ObstacleMovementScript : MonoBehaviour
{
    [SerializeField] public float speed = 4f;
    [SerializeField] public float height = 10f;
    
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}