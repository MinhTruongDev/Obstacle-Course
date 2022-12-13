using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(this.name);
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
