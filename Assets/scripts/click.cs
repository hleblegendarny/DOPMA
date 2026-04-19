using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
   Camera cam;
   [SerializeField] float maxDistanceRay=100f;
   [SerializeField] LayerMask layerBook;
    void Start()
    {
        cam=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray=cam.ScreenPointToRay(Input.mousePosition);  
        Debug.DrawRay(ray.origin,ray.direction*maxDistanceRay,Color.green);

        

        if(Physics.Raycast(ray, out hit,maxDistanceRay,layerBook)&&Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("books");
        }

    }
}
