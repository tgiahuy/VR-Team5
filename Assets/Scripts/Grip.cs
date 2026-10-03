using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grip : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor currentInteractor;

    // Góc ban đầu của vật thể
    private Quaternion originalRotation;

    // Góc của controller tại thời điểm bắt đầu Grip
    private Quaternion lastControllerRotation;

    // Tốc độ xoay
    [SerializeField]
    private float rotationSpeed = 1.5f;

    // Thời gian quay về góc ban đầu
    [SerializeField]
    private float returnDuration = 0.4f;

    private bool isReturning = false;
    private float returnTimer;

    private Quaternion startReturnRotation;

    private void Start()
    {
        // Lưu góc ban đầu
        originalRotation = transform.rotation;
    }

    private void OnEnable()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable =
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();

        interactable.selectEntered.AddListener(OnSelectEntered);
        interactable.selectExited.AddListener(OnSelectExited);
    }

    private void OnDisable()
    {
        UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable =
            GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();

        interactable.selectEntered.RemoveListener(OnSelectEntered);
        interactable.selectExited.RemoveListener(OnSelectExited);
    }

    // Khi bắt đầu Grip
    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        currentInteractor = args.interactorObject;

        // Lấy góc hiện tại của controller
        lastControllerRotation = currentInteractor.transform.rotation;

        // Nếu đang quay về thì dừng lại
        isReturning = false;
    }

    // Khi thả Grip
    private void OnSelectExited(SelectExitEventArgs args)
    {
        currentInteractor = null;

        // Bắt đầu quay về góc ban đầu
        startReturnRotation = transform.rotation;

        returnTimer = 0f;
        isReturning = true;
    }

    private void Update()
    {
        // =========================
        // ĐANG GRIP → XOAY VẬT THỂ
        // =========================

        if (currentInteractor != null)
        {
            Quaternion currentRotation =
                currentInteractor.transform.rotation;

            Quaternion rotationDelta =
                currentRotation *
                Quaternion.Inverse(lastControllerRotation);

            // Tăng tốc độ xoay
            rotationDelta =
                Quaternion.Slerp(
                    Quaternion.identity,
                    rotationDelta,
                    rotationSpeed
                );

            transform.rotation =
                rotationDelta * transform.rotation;

            lastControllerRotation = currentRotation;
        }

        // =========================
        // THẢ GRIP → QUAY VỀ BAN ĐẦU
        // =========================

        if (isReturning)
        {
            returnTimer += Time.deltaTime;

            float t = returnTimer / returnDuration;

            // Làm chuyển động mượt hơn
            t = Mathf.SmoothStep(0f, 1f, t);

            transform.rotation =
                Quaternion.Slerp(
                    startReturnRotation,
                    originalRotation,
                    t
                );

            if (t >= 1f)
            {
                transform.rotation = originalRotation;
                isReturning = false;
            }
        }
    }
}