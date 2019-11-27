
using UnityEngine;  //引用unity API

//類別 類別名稱 文件名稱
public class FIRST : MonoBehaviour
{
    //{為程式內容}
    //宣告變數-定義欄位 Field
    //顯示與否(修飾詞) 欄位內容 欄位名稱(指定  值) 結束
    //私人 - 隱藏  private (預設)
    //公開 - 顯示 public
    [Header("金幣"), Range(0,999999)]
    public int coin=10;                //整數
    [Header("速度"),Range(0.5F,55F)]
    public float speed=2.5f;            //浮點數
    [Tooltip("喝了會補血的藥水")]
    public string prop="紅水";         //字串
    public bool dead=true;             //布林值

    //事件:在特定時間點執行指定次數
    //這是"開始"遊戲開始時會執行
    private void Start()
    {
        //輸出("訊息")
        print("嗨~~");
    }
    
    //做一些持續動作
    private void Update()
    {
        print("嗨~嗨~");
    }






}
