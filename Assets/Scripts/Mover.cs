using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float yValue = 0.01f;

    [SerializeField]
    float moveSpeed = 100f;
    [SerializeField]
    Rigidbody _rigidbody;
   

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), yValue, Input.GetAxis("Vertical"));
        transform.position += move * Time.deltaTime * moveSpeed;
    }
}
