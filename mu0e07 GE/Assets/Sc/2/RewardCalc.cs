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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
