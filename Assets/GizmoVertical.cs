using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoVertical : MonoBehaviour
{
    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.red;
        Vector3 VerticalLine = new Vector3(transform.position.x, transform.position.y + 5000, transform.position.z);
        Gizmos.DrawLine(transform.position, VerticalLine);
    }
}
