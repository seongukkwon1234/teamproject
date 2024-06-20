using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeController : MonoBehaviour
{
    public GameObject[] items;  // ���� ������ �����۵�

    void Start()
    {
        // �����۵��� ���� ��ġ�� ��ġ
        foreach (var item in items)
        {
            item.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
        }
    }

    void Update()
    {
        // �������� �����ϰ� �����̵��� ����
        foreach (var item in items)
        {
            item.transform.Translate(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0) * Time.deltaTime);
        }
    }
}