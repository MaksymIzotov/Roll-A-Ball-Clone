using UnityEngine;
 
public class CameraFollow : MonoBehaviour
{
    public float smoothTime = 0.3f;

    [SerializeField] private Transform target;
    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        transform.LookAt(target);
    }
}
