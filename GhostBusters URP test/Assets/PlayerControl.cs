using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] GameObject torch_light;

    bool state = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Torch"))
        {
            if(state == true)
            {
                torch_light.SetActive(false);
                state = false;
            }
            else
            {
                torch_light.SetActive(true);
                state = true;
            }
        }
    }
}
