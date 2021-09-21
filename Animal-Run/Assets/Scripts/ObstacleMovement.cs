using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public bool isRotate, isMovement;
    private Vector3 startPos;
    public Vector3 endingPos;
    public Vector3 rotateAdd;
    
    public float speed = 1f;
    public float rotateSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.localPosition;

        if (isMovement)
        {
            ToEndPos();
        }

        if (isRotate)
        {
            RotateObj();
        }
    }

    private void RotateObj()
    {
        transform.DOLocalRotate(rotateAdd, rotateSpeed, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).OnComplete(RotateObj);
    }

    private void ToEndPos()
    {
        transform.DOLocalMove(endingPos, speed).SetEase(Ease.Linear).OnComplete(ToStart);
    }
    
    private void ToStart()
    {
        transform.DOLocalMove(startPos, speed).SetEase(Ease.Linear).OnComplete(ToEndPos);
    }
}
