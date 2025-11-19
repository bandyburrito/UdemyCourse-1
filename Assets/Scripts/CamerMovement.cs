using UnityEngine;
using Unity.Cinemachine;

public class CameraMovement : MonoBehaviour
{
    
    public CinemachineFreeLook freeLookCamera;
    
    [Header("Mouse Settings")]
    public float mouseSensitivityX = 2f;
    public float mouseSensitivityY = 2f;
    
    void Update()
    {
        // Only rotate when right mouse button is held
        if (Input.GetMouseButton(1))
        {
            // Get mouse movement
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;
            
            // Apply to FreeLook camera axes
            freeLookCamera.m_XAxis.Value += mouseX;
            freeLookCamera.m_YAxis.Value += mouseY;
        }
    }
}
