using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotPosition : MonoBehaviour
{
	public RectTransform pivot;


    // Update is called once per frame
    void Update()
    {
		pivot.localPosition = Vector3.zero;

	}
}
