using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lean : MonoBehaviour
{
    enum Type
    {
        Rotate,
        Move,
        Scale
    }

    [Header("Move Settings")]
    [SerializeField]
    private Type type;
    [SerializeField]
    private LeanTweenType ease;
    [SerializeField]
    private float time;
    [SerializeField]
    private float delay;
    [SerializeField]
    private Vector3 to;

    [Header("Loop Settings")]
    [SerializeField]
    private bool loop;
    [SerializeField]
    private bool pingPong;
    [SerializeField]
    private int loopNumber;

    LTDescr _tweenObject;

    private void Start()
    {
        _tweenObject.setEase(ease);
        _tweenObject.setDelay(delay);

        if (loop)
        {
            _tweenObject.setLoopCount(loopNumber == 0 ? int.MaxValue : loopNumber);
        }

        if (pingPong)
        {
            _tweenObject.setLoopPingPong();
        }

        switch (type)
        {
            case Type.Move:
                LeanTween.moveLocal(gameObject, to, time);
                break;

            case Type.Rotate:
                LeanTween.rotateLocal(gameObject, to, time);
                break;

            case Type.Scale:
                LeanTween.scale(gameObject, to, time);
                break;
        }
    }
}
