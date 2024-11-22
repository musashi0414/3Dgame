using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    

    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 30;
    private float shotInterval;

    private float timeBetweenShot = 0.05f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーの時間を動かす
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0) && timer > timeBetweenShot)
        {
            // タイマーの時間を０に戻す。
            timer = 0.0f;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * shotSpeed);

            //射撃されてから3秒後に銃弾のオブジェクトを破壊する.
            Destroy(bullet, 3.0f);

        }
       
    }


}
