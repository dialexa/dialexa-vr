using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace User
{
  public class CastLaser : MonoBehaviour
  {
    private LineRenderer lr;
    void Start () {
      lr= GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update () {
      lr.SetPosition(0, transform.localPosition);
      RaycastHit hit;
      if (Physics.Raycast(transform.position, transform.forward, out hit))
      {
        if (hit.collider)
        {
          lr.SetPosition(1, transform.InverseTransformPoint(hit.point));
        }
      }
      else lr.SetPosition(1, transform.InverseTransformPoint(transform.forward*100));
    }
  }
}
