using UnityEngine;


public class ZombieController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void Walk()
    {
        animator.SetTrigger("walk");
    }
    public void Idle()
    {
        animator.SetTrigger("idle");
    }
    public void Kill()
    {
        animator.SetTrigger("kill");
    }
}
