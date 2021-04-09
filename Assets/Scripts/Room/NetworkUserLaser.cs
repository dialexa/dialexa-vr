using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Room
{
  public class NetworkUserLaser : MonoBehaviour
  {
    private LineRenderer lr;
    public Vector3 laserPosition;
    void Start () {
      lr= GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update () {
      lr.SetPosition(0, transform.localPosition);
      lr.SetPosition(1, laserPosition);
    }
  }
}