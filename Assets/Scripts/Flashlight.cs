using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlightLight;   // Referință la obiectul Light (lanterna)
    public KeyCode toggleKey = KeyCode.F;  // Tasta care va activa/dezactiva lanterna

    void Start()
    {
        // Asigură-te că lanterna este oprită la început
        flashlightLight.enabled = false;
    }

    void Update()
    {
        // Când se apasă tasta F, schimbăm starea lanternei
        if (Input.GetKeyDown(toggleKey))
        {
            flashlightLight.enabled = !flashlightLight.enabled;  // Toggle (pornit/oprit) lanterna
        }
    }
}
