using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text gameOverText;//ゲームオーバー用テキスト
    public Text scoreText;//スコア用テキスト
    private int _score = 0;//スコア

    private void Start()
    {
        //ゲーム開始時のスコア更新
        scoreText.text = "Score:" + _score;
        gameOverText.text = "";
    }

    public void ChangeScore(int score)//追加スコアを受け取る
    {
        _score = _score + score;//受け取ったスコアを元のスコアに足す
        scoreText.text = "Score:" + _score.ToString();
        //score.ToString()で、面倒だがscoreというint型を
        //わざわざString型という文字列の型に直している
        //それをScore:という文字列と結合している
    }
    public void ShowGameOver()
    {
        //GameOverのUIを表示させる
        gameOverText.text = "GameOver";
    }
}
