# SPEC DỰ ÁN UNITY — BẢO TÀNG ẢO TRANG PHỤC TRUYỀN THỐNG TÂY NGUYÊN

## 1. Thông tin chung

- **Tên đề tài:** Mô phỏng bảo tàng trưng bày trang phục truyền thống của đồng bào Tây Nguyên.
- **Loại dự án:** Ứng dụng bảo tàng ảo 3D xây dựng bằng Unity.
- **Nhân sự:** 4 thành viên.
- **Thời gian thực hiện:** 4 tuần, khoảng 20 ngày làm việc chính; cuối tuần dùng làm thời gian dự phòng.
- **Nền tảng mục tiêu:** PC Windows.
- **Điều khiển chính:** Bàn phím + chuột.
- **Công cụ:** Unity LTS, Blender, Git/GitHub, Photoshop/GIMP/Krita, Audacity và Trello/Notion/GitHub Projects.
- **Sản phẩm cuối:** Ứng dụng bảo tàng ảo chạy độc lập, cho phép người dùng tham quan không gian 3D, tương tác với trang phục, đọc/nghe thông tin và thực hiện bài trắc nghiệm cuối hành trình.

> Dự án tập trung vào một trải nghiệm bảo tàng ảo 3D có thể hoàn thành tốt trong 1 tháng bởi nhóm 4 người. Phạm vi văn hóa được giới hạn có chủ đích và không đại diện đầy đủ cho toàn bộ các cộng đồng tại Tây Nguyên.

---

## 2. Mục tiêu dự án

### 2.1. Mục tiêu chính

Xây dựng một bảo tàng ảo 3D giới thiệu trang phục truyền thống của một số cộng đồng tại Tây Nguyên theo hướng trực quan, dễ sử dụng và có nguồn nội dung rõ ràng.

Người dùng có thể:

- Đi lại tự do trong bảo tàng.
- Tham quan tối thiểu 3 khu trưng bày.
- Tương tác với tối thiểu 6 hiện vật.
- Đọc thông tin chi tiết của từng hiện vật.
- Xem mô hình trang phục ở chế độ riêng, xoay và phóng to/thu nhỏ.
- Nghe thuyết minh tại các điểm trưng bày.
- Xem sơ đồ hoặc biển chỉ dẫn.
- Hoàn thành bài quiz 5 câu cuối hành trình.
- Tạm dừng, chỉnh âm lượng/độ nhạy và quay lại menu.

### 2.2. Mục tiêu học thuật

- Vận dụng Unity trong xây dựng môi trường 3D.
- Xây dựng hệ thống gameplay và tương tác cơ bản.
- Thực hành quy trình làm dự án Unity theo nhóm bằng Git/GitHub.
- Tổ chức dữ liệu hiện vật tách biệt khỏi UI bằng ScriptableObject hoặc giải pháp tương đương.
- Áp dụng quy trình tìm kiếm, kiểm tra và trích dẫn dữ liệu văn hóa.
- Thực hiện kiểm thử, profiling và tối ưu một ứng dụng 3D.
- Hoàn thiện build, báo cáo, slide và video demo.

### 2.3. Tiêu chí thành công

Dự án được xem là hoàn thành khi:

1. Có build Windows chạy độc lập không cần Unity Editor.
2. Hoàn thành được luồng `Main Menu → Museum → 3 khu → Quiz → Result`.
3. Có ít nhất 3 khu và 6 hiện vật.
4. Cả 6 hiện vật đều tương tác được.
5. Mỗi hiện vật có tên, cộng đồng liên quan, mô tả, hình ảnh/mô hình và nguồn.
6. Có chế độ xem 3D xoay/zoom.
7. Có tối thiểu 3 đoạn audio guide dài khoảng 30–60 giây.
8. Quiz có 5 câu và tính điểm chính xác.
9. Không còn lỗi P0/P1 trước release.
10. Mục tiêu hiệu năng là 60 FPS; ngưỡng nghiệm thu tối thiểu trung bình 45 FPS trên máy mục tiêu.
11. Có báo cáo, slide, README và video demo 3–5 phút.

---

## 3. Phạm vi dự án

### 3.1. MVP bắt buộc

#### A. Main Menu

Bao gồm:

