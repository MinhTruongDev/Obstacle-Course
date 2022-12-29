using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]
    float spinAmountX = 0;
    [SerializeField]
    float spinAmountY = 0.5f;
    [SerializeField]
    float spinAmountZ = 0;    
   
    // Update is called once per frame
    void Update()
    {
        Spin();
    }
    void Spin()
    {
        if (Time.time > 35f)
        {
            transform.Rotate(spinAmountX, spinAmountY, spinAmountZ);
        }
        else if (Time.time < 35f)
        {
            transform.Rotate(spinAmountX, -spinAmountY, spinAmountZ);
        }
    }
}
