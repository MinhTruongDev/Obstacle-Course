using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpedCounter = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            bumpedCounter++;
            Debug.Log("You've bumped into a thing this many times: " + bumpedCounter);
        }
    }
}
