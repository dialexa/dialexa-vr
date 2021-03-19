using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace User
{
  public class ToggleLaser : MonoBehaviour
  {
      // Start is called before the first frame update
      public StringVariable enabled;
      void Start()
      {
          this.GetComponent<Renderer>().enabled = false;
          enabled.SetValue("false");
      }

      // Update is called once per frame
      void Update()
      {
          if(Input.GetKeyDown("f")) {
            this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
            if (this.GetComponent<Renderer>().enabled) {
              enabled.SetValue("true");
            } else {
              enabled.SetValue("false");
            }
          }
      }
  }
}
