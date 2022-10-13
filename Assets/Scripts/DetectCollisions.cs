using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public UIManager UIManager;

    private void Start()
    {
        UIManager = GameObject.Find("UIManager").
            GetComponent<UIManager>();
    }

    //すり抜けが起きた瞬間にのみ呼ばれる
    private void OnTriggerEnter(Collider other)
    {//メモ：other = （スクリプトが付いている物体にとっての）すり抜けた相手

        //ぶつかった相手を消去
        Destroy(other.gameObject);
        //このスクリプトを付けている自分自身を消去
        Destroy(gameObject);

        //バナナにとって、敵とぶつかることができたら
        if (other.gameObject.CompareTag("enemy"))
        {
            //UIマネージャを呼び出して、スコア加算
            UIManager.ChangeScore(100);
        }

        if (other.gameObject.CompareTag("enemy2"))
        {
            //UIマネージャを呼び出して、スコア加算
            UIManager.ChangeScore(1000);
        }

        if (other.gameObject.CompareTag("enemy3"))
        {
            //UIマネージャを呼び出して、スコア加算
            UIManager.ChangeScore(2000);
        }
    }
}