- Bắt đầu tham quan.
- Hướng dẫn.
- Giới thiệu.
- Cài đặt.
- Thoát.

#### B. Không gian bảo tàng

Gồm:

- Sảnh chính.
- Khu Ê Đê.
- Khu Ba Na.
- Khu Gia Rai.
- Khu Quiz/Kết thúc.

Mỗi khu trưng bày chính có tối thiểu:

- 2 hiện vật.
- Biển tên khu.
- Nội dung giới thiệu chung.
- Bục/tủ hoặc không gian trưng bày.
- Điểm tương tác/thuyết minh phù hợp.

#### C. Player Controller

- Di chuyển WASD.
- Điều khiển góc nhìn bằng chuột.
- Collision.
- Không thể đi xuyên tường hoặc rơi khỏi map trong luồng bình thường.
- Khóa/mở cursor phù hợp với trạng thái.
- Có thể thay đổi độ nhạy chuột.

#### D. Interaction System

Người chơi nhìn vào đối tượng tương tác trong khoảng cách quy định.

Hệ thống:

1. Raycast từ camera.
2. Phát hiện đối tượng có thể tương tác.
3. Hiển thị prompt, ví dụ `Nhấn E để xem`.
4. Nhấn `E`.
5. Đối tượng thực hiện hành vi tương ứng.

Hệ thống nên dùng interface/base component chung để có thể mở rộng cho:

- Exhibit.
- Audio point.
- Quiz.
- Door hoặc đối tượng khác nếu cần.

#### E. Exhibit System

Mỗi hiện vật có dữ liệu độc lập, đề xuất sử dụng `ExhibitData : ScriptableObject`.

Thông tin có thể gồm:

- ID.
- Tên hiện vật.
- Cộng đồng/dân tộc liên quan.
- Mô tả ngắn.
- Nội dung chi tiết.
- Chất liệu.
- Hoàn cảnh sử dụng.
- Địa bàn/giai đoạn nếu nguồn có nêu.
- Hình ảnh.
- Prefab/model 3D.
- Audio guide.
- Nguồn tham khảo.
- Thông tin giấy phép asset/hình ảnh.

Không hard-code nội dung của từng hiện vật trực tiếp vào script UI.

#### F. Exhibit Information UI

Khi tương tác:

- Mở panel thông tin.
- Hiển thị tên.
- Hình ảnh.
- Nội dung.
- Nguồn.
- Nút nghe thuyết minh nếu có.
- Nút xem mô hình 3D.
- Nút đóng.

Khi panel mở, gameplay phải được khóa phù hợp.

#### G. Exhibit Viewer

Cho phép:

- Hiển thị mô hình riêng.
- Kéo chuột để xoay.
- Scroll để zoom.
- Giới hạn khoảng zoom.
- Đóng viewer và quay lại gameplay.
- Không làm thay đổi transform của hiện vật gốc trong bảo tàng.

#### H. Audio System

Bao gồm:

- BGM nhẹ.
- Ambient sound.
- UI SFX.
- Interaction SFX.
- Voice-over/audio guide.

Yêu cầu:

- Không phát nhiều voice-over chồng nhau.
- Có thể dừng audio.
- Điều chỉnh âm lượng.
- Tối thiểu 3 đoạn thuyết minh chính thức.

#### I. Quiz

- 5 câu hỏi.
- Mỗi câu có các đáp án lựa chọn.
- Một đáp án đúng.
- Chuyển câu.
- Tính điểm.
- Màn hình kết quả.
- Chơi lại.
- Quay về bảo tàng/menu.

Nội dung câu hỏi chỉ lấy từ những kiến thức đã xuất hiện trong trải nghiệm.

#### J. Pause & Settings

Pause Menu:

- Tiếp tục.
- Cài đặt.
- Quay về menu.

Settings:

- Master Volume.
- Music.
- SFX/Voice nếu nhóm có thời gian tách mixer.
- Mouse sensitivity.
- Graphics quality nếu cần.

#### K. Navigation

- Sơ đồ bảo tàng hoặc bảng định hướng.
- Biển tên rõ cho từng khu.
- Khu Quiz dễ nhận biết.
- Người dùng mới phải có khả năng tự tìm đường mà không cần thành viên nhóm hướng dẫn trực tiếp.

