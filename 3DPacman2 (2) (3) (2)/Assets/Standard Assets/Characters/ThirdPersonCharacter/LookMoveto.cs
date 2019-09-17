using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LookMoveto : MonoBehaviour
{
    public GameObject ground;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100.0f);
        ray = new Ray(camera.position, camera.rotation * Vector3.forward * 100.0f);
        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground)
            {
                Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                transform.position = hit.point;
            }
        }
    }
}