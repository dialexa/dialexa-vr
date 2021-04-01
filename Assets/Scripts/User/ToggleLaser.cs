using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace User
{
  public class ToggleLaser : MonoBehaviour
  {
      // Start is called before the first frame update
      void Start()
      {
          this.GetComponent<Renderer>().enabled = false;
      }

      // Update is called once per frame
      void Update()
      {
          if(Input.GetKeyDown("f")) {
            this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
          }
      }
  }
}
