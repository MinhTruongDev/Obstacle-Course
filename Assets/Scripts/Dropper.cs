using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float dropTime = 3f;
    [SerializeField]
    MeshRenderer _renderer;
    [SerializeField]
    Rigidbody _rigidbody;
    void Start() 
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        DropObstacle();
    }
    void DropObstacle()
    {
        if (Time.time > dropTime)
        {
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
    