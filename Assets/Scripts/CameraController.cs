using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform lookAt;

    private void LateUpdate()
    {
        transform.rotation = Quaternion.LookRotation(lookAt.position - transform.position);
    }
}