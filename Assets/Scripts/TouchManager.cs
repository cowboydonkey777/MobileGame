using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider != null){
                        Color color = new Color(Random.value, Random.value, Random.value);
                        hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
                    }
                }
            }
        }
    }
}
