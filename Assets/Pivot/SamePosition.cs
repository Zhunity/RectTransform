using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamePosition : MonoBehaviour
{
	public RectTransform otherUI;
	public Transform otherCube;
	public RectTransform self;

    // Update is called once per frame
    void Update()
    {
		otherUI.position = self.position;
		otherCube.position = self.position;
	}
}
