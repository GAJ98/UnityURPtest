using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 1;
    [SerializeField] Transform Player;
    [SerializeField] Transform Target;

    private float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX = mouseX + Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY = mouseY - Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            Player.rotation = Quaternion.Euler(0, mouseX, 0);
        }
    }
}


