using Unity.VisualScripting;
using UnityEngine;

public class mover : MonoBehaviour

{
    [SerializeField] float movespeed = 1f;

    void Start()
    {
        Printnstruction();
    }


    void Update()
    {
        MovePlayer();
    }

    void Printnstruction()
    {
        Debug.Log("welcome ot the game");
        Debug.Log("use arrow key to move");

    }

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yvalue = 0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue, yvalue, zvalue);
    }
}
