using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target; // 카메라가 따라갈 대상.
    public float moveSpeed; // 카메라 이동 속도
    private Vector3 targetPosition; // 대상의 현재 위치 값.

    void Start()
    {
        
    }

    void Update()
    {
        if(target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
