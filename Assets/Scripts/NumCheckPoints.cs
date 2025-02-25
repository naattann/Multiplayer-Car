using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class NumCheckPoints : MonoBehaviour
{
    public Transform[] checkPoints;
    void Start()
    {
        checkPoints = GetComponentsInChildren<Transform>();
        for (int i = 1; i < checkPoints.Length; i++)
        {
            checkPoints[i].gameObject.name = (i - 1).ToString();
        }
    }
}
