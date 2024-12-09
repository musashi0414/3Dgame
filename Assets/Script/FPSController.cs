using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    //float x, z;
    //float speed = 0.1f;

    //public GameObject cam;
    //Quaternion cameraRot, characterRot;
    //float Xsensityvity = 3f, Ysensityvity = 3f;

    //bool cursorLock = true;

    ////変数の宣言(角度の制限用)
    //float minX = -90f, maxX = 90f;

    [Range(0.1f, 10f)]
    //カメラ感度、数値が大きいほどより直感的な操作が可能.
    public float lookSensitivity = 2f;
    [Range(0.1f, 1f)]
    //数値が大きいほどカメラが向きたい方向に向くまでの時間が長くなる.
    public float lookSmooth = 0.1f;

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
        //cameraRot = cam.transform.localRotation;
        //characterRot = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //float xRot = Input.GetAxis("Mouse X") * Ysensityvity;
        //float yRot = Input.GetAxis("Mouse Y") * Xsensityvity;

        //cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        //characterRot *= Quaternion.Euler(0, xRot, 0);

        ////Updateの中で作成した関数を呼ぶ
        //cameraRot = ClampRotation(cameraRot);

        //cam.transform.localRotation = cameraRot;
        //transform.localRotation = characterRot;


        //UpdateCursorLock();

        //UpdateCursorLock();

        yRot += Input.GetAxis("Mouse X") * lookSensitivity; //マウスの移動.
        xRot -= Input.GetAxis("Mouse Y") * lookSensitivity; //マウスの移動.



        xRot = Mathf.Clamp(xRot, MinMaxAngle.x, MinMaxAngle.y);//上下の角度移動の最大、最小.


        currentXRot = Mathf.SmoothDamp(currentXRot, xRot, ref xRotVelocity, lookSmooth);
        currentYRot = Mathf.SmoothDamp(currentYRot, yRot, ref yRotVelocity, lookSmooth);

        transform.rotation = Quaternion.Euler(currentXRot, currentYRot, 0);
    }

    //private void FixedUpdate()
    //{
    //    x = 0;
    //    z = 0;

    //    x = Input.GetAxisRaw("Horizontal") * speed;
    //    z = Input.GetAxisRaw("Vertical") * speed;

    //    //transform.position += new Vector3(x,0,z);

    //    transform.position += cam.transform.forward * z + cam.transform.right * x;
    //}


    //public void UpdateCursorLock()
    //{
    //    if (Input.GetKeyDown(KeyCode.Escape))
    //    {
    //        cursorLock = false;
    //    }
    //    else if (Input.GetMouseButton(0))
    //    {
    //        cursorLock = true;
    //    }


    //    if (cursorLock)
    //    {
    //        Cursor.lockState = CursorLockMode.Locked;
    //    }
    //    else if (!cursorLock)
    //    {
    //        Cursor.lockState = CursorLockMode.None;
    //    }
    //}

    ////角度制限関数の作成
    //public Quaternion ClampRotation(Quaternion q)
    //{
    //    //q = x,y,z,w (x,y,zはベクトル（量と向き）：wはスカラー（座標とは無関係の量）)

    //    q.x /= q.w;
    //    q.y /= q.w;
    //    q.z /= q.w;
    //    q.w = 1f;

    //    float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

    //    angleX = Mathf.Clamp(angleX, minX, maxX);

    //    q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

    //    return q;
    //}
}
