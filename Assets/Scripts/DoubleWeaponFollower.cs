using System.Collections;
using Unity.Mathematics;
using UnityEngine;


public class DoubleWeaponFollower : MonoBehaviour
{
    [SerializeField] private Transform firstRoot;
    [SerializeField] private Transform secondRoot;
    [SerializeField] private Transform handRoot;
    [SerializeField] private float dur;
    [SerializeField] private float del;
    
    [SerializeField] private bool isFollowing;
    [SerializeField] private bool isFollowingOneHand;


    private void LateUpdate()
    {
        if (isFollowing)
        {
            transform.rotation = Quaternion.LookRotation(firstRoot.position - secondRoot.position)* Quaternion.Euler(0,0, 90.0f);
        }
        if (isFollowingOneHand)
        {
            transform.position += secondRoot.transform.position - handRoot.transform.position;
        }
    }
    
    public void FollowOneHand()
    {
        StartCoroutine(Routine3());
        isFollowingOneHand = true;
    }


    private IEnumerator Routine3()
    {
        var rot = transform.position;
        var time = 0.0f;

        while (true)
        {
            time += Time.deltaTime;
            var res = rot + secondRoot.transform.position - handRoot.transform.position;
            transform.position = Vector3.Lerp(rot, res, time / 1f);
            
            if (time >= 1f)
            {
                break;
            }

            yield return null;
        }
    }


    public void StopFollow()
    {
        isFollowing = false;
        isFollowingOneHand = false;
    }
    
    public void Full()
    {
        StartCoroutine(Routine());
    }


    private IEnumerator Routine()
    {
        var rot = transform.rotation;
        var time = 0.0f;
        yield return new WaitForSeconds(del);

        while (true)
        {
            time += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(rot, Quaternion.LookRotation(firstRoot.position - secondRoot.position), time / dur) *
                Quaternion.Lerp(quaternion.identity, Quaternion.Euler(0,0, 90.0f), time / dur);
            
            if (time >= dur)
            {
                break;
            }

            yield return null;
        }
        
        isFollowing = true;
    }


    public void Rot()
    {
    }
}