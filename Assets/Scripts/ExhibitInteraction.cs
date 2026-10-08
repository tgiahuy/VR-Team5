using UnityEngine;
using UnityEngine.InputSystem;

public class ExhibitInteraction : MonoBehaviour
{
    [Header("Thông tin hiện vật")]
    [SerializeField] private string exhibitName = "Trang phục Ba Na";

    [Header("Bảng thông tin")]
    [SerializeField] private GameObject infoBoard;

    [Header("Prompt")]
    [SerializeField] private Transform promptPoint;

    [Header("Viewer 3D")]
    [SerializeField] private OutfitViewer outfitViewer;
    [SerializeField] private GameObject viewerPrefab;

    [Header("Căn chỉnh model trong Viewer")]
    [SerializeField] private Vector3 viewerPosition = Vector3.zero;
    [SerializeField] private Vector3 viewerRotation = Vector3.zero;
    [SerializeField] private float viewerScale = 1f;

    [Header("Thiết lập")]
    [SerializeField] private bool hideInfoWhenLeave = true;

    private bool playerInside = false;

    private void Start()
    {
        // Ẩn bảng thông tin lúc bắt đầu game
        if (infoBoard != null)
        {
            infoBoard.SetActive(false);
        }
        else
        {
            Debug.LogWarning(
                "InfoBoard chưa được gán cho: " +
                exhibitName
            );
        }
    }

    private void Update()
    {
        // Chỉ nhận input khi người chơi đang ở trong InteractionZone
        if (!playerInside)
            return;

        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        // Khi Viewer đang mở thì không xử lý F / I
        // vì Viewer sẽ tự xử lý Esc, R, chuột...
        if (outfitViewer != null && outfitViewer.IsOpen)
            return;

        // ==============================
        // I - HIỆN / ẨN BẢNG THÔNG TIN
        // ==============================
        if (keyboard.iKey.wasPressedThisFrame)
        {
            ToggleInfoBoard();
        }

        // ==============================
        // F - MỞ VIEWER 3D
        // ==============================
        if (keyboard.fKey.wasPressedThisFrame)
        {
            OpenViewer();
        }
    }

    private void ToggleInfoBoard()
    {
        if (infoBoard == null)
        {
            Debug.LogError(
                "InfoBoard chưa được gán cho: " +
                exhibitName
            );

            return;
        }

        bool newState = !infoBoard.activeSelf;

        infoBoard.SetActive(newState);

        Debug.Log(
            "===== INFO BOARD DEBUG =====\n" +
            "Exhibit: " + exhibitName + "\n" +
            "Object: " + infoBoard.name + "\n" +
            "activeSelf: " + infoBoard.activeSelf + "\n" +
            "activeInHierarchy: " + infoBoard.activeInHierarchy
        );
    }

    private void OpenViewer()
    {
        if (outfitViewer == null)
        {
            Debug.LogError(
                "OutfitViewer chưa được gán cho: " +
                exhibitName
            );

            return;
        }

        if (viewerPrefab == null)
        {
            Debug.LogError(
                "ViewerPrefab chưa được gán cho: " +
                exhibitName
            );

            return;
        }

        // Ẩn bảng thông tin khi mở Viewer
        if (infoBoard != null)
        {
            infoBoard.SetActive(false);
        }

        // Ẩn prompt [F] / [I]
        if (InteractionPromptManager.Instance != null)
        {
            InteractionPromptManager.Instance.HidePrompt(
                promptPoint
            );
        }

        // Mở Viewer
        outfitViewer.Open(
            viewerPrefab,
            exhibitName,
            viewerPosition,
            viewerRotation,
            viewerScale,
            this
        );

        Debug.Log(
            "Đã yêu cầu mở Viewer: " +
            exhibitName
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!IsPlayer(other))
            return;

        playerInside = true;

        Debug.Log(
            "Player vào vùng: " +
            exhibitName
        );

        ShowPrompt();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!IsPlayer(other))
            return;

        playerInside = false;

        Debug.Log(
            "Player rời vùng: " +
            exhibitName
        );

        // Ẩn prompt
        if (InteractionPromptManager.Instance != null)
        {
            InteractionPromptManager.Instance.HidePrompt(
                promptPoint
            );
        }

        // Tự ẩn bảng thông tin khi rời vùng
        if (hideInfoWhenLeave && infoBoard != null)
        {
            infoBoard.SetActive(false);

            Debug.Log(
                "Đã ẩn InfoBoard vì Player rời vùng: " +
                exhibitName
            );
        }
    }

    private void ShowPrompt()
    {
        if (InteractionPromptManager.Instance != null)
        {
            InteractionPromptManager.Instance.ShowPrompt(
                promptPoint,
                exhibitName
            );
        }
        else
        {
            Debug.LogWarning(
                "Không tìm thấy InteractionPromptManager!"
            );
        }
    }

    // Được OutfitViewer gọi sau khi Viewer đóng
    public void OnViewerClosed()
    {
        Debug.Log(
            "Viewer đã đóng | Exhibit: " +
            exhibitName +
            " | PlayerInside = " +
            playerInside
        );

        // Nếu người chơi vẫn đang trong vùng
        // thì hiện lại prompt
        if (playerInside)
        {
            ShowPrompt();
        }
    }

    private bool IsPlayer(Collider other)
    {
        // Collider trực tiếp có tag Player
        if (other.CompareTag("Player"))
            return true;

        // Collider nằm trong XR Origin có tag Player
        if (other.transform.root.CompareTag("Player"))
            return true;

        return false;
    }
}