using System;
using UnityEngine;

public class fly : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.position; 
    }


    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
    void MoveToPlayer()
    {
        
        transform.position = Vector3.MoveTowards
        (transform.position, playerPosition, speed * Time.deltaTime);
        
    }
    void DestroyWhenReached() 
    {
        if(transform.position==playerPosition)
        Destroy(gameObject);
        
    }
}
