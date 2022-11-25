using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoHorizontal : MonoBehaviour
{
    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.red;
        Vector3 HorizontalLine = new Vector3(transform.position.x + 10000, transform.position.y, transform.position.z);
        Gizmos.DrawLine(transform.position, HorizontalLine);
    }
}
