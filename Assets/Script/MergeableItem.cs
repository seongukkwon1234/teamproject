using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeableItem : MonoBehaviour
{
    public string itemName;         // ������ �̸�
    public Sprite mergedSprite;     // ���� ���� ��������Ʈ
    public float mergeDistance = 1.0f; // ������ �Ͼ�� �Ÿ�

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        CheckForMerge();
    }

    void CheckForMerge()
    {
        // ���� ���� ��� MergeableItem�� ã���ϴ�.
        MergeableItem[] items = FindObjectsOfType<MergeableItem>();

        foreach (MergeableItem item in items)
        {
            if (item != this && itemName == item.itemName)
            {
                float distance = Vector3.Distance(transform.position, item.transform.position);
                if (distance <= mergeDistance)
                {
                    Merge(item);
                }
            }
        }
    }

    public void Merge(MergeableItem other)
    {
        if (other.itemName == itemName)
        {
            // �������� ���� �� ����
            spriteRenderer.sprite = mergedSprite;
            other.gameObject.SetActive(false);
            Debug.Log(itemName + " merged!");
        }
    }
}