---

## 4. Tính năng mở rộng

Chỉ triển khai sau khi MVP ổn định:

- Khu thứ 4 – M’nông.
- Chế độ VR thực tế.
- Song ngữ Việt–Anh.
- Phụ đề audio guide.
- Hệ thống thu thập/con dấu.
- Nhân vật hướng dẫn.
- Video quy trình dệt.
- Mini-game ghép họa tiết.
- Hiệu ứng chuyển cảnh nâng cao.

Các tính năng này không được làm ảnh hưởng deadline của MVP.

---

## 5. Ngoài phạm vi

Trong 1 tháng không đặt mục tiêu:

- Multiplayer.
- Backend/server.
- Tài khoản người dùng.
- Database online.
- Cloth simulation chất lượng cao realtime.
- Tái tạo bảo tàng thực tế 1:1.
- Xây dựng trang phục của toàn bộ cộng đồng Tây Nguyên.
- Phát hành đồng thời Windows, WebGL và mobile.

---

## 6. Thiết kế trải nghiệm

### 6.1. User Flow

```text
Launch
  ↓
Main Menu
  ↓
Bắt đầu
  ↓
Sảnh chính
  ↓
Hướng dẫn + sơ đồ
  ↓
Khu Ê Đê ──→ Exhibit Interaction
  ↓
Khu Ba Na ─→ Exhibit Interaction
  ↓
Khu Gia Rai → Exhibit Interaction
  ↓
Quiz
  ↓
Result
  ↓
Tiếp tục tham quan / Main Menu
```

Người dùng không bắt buộc phải tham quan ba khu theo thứ tự nếu thiết kế mặt bằng cho phép tự do khám phá.

### 6.2. Bản vẽ sơ lược mặt bằng

Sơ đồ dưới đây là bản phác thảo định hướng để nhóm dựng blockout trong Unity. Kích thước thực tế có thể điều chỉnh khi test di chuyển, nhưng nên giữ cấu trúc: sảnh trung tâm, ba khu trưng bày rõ ràng và khu quiz ở cuối hành trình.

```text
+--------------------------------------------------------------------------------+
|                                BAO TANG AO 3D                                  |
|                                                                                |
|  +----------------------+      +----------------------+      +----------------+ |
|  |      KHU E DE        |      |      KHU BA NA       |      |   KHU GIA RAI | |
|  |                      |      |                      |      |                | |
|  |  [H1]      [H2]      |      |  [H3]      [H4]      |      | [H5]    [H6]  | |
|  |  Bia gioi thieu     |      |  Bia gioi thieu     |      | Bia gioi thieu| |
|  |  Audio guide         |      |  Audio guide         |      | Audio guide    | |
|  +----------+-----------+      +----------+-----------+      +--------+-------+ |
|             |                             |                           |         |
|             +-------------+---------------+---------------+-----------+         |
|                           |                               |                     |
|                    +------+-------------------------------+------+              |
|                    |              SANH CHINH                     |              |
|                    |                                             |              |
|                    |  Ten du an + gioi thieu ngan                |              |
|                    |  So do bao tang + huong dan dieu khien      |              |
|                    |  Bien chi dan den 3 khu trung bay           |              |
|                    +------+-------------------------------+------+              |
|                           |                               |                     |
|                           |                               |                     |
|                    +------+-------------------------------+------+              |
|                    |              KHU QUIZ / KET THUC            |              |
|                    |  5 cau hoi  ->  Man hinh ket qua            |              |
|                    |  Loi cam on + tai lieu tham khao            |              |
|                    +---------------------------------------------+              |
|                                                                                |
+--------------------------------------------------------------------------------+

Chu thich:
[H1]..[H6] = 6 hien vat trang phuc, moi hien vat co model/anh, bang thong tin,
nguon tham khao va nut xem 3D/audio neu co.
```

### 6.3. Luồng di chuyển trong mặt bằng

```text
Main Menu
   ↓
Sanh chinh
   ├── Khu E De ── xem H1, H2 ── nghe audio
   ├── Khu Ba Na ─ xem H3, H4 ── nghe audio
   └── Khu Gia Rai xem H5, H6 ── nghe audio
   ↓
Khu Quiz
   ↓
Result / Quay lai bao tang / Main Menu
```

