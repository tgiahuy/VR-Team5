# SPEC DỰ ÁN — BẢO TÀNG ẢO TRANG PHỤC TRUYỀN THỐNG

## 1. Tổng quan

- **Tên dự án:** MuseumVR — Bảo tàng ảo trang phục truyền thống.
- **Loại sản phẩm:** Trải nghiệm tham quan bảo tàng 3D trong môi trường VR.
- **Nền tảng ưu tiên:** Thiết bị VR tương thích OpenXR; dùng XR Device Simulator để phát triển khi không có kính.
- **Công nghệ:** Unity, Universal Render Pipeline, OpenXR, XR Interaction Toolkit.
- **Quy mô nội dung:** 1 không gian bảo tàng cơ sở và 4 asset trang phục.
- **Thời lượng mục tiêu:** 5–10 phút cho một lượt tham quan.
- **Ngôn ngữ:** Tiếng Việt.

Mục tiêu của bản đầu tiên là tạo một không gian trưng bày nhỏ nhưng hoàn chỉnh: người dùng bước vào bảo tàng, di chuyển giữa các vị trí trưng bày, quan sát 4 bộ trang phục và mở thông tin giới thiệu cho từng bộ. Không mở rộng thành nhiều khu văn hóa hoặc một hệ thống bảo tàng lớn khi chưa hoàn thiện trải nghiệm cốt lõi.

---

## 2. Cơ sở asset hiện có

### 2.1. Asset nền tảng

| Nhóm | Số lượng | Vai trò |
|---|---:|---|
| Base map / không gian bảo tàng | 1 | Không gian chính chứa sảnh, lối đi và các vị trí trưng bày |
| Asset trang phục | 4 | Bốn hiện vật 3D trung tâm của trải nghiệm |
| Asset trưng bày phụ | Có thể dùng | Bục, tủ, biển tên, vật liệu và ánh sáng hỗ trợ bố cục |

Model không gian hiện có nằm tại `MuseumVR/Assets/Project/Art/Museum/Models/Art+Room.fbx`. Model môi trường trưng bày tại `MuseumVR/Assets/Project/Art/Environments/ExhibitDisplay/Models/vr+halls-fbx.fbx` chỉ dùng khi phù hợp với base map, không tạo thêm một map ngoài phạm vi.

### 2.2. Quy ước cho 4 asset trang phục

Tên và thông tin văn hóa của 4 asset cần được xác nhận từ nguồn cung cấp. Trong quá trình phát triển dùng ID ổn định:

```text
OUTFIT_01
OUTFIT_02
OUTFIT_03
OUTFIT_04
```

Mỗi asset phải được kiểm tra trước khi đưa vào scene:

- Scale và hướng trục thống nhất với Unity.
- Pivot đặt hợp lý để đặt trên mannequin hoặc bục.
- Có collider hoặc collider riêng cho tương tác.
- Material và texture hiển thị đúng trong URP.
- Không gán dân tộc, ý nghĩa họa tiết hoặc thông tin lịch sử khi chưa có nguồn xác nhận.
- Có thông tin license/quyền sử dụng nếu asset không do nhóm tự tạo.

---

## 3. Mục tiêu và tiêu chí hoàn thành

### 3.1. Mục tiêu trải nghiệm

Người dùng có thể:

1. Khởi động ứng dụng và vào không gian bảo tàng.
2. Di chuyển hoặc teleport trong base map.
3. Nhận biết một bộ trang phục là đối tượng tương tác.
4. Dùng tay cầm hoặc hand tracking để chọn hiện vật.
5. Mở panel thông tin của hiện vật.
6. Xem tên, ảnh/preview, mô tả ngắn và nguồn tham khảo.
7. Đóng panel và tiếp tục tham quan.
8. Xem đủ 4 asset trang phục trong cùng một không gian.

### 3.2. Tiêu chí nghiệm thu MVP

- Build chạy được trong Unity Editor bằng XR Device Simulator và trên ít nhất một thiết bị OpenXR mục tiêu nếu có.
- Có một scene bảo tàng hoàn chỉnh dựa trên base map hiện có.
- Có đủ 4 vị trí trưng bày, mỗi vị trí gắn đúng một asset trang phục.
- Cả 4 hiện vật dùng được cùng một quy trình tương tác.
- Panel thông tin mở/đóng ổn định, không làm biến đổi vị trí hiện vật gốc.
- Người dùng không bị kẹt trong tường, sàn hoặc ngoài map trong luồng bình thường.
- Có hướng dẫn điều khiển ngắn trong sảnh hoặc màn hình mở đầu.
- Không có lỗi nghiêm trọng chặn việc vào map, di chuyển, tương tác hoặc thoát ứng dụng.

