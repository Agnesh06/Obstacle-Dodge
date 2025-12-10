using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    MeshRenderer mymesh;
    Rigidbody myrigid;
    void Start()
    {
        mymesh = GetComponent<MeshRenderer>();
        myrigid = GetComponent<Rigidbody>();

        myrigid.useGravity = false;
        mymesh.enabled = false;
    }

    
    void Update()
    {
        if (Time.time > timeToWait)
        {
            myrigid.useGravity = true;
            mymesh.enabled = true;
        
        }
    }
}
