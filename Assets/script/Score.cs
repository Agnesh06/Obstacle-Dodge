using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into a things this many times:  " + hits);
        }
       
    }

}
