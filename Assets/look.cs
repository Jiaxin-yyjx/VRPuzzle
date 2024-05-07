using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class look : MonoBehaviour
{
    public Transform[] all;

    private Transform closestItem;
    private float closestDistance;
    public Text textui;
    // Update is called once per frame
    void Update()
    {
        FindClosestItem();

        if (closestItem != null)
        {
            transform.LookAt(closestItem);
            float distance = Vector3.Distance(transform.position, closestItem.position);
            textui.text = "Distance:"+distance.ToString("0.00");

        }
    }

    void FindClosestItem()
    {
        closestItem = null;
        closestDistance = Mathf.Infinity;

        foreach (Transform item in all)
        {
            if (item != null)
            {
                float distance = Vector3.Distance(transform.position, item.position);
                if (distance < closestDistance)
                {
                    closestItem = item;
                    closestDistance = distance;
                }
            }
        }
    }
}