using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerScript : MonoBehaviour {
    public Text text;

    void Start()
        {
        text.text = "";
        }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WalkPass")
        {
            //Debug.log("ok");
            text.text = "Warning, there's a crosswalk !";
        }
    }
}
