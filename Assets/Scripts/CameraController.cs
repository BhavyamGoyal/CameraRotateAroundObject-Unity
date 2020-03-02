using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CameraController : MonoBehaviour
{
    public float rotSpeed = 5;
    public GameObject temp;
    Vector3 distanceX, prev=Vector3.zero, prevPos, distance, oldRotation;
    public Transform obj;
    private void Start()
    {
        Debug.Log(Quaternion.Euler(100, 10, 0).eulerAngles);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            prevPos = Input.mousePosition;
            oldRotation = transform.rotation.eulerAngles;
            Debug.Log( "old  " + oldRotation);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("new "+transform.rotation.eulerAngles);
            // prevPos = Input.mousePosition;
            //oldRotation = transform.rotation.eulerAngles;
        }

        if (Input.GetMouseButton(0))
        {
            distance = Input.mousePosition - prevPos;
            Vector3 addRot = new Vector3(360 * (distance.x / Screen.width), 360 * (distance.y / Screen.height),0);
            // rotSpeed * Mathf.PI * (distance.y / Screen.height);
            Vector3 result;
            result = new Vector3(oldRotation.x - addRot.y, oldRotation.y, oldRotation.z);
            //if (prev.y-Input.mousePosition.y != 0)
            //{
            //    Debug.Log("adding " + addRot.y+" result  "+result+"  QQQQ  "+ Quaternion.Euler(result.x, result.y, oldRotation.z).eulerAngles);
            //}
            //Debug.Log(result);
            prev = Input.mousePosition;
            transform.
            transform.eulerAngles =result;
        }
    }

    public void RemoveFloor()
    {
        temp.SetActive(!temp.activeInHierarchy);
    }
}