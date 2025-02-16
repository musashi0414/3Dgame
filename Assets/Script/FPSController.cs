using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
   
    [Range(0.1f, 0.0f)]
    //カメラ感度、数値が大きいほどより直感的な操作が可能.
    public float lookSensitivity = 0.0f;
    [Range(0.0f, 0.0f)]
    //数値が大きいほどカメラが向きたい方向に向くまでの時間が長くなる.
    public float lookSmooth = 0.0f;

    public Vector2 MinMaxAngle = new Vector2(-65, 65);

    private float yRot;
    private float xRot;

    private float currentYRot;
    private float currentXRot;

    private float yRotVelocity;
    private float xRotVelocity;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        yRot += Input.GetAxis("Mouse X") * lookSensitivity; //マウスの移動.
        xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //マウスの移動.



        xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//上下の角度移動の最大、最小.


        currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
        currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

        transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
    }

    
}
