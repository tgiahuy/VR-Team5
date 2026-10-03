using UnityEngine;

public class FloatingInfoPanel : MonoBehaviour
{
    [Header("Mục tiêu hướng mặt (Camera người chơi)")]
    [SerializeField] private Transform vrCamera;

    [Header("Khóa trục xoay")]
    [SerializeField] private bool lockVerticalRotation = true;

    void Start()
    {
        if (vrCamera == null && Camera.main != null)
        {
            vrCamera = Camera.main.transform;
        }

        // Ẩn Canvas khi bắt đầu
        gameObject.SetActive(false);
    }

    // Bật hoặc tắt Canvas
    public void TogglePanel()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    // Chỉ mở Canvas
    public void OpenPanel()
    {
        gameObject.SetActive(true);
    }

    // Chỉ đóng Canvas
    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}