
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public int combo;

    private void Start()
    { 
     if (combo <=49)
        {
            print("攻擊*1");
        }
     else if (combo <= 99)
        {
            print("攻擊*2");
        }
     else if (combo <= 149)
        {
            print("攻擊*5");
        }
     else if (combo >= 150)
        {
            print("攻擊*10");
        }

    }
    private void Update()
    {
        if (combo <= 49)
        {
            print("攻擊*1");
        }
        else if (combo <= 99)
        {
            print("攻擊*2");
        }
        else if (combo <= 149)
        {
            print("攻擊*5");
        }
        else if (combo >= 150)
        {
            print("攻擊*10");
        }
    }
}
