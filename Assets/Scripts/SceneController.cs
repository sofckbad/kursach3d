using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private ScytheController scythe;
    [SerializeField] private ZombieController zombie;
    
    void OpenScythe()
    {
        scythe.Open();
    }
    void rotate()
    {
        scythe.Rot();
    }
    void CloseScythe()
    {
        scythe.Close();
    }
    void StopFollow()
    {
        scythe.StopFollow();
    }
    void GunScythe()
    {
        scythe.Gun();
    }
    
    void WalkZombie()
    {
        zombie.Walk();
    }
    void IdleZombie()
    {
        zombie.Idle();
    }
    void KillZombie()
    {
        zombie.Kill();
    }
}