### 6.4. Phong cách hình ảnh

- Không gian sạch và dễ quan sát.
- Màu môi trường tương đối trung tính để trang phục nổi bật.
- Ánh sáng ấm, dịu.
- Hạn chế post-processing quá mạnh.
- Các khu phân biệt chủ yếu bằng biển tên, bố cục và nội dung.
- Không tùy tiện gán màu/họa tiết mang ý nghĩa văn hóa khi chưa có nguồn.
- UI có độ tương phản cao và đọc được ở khoảng cách sử dụng thông thường.

---

## 7. Phân công nhóm 4 người

### Thành viên 1 — Gameplay & Integration Lead (GP)

**Trách nhiệm chính:**

- Unity project architecture.
- Player Controller.
- Interaction System.
- Exhibit Viewer.
- GameManager.
- Settings.
- Scene integration.
- Build.
- Git integration và xử lý conflict kỹ thuật.

**Module phụ trách:**

```text
Scripts/
├── Core/
├── Player/
└── Interaction/
```

Thành viên 1 chịu trách nhiệm đảm bảo các hệ thống của các thành viên khác được tích hợp thành một build chạy được.

### Thành viên 2 — Environment & Optimization (ENV)

**Trách nhiệm:**

- Layout bảo tàng.
- Blockout.
- Sảnh.
- 3 khu trưng bày.
- Bục/tủ kính.
- Material môi trường.
- Lighting.
- Light baking.
- Collider.
- Occlusion/LOD.
- Profiling và tối ưu môi trường.

Ưu tiên asset modular/free có giấy phép phù hợp thay vì tự dựng toàn bộ kiến trúc.

### Thành viên 3 — Exhibit 3D & Cultural Content (CONT)

**Trách nhiệm:**

- Nghiên cứu nội dung.
- Chọn 6 hiện vật.
- Thu thập nguồn.
- Tìm/chuẩn hóa model trang phục và mannequin.
- Texture/material của hiện vật.
- Viết nội dung bảng thông tin.
- Kịch bản voice-over.
- Credits và danh mục nguồn.
- Kiểm tra quyền sử dụng asset.

Mỗi hiện vật phải có hồ sơ nguồn trước khi nội dung được khóa.

### Thành viên 4 — UI/UX, Audio, Quiz & QA (UITEST)

**Trách nhiệm:**

- Main Menu.
- Pause Menu.
- Information Panel.
- Settings UI.
- Quiz UI.
- Result Screen.
- Interaction prompt.
- Audio/SFX/voice processing.
- Test case.
- Bug report.
- User test.
- Hỗ trợ README/video/slide.

### 7.1. Trách nhiệm chung

Cả 4 thành viên:

- Pull trước khi bắt đầu làm.
- Làm trên branch riêng.
- Không sửa file/scene người khác đang giữ nếu chưa trao đổi.
- Commit rõ ràng.
- Review build cuối tuần.
- Test phần mình làm trước khi merge.
- Hỗ trợ regression test trước release.

---

## 8. Chiến lược tránh conflict Unity

Scene và prefab nhị phân/serialized là nguồn conflict lớn, vì vậy phân quyền asset rõ ràng.

Đề xuất:

```text
GP      → Bootstrap, gameplay prefabs, scripts
ENV     → Museum scene + environment prefabs
CONT    → Exhibit prefabs/data/content
UITEST  → MainMenu + UI prefabs + quiz assets
```

Không để hai người đồng thời chỉnh cùng một scene/prefab lớn.

Ưu tiên prefab hóa:

- Exhibit.
- Display case.
- UI.
- Interaction point.
- Sign.
- Quiz components.

Khi cần tích hợp vào `Museum`, ENV hoặc GP làm người tích hợp theo thời điểm đã thống nhất.

---

## 9. Kiến trúc kỹ thuật

### 9.1. Scene

```text
Bootstrap
MainMenu
Museum
```

`Bootstrap`:

- Khởi tạo manager cần tồn tại.
- Load configuration.

`MainMenu`:

- Main menu.
- Instructions.
- About/Credits.
- Settings.

`Museum`:

