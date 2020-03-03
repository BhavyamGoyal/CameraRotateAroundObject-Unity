using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    public GameObject temp, cameraObj;
    Vector3 prev = Vector3.zero, prevPos, distance, oldRotation;
    public Transform obj;
    public float dist;
    Vector3 result;
    private void Start()
    {
        oldRotation = transform.eulerAngles;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            prevPos = Input.mousePosition;
        }
        else
        if (Input.GetMouseButtonUp(0))
        {
            oldRotation = result;
        }

        if (Input.GetMouseButton(0))
        {
            distance = Input.mousePosition - prevPos;
            Vector3 addRot = new Vector3(360 * (distance.x / Screen.width), 360 * (distance.y / Screen.height), 0);
            result = new Vector3((oldRotation.x - addRot.y), oldRotation.y + addRot.x, oldRotation.z);
            //Debug.Log(transform.rotation+"    "+ Quaternion.Euler(result));
            transform.rotation = Quaternion.Euler(result);
        }
    }
    public void RemoveFloor()
    {
        temp.SetActive(!temp.activeInHierarchy);
    }
}