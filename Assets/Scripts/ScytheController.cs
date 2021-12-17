using UnityEngine;


public class ScytheController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private DoubleWeaponFollower follower;
    [SerializeField] private ParticleSystem particle;
    public void Open()
    {
        animator.SetTrigger("open");
        follower.FollowOneHand();
        follower.Full();
    }
    public void Gun()
    {
        animator.SetTrigger("gun");
        particle.Play();
    }
    public void StopFollow()
    {
        follower.StopFollow();
    }


    public void Close()
    {
        animator.SetTrigger("close");

    }


    public void Rot()
    {
        follower.Rot();
    }
}
