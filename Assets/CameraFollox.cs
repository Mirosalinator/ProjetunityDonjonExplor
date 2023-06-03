
using UnityEngine;

public class CameraFollox : MonoBehaviour
{
    public GameObject perssonage;
    public float timeOffset;
    public Vector3 postOffset;

    private Vector3 velocity;


    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, perssonage.transform.position + postOffset, ref velocity, timeOffset);
    }
}
