# PROJECT PROGRESS — BẢO TÀNG ẢO TRANG PHỤC TRUYỀN THỐNG TÂY NGUYÊN

> Tài liệu theo dõi tiến độ dành cho **nhóm 4 thành viên**, đồng bộ với `spec_v2_4_members.md`.

## 1. Quy ước và phân công

### Trạng thái

- `[ ]` Chưa bắt đầu.
- `[-]` Đang thực hiện.
- `[x]` Đã hoàn thành và kiểm tra.
- `[!]` Bị chặn/có nguy cơ trễ.

### Vai trò

- **GP — Thành viên 1:** Gameplay & Integration Lead.
- **ENV — Thành viên 2:** Environment & Optimization.
- **CONT — Thành viên 3:** Exhibit 3D & Cultural Content.
- **UITEST — Thành viên 4:** UI/UX, Audio, Quiz & QA.

### Nguyên tắc cập nhật

1. Mỗi thành viên cập nhật phần việc của mình cuối ngày.
2. Chỉ đánh dấu `[x]` khi task đã được tự test.
3. Task ảnh hưởng module khác chỉ hoàn thành sau integration test.
4. Task bị chặn phải chuyển `[!]` và ghi nguyên nhân.
5. P0/P1 luôn ưu tiên hơn polish.
6. Không tự ý chỉnh scene/prefab thuộc quyền thành viên khác.
7. Mỗi milestone phải có build/tag rõ ràng.
8. Sau Beta không thêm tính năng mới.
9. Mọi nội dung/asset văn hóa phải có nguồn và license phù hợp.

---

# 2. Dashboard tổng thể

| Milestone | Thời gian | Mục tiêu | Build | Trạng thái |
|---|---|---|---|---|
| M0 | Ngày 1 | Setup dự án và thống nhất workflow | — | `[-]` |
| M1 | Tuần 1 | Prototype chơi được | `Prototype_v0.1` | `[ ]` |
| M2 | Tuần 2 | MVP end-to-end | `Alpha_v0.1` | `[ ]` |
| M3 | Tuần 3 | Nội dung + hình ảnh + user test | `Beta_v0.5` | `[ ]` |
| M4 | Tuần 4 | Tối ưu + đóng gói | `Release_v1.0` | `[ ]` |

## Tiến độ hiện tại

- **Milestone:** `M0 — Setup`
- **Tiến độ tổng:** `_____ %`
- **Build mới nhất:** `Chưa có`
- **P0:** `0`
- **P1:** `0`
- **P2:** `0`
- **P3:** `0`
- **Ngày cập nhật:** `____ / ____ / 2026`

---

# 3. M0 — SETUP

## Mục tiêu

Thiết lập project, Git, cấu trúc Unity, phạm vi nội dung và nguyên tắc phối hợp nhóm.

## GP — Gameplay & Integration

- [x] Chọn phiên bản Unity/render pipeline.
- [x] Tạo Unity project.
- [x] Tạo Git repository.
- [x] Thêm `.gitignore` Unity.
- [x] Tạo `main`.
- [x] Tạo `develop`.
- [x] Tạo cấu trúc `Assets/_Project`.
- [x] Tạo các scene `Bootstrap`, `MainMenu`, `Museum`.
- [x] Tạo bảng quản lý task.
- [ ] Kiểm tra clone project trên máy thành viên khác.
- [ ] Thống nhất Git workflow.
- [ ] Thiết lập quy tắc prefab/scene ownership.

## ENV — Environment

- [ ] Vẽ layout sảnh + 3 khu + quiz.
- [ ] Xác định kích thước bảo tàng.
- [ ] Xác định vị trí 6 hiện vật.
- [ ] Xác định vị trí biển chỉ dẫn.
- [ ] Chọn asset/environment chính.
- [ ] Kiểm tra license asset.
- [ ] Tạo moodboard/phong cách ánh sáng.

## CONT — Content

