using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class OutfitViewer : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject viewerCanvas;
    [SerializeField] private TMP_Text titleText;

    [Header("Spawn Model")]
    [SerializeField] private Transform viewerPivot;

    [Header("Player")]
    [Tooltip("Kéo component điều khiển di chuyển Player vào đây. Có thể để trống nếu chưa dùng.")]
    [SerializeField] private MonoBehaviour playerMovement;

    [Header("Layer Viewer")]
    [SerializeField] private string viewerLayerName = "ViewerModel";

    [Header("Điều khiển xoay")]
    [SerializeField] private float mouseRotationSpeed = 0.25f;
    [SerializeField] private float keyboardRotationSpeed = 80f;

    [Header("Zoom")]
    [SerializeField] private float zoomStep = 0.1f;
    [SerializeField] private float minZoom = 0.5f;
    [SerializeField] private float maxZoom = 2.0f;

    private GameObject currentModel;

    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Vector3 originalScale;

    private float currentZoom = 1f;

    private ExhibitInteraction currentExhibit;

    public bool IsOpen { get; private set; }

    private void Awake()
    {
        if (viewerCanvas != null)
        {
            viewerCanvas.SetActive(false);
        }

        IsOpen = false;
    }

    public void Open(
        GameObject modelPrefab,
        string displayName,
        Vector3 localPosition,
        Vector3 localRotation,
        float scale,
        ExhibitInteraction exhibit)
    {
        // ==========================
        // KIỂM TRA DỮ LIỆU
        // ==========================

        if (modelPrefab == null)
        {
            Debug.LogWarning(
                "ViewerPrefab chưa được gán!"
            );

            return;
        }

        if (viewerPivot == null)
        {
            Debug.LogError(
                "ViewerPivot chưa được gán trong OutfitViewer!"
            );

            return;
        }

        // Lưu exhibit đang mở Viewer
        currentExhibit = exhibit;

        // ==========================
        // XÓA MODEL CŨ
        // ==========================

        ClearCurrentModel();

        // ==========================
        // TẠO MODEL MỚI
        // ==========================

        currentModel = Instantiate(
            modelPrefab,
            viewerPivot
        );

        currentModel.transform.localPosition =
            localPosition;

        currentModel.transform.localRotation =
            Quaternion.Euler(localRotation);

        currentModel.transform.localScale =
            Vector3.one * scale;

        // ==========================
        // GÁN LAYER VIEWERMODEL
        // ==========================

        int viewerLayer =
            LayerMask.NameToLayer(viewerLayerName);

        if (viewerLayer >= 0)
        {
            SetLayerRecursively(
                currentModel,
                viewerLayer
            );
        }
        else
        {
            Debug.LogWarning(
                "Không tìm thấy Layer: " +
                viewerLayerName
            );
        }

        // ==========================
        // LƯU TRANSFORM BAN ĐẦU
        // ==========================

        originalPosition =
            currentModel.transform.localPosition;

        originalRotation =
            currentModel.transform.localRotation;

        originalScale =
            currentModel.transform.localScale;

        currentZoom = 1f;

        // ==========================
        // TITLE
        // ==========================

        if (titleText != null)
        {
            titleText.text = displayName;
        }

        // ==========================
        // HIỆN VIEWER
        // ==========================

        if (viewerCanvas != null)
        {
            viewerCanvas.SetActive(true);
        }

        // ==========================
        // KHÓA PLAYER MOVEMENT
        // ==========================

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }

        // ==========================
        // CURSOR
        // ==========================

        Cursor.lockState =
            CursorLockMode.None;

        Cursor.visible = true;

        IsOpen = true;

        Debug.Log(
            "Đã mở Viewer: " +
            displayName
        );
    }

    private void Update()
    {
        if (!IsOpen || currentModel == null)
            return;

        Keyboard keyboard =
            Keyboard.current;

        Mouse mouse =
            Mouse.current;

        // ==========================
        // ESC - ĐÓNG VIEWER
        // ==========================

        if (keyboard != null &&
            keyboard.escapeKey.wasPressedThisFrame)
        {
            Close();
            return;
        }

        // ==========================
        // R - RESET MODEL
        // ==========================

        if (keyboard != null &&
            keyboard.rKey.wasPressedThisFrame)
        {
            ResetModel();
        }

        // ==========================
        // CHUỘT TRÁI - XOAY MODEL
        // ==========================

        if (mouse != null &&
            mouse.leftButton.isPressed)
        {
            Vector2 delta =
                mouse.delta.ReadValue();

            // Trái / phải
            currentModel.transform.Rotate(
                Vector3.up,
                -delta.x *
                mouseRotationSpeed,
                Space.World
            );

            // Lên / xuống
            currentModel.transform.Rotate(
                Vector3.right,
                delta.y *
                mouseRotationSpeed,
                Space.Self
            );
        }

        // ==========================
        // WASD - XOAY MODEL
        // ==========================

        if (keyboard != null)
        {
            float horizontal = 0f;
            float vertical = 0f;

            if (keyboard.aKey.isPressed)
                horizontal += 1f;

            if (keyboard.dKey.isPressed)
                horizontal -= 1f;

            if (keyboard.wKey.isPressed)
                vertical += 1f;

            if (keyboard.sKey.isPressed)
                vertical -= 1f;

            // Xoay trái / phải
            if (horizontal != 0f)
            {
                currentModel.transform.Rotate(
                    Vector3.up,
                    horizontal *
                    keyboardRotationSpeed *
                    Time.deltaTime,
                    Space.World
                );
            }

            // Xoay lên / xuống
            if (vertical != 0f)
            {
                currentModel.transform.Rotate(
                    Vector3.right,
                    vertical *
                    keyboardRotationSpeed *
                    Time.deltaTime,
                    Space.Self
                );
            }
        }

        // ==========================
        // SCROLL - ZOOM
        // ==========================

        if (mouse != null)
        {
            float scroll =
                mouse.scroll.ReadValue().y;

            if (scroll > 0f)
            {
                currentZoom += zoomStep;
            }
            else if (scroll < 0f)
            {
                currentZoom -= zoomStep;
            }

            currentZoom =
                Mathf.Clamp(
                    currentZoom,
                    minZoom,
                    maxZoom
                );

            currentModel.transform.localScale =
                originalScale *
                currentZoom;
        }
    }

    public void ResetModel()
    {
        if (currentModel == null)
            return;

        currentZoom = 1f;

        currentModel.transform.localPosition =
            originalPosition;

        currentModel.transform.localRotation =
            originalRotation;

        currentModel.transform.localScale =
            originalScale;

        Debug.Log(
            "Đã reset model Viewer"
        );
    }

    public void Close()
    {
        if (!IsOpen)
            return;

        // ==========================
        // XÓA MODEL VIEWER
        // ==========================

        ClearCurrentModel();

        // ==========================
        // ẨN CANVAS
        // ==========================

        if (viewerCanvas != null)
        {
            viewerCanvas.SetActive(false);
        }

        // ==========================
        // BẬT LẠI PLAYER MOVEMENT
        // ==========================

        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }

        Cursor.lockState =
            CursorLockMode.None;

        Cursor.visible = true;

        IsOpen = false;

        // ==========================
        // BÁO CHO EXHIBIT
        // VIEWER ĐÃ ĐÓNG
        // ==========================

        if (currentExhibit != null)
        {
            currentExhibit.OnViewerClosed();

            currentExhibit = null;
        }

        Debug.Log(
            "Đã đóng Viewer"
        );
    }

    private void ClearCurrentModel()
    {
        if (currentModel != null)
        {
            Destroy(currentModel);

            currentModel = null;
        }
    }

    private void SetLayerRecursively(
        GameObject obj,
        int layer)
    {
        obj.layer = layer;

        foreach (Transform child
                 in obj.transform)
        {
            SetLayerRecursively(
                child.gameObject,
                layer
            );
        }
    }
}