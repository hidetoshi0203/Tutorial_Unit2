using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;//左右キーの値
    public float speed = 10.0f;//速さ
    public float xRange = 10.0f;//ｘ座標の範囲
    public GameObject projectilePrefab;//食べ物のプレハブ
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //transform.position = 座標（３次元ベクトル）
        //new 作る
        //Vector3(*,*,*)＝３次元ベクトル
        //単なる数字＝マジックナンバー
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }

        //スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //食べ物を生成
            Instantiate(projectilePrefab,
                transform.position,
                projectilePrefab.transform.rotation);
        }
    }
}