- [ ] Chốt khu Ê Đê.
- [ ] Chốt khu Ba Na.
- [ ] Chốt khu Gia Rai.
- [ ] Chọn 6 hiện vật.
- [ ] Tạo ID cho 6 hiện vật.
- [ ] Tìm nguồn ban đầu.
- [ ] Tạo biểu mẫu hồ sơ hiện vật.
- [ ] Kiểm tra khả năng tìm model/ảnh.
- [ ] Đánh dấu asset cần tự chỉnh sửa.

## UITEST — UI/QA

- [ ] Wireframe Main Menu.
- [ ] Wireframe Information Panel.
- [ ] Wireframe Exhibit Viewer.
- [ ] Wireframe Quiz.
- [ ] Wireframe Result.
- [ ] Thiết kế interaction prompt.
- [ ] Tạo test-case template.
- [ ] Tạo bug-report template.

## Nghiệm thu M0

- [ ] Project clone/mở được trên máy nhóm.
- [ ] Git workflow thống nhất.
- [ ] Không commit cache Unity.
- [ ] Layout bảo tàng được duyệt.
- [ ] Có danh sách 6 hiện vật.
- [ ] Có nguồn sơ bộ.
- [ ] Có wireframe chính.

---

# 4. M1 — PROTOTYPE v0.1

## Mục tiêu

Có luồng:

`Main Menu → Museum → di chuyển → tương tác → xem một hiện vật`.

## GP

### Player

- [ ] WASD movement.
- [ ] Mouse look.
- [ ] Gravity.
- [ ] Collision.
- [ ] Cursor lock/unlock.
- [ ] Pause/resume.

### Interaction

- [ ] Camera raycast.
- [ ] Interaction distance.
- [ ] Detect interactable.
- [ ] Gọi interaction bằng `E`.
- [ ] Kết nối interaction prompt.

### Exhibit prototype

- [ ] Tạo `ExhibitData`.
- [ ] Tạo `ExhibitInteractable`.
- [ ] Tạo một dữ liệu hiện vật mẫu.
- [ ] Mở Information Panel.
- [ ] Khóa player khi panel mở.
- [ ] Đóng panel và trả lại gameplay.

## ENV

- [ ] Blockout sảnh.
- [ ] Blockout khu Ê Đê.
- [ ] Blockout khu Ba Na.
- [ ] Blockout khu Gia Rai.
- [ ] Blockout Quiz area.
- [ ] Collider sàn.
- [ ] Collider tường.
- [ ] Kiểm tra không có vị trí player bị kẹt.
- [ ] Đặt 6 vị trí trưng bày placeholder.
- [ ] Tạo/nhập tủ hoặc bục mẫu.
- [ ] Lighting prototype.

## CONT

- [ ] Hoàn thiện hồ sơ hiện vật mẫu.
- [ ] Chuẩn bị model/mannequin mẫu.
- [ ] Chuẩn hóa scale.
- [ ] Chuẩn hóa material.
- [ ] Chuẩn bị ảnh minh họa.
- [ ] Viết mô tả mẫu.
- [ ] Ghi nguồn.
- [ ] Tìm asset cho 5 hiện vật còn lại.

## UITEST

### Main Menu

- [ ] Bắt đầu.
- [ ] Hướng dẫn.
- [ ] Giới thiệu.
- [ ] Cài đặt placeholder.
- [ ] Thoát.

### Information UI

- [ ] Tên hiện vật.
- [ ] Ảnh.
- [ ] Mô tả.
- [ ] Nguồn.
- [ ] Nút đóng.
- [ ] Nút xem 3D placeholder.
- [ ] Nút audio placeholder.

### QA

- [ ] Kiểm tra UI 1920×1080.
- [ ] Kiểm tra menu → museum.
- [ ] Kiểm tra interaction prototype.
- [ ] Ghi bug.

## Integration M1

- [ ] Merge Player.
- [ ] Merge Environment.
- [ ] Merge Exhibit prototype.
- [ ] Merge UI.
- [ ] Test trên máy GP.
- [ ] Test trên ít nhất một máy thành viên khác.
- [ ] Không còn P0.
- [ ] Không còn P1 chặn demo.

## Build

- [ ] Tạo `Prototype_v0.1`.
- [ ] Tag Git.
- [ ] Backup build.

### Review M1

