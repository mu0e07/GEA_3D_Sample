using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int playHour = playSeconds / 3600;
        int playMin = (playSeconds - 3600) / 60;
        int playSec = playSeconds % 60;
        Debug.Log("PlayTime: " + playHour + ":" + playMin + ":"+ playSec);

        coin();
    }

    void coin()
    {
        int member1 = gold / members;
        int leader = gold % members;
        Debug.Log("1인당: " + member1 + "G, " + ("리더 보너스: " + leader + "G"));

        Exp();
    }

    void Exp()
    {
        int basicExp = kills * expPerKill;
        int finalExp = (int)(basicExp * expRate);
        int level = finalExp / 100 + 1;
        int remainExp = finalExp % 100;
        int nextExp = 100 - remainExp;


        Debug.Log("경험치 " + finalExp + " (기본 " + basicExp + ")");
        Debug.Log("Lv " + level + ", 다음 레벨까지 " + nextExp);

        Damage();

    }
    void Damage()
    {
        float averageDamage = (float)totalDamage / hits;

        Debug.Log("평균 데미지 " + averageDamage);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
