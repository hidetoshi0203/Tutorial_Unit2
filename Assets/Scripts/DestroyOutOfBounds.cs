using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;//ゲーム画面上端
    private float lowerBound = -10.0f;//ゲーム画面下端
    public UIManager UIManager;

    private void Start()
    {
        UIManager = GameObject.Find("UIManager").
            GetComponent<UIManager>();
    }
    void Update()
    {
        //食べ物のz座標が一定値を超えたら
        if (transform.position.z > topBound)
        {
            //食べ物を消す メモ：gameObjectという
            //小文字から始まるgameObjectは変数で、
            //自分自身の事を指す
            Destroy(gameObject);
        }
        //動物のz座標が一定値を下回ったら
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            UIManager.ShowGameOver();
        }

    }
}