- **Ngày:** `____________`
- **FPS:** `____________`
- **P0:** `____________`
- **P1:** `____________`
- **Kết quả:** `PASS / CONDITIONAL / FAIL`
- **Ghi chú:** `____________________________________________`

---

# 5. M2 — ALPHA v0.1

## Mục tiêu

Toàn bộ MVP có thể chơi end-to-end với 3 khu và 6 hiện vật.

## GP

### Exhibit System

- [ ] Hoàn thiện `ExhibitData`.
- [ ] Data không hard-code trong UI.
- [ ] 6 exhibit dùng chung hệ thống interaction.
- [ ] Hoàn thiện trạng thái mở/đóng UI.

### Exhibit Viewer

- [ ] Spawn/display model.
- [ ] Mouse rotation.
- [ ] Zoom.
- [ ] Zoom limits.
- [ ] Close.
- [ ] Không thay transform exhibit gốc.
- [ ] Player bị khóa khi viewer mở.

### Audio Integration

- [ ] AudioManager.
- [ ] Play voice-over.
- [ ] Stop voice-over.
- [ ] Không phát chồng voice-over.
- [ ] Volume integration.

### Settings

- [ ] Master Volume.
- [ ] Mouse sensitivity.
- [ ] Lưu setting trong phiên chạy.
- [ ] Graphics setting nếu cần.

### Quiz Integration

- [ ] Kết nối QuizManager.
- [ ] Start quiz.
- [ ] Result.
- [ ] Replay.
- [ ] Return.

## ENV

### Sảnh

- [ ] Kiến trúc chính.
- [ ] Quầy/điểm giới thiệu.
- [ ] Sơ đồ.
- [ ] Biển hướng dẫn.

### Ê Đê

- [ ] Layout.
- [ ] 2 display positions.
- [ ] Sign.
- [ ] Lighting pass 1.

### Ba Na

- [ ] Layout.
- [ ] 2 display positions.
- [ ] Sign.
- [ ] Lighting pass 1.

### Gia Rai

- [ ] Layout.
- [ ] 2 display positions.
- [ ] Sign.
- [ ] Lighting pass 1.

### Quiz Area

- [ ] Layout.
- [ ] Sign.
- [ ] Trigger/interaction position.

### Environment QA

- [ ] Collider.
- [ ] Scale.
- [ ] Không có lỗ map.
- [ ] Không có vật cản vô hình.
- [ ] Navigation rõ.

## CONT

### Exhibit 01

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Exhibit 02

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Exhibit 03

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Exhibit 04

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Exhibit 05

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Exhibit 06

- [ ] Model.
- [ ] Texture/material.
- [ ] Data.
- [ ] Image.
- [ ] Source.

### Nội dung

- [ ] Giới thiệu Ê Đê.
- [ ] Giới thiệu Ba Na.
- [ ] Giới thiệu Gia Rai.
- [ ] Kịch bản voice 1.
- [ ] Kịch bản voice 2.
- [ ] Kịch bản voice 3.
- [ ] License list được cập nhật.

## UITEST

### UI

- [ ] Information Panel final structure.
- [ ] Exhibit Viewer UI.
- [ ] Pause Menu.
- [ ] Settings.
- [ ] Navigation prompt.

### Quiz

- [ ] 5 câu hỏi.
- [ ] Đáp án.
- [ ] Next question.
- [ ] Score.
- [ ] Result.
- [ ] Replay.
- [ ] Return.

### Audio

- [ ] BGM prototype.
- [ ] Ambient prototype.
- [ ] Button SFX.
- [ ] Interaction SFX.
- [ ] Voice-over prototype.

### QA

- [ ] Test 6 exhibit.
- [ ] Test viewer.
- [ ] Test audio.
- [ ] Test settings.
- [ ] Test quiz.

## Integration M2

- [ ] 3 khu có trong build.
- [ ] 6/6 exhibit có trong build.
- [ ] 6/6 Information Panel đúng data.
- [ ] 6/6 viewer hoạt động.
- [ ] Audio guide hoạt động.
- [ ] Quiz 5 câu hoạt động.
- [ ] Menu → Museum → Quiz → Result hoàn chỉnh.
- [ ] Test ít nhất 2 máy.

