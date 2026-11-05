using UnityEngine;

public class HpPractice : MonoBehaviour
{
    int currentHp;
    int maxHp;
    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);
        Debug.Log("Hp" + a + "%");

        int b = currentHp * 100 / maxHp;
        Debug.Log("HP" + b + "%");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
