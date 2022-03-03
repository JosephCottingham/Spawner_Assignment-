using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacementManager : MonoBehaviour
{

    public Transform placeableObj;
    public Transform placeableObjParent;
    public Camera cam;
    public LayerMask mask;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>();   
    }

    // Update is called once per frame
    void Update()
    {
        // Handle Moving placeableObj 
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        Vector3 pos;
        Quaternion rot;

        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            pos = hitInfo.point + new Vector3(0, .5f, 0);
            rot = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);

            if (placeableObj)
            {
                placeableObj.position = pos;
                placeableObj.rotation = rot;
            }
            

            // Handle Placing Object
            if (Input.GetButtonDown("Fire1"))
            {
                placeableObj = null;
            }

            // Handle Placing Object
            if (Input.GetButtonDown("Fire2") && placeableObj == null)
            {
                placeableObj = Instantiate(placeableObjParent, hitInfo.point + new Vector3(0, .5f, 0), Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
        }
    }
}
