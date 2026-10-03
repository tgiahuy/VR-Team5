using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Cài đặt di chuyển")]
    public float moveSpeed = 5f;
    public float mouseSensitivity = 2f;
    public float gravity = -9.81f;

    private float pitch = 0f;
    private float yaw = 0f;

    private CharacterController controller;
    private Transform cameraTransform;
    private float verticalVelocity;

    void Start()
    {
        // Lấy Character Controller gắn trên chính Player
        controller = GetComponent<CharacterController>();

        // Tìm Main Camera là con của Player
        Camera cam = GetComponentInChildren<Camera>();
        if (cam != null)
        {
            cameraTransform = cam.transform;
            cameraTransform.localPosition = new Vector3(0f, 1.6f, 0f); // Căn đúng tầm mắt
        }
        else
        {
            Debug.LogError("Chưa có Camera bên trong Player!");
        }

        // Lấy góc xoay Y ban đầu của Player
        yaw = transform.eulerAngles.y;
    }

    void Update()
    {
        if (controller == null) return;

        // =====================================
        // 1. DI CHUYỂN BẰNG PHÍM WASD
        // =====================================
        Vector2 input = Vector2.zero;

        if (Input.GetKey(KeyCode.W)) input.y += 1;
        if (Input.GetKey(KeyCode.S)) input.y -= 1;
        if (Input.GetKey(KeyCode.A)) input.x -= 1;
        if (Input.GetKey(KeyCode.D)) input.x += 1;

        Vector3 move = transform.right * input.x + transform.forward * input.y;
        move = move.normalized;

        float speed = moveSpeed;

        // Nhấn giữ Shift để chạy nhanh
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed *= 2f;
        }

        // =====================================
        // 2. TRỌNG LỰC (GRAVITY)
        // =====================================
        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 finalMove = move * speed;
        finalMove.y = verticalVelocity;

        // Di chuyển nhân vật
        controller.Move(finalMove * Time.deltaTime);

        // =====================================
        // 3. XOAY GÓC NHÌN BẰNG CHUỘT PHẢI
        // =====================================
        if (Input.GetMouseButton(1)) // Giữ chuột phải để quay nhìn
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            yaw += mouseX;
            pitch -= mouseY;
            pitch = Mathf.Clamp(pitch, -89f, 89f);

            // Xoay toàn bộ thân Player sang trái/phải
            transform.rotation = Quaternion.Euler(0f, yaw, 0f);

            // Chỉ xoay riêng Camera lên/xuống
            if (cameraTransform != null)
            {
                cameraTransform.localRotation = Quaternion.Euler(pitch, 0f, 0f);
            }
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}