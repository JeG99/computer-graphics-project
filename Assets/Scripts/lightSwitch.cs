using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
   [SerializeField] Light light;
    public GameObject target;
    public bool isOn = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O)) {
          light.enabled = false;
        }
        if (Input.GetKey(KeyCode.I)) {
          light.enabled = true;
        }
    }
}
