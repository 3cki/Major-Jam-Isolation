using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    void Update()
    {
        Cast();
    }

    private void Cast() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (hit.transform.gameObject.tag == "Interactable") {
                hit.transform.gameObject.GetComponent<OutlineManager>().isLookedAt = true;

                if (Input.GetMouseButtonDown(0)) {

                }
            }
        }
    }
}
