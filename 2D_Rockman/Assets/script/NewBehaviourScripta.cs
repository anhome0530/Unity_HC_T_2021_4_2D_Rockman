using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScripta : MonoBehaviour
{
    #region 事件
    public int number = 1;
    public bool test = false;
    public string prop = "紅色藥水";



    // 有預設值的參數為[



    // 事件:在特定時間點會被執行的方法
    // Unity 提供的事件:開始、更新

    // 開始事件執行時間點與次數:播放遊戲後執行一次
    // 

    // 更新事件時間點與次數 : 開始事件後以每秒約六十次執行
    private void Update()
    {

    }
    #endregion

    #region 方法 Unity Method,Function
    // 方法 : 保存較複雜或演算法的程式區塊
    // 語法 : 
    // 修飾詞 傳回類型 名稱(參數1 參數2... 參數n) { 較複雜或演算法的程式區塊}
    // void 無傳回 : 使用這個方法不會有傳回
    // 方法需要被(呼叫)才會執行
    ///<summary>
    ///我是一個測試方法
    ///</summary>
    ///
    private void Test()
    {

    }


    // 如果不是無傳回 void
    // 在大括號內必須使用 傳回 return 值 (必須跟傳回類型相同)
    /// <summary>
    /// 傳回整數十的方法
    /// </summary>
    /// <returns>整數十</returns>
    private int Ten()
    {
        return 10;
    }

    // 舉例 :
    // 三個方法 1.以時速 50 開車 2. 時速 100 開車 3. 時速 300 開車
    // 加新功能要有音效
    // 加特效
    private void Drive50()
    {
        print("開車時速:" + 50);
        print("開車音效");
    }
    private void Drive100()
    {
        print("開車時速:" + 100);
        print("開車音效");
    }
    private void Drive300()
    {
        print("開車時速:" + 300);
        print("開車音效");
    }

    // 用參數解決 Paramater
    // 參數語法:類型 參數名稱
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">開車的時速</param>    
    /// <param name="sound">開車的音效</param>
    /// <param name="effect">特效</param>
    // 有預設值的參數只能寫在最右邊
    private void Drive(int speed, string sound, string effect = "灰塵效果")
    {
        print("開車時速:" + speed);
        print("開車音效:" + sound);
        print("開車音效:" + sound);
        print("特效:" + effect);
    }

    /// <summary>
    /// BMI 值計算方法
    /// </summary>
    /// <param name="hight">請輸入身高 (單位為公尺)</param>
    /// <param name="weight">請輸入體重 (單位為公斤)</param>
    /// <returns></returns>
    private float BMI(float height, float weight)
    {
        return weight / (height * height);
    }



    #endregion
}