using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace User
{
  public class CastLaser : MonoBehaviour
  {
    private LineRenderer lr;
    public Vector3Variable laserPosition;
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
          laserPosition.SetValue(hit.point);
        }
      }
      else {
        lr.SetPosition(1, transform.InverseTransformPoint(transform.forward*100));
        laserPosition.SetValue(transform.forward*100);
      }
    }
  }
}
