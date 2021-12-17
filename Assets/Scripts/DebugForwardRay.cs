using UnityEngine;


namespace Assets.Scripts
{
    public class DebugForwardRay : MonoBehaviour
    {
        [SerializeField] private Color color;
        [SerializeField] private float length = 2.0f;
        private void OnDrawGizmos()
        {
            var buffer = Gizmos.color;
            Gizmos.color = color;
            Gizmos.DrawRay(transform.position, transform.forward * length);
            Gizmos.color = buffer;
        }
    }
}