## Build

- [ ] `Alpha_v0.1`.
- [ ] Git tag.
- [ ] Backup.
- [ ] Bug triage P0–P3.

### Review M2

- **Ngày:** `____________`
- **Exhibit:** `____ / 6`
- **Khu:** `____ / 3`
- **FPS:** `____________`
- **P0:** `____________`
- **P1:** `____________`
- **Kết quả:** `PASS / CONDITIONAL / FAIL`
- **Phạm vi cần điều chỉnh:** `_______________________________`

---

# 6. M3 — BETA v0.5

## Mục tiêu

Hoàn thiện nội dung, đồ họa, audio và UX; thực hiện user test.

## GP

- [ ] Sửa P0 Alpha.
- [ ] Sửa P1 Alpha.
- [ ] Polish interaction.
- [ ] Kiểm tra UI/gameplay state.
- [ ] Kiểm tra cursor state.
- [ ] Kiểm tra return menu.
- [ ] Kiểm tra reload Museum.
- [ ] Interaction feedback.

## ENV

- [ ] Material sàn.
- [ ] Material tường.
- [ ] Tủ/bục.
- [ ] Glass material.
- [ ] Lighting Ê Đê.
- [ ] Lighting Ba Na.
- [ ] Lighting Gia Rai.
- [ ] Lighting sảnh.
- [ ] Bake lighting.
- [ ] Light probes.
- [ ] Occlusion nếu cần.
- [ ] LOD nếu cần.
- [ ] Profiler environment.
- [ ] FPS trung bình ≥ 45 trên máy mục tiêu hoặc có kế hoạch tối ưu cụ thể.

## CONT

- [ ] Review Exhibit 01.
- [ ] Review Exhibit 02.
- [ ] Review Exhibit 03.
- [ ] Review Exhibit 04.
- [ ] Review Exhibit 05.
- [ ] Review Exhibit 06.
- [ ] Kiểm tra tên riêng.
- [ ] Kiểm tra cộng đồng liên quan.
- [ ] Kiểm tra chất liệu.
- [ ] Kiểm tra hoàn cảnh sử dụng.
- [ ] Kiểm tra nguồn ảnh.
- [ ] Kiểm tra license model.
- [ ] Kiểm tra mọi diễn giải họa tiết/màu sắc.
- [ ] Review với giảng viên/người am hiểu.
- [ ] Khóa nội dung.

## UITEST

### Audio final

- [ ] Voice-over 1.
- [ ] Voice-over 2.
- [ ] Voice-over 3.
- [ ] Noise reduction.
- [ ] Normalize.
- [ ] BGM.
- [ ] Ambient.
- [ ] SFX.

### UI polish

- [ ] 1920×1080.
- [ ] 1600×900.
- [ ] 1366×768.
- [ ] Font size.
- [ ] Contrast.
- [ ] Overflow.
- [ ] Interaction prompt.

### User Test

- [ ] Chuẩn bị kịch bản.
- [ ] Có 3–5 tester.
- [ ] Không hướng dẫn trực tiếp ngoài phần game cung cấp.
- [ ] Ghi thời gian.
- [ ] Ghi điểm bị lạc.
- [ ] Ghi lỗi interaction.
- [ ] Ghi nhận nội dung khó đọc.
- [ ] Ghi quiz score.
- [ ] Tổng hợp feedback.

## User Test Metrics

- **Số tester:** `______`
- **Hoàn thành trải nghiệm:** `______ / ______`
- **Thời gian trung bình:** `______ phút`
- **Bị lạc:** `______ / ______`
- **Mắc kẹt:** `______ / ______`
- **Quiz trung bình:** `______ / 5`

### Top issues

1. `________________________________________________`
2. `________________________________________________`
3. `________________________________________________`

## Integration M3

- [ ] Không còn placeholder quan trọng.
- [ ] Nội dung đã khóa.
- [ ] Audio final.
- [ ] Environment final pass.
- [ ] Không còn P0.
- [ ] P1 có kế hoạch sửa trước release.
- [ ] User mới có thể hoàn thành trải nghiệm.

