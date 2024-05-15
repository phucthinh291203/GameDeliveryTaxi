using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject ThingToFollow;
    Vector3 CameraPosition = new Vector3(0, 0, -10);
    void LateUpdate()
    {
        transform.position = ThingToFollow.transform.position + CameraPosition;
    }
}
