using UnityEngine;
using UnityEngine.InputSystem;

public class InfoExhibitInteraction : MonoBehaviour
{
    [Header("Thông tin")]
    [SerializeField] private string exhibitName = "Thông tin";

    [Header("Bảng thông tin")]
    [SerializeField] private GameObject infoBoard;

    [Header("Prompt")]
    [SerializeField] private Transform promptPoint;

    [Header("Thiết lập")]
    [SerializeField] private bool hideInfoWhenLeave = true;

    private bool playerInside = false;

    private void Start()
    {
        if (infoBoard != null)
        {
            infoBoard.SetActive(false);
        }
    }

    private void Update()
    {
        if (!playerInside)
            return;

        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        if (keyboard.iKey.wasPressedThisFrame)
        {
            ToggleInfoBoard();
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
            "InfoBoard " +
            exhibitName +
            " = " +
            newState
        );
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!IsPlayer(other))
            return;

        playerInside = true;

        if (InteractionPromptManager.Instance != null)
        {
            InteractionPromptManager.Instance.ShowInfoOnlyPrompt(
                promptPoint,
                exhibitName
            );
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!IsPlayer(other))
            return;

        playerInside = false;

        if (InteractionPromptManager.Instance != null)
        {
            InteractionPromptManager.Instance.HidePrompt(
                promptPoint
            );
        }

        if (hideInfoWhenLeave && infoBoard != null)
        {
            infoBoard.SetActive(false);
        }
    }

    private bool IsPlayer(Collider other)
    {
        if (other.CompareTag("Player"))
            return true;

        if (other.transform.root.CompareTag("Player"))
            return true;

        return false;
    }
}