## Build

- [ ] `Beta_v0.5`.
- [ ] Git tag.
- [ ] Backup.

## FEATURE FREEZE

- [ ] Nhóm xác nhận không thêm feature sau Beta.

### Review M3

- **Ngày:** `____________`
- **FPS:** `____________`
- **P0:** `____________`
- **P1:** `____________`
- **User test:** `____________ người`
- **Kết quả:** `PASS / CONDITIONAL / FAIL`

---

# 7. M4 — RELEASE v1.0

## Mục tiêu

Tạo build ổn định và hoàn thành hồ sơ bảo vệ.

## GP

- [ ] Sửa P0.
- [ ] Sửa P1.
- [ ] Regression gameplay.
- [ ] Build settings.
- [ ] Release Candidate.
- [ ] Build trên máy sạch.
- [ ] Build trên máy trình chiếu.
- [ ] `Release_v1.0`.

## ENV

- [ ] Profiler CPU.
- [ ] Profiler GPU.
- [ ] Profiler Memory.
- [ ] Texture optimization.
- [ ] Mesh optimization.
- [ ] Light optimization.
- [ ] Kiểm tra baked light trong build.
- [ ] Chụp screenshot môi trường.

## CONT

- [ ] Final content proofread.
- [ ] Final references.
- [ ] Asset licenses.
- [ ] Image credits.
- [ ] Audio credits.
- [ ] Font credits.
- [ ] Nội dung báo cáo.
- [ ] Chuẩn bị câu hỏi về tính chính xác văn hóa.

## UITEST

- [ ] Full regression.
- [ ] Known Issues.
- [ ] README.
- [ ] Screenshot.
- [ ] Video demo 3–5 phút.
- [ ] Hỗ trợ slide.
- [ ] Video offline backup.

---

# 8. RELEASE REGRESSION CHECKLIST

- [ ] `.exe` mở được.
- [ ] Main Menu hoạt động.
- [ ] Start hoạt động.
- [ ] Instructions hoạt động.
- [ ] About hoạt động.
- [ ] Settings hoạt động.
- [ ] Exit hoạt động.
- [ ] WASD hoạt động.
- [ ] Mouse look hoạt động.
- [ ] Không xuyên tường.
- [ ] Không rơi khỏi map.
- [ ] Không mắc kẹt.
- [ ] Exhibit 01 hoạt động.
- [ ] Exhibit 02 hoạt động.
- [ ] Exhibit 03 hoạt động.
- [ ] Exhibit 04 hoạt động.
- [ ] Exhibit 05 hoạt động.
- [ ] Exhibit 06 hoạt động.
- [ ] Information Panel đúng.
- [ ] Viewer rotate.
- [ ] Viewer zoom.
- [ ] Viewer close.
- [ ] Audio không chồng.
- [ ] Volume hoạt động.
- [ ] Pause.
- [ ] Resume.
- [ ] Return Menu.
- [ ] Quiz đủ 5 câu.
- [ ] Quiz score đúng.
- [ ] Replay Quiz.
- [ ] Result.
- [ ] UI không overflow.
- [ ] Chơi 20 phút không crash.
- [ ] FPS trung bình ≥ 45 trên máy mục tiêu.

---

# 9. DOCUMENTATION CHECKLIST

- [ ] Windows build.
- [ ] Unity source.
- [ ] README.
- [ ] Báo cáo.
- [ ] Slide.
- [ ] Video demo.
- [ ] Screenshot/poster.
- [ ] References.
- [ ] Asset license list.
- [ ] Known issues.
- [ ] Git repository sạch.
- [ ] Backup cloud.
- [ ] Backup USB.

---

# 10. BẢNG THEO DÕI THÀNH VIÊN

## GP

- **Task hiện tại:** `________________________________`
- **Branch:** `______________________________________`
- **Trạng thái:** `[ ] / [-] / [x] / [!]`
- **Blocker:** `_____________________________________`
- **ETA:** `_________________________________________`

## ENV

