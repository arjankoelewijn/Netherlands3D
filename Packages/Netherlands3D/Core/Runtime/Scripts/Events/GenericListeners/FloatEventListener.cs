using Netherlands3D.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatEventListener : MonoBehaviour
{
    [SerializeField]
    private FloatEvent onEvent;

    [SerializeField]
    private FloatValueUnityEvent trigger;

    void Awake()
    {
        if (onEvent)
        {
            onEvent.started.AddListener(Invoke);
        }
    }

	public void Invoke(float arg0)
	{
        trigger.Invoke(arg0);
    }
}
