using UnityEngine;

public class FloatingInfoPanel : MonoBehaviour
{
    [Header("Mục tiêu hướng mặt (Camera người chơi)")]
    [SerializeField] private Transform vrCamera;

    [Header("Khóa trục xoay")]
    [SerializeField] private bool lockVerticalRotation = true;

    private void Awake()
    {
        if (vrCamera == null && Camera.main != null)
        {
            vrCamera = Camera.main.transform;
        }
    }

    private void LateUpdate()
    {
        if (vrCamera == null)
            return;

        Vector3 direction =
            vrCamera.position - transform.position;

        // Chỉ xoay theo trục Y
        if (lockVerticalRotation)
        {
            direction.y = 0f;
        }

        if (direction.sqrMagnitude > 0.001f)
        {
            transform.rotation =
                Quaternion.LookRotation(-direction);
        }
    }

    public void TogglePanel()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void OpenPanel()
    {
        gameObject.SetActive(true);
    }

    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}