- Player.
- Environment.
- Exhibits.
- Navigation.
- Quiz area.

Giữ bảo tàng trong một scene nếu hiệu năng cho phép.

### 9.2. Module

```text
GameManager
├── PlayerController
├── InteractionController
├── UIManager
├── AudioManager
├── SettingsManager
└── QuizManager

Exhibit
├── ExhibitData
├── ExhibitInteractable
└── ExhibitViewer
```

### 9.3. Cấu trúc Assets

```text
Assets/
├── _Project/
│   ├── Art/
│   │   ├── Costumes/
│   │   ├── Environment/
│   │   ├── Materials/
│   │   └── Textures/
│   ├── Audio/
│   │   ├── Music/
│   │   ├── SFX/
│   │   └── VoiceOver/
│   ├── Data/
│   │   ├── Exhibits/
│   │   └── Quiz/
│   ├── Prefabs/
│   │   ├── Environment/
│   │   ├── Exhibits/
│   │   └── UI/
│   ├── Scenes/
│   ├── Scripts/
│   │   ├── Core/
│   │   ├── Interaction/
│   │   ├── Player/
│   │   ├── Quiz/
│   │   └── UI/
│   └── UI/
├── ThirdParty/
└── Plugins/
```

---

## 10. Quy tắc đặt tên

- Static Mesh: `SM_Name`
- Skinned Mesh: `SK_Name`
- Material: `M_Name`
- Texture: `T_Name_Type`
- Prefab: `PF_Name`
- ScriptableObject: `SO_Name`
- Audio Voice: `VO_Name`
- SFX: `SFX_Name`
- BGM: `BGM_Name`
- Scene: `SC_Name` nếu nhóm muốn áp dụng prefix nhất quán.
- Script: PascalCase và trùng tên class.

Không dùng tên kiểu `final`, `final2`, `new`, `test123`.

---

## 11. Git Workflow

### 11.1. Branch

```text
main
└── develop
    ├── feature/player-controller
    ├── feature/exhibit-system
    ├── feature/environment
    ├── feature/ui
    ├── feature/quiz
    └── fix/...
```

### 11.2. Quy trình

```text
git checkout develop
git pull
↓
tạo feature branch
↓
thực hiện task
↓
test
↓
commit
↓
push
↓
merge/pull request vào develop
↓
integration test
↓
milestone ổn định → main
```

### 11.3. Commit convention

Ví dụ:

```text
feat: add player interaction
feat: add exhibit viewer
art: add museum display cabinet
content: add Ede exhibit data
ui: add quiz result panel
fix: prevent player falling through floor
perf: optimize museum lighting
docs: update project progress
```

Không commit:

```text
Library/
Temp/
Logs/
Obj/
Build/
```

---

## 12. Kế hoạch 4 tuần

### Tuần 1 — Prototype

**Mục tiêu:** Có bảo tàng blockout và một luồng tương tác hoàn chỉnh.

**GP**
- Project architecture.
- Player movement/camera.
- Interaction.
- Pause.
- Exhibit prototype.

**ENV**
- Layout.
- Blockout sảnh + 3 khu + quiz.
- Collider.
- Display case prototype.

**CONT**
- Chọn 6 hiện vật.
- Thu thập nguồn.
- Chuẩn bị exhibit mẫu.
- Tìm asset/mannequin.

**UITEST**
- Wireframe.
- Main Menu.
- Information Panel.
- Interaction prompt.
- Test template.

**Cuối tuần:**

`Prototype_v0.1`

Điều kiện:
- Menu → Museum hoạt động.
- Đi lại được.
- 3 khu đã blockout.
- 1 hiện vật tương tác hoàn chỉnh.

### Tuần 2 — Alpha

**GP**
- `ExhibitData`.
- Viewer.
- Audio integration.
- Settings integration.
- Quiz integration.

**ENV**
- Hoàn thiện cấu trúc 3 khu.
- Display area.
- Signs.
- Lighting pass 1.

**CONT**
- Hoàn thành 6 hiện vật.
- Nội dung nháp.
- Material/texture.
- Voice-over script.

**UITEST**
- UI đầy đủ.
- Quiz 5 câu.
- Settings UI.
- Audio prototype.

**Cuối tuần:**

`Alpha_v0.1`

