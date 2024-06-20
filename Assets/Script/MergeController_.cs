using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeController : MonoBehaviour
{
    public GameObject[] items;  // 병합 가능한 아이템들

    void Start()
    {
        // 아이템들을 랜덤 위치에 배치
        foreach (var item in items)
        {
            item.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        }
    }

    void Update()
    {
        // 아이템을 랜덤하게 움직이도록 설정
        foreach (var item in items)
        {
            item.transform.Translate(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0) * Time.deltaTime);
        }
    }
}