using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineManager : MonoBehaviour
{
    public List<GameObject> outlinedChildren;
    public bool isLookedAt = false;

    void Start()
    {
        LookAway();
    }

    private void FixedUpdate() {
        if (isLookedAt)
            LookAt();

        if (!isLookedAt)
            LookAway();

        isLookedAt = false;
    }

    public void LookAt() {
        foreach (GameObject child in outlinedChildren) {
            child.GetComponent<cakeslice.Outline>().enabled = true;
        }
    }

    public void LookAway() {
        foreach (GameObject child in outlinedChildren) {
            child.GetComponent<cakeslice.Outline>().enabled = false;
        }
    }
}
