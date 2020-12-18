using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwitcher : MonoBehaviour
{
    [SerializeField] GameObject ogCam;
    [SerializeField] GameObject freeCam;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            ogCam.SetActive(false);
            freeCam.SetActive(true);
        }
        else
        {
            freeCam.SetActive(false);
            ogCam.SetActive(true);
        }
    }
}
