using UnityEngine;
using static UnityEditor.PlayerSettings;
using System.Collections.Generic;



public class Lesson11 : MonoBehaviour
{
    [ContextMenu("배열")]
    void ArrayLoop()
    {
        int[] scores = { 90, 75, 60, 88 };
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        Debug.Log("합 " + sum);
        Debug.Log("평균 " + (float)sum / scores.Length);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int[] hp = { 10, 20, 30 };
        hp[1] = hp[0] + hp[2];
        Debug.Log(hp[1]);
        Debug.Log(hp.Length);
        int[] copy = hp;
        copy[0] = 99;
        Debug.Log(hp[0]);
        int a = hp[2];
        a = 0;
        Debug.Log(hp[2]);
    }

    [ContextMenu("배열 비교")]
    void ArrayEquals()
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 1, 2, 3 };
        int[] c = a;
        Debug.Log(a == b);
        Debug.Log(a == c);
        Debug.Log(a[0] == b[0]);
    }

    public int[] golds = { 300, 1200, 50, 800 };

    [ContextMenu("배열 실습")]
    void ShowGolds()
    {
        int total = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번: " + golds[i]);
            total += golds[i];
        }
        Debug.Log("합계 " + total);
    }

    [ContextMenu("List")]
    void ListBasic()
    {
        List<string> items = new List<string>();
        items.Add("포션");
        items.Add("화살");
        items.Remove("포션");
        Debug.Log(items.Count + " " + items[0]);
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        List<int> nums = new List<int>();
        nums.Add(5);
        nums.Add(3);
        nums.Add(5);
        nums.Remove(5);
        Debug.Log(nums.Count);
        Debug.Log(nums[0]);
        nums.RemoveAt(0);
        Debug.Log(nums[0]);
        Debug.Log(nums.Contains(3));
    }

    [ContextMenu("추가 비교")]
    void AddCompare()
    {
        int[] arr = { 10, 20 };
        int[] bigger = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            bigger[i] = arr[i];
        }
        bigger[arr.Length] = 30;
        arr = bigger;

        List<int> list = new List<int> { 10, 20 };
        list.Add(30);
        Debug.Log(arr.Length + " " + list.Count);
    }

    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> inventory = new List<string>();
        inventory.Add("포션");
        inventory.Add("화살");
        inventory.Add("포션");
        inventory.Add("열쇠");
        inventory.Remove("포션");
        Debug.Log("아이템 " + inventory.Count + " 개");
        Debug.Log("열쇠 있음: " + inventory.Contains("열쇠"));
        for (int i = 0; i < inventory.Count; i++)
        {
            Debug.Log(i + "번: " + inventory[i]);
        }
    }

    [ContextMenu("List 순회")]
    void ListLoop()
    {
        List<string> items = new List<string>();
        items.Add("포션");
        items.Add("화살");
        items.Add("열쇠");
        foreach (string item in items)
        {
            Debug.Log(item);
        }
        Debug.Log(items.Count + " 개");
    }

    [ContextMenu("반복 비교")]
    void LoopCompare()
    {
        int[] golds = { 300, 500, 700 };
        int totalA = 0;
        for (int i = 0; i < golds.Length; i++)
        {
            totalA += golds[i];
        }
        int totalB = 0;
        foreach (int gold in golds)
        {
            totalB += gold;
        }
        Debug.Log(totalA + " " + totalB);
    }

    [ContextMenu("foreach")]
    void ForEach()
    {
        string[] names = { "슬라임", "고블린", "보스" };
        foreach (string name in names)
        {
            Debug.Log(name);
        }
    }

    [ContextMenu("제약")]
    void ForeachLimit()
    {
        int[] hps = { 30, 0, 50 };
        int number = 1;
        foreach (int hp in hps)
        {
            Debug.Log(number + "번: " + hp);
            number++;
        }
        for (int i = 0; i < hps.Length; i++)
        {
            hps[i] = 100;
        }
        Debug.Log(hps[1]);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int[] hps = { 20, 0, 35, 0, 50 };
        int count = 0;
        int sum = 0;
        foreach (int hp in hps)
        {
            if (hp == 0) continue;
            count++;
            if (count == 3) break;
            sum += hp;
        }
        Debug.Log(count + " " + sum);
    }

    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int aliveCount = 0;
        int hpSum = 0;
        foreach (int hp in monsterHps) ;
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
