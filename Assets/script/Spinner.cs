using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xangle = 0f;
    [SerializeField] float yangle = 0f;
    [SerializeField] float zangle = 0f;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xangle , yangle , zangle );
    }
}