---

## 4. Phạm vi chức năng

### 4.1. Luồng người dùng

```text
Launch
  ↓
Welcome / Main Menu tối giản
  ↓
Hướng dẫn điều khiển
  ↓
Museum Scene
  ↓
Tham quan tự do
  ├── OUTFIT_01 → Thông tin hiện vật
  ├── OUTFIT_02 → Thông tin hiện vật
  ├── OUTFIT_03 → Thông tin hiện vật
  └── OUTFIT_04 → Thông tin hiện vật
  ↓
Pause / Exit
```

Người dùng không bắt buộc phải xem theo thứ tự. Base map là một không gian duy nhất; không chia thành 3 khu hoặc 3 scene độc lập.

### 4.2. Khởi động và menu

MVP chỉ cần:

- **Start / Bắt đầu:** vào scene bảo tàng.
- **How to play / Hướng dẫn:** hiển thị cách di chuyển và tương tác.
- **Quit / Thoát:** đóng ứng dụng trên bản build hỗ trợ thao tác này.

Settings, âm lượng và menu giới thiệu là phần mở rộng, không được làm chậm việc hoàn thiện scene chính.

### 4.3. Di chuyển VR

Ưu tiên cơ chế phù hợp với XR Interaction Toolkit:

- Teleport bằng ray tới các vị trí hợp lệ.
- Smooth locomotion chỉ bật nếu không gây khó chịu hoặc say VR.
- Snap turn hoặc smooth turn tùy thiết bị và cấu hình.
- Có XR Origin, camera, controller/interactor và locomotion system.
- Có vùng teleport hợp lệ, collider sàn và collider biên map.
- Không yêu cầu bàn phím + chuột là phương thức điều khiển chính.

Trong giai đoạn phát triển, XR Device Simulator dùng để mô phỏng headset và controller trên máy tính.

### 4.4. Hệ thống tương tác

Tất cả 4 hiện vật dùng chung một interface hoặc base component, ví dụ `IInteractable` / `ExhibitInteractable`.

Khi người dùng trỏ vào hiện vật trong khoảng cách hợp lệ:

1. Hiện highlight hoặc reticle.
2. Hiện prompt ngắn, ví dụ `Select để xem thông tin`.
3. Nhấn nút controller hoặc thực hiện poke/selection.
4. Mở panel thông tin tương ứng.

Tương tác chỉ đọc dữ liệu và mở UI; không cho phép kéo hiện vật ra khỏi vị trí trưng bày trong MVP.

### 4.5. Dữ liệu hiện vật

Dữ liệu phải tách khỏi logic UI, ưu tiên `ExhibitData : ScriptableObject`.

```text
ExhibitData
├── id
├── displayName
├── category / community (nếu đã xác minh)
├── shortDescription
├── detailedDescription (tùy chọn)
├── displayImage (tùy chọn)
├── modelPrefab
├── sourceUrl hoặc sourceText
└── assetLicense
```

Tạo 4 data asset tương ứng: `OUTFIT_01_Data` đến `OUTFIT_04_Data`. Nếu chưa có nội dung đã kiểm chứng, dùng tên tạm như `Trang phục 01` và ghi rõ trạng thái cần bổ sung; không tự suy đoán nguồn gốc văn hóa.

### 4.6. Panel thông tin

Panel đọc dữ liệu từ `ExhibitData` và hiển thị tối thiểu:

- Tên hiện vật.
- Ảnh hoặc preview nếu có.
- Mô tả ngắn.
- Nguồn tham khảo hoặc trạng thái `Nguồn đang cập nhật`.
- Nút đóng.

Khi panel mở:

- Tạm dừng hoặc vô hiệu hóa locomotion để người dùng đọc.
- Vẫn cho phép thao tác UI bằng controller.
- Không tạo bản sao model nếu không cần thiết.

### 4.7. Preview 3D — tùy chọn sau MVP

