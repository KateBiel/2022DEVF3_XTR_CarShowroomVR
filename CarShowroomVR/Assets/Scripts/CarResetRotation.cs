using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarResetRotation : MonoBehaviour

{
    [SerializeField] GameObject RotationCar;

    [SerializeField] float RotationX ;
    bool  transformAnim = false;

     void Update()
    {
        ResetLocation();
    }



    void  ResetLocation()
    {
        if(transformAnim == true  )
        { transform.localRotation = Quaternion.Euler(RotationX, 1, 1); }
        
    }
}