- **Task hiện tại:** `________________________________`
- **Branch:** `______________________________________`
- **Trạng thái:** `[ ] / [-] / [x] / [!]`
- **Blocker:** `_____________________________________`
- **ETA:** `_________________________________________`

## CONT

- **Task hiện tại:** `________________________________`
- **Branch:** `______________________________________`
- **Trạng thái:** `[ ] / [-] / [x] / [!]`
- **Blocker:** `_____________________________________`
- **ETA:** `_________________________________________`

## UITEST

- **Task hiện tại:** `________________________________`
- **Branch:** `______________________________________`
- **Trạng thái:** `[ ] / [-] / [x] / [!]`
- **Blocker:** `_____________________________________`
- **ETA:** `_________________________________________`

---

# 11. DAILY STANDUP

Sao chép phần này cho mỗi ngày.

## Ngày ____ / ____ / ______

### GP

- **Hôm qua:** `_____________________________________`
- **Hôm nay:** `_____________________________________`
- **Blocker:** `_____________________________________`

### ENV

- **Hôm qua:** `_____________________________________`
- **Hôm nay:** `_____________________________________`
- **Blocker:** `_____________________________________`

### CONT

- **Hôm qua:** `_____________________________________`
- **Hôm nay:** `_____________________________________`
- **Blocker:** `_____________________________________`

### UITEST

- **Hôm qua:** `_____________________________________`
- **Hôm nay:** `_____________________________________`
- **Blocker:** `_____________________________________`

### Integration cần thực hiện

`___________________________________________________`

### Quyết định của nhóm

`___________________________________________________`

---

# 12. BUG TRACKER

## BUG-001

- **Severity:** `P0 / P1 / P2 / P3`
- **Build:** `________________`
- **Người phát hiện:** `________________`
- **Module:** `________________`
- **Mô tả:** `________________________________________`
- **Cách tái hiện:** `________________________________`
- **Người xử lý:** `________________`
- **Branch:** `________________`
- **Status:** `Open / Fixing / Verify / Closed`

## BUG-002

- **Severity:** `P0 / P1 / P2 / P3`
- **Build:** `________________`
- **Người phát hiện:** `________________`
- **Module:** `________________`
- **Mô tả:** `________________________________________`
- **Cách tái hiện:** `________________________________`
- **Người xử lý:** `________________`
- **Branch:** `________________`
- **Status:** `Open / Fixing / Verify / Closed`

---

# 13. BUILD LOG

## Build 01

- **Tên:** `Prototype_v0.1`
- **Ngày:** `____________`
- **Commit:** `____________`
- **Tag:** `____________`
- **Máy test:** `____________`
- **FPS:** `____________`
- **P0/P1:** `____________`
- **Kết quả:** `PASS / FAIL`

## Build 02

- **Tên:** `Alpha_v0.1`
- **Ngày:** `____________`
- **Commit:** `____________`
- **Tag:** `____________`
- **Máy test:** `____________`
- **FPS:** `____________`
- **P0/P1:** `____________`
- **Kết quả:** `PASS / FAIL`

## Build 03

- **Tên:** `Beta_v0.5`
- **Ngày:** `____________`
- **Commit:** `____________`
- **Tag:** `____________`
- **Máy test:** `____________`
- **FPS:** `____________`
- **P0/P1:** `____________`
- **Kết quả:** `PASS / FAIL`

## Build 04

- **Tên:** `Release_v1.0`
- **Ngày:** `____________`
- **Commit:** `____________`
- **Tag:** `____________`
- **Máy test:** `____________`
- **FPS:** `____________`
- **P0/P1:** `0 / 0`
- **Kết quả:** `READY / NOT READY`

---

# 14. RISK TRACKER