Điều kiện:
- 3 khu.
- 6 hiện vật.
- Viewer.
- Audio prototype.
- Quiz.
- End-to-end flow.

### Tuần 3 — Beta

**GP**
- Sửa P0/P1.
- Polish interaction.
- State handling.

**ENV**
- Material.
- Lighting.
- Bake.
- Optimization.

**CONT**
- Xác minh nội dung.
- Hoàn thiện nguồn.
- Khóa nội dung.
- Chuẩn hóa 6 hiện vật.

**UITEST**
- Voice-over chính thức.
- Audio polish.
- Responsive UI.
- User test 3–5 người.

**Cuối tuần:**

`Beta_v0.5`

Sau Beta: **Feature Freeze**.

### Tuần 4 — Release

Cả nhóm ưu tiên:

1. P0.
2. P1.
3. Performance.
4. Regression.
5. Documentation.
6. Presentation.

Các mốc:

- `ReleaseCandidate_v0.9`
- `Release_v1.0`

---

## 13. Quy trình nội dung văn hóa

### 13.1. Nguồn ưu tiên

1. Bảo tàng/cơ quan văn hóa/thư viện.
2. Sách và nghiên cứu học thuật.
3. Tài liệu từ cộng đồng/nghệ nhân có thông tin rõ.
4. Báo chí uy tín.
5. Blog/mạng xã hội chỉ dùng để tìm đầu mối.

### 13.2. Hồ sơ hiện vật

Mỗi hiện vật cần lưu:

- ID.
- Tên.
- Cộng đồng liên quan.
- Đối tượng sử dụng nếu nguồn nêu.
- Chất liệu.
- Kỹ thuật.
- Hoàn cảnh sử dụng.
- Địa bàn/giai đoạn.
- Mô tả.
- Nguồn văn bản.
- Nguồn hình.
- Nguồn model.
- License.
- Ngày truy cập.
- Trạng thái kiểm duyệt.

### 13.3. Nguyên tắc

Không:

- Tự suy diễn ý nghĩa màu sắc/họa tiết.
- Trộn biểu tượng của các cộng đồng để trang trí tùy ý.
- Dùng asset không rõ license.
- Khẳng định một biến thể trang phục đại diện cho toàn bộ cộng đồng.

Nếu không xác minh được thông tin, sử dụng mô tả trung tính hoặc loại bỏ.

---

## 14. Kiểm thử

### 14.1. Mức lỗi

**P0 — Blocker**
- Crash.
- Không mở game.
- Scene lỗi.
- Không thể tiếp tục trải nghiệm.

**P1 — Critical**
- Player mắc kẹt.
- Interaction không hoạt động.
- Quiz không hoàn thành.
- Audio lỗi nghiêm trọng.

**P2 — Medium**
- UI lệch.
- Material/lighting lỗi.
- Chính tả.
- Animation không mượt.

**P3 — Minor**
- Lỗi thẩm mỹ nhỏ.

### 14.2. Regression Test

Trước release phải kiểm tra:

- Build mở được.
- Menu hoạt động.
- Player movement đúng.
- Không xuyên tường/rơi.
- 6/6 exhibit tương tác.
- Information Panel đúng.
- Viewer xoay/zoom.
- Audio không chồng.
- Volume hoạt động.
- Pause/resume đúng.
- Quiz tính điểm đúng.
- Restart quiz đúng.
- Return menu đúng.
- UI không tràn.
- Chơi 20 phút không crash.

---

## 15. Performance Budget

Mục tiêu:

- 60 FPS.
- Tối thiểu trung bình 45 FPS trên máy mục tiêu.

Nguyên tắc:

- Texture chủ yếu 1K–2K.
- 4K chỉ khi thật sự cần.
- Baked lighting ưu tiên.
- Hạn chế realtime light.
- Collider đơn giản.
- LOD với mesh nặng nếu cần.
- Occlusion Culling khi có lợi.
- Nén audio.
- Dùng Unity Profiler trước khi quyết định giảm chất lượng.

---

## 16. Quản lý rủi ro

### Conflict Git

**Giải pháp:** chia quyền scene/prefab, branch riêng, pull thường xuyên và prefab hóa.

### Asset trang phục khó tìm