Nếu còn thời gian, panel có nút `Xem 3D` mở một preview riêng. Preview có thể xoay/zoom trong giới hạn, đóng được bằng controller và không thay đổi transform của asset đang trưng bày. Chỉ triển khai sau khi tương tác và panel thông tin của cả 4 hiện vật ổn định.

### 4.8. Audio và quiz — ngoài MVP

Audio guide, voice-over, quiz 5 câu và hệ thống điểm không phải yêu cầu bắt buộc của bản hiện tại. Chỉ bổ sung khi đã có nội dung, bản ghi âm và thời gian kiểm thử phù hợp.

---

## 5. Thiết kế không gian

### 5.1. Bố cục đề xuất

```text
+-------------------------------------------------------+
|                    BASE MAP / MUSEUM                  |
|                                                       |
|  [OUTFIT_01]        Sảnh + hướng dẫn       [OUTFIT_02]|
|                                                       |
|  [OUTFIT_03]         Lối đi tham quan      [OUTFIT_04]|
|                                                       |
|              Điểm bắt đầu / điểm thoát               |
+-------------------------------------------------------+
```

Bố cục thực tế điều chỉnh theo hình học của base map. Các vị trí trưng bày phải không che lối teleport/tầm nhìn chính, có khoảng cách đủ để quan sát từng asset, có ánh sáng phù hợp và dùng biển tên/marker nhất quán.

### 5.2. Phong cách hình ảnh

- Không gian tối giản, sạch và ưu tiên khả năng đọc trong VR.
- Trang phục là điểm nhấn chính; background không dùng màu quá gắt.
- Ánh sáng mềm, tránh vùng tối khiến model khó quan sát.
- Hạn chế post-processing, bloom và hiệu ứng gây khó chịu.
- UI có kích thước chữ, độ tương phản và khoảng cách phù hợp với headset.

### 5.3. Âm thanh tối thiểu

MVP không bắt buộc voice-over. Có thể dùng một ambient loop nhẹ và UI feedback nếu asset âm thanh sẵn có. Âm thanh phải có tùy chọn tắt nếu được triển khai.

---

## 6. Kiến trúc kỹ thuật

### 6.1. Scene

Đề xuất giữ cấu trúc đơn giản:

```text
Scenes/
├── MainMenu.unity       (tùy chọn; có thể dùng Welcome trong Museum)
└── Museum.unity         (base map + 4 exhibits + XR Origin)
```

Nếu project đang dùng `BasicScene` hoặc `SampleScene` để kiểm thử template, không xem scene mẫu của Unity/XR Interaction Toolkit là sản phẩm cuối. Chỉ đưa scene dự án vào Build Settings sau khi đã dọn nội dung demo không liên quan.

### 6.2. Module logic

```text
Scripts/
├── Core/
│   ├── GameManager
│   └── SceneLoader
├── XR/
│   ├── XRSetup
│   └── LocomotionSetup
├── Interaction/
│   ├── IInteractable
│   ├── ExhibitInteractable
│   └── InteractionPrompt
├── Exhibits/
│   ├── ExhibitData
│   └── ExhibitPresenter
└── UI/
    ├── WelcomeUI
    ├── ExhibitInfoPanel
    └── PauseUI
```

XR/di chuyển không chứa nội dung hiện vật; UI không hard-code dữ liệu của 4 bộ trang phục.

### 6.3. Tổ chức asset

```text
Assets/Project/
├── Art/
│   ├── Museum/
│   ├── Environments/
│   └── Exhibits/
├── Data/Exhibits/
├── Prefabs/
│   ├── Exhibits/
│   ├── Displays/
│   └── UI/
├── Scenes/
├── Scripts/
└── Audio/
```

Mỗi bộ trang phục nên là một prefab riêng, gồm model, material, collider, interaction component và điểm neo preview nếu có.

---

## 7. Phân công và quy trình nhóm

### Environment / Map

- Đưa base map vào scene.
- Thiết lập scale, collider, ánh sáng và vị trí 4 display.
- Kiểm tra vùng teleport, lối đi và hiệu năng.

### Exhibit / Content

- Import và chuẩn hóa 4 asset trang phục.
- Tạo 4 prefab và 4 `ExhibitData`.
- Hoàn thiện tên, mô tả, nguồn và license.

### XR / Interaction

- Thiết lập OpenXR, XR Origin và locomotion.
- Xây dựng tương tác dùng chung cho 4 hiện vật.
- Tích hợp highlight, prompt và trạng thái panel.