| Rủi ro | Mức độ | Owner | Trạng thái | Hướng xử lý |
|---|---|---|---|---|
| Git/scene conflict | Cao | GP | `[ ]` | Scene ownership + prefab + branch |
| Asset trang phục khó tìm | Cao | CONT | `[ ]` | Asset có license + mannequin + ảnh |
| Nội dung chưa xác minh | Rất cao | CONT | `[ ]` | Review nguồn/người am hiểu |
| FPS thấp | Cao | ENV | `[ ]` | Profiler + bake + optimize |
| UI khó đọc | Trung bình | UITEST | `[ ]` | Multi-resolution test |
| Integration lỗi | Cao | GP | `[ ]` | Merge sớm + milestone build |
| Scope creep | Cao | Cả nhóm | `[ ]` | MVP first + feature freeze |
| Thành viên trễ task | Cao | Cả nhóm | `[ ]` | Hỗ trợ task blocker |
| Máy demo lỗi | Cao | GP/UITEST | `[ ]` | Test máy trình chiếu + video backup |

---

# 15. QUY TẮC KHI CHẬM TIẾN ĐỘ

Nếu milestone chậm:

1. Không nhận feature mới.
2. Tất cả thành viên ưu tiên blocker của luồng chính.
3. P0 → P1 → performance → P2 → polish.
4. Dừng tính năng mở rộng.
5. Giảm prop/trang trí.
6. Giảm post-processing.
7. Giảm độ chi tiết model/texture.
8. Dùng asset phù hợp thay vì tự dựng nếu cần.
9. Giữ 3 khu + 6 hiện vật.
10. Ghi rõ scope bị cắt trong milestone review.

Không cắt:

- Kiểm chứng nội dung.
- Nguồn/license.
- Interaction.
- Information Panel.
- Quiz.
- Build test.
- Backup.
- Hồ sơ bảo vệ.

---

# 16. TÌNH TRẠNG DỰ ÁN HIỆN TẠI

Dựa trên trạng thái đã có trước khi chuyển kế hoạch sang nhóm 4 người:

### Đã hoàn thành

- [x] Chọn Unity/render pipeline.
- [x] Tạo project.
- [x] Project mở/chạy được.
- [x] Tạo Git repository.
- [x] `.gitignore`.
- [x] `main`.
- [x] `develop`.
- [x] `Assets/_Project`.
- [x] `Bootstrap`.
- [x] `MainMenu`.
- [x] `Museum`.
- [x] Bảng quản lý task.

### Cần thực hiện tiếp

**ENV**
- [ ] Layout bảo tàng.
- [ ] Scale/kích thước.
- [ ] Vị trí hiện vật.
- [ ] Chốt environment asset.

**CONT**
- [ ] Chốt 6 hiện vật.
- [ ] Nguồn.
- [ ] Model/mannequin.
- [ ] Hồ sơ license.

**UITEST**
- [ ] Wireframe.
- [ ] UI structure.
- [ ] Test template.

**GP**
- [ ] Xác nhận project hoạt động trên máy các thành viên.
- [ ] Thống nhất Git workflow.
- [ ] Bắt đầu Player Controller.

---

# 17. VIỆC NHÓM NÊN LÀM NGAY

### GP

`PlayerController + Interaction prototype`

### ENV

`Hoàn thành layout và blockout bảo tàng`

### CONT

`Chốt danh sách 6 hiện vật + nguồn + asset`

### UITEST

`Wireframe + Main Menu + Information Panel`

Bốn phần này có thể được thực hiện **song song**. Khi hoàn thành, nhóm tích hợp thành `Prototype_v0.1`.

---

# 18. DEFINITION OF RELEASE READY

Chỉ đánh dấu dự án **READY** khi:

- [ ] 3/3 khu hoàn chỉnh.
- [ ] 6/6 hiện vật hoàn chỉnh.
- [ ] 6/6 interaction đúng.
- [ ] Viewer hoạt động.
- [ ] Audio hoạt động.
- [ ] Quiz hoạt động.
- [ ] Không có P0.
- [ ] Không có P1.
- [ ] FPS trung bình ≥ 45 trên máy mục tiêu.
- [ ] Nội dung đã review.
- [ ] References/license đầy đủ.
- [ ] Build chạy trên máy trình chiếu.
- [ ] README hoàn thành.
- [ ] Báo cáo hoàn thành.
- [ ] Slide hoàn thành.
- [ ] Video demo hoàn thành.
- [ ] Backup USB.
- [ ] Backup cloud.
- [ ] Nhóm đã diễn tập demo/bảo vệ.
