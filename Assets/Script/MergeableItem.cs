using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeableItem : MonoBehaviour
{
    public string itemName;         // 아이템 이름
    public Sprite mergedSprite;     // 병합 후의 스프라이트
    public float mergeDistance = 1.0f; // 병합이 일어나는 거리

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
        // 현재 씬의 모든 MergeableItem을 찾습니다.
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
            // 아이템이 같을 때 병합
            spriteRenderer.sprite = mergedSprite;
            other.gameObject.SetActive(false);
            Debug.Log(itemName + " merged!");
        }
    }
}

