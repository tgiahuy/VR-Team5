using UnityEngine;
using UnityEngine.InputSystem;
using Unity.XR.CoreUtils;

public class KeyboardXRMovement : MonoBehaviour
{
    [Header("XR")]
    [SerializeField] private XROrigin xrOrigin;
    [SerializeField] private Transform headTransform;
    [SerializeField] private CharacterController characterController;

    [Header("Tốc độ")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sprintMultiplier = 2f;

    [Header("Trọng lực")]
    [SerializeField] private bool useGravity = true;
    [SerializeField] private float gravity = -9.81f;

    private float verticalVelocity;

    private void Awake()
    {
        if (xrOrigin == null)
            xrOrigin = GetComponent<XROrigin>();

        if (characterController == null)
            characterController = GetComponent<CharacterController>();

        if (headTransform == null && Camera.main != null)
            headTransform = Camera.main.transform;
    }

    private void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null || headTransform == null)
            return;

        float x = 0f;
        float z = 0f;

        if (keyboard.wKey.isPressed)
            z += 1f;

        if (keyboard.sKey.isPressed)
            z -= 1f;

        if (keyboard.aKey.isPressed)
            x -= 1f;

        if (keyboard.dKey.isPressed)
            x += 1f;

        Vector2 input = new Vector2(x, z);

        // Tránh W+D nhanh hơn W
        input = Vector2.ClampMagnitude(input, 1f);

        // Hướng nhìn của headset/camera
        Vector3 forward = headTransform.forward;
        Vector3 right = headTransform.right;

        // WASD chỉ đi trên mặt đất
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 move =
            forward * input.y +
            right * input.x;

        float speed = moveSpeed;

        // Shift để chạy
        if (keyboard.leftShiftKey.isPressed ||
            keyboard.rightShiftKey.isPressed)
        {
            speed *= sprintMultiplier;
        }

        move *= speed;

        // Gravity
        if (useGravity)
        {
            if (characterController != null &&
                characterController.isGrounded &&
                verticalVelocity < 0f)
            {
                verticalVelocity = -2f;
            }

            verticalVelocity += gravity * Time.deltaTime;
            move.y = verticalVelocity;
        }

        if (characterController != null)
        {
            characterController.Move(
                move * Time.deltaTime
            );
        }
        else
        {
            transform.position +=
                move * Time.deltaTime;
        }
    }
}