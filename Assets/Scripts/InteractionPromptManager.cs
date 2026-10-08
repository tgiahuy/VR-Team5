using TMPro;
using UnityEngine;

public class InteractionPromptManager : MonoBehaviour
{
    public static InteractionPromptManager Instance { get; private set; }

    [Header("UI")]
    [SerializeField] private Canvas promptCanvas;
    [SerializeField] private TMP_Text promptText;

    [Header("Camera người chơi")]
    [SerializeField] private Transform playerCamera;

    [Header("Hiển thị")]
    [SerializeField] private bool lockVerticalRotation = true;

    [Tooltip("Đẩy prompt về phía camera để tránh bị tủ / vật thể che")]
    [SerializeField] private float cameraOffset = 0.15f;

    [Tooltip("Đẩy prompt lên trên một chút")]
    [SerializeField] private float verticalOffset = 0.05f;

    // PromptPoint hiện tại đang sử dụng Canvas
    private Transform currentPromptPoint;

    private void Awake()
    {
        // =========================
        // SINGLETON
        // =========================
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // =========================
        // TỰ TÌM CAMERA
        // =========================
        if (playerCamera == null && Camera.main != null)
        {
            playerCamera = Camera.main.transform;
        }

        // =========================
        // ẨN PROMPT LÚC BẮT ĐẦU
        // =========================
        if (promptCanvas != null)
        {
            promptCanvas.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogWarning(
                "InteractionPromptManager: Prompt Canvas chưa được gán!"
            );
        }

        if (promptText == null)
        {
            Debug.LogWarning(
                "InteractionPromptManager: Prompt Text chưa được gán!"
            );
        }
    }

    private void LateUpdate()
    {
        if (promptCanvas == null ||
            currentPromptPoint == null)
        {
            return;
        }

        // =========================
        // NẾU CHƯA CÓ CAMERA
        // THÌ THỬ TÌM LẠI
        // =========================
        if (playerCamera == null)
        {
            if (Camera.main != null)
            {
                playerCamera = Camera.main.transform;
            }
            else
            {
                return;
            }
        }

        // =========================
        // HƯỚNG TỪ PROMPTPOINT
        // ĐẾN CAMERA
        // =========================
        Vector3 toCamera =
            playerCamera.position -
            currentPromptPoint.position;

        Vector3 directionToCamera =
            toCamera.normalized;

        // =========================
        // ĐẶT VỊ TRÍ PROMPT
        // =========================
        promptCanvas.transform.position =
            currentPromptPoint.position +
            directionToCamera * cameraOffset +
            Vector3.up * verticalOffset;

        // =========================
        // QUAY PROMPT VỀ CAMERA
        // =========================
        Vector3 lookDirection =
            playerCamera.position -
            promptCanvas.transform.position;

        if (lockVerticalRotation)
        {
            lookDirection.y = 0f;
        }

        if (lookDirection.sqrMagnitude > 0.001f)
        {
            promptCanvas.transform.rotation =
                Quaternion.LookRotation(
                    -lookDirection
                );
        }
    }

    // =================================================
    // DÙNG CHO TRANG PHỤC
    // =================================================
    public void ShowPrompt(
        Transform promptPoint,
        string exhibitName)
    {
        if (!ValidatePromptPoint(
                promptPoint,
                exhibitName))
        {
            return;
        }

        currentPromptPoint =
            promptPoint;

        if (promptText != null)
        {
            promptText.text =
                "[F] Xem chi tiết\n" +
                "[I] Xem thông tin";
        }

        ShowCanvas();

        Debug.Log(
            "Hiện prompt trang phục: " +
            exhibitName
        );
    }

    // =================================================
    // DÙNG CHO CÁC BỤC THÔNG TIN
    // =================================================
    public void ShowInfoOnlyPrompt(
        Transform promptPoint,
        string exhibitName)
    {
        if (!ValidatePromptPoint(
                promptPoint,
                exhibitName))
        {
            return;
        }

        currentPromptPoint =
            promptPoint;

        if (promptText != null)
        {
            promptText.text =
                "[I] Xem thông tin";
        }

        ShowCanvas();

        Debug.Log(
            "Hiện prompt thông tin: " +
            exhibitName
        );
    }

    // =================================================
    // ẨN PROMPT
    // =================================================
    public void HidePrompt(
        Transform promptPoint)
    {
        // Zone khác không được phép tắt prompt
        // đang thuộc về zone hiện tại
        if (currentPromptPoint != promptPoint)
        {
            return;
        }

        currentPromptPoint = null;

        if (promptCanvas != null)
        {
            promptCanvas.gameObject.SetActive(false);
        }
    }

    // =================================================
    // ẨN PROMPT BẤT KỂ PROMPTPOINT NÀO
    // Có thể dùng sau này khi mở menu/viewer
    // =================================================
    public void HidePromptImmediately()
    {
        currentPromptPoint = null;

        if (promptCanvas != null)
        {
            promptCanvas.gameObject.SetActive(false);
        }
    }

    // =================================================
    // HIỆN CANVAS
    // =================================================
    private void ShowCanvas()
    {
        if (promptCanvas != null)
        {
            promptCanvas.gameObject.SetActive(true);
        }
    }

    // =================================================
    // KIỂM TRA PROMPTPOINT
    // =================================================
    private bool ValidatePromptPoint(
        Transform promptPoint,
        string exhibitName)
    {
        if (promptPoint == null)
        {
            Debug.LogWarning(
                "PromptPoint chưa được gán cho: " +
                exhibitName
            );

            return false;
        }

        return true;
    }
}