### UI / QA

- Thiết kế Welcome, hướng dẫn và information panel.
- Kiểm thử controller, panel, teleport và lỗi va chạm.
- Chuẩn bị build demo và ghi nhận lỗi.

### Quy tắc Git và Unity

- Pull trước khi bắt đầu làm việc.
- Mỗi thành viên làm trên branch riêng.
- Không sửa đồng thời cùng một scene hoặc prefab lớn.
- Commit theo một thay đổi có ý nghĩa.
- Prefab hóa 4 hiện vật để giảm conflict.
- Người tích hợp scene chịu trách nhiệm merge thay đổi vào scene chính.
- Không commit cache hoặc build sinh tự động.

---

## 8. Tiến độ đề xuất

### M0 — Kiểm kê và chuẩn hóa asset

- Xác nhận base map và 4 asset trang phục.
- Kiểm tra scale, texture, license và tên asset.
- Chọn scene chính và kiểm tra OpenXR/XR Device Simulator.

### M1 — Blockout và XR prototype

- Đặt base map vào scene.
- Thiết lập XR Origin, teleport và điểm bắt đầu.
- Đặt 4 placeholder display.
- Hoàn thành một hiện vật tương tác mẫu.

### M2 — MVP 4 hiện vật

- Hoàn thiện 4 prefab trang phục.
- Tạo 4 data asset.
- Tích hợp information panel.
- Thêm hướng dẫn và điểm thoát.

### M3 — Kiểm thử và hoàn thiện

- Test trên simulator và thiết bị mục tiêu.
- Sửa lỗi collider, scale, UI và locomotion.
- Tối ưu model, texture, lighting nếu cần.
- Tạo build demo/release và README.

---

## 9. Kiểm thử và hiệu năng

### Checklist chức năng

- [ ] Ứng dụng mở được vào luồng chính.
- [ ] XR Origin đặt đúng vị trí và camera không nằm trong tường.
- [ ] Teleport chỉ tới vùng hợp lệ.
- [ ] Không xuyên tường/sàn trong luồng bình thường.
- [ ] Nhận diện đúng cả 4 hiện vật.
- [ ] Mỗi hiện vật mở đúng nội dung của mình.
- [ ] Panel đóng được bằng controller.
- [ ] Thoát hoặc quay lại menu hoạt động.
- [ ] Không có model bị mất material hoặc sai scale.
- [ ] Build chạy được ngoài Unity Editor.

### Mục tiêu hiệu năng

- Ưu tiên trải nghiệm ổn định, không giật và không gây khó chịu trong VR.
- Giảm polygon/material/texture khi cần nhưng không làm mất chi tiết quan trọng của trang phục.
- Dùng baked lighting hoặc cấu hình ánh sáng nhẹ nếu phù hợp.
- Kiểm tra draw calls, texture memory và FPS bằng Unity Profiler trên thiết bị mục tiêu.
- Chốt ngưỡng FPS sau khi xác định headset và cấu hình máy chạy build.

---

## 10. Ngoài phạm vi bản MVP

- Nhiều base map hoặc nhiều tầng bảo tàng.
- Chia thành 3 khu Ê Đê, Ba Na, Gia Rai khi chưa có nội dung và asset tương ứng.
- Trưng bày 6 hiện vật trở lên.
- Multiplayer, tài khoản, backend hoặc database online.
- Tương tác vật lý phức tạp, cloth simulation realtime.
- Quiz, hệ thống điểm, bộ sưu tập hoặc achievement.
- Voice-over/song ngữ nếu chưa có kịch bản và audio được duyệt.
- Hỗ trợ đồng thời PC, WebGL, mobile và nhiều nền tảng VR.

Các hạng mục trên chỉ được mở lại sau khi MVP đạt toàn bộ tiêu chí nghiệm thu.

---

## 11. Deliverables

- Unity project có scene bảo tàng chính.
- Một build demo chạy được trên môi trường mục tiêu.
- 4 prefab trang phục và 4 data asset tương ứng.
- UI hướng dẫn và panel thông tin hiện vật.
- README hướng dẫn mở project, chạy simulator và build.
- Danh sách nguồn nội dung và license asset.
- Video demo ngắn thể hiện: vào map, teleport/di chuyển, tương tác đủ 4 hiện vật và đóng panel.
