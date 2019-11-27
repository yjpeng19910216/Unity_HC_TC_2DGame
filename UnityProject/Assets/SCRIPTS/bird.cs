using UnityEngine;

public class bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 20000)]
    public int jumpHeight=100;
    [Header("是否死亡"), Tooltip("判斷腳色是否死亡")]
    public bool isDead;

}
