using UnityEngine;
using System.Collections;

public class GrappleInfo : MonoBehaviour
{
    // add this script to geometry and edit the nodes using the specialeditor. The orientation of the nodes is counter clockwise (left to right) this is used to calculate the perependicular of the line
    // remember to attach or create a Collider near the path otherwise it will not work

    // The list of nodes, if there is one single node is a point, otherwiese a line
    public Vector3[] nodes = new Vector3[0];

    // The last node and the first node are linked and the polyline is a loop?
    public bool ClosePolyline;

    // The weight of the point to priorize instead of others nearby
    public float Weight = 1f;
}
