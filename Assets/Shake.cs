using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Shake : MonoBehaviour
{
    private Transform cam;
    private float shakeDuration = 10f;
    private float shakeAmount = 0.7f;
    private float decreaseFactor = 1.0f;

    Vector3 oPos;

    void Start()
    {
        cam=GameObject.Find("MainCamera").GetComponent<Transform>();
        oPos = cam.localPosition;
    }

    [YarnCommand("cam_Shake")]
    public void camShake()
    {
        if (shakeDuration > 0)
		{
			cam.localPosition = oPos + Random.insideUnitSphere * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shakeDuration = 0f;
			cam.localPosition = oPos;
		}
    }
}