**Giải pháp:** mannequin + asset có license + hình ảnh tư liệu; không đặt mục tiêu tự dựng tất cả.

### Nội dung văn hóa sai

**Giải pháp:** lưu nguồn ngay từ đầu và review với giảng viên/người am hiểu trước khi khóa nội dung.

### Scope creep

**Giải pháp:** tính năng mới đưa vào backlog; feature freeze sau Beta.

### Hiệu năng thấp

**Giải pháp:** profiling, baked light, giảm mesh/texture và kiểm tra từ tuần 2.

### Thành viên trễ task

Task chặn luồng được ưu tiên hỗ trợ chéo. Không để một thành viên tiếp tục làm polish trong khi module quan trọng của nhóm đang bị blocker.

### Mất dữ liệu

- GitHub.
- Backup cloud.
- Build milestone.
- Không lưu duy nhất trên một máy.

---

## 17. Definition of Done cho một task

Task chỉ được coi là hoàn thành khi:

1. Chức năng/nội dung đã làm xong.
2. Đã tự test.
3. Không có lỗi rõ ràng.
4. Asset đúng thư mục/tên.
5. Không có reference mất.
6. Commit và push.
7. Nếu ảnh hưởng module khác, đã integration test.
8. `project_progress.md` được cập nhật.

---

## 18. Milestone

### M0 — Setup
Project + Git + layout + nội dung sơ bộ.

### M1 — Prototype v0.1
Đi lại + blockout + một exhibit.

### M2 — Alpha v0.1
Toàn bộ MVP chạy end-to-end.

### M3 — Beta v0.5
Nội dung/đồ họa/audio gần hoàn thiện + user test.

### M4 — Release v1.0
Build ổn định + tài liệu + video + slide.

---

## 19. Bàn giao

```text
MuseumTayNguyen/
├── Build/
│   └── MuseumTayNguyen_v1.0_Windows/
├── Source/
├── Documentation/
│   ├── Report
│   ├── README
│   ├── References
│   └── KnownIssues
├── Presentation/
├── Screenshots/
└── DemoVideo/
```

Bắt buộc có:

- Windows build.
- Unity source.
- README.
- Báo cáo.
- Slide.
- Video 3–5 phút.
- Screenshot/poster.
- References.
- Asset licenses.
- Known issues nếu còn.

---

## 20. Kịch bản demo/bảo vệ

Đề xuất 8–10 phút:

1. **1 phút:** Giới thiệu đề tài.
2. **1 phút:** Mục tiêu và phạm vi.
3. **1–2 phút:** Kiến trúc và cách nhóm 4 người thực hiện.
4. **3–4 phút:** Demo.
5. **1 phút:** Nội dung văn hóa/nguồn.
6. **1 phút:** Kết quả, hạn chế và hướng phát triển.

Demo ưu tiên:

```text
Main Menu
→ Museum
→ Di chuyển
→ Một exhibit
→ Information
→ 3D Viewer
→ Audio Guide
→ Quiz
→ Result
```

---

## 21. Nguyên tắc khi chậm tiến độ

Cắt giảm theo thứ tự:

1. Toàn bộ tính năng mở rộng.
2. Hiệu ứng trang trí.
3. Prop không quan trọng.
4. Post-processing.
5. Độ chi tiết model.
6. Số lượng audio vượt mức tối thiểu.

**Không cắt:**

- 3 khu.
- 6 hiện vật.
- Interaction cơ bản.
- Information Panel.
- Nội dung có nguồn.
- Quiz.
- Kiểm thử build.
- Hồ sơ bàn giao.

---

## 22. Kết luận phạm vi

Với nhóm 4 người trong 1 tháng, mục tiêu quan trọng nhất không phải tạo một bảo tàng cực lớn mà là tạo **một trải nghiệm nhỏ nhưng hoàn chỉnh**:

> **3 khu trưng bày + 6 hiện vật + gameplay tham quan + tương tác + thông tin văn hóa + 3D viewer + audio guide + quiz + build ổn định.**

Bốn thành viên làm song song theo module, tích hợp theo milestone hằng tuần và đóng băng tính năng sau Beta. `project_progress.md` là tài liệu vận hành hằng ngày và phải được cập nhật theo SPEC này.
