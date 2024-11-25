using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSiren : MonoBehaviour
{
    public GameObject PoliceSirenScreenDisplay;

    public void SetPoliceSirenStatus(bool status)
    {
        PoliceSirenScreenDisplay.SetActive(status);
    }
}
