# PROJECT PROGRESS — BẢO TÀNG TRANG PHỤC TÂY NGUYÊN (LÀM MỘT MÌNH)

## 1. Cách sử dụng tài liệu

File này dùng để theo dõi tiến độ dự án trong 1 tháng do **một người** thực hiện. Cập nhật vào cuối mỗi ngày làm việc và tự review chính thức vào cuối mỗi milestone.

Quy ước trạng thái:

- `[ ]` Chưa bắt đầu.
- `[-]` Đang thực hiện.
- `[x]` Đã hoàn thành và được kiểm tra.
- `[!]` Đang bị chặn hoặc có rủi ro trễ.

Các mảng công việc (do cùng một người đảm nhiệm luân phiên):

- **GP:** Gameplay, tích hợp và build.
- **ENV:** Môi trường 3D, ánh sáng và tối ưu.
- **CONT:** Trang phục 3D, nghiên cứu và kiểm duyệt nội dung.
- **UITEST:** UI/UX, âm thanh, kiểm thử và hồ sơ.

Nguyên tắc cập nhật:

1. Chỉ đánh dấu `[x]` khi sản phẩm đã được tích hợp hoặc có minh chứng kiểm tra.
2. Task bị chặn quá một ngày phải chuyển thành `[!]` và ghi rõ nguyên nhân.
3. Không bắt đầu milestone tiếp theo nếu còn tiêu chí bắt buộc của milestone hiện tại chưa đạt, trừ khi tự ghi nhận ngoại lệ có lý do.
4. Tính năng mở rộng không được ưu tiên hơn task MVP.
5. Giữ WIP = 1: chỉ mở một hạng mục đang làm tại một thời điểm.
6. Cuối mỗi milestone phải tạo một bản build hoặc gói bàn giao có tên phiên bản rõ ràng.

## 2. Tổng quan milestone

### Milestone 0 — Khởi tạo dự án

- **Thời gian:** Ngày 1.
- **Mục tiêu:** Chốt phạm vi, công cụ, dữ liệu cần sản xuất và nền tảng làm việc.
- **Bản bàn giao:** Project Unity khởi tạo, repository Git, sơ đồ bảo tàng, danh sách 6 hiện vật và biểu mẫu ghi nguồn.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 1 — Prototype có thể chơi

- **Thời gian:** Ngày 2–5, kết thúc tuần 1.
- **Mục tiêu:** Người dùng vào được bảo tàng, đi lại và tương tác với một hiện vật mẫu.
- **Bản bàn giao:** `Prototype_v0.1`.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 2 — Alpha đầy đủ chức năng

- **Thời gian:** Ngày 6–10, kết thúc tuần 2.
- **Mục tiêu:** Hoàn thành toàn bộ luồng chức năng MVP với 3 khu và 6 hiện vật.
- **Bản bàn giao:** `Alpha_v0.1`.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 3 — Beta hoàn chỉnh nội dung

- **Thời gian:** Ngày 11–15, kết thúc tuần 3.
- **Mục tiêu:** Hoàn thiện hình ảnh, âm thanh, nội dung và kiểm thử với người ngoài.
- **Bản bàn giao:** `Beta_v0.5`.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 4 — Release và bảo vệ

- **Thời gian:** Ngày 16–20, kết thúc tuần 4.
- **Mục tiêu:** Sửa lỗi, tối ưu, đóng gói ứng dụng và hoàn thiện hồ sơ bảo vệ.
- **Bản bàn giao:** `Release_v1.0` cùng báo cáo, slide và video demo.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

---

## 3. Milestone 0 — Khởi tạo dự án

### Mục tiêu

Tạo nền tảng làm việc thống nhất để bắt đầu sản xuất mà không vướng về phiên bản, phạm vi hoặc định dạng dữ liệu.

### Checklist công việc

- [x] (GP) Chốt phiên bản Unity LTS và render pipeline.
- [x] (GP) Tạo project Unity và kiểm tra project mở/chạy được.
- [x] (GP) Tạo repository Git và `.gitignore` cho Unity.
- [x] (GP) Tạo các nhánh `main` và `develop`.
- [x] (GP) Tạo cấu trúc thư mục trong `Assets/_Project`.
- [x] (GP) Tạo các scene `Bootstrap`, `MainMenu` và `Museum`.
- [x] (GP) Tạo bảng quản lý task cá nhân (Trello/Notion/GitHub Projects).
- [ ] (ENV) Vẽ sơ đồ mặt bằng gồm sảnh, 3 khu trưng bày và khu quiz.
- [ ] (ENV) Xác định tỷ lệ, kích thước hành lang và vị trí hiện vật.
- [ ] (ENV) Chốt phong cách ánh sáng và hình ảnh tham chiếu.
- [ ] (CONT) Chọn 3 khu đại diện: Ê Đê, Ba Na và Gia Rai.
- [ ] (CONT) Lập danh sách sơ bộ 6 hiện vật.
- [ ] (CONT) Tạo biểu mẫu lưu nguồn, giấy phép và ngày truy cập.
- [ ] (CONT) Đánh giá độ khó khi dựng từng hiện vật và đánh dấu hiện vật dùng asset/ảnh có sẵn.
- [ ] (UITEST) Vẽ wireframe menu chính, bảng thông tin, chế độ xem 3D và quiz.
- [ ] (UITEST) Tạo bản nháp hướng dẫn điều khiển và mẫu test case/báo cáo bug.

### Điều kiện nghiệm thu

- [ ] Clone, mở và chạy được project.
- [ ] Không commit các thư mục cache như `Library`, `Temp`, `Logs`, `Obj`.
- [ ] Có sơ đồ bảo tàng 3 khu đã duyệt.
- [ ] Có danh sách 6 hiện vật khả thi và nguồn ban đầu.
- [ ] Có wireframe của tất cả màn hình chính.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Vấn đề còn lại:** `________________________________________`
- **Quyết định:** `____________________________________________`

---

## 4. Milestone 1 — Prototype có thể chơi

### Mục tiêu

Chứng minh luồng kỹ thuật cốt lõi: mở game, vào bảo tàng, di chuyển, nhìn, tương tác và xem thông tin hiện vật.

### Checklist công việc

- [ ] (GP) Hoàn thiện di chuyển bằng `WASD`.
- [ ] (GP) Hoàn thiện điều khiển camera bằng chuột.
- [ ] (GP) Thêm va chạm và giới hạn để người chơi không rơi khỏi bản đồ.
- [ ] (GP) Thêm khóa/mở con trỏ đúng trạng thái.
- [ ] (GP) Tạo raycast tương tác và lời nhắc nhấn `E`.
- [ ] (GP) Mở/đóng được bảng thông tin của một hiện vật mẫu.
- [ ] (GP) Tạo menu tạm dừng cơ bản.
- [ ] (ENV) Blockout sảnh chính và đủ 3 khu trưng bày.
- [ ] (ENV) Tạo lối đi và vị trí khu quiz.
- [ ] (ENV) Thêm collider cho toàn bộ sàn và tường.
- [ ] (ENV) Đặt bục hoặc tủ trưng bày mẫu.
- [ ] (CONT) Chuẩn hóa ít nhất 1 mannequin hoặc mô hình trang phục mẫu.
- [ ] (CONT) Viết nội dung thử và chuẩn bị ảnh/nguồn cho hiện vật mẫu.
- [ ] (CONT) Bắt đầu nội dung nháp cho 2 khu đầu tiên.
- [ ] (UITEST) Hoàn thiện menu Bắt đầu, Hướng dẫn, Giới thiệu và Thoát.
- [ ] (UITEST) Tạo prefab bảng thông tin hiển thị đúng tên, ảnh, mô tả và nguồn.
- [ ] (UITEST) Kiểm tra cỡ chữ và độ tương phản ở 1920×1080.

### Điều kiện nghiệm thu

- [ ] Mở game từ menu và vào được scene Museum.
- [ ] Đi qua được sảnh và cả 3 khu blockout.
- [ ] Không đi xuyên tường hoặc rơi khỏi sàn trong luồng bình thường.
- [ ] Có ít nhất một hiện vật tương tác hoàn chỉnh.
- [ ] Bảng thông tin mở, hiển thị đúng dữ liệu và đóng được.
- [ ] Menu tạm dừng hoạt động.
- [ ] Có bản build `Prototype_v0.1` chạy trên ít nhất 2 máy.

### Tiêu chí Go/No-Go

- **Go:** Controller ổn định, interaction hoạt động và layout không gây mắc kẹt.
- **No-Go:** Chưa tạo được build hoặc không thể hoàn thành luồng menu → bảo tàng → tương tác mẫu.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Prototype_v0.1`
- **FPS trung bình:** `______ FPS`
- **Số lỗi P0/P1:** `______`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Vấn đề còn lại:** `________________________________________`

---

## 5. Milestone 2 — Alpha đầy đủ chức năng

### Mục tiêu

Hoàn thành toàn bộ tính năng bắt buộc. Hình ảnh chưa cần tinh chỉnh cuối nhưng trải nghiệm phải đi được từ đầu đến cuối.

### Checklist công việc

- [ ] (GP) Tạo `ExhibitData` bằng ScriptableObject hoặc cấu trúc tương đương.
- [ ] (GP) Mỗi hiện vật đọc dữ liệu độc lập, không hard-code nội dung trong UI.
- [ ] (GP) Hoàn thiện chế độ xem hiện vật 3D (xoay và zoom).
- [ ] (GP) Khóa di chuyển đúng cách khi panel hoặc viewer đang mở.
- [ ] (GP) Hoàn thiện hệ thống audio guide.
- [ ] (GP) Tích hợp hệ thống quiz và màn hình kết quả.
- [ ] (GP) Tích hợp cài đặt âm lượng và độ nhạy chuột.
- [ ] (ENV) Hoàn thiện kiến trúc sảnh chính.
- [ ] (ENV) Hoàn thiện khu Ê Đê.
- [ ] (ENV) Hoàn thiện khu Ba Na.
- [ ] (ENV) Hoàn thiện khu Gia Rai.
- [ ] (ENV) Hoàn thiện khu quiz.
- [ ] (ENV) Thêm biển tên và chỉ dẫn giữa các khu.
- [ ] (ENV) Thiết lập ánh sáng thử cho toàn bộ bảo tàng.
- [ ] (CONT) Hoàn thiện hiện vật 1–2.
- [ ] (CONT) Hoàn thiện hiện vật 3–4.
- [ ] (CONT) Hoàn thiện hiện vật 5–6.
- [ ] (CONT) Chuẩn hóa tỷ lệ mannequin và hướng đặt hiện vật.
- [ ] (CONT) Hoàn thiện nội dung nháp của cả 3 khu.
- [ ] (CONT) Hoàn thiện kịch bản cho ít nhất 3 đoạn thuyết minh.
- [ ] (CONT) Kiểm tra nguồn và giấy phép của toàn bộ asset nội dung.
- [ ] (UITEST) Hoàn thiện bảng thông tin cho đủ 6 hiện vật.
- [ ] (UITEST) Hoàn thiện hướng dẫn điều khiển và menu cài đặt.
- [ ] (UITEST) Thu và xử lý ít nhất 1 đoạn thuyết minh mẫu.
- [ ] (UITEST) Hoàn thiện quiz 5 câu, tính điểm, chơi lại và màn hình kết quả.

### Điều kiện nghiệm thu

- [ ] Có đủ 3 khu trưng bày và 6 hiện vật.
- [ ] Cả 6 hiện vật đều mở đúng bảng thông tin.
- [ ] Tất cả hiện vật có thể xoay và zoom trong viewer.
- [ ] Audio guide mẫu phát, dừng và điều chỉnh âm lượng đúng.
- [ ] Quiz có 5 câu, tính điểm chính xác và chơi lại được.
- [ ] Hoàn thành được toàn bộ hành trình mà không cần Unity Editor.
- [ ] Có bản build `Alpha_v0.1` chạy trên ít nhất 2 máy.

### Tiêu chí Go/No-Go

- **Go:** Đã hoàn thành toàn bộ chức năng MVP, dù còn placeholder thẩm mỹ.
- **No-Go:** Thiếu khu, thiếu hiện vật, quiz chưa chạy hoặc có lỗi chặn luồng.
- Nếu No-Go ở ngày 10, dừng mọi tính năng mở rộng và giảm độ chi tiết đồ họa để bảo vệ luồng MVP.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Alpha_v0.1`
- **Số hiện vật hoàn tất:** `______ / 6`
- **Số khu hoàn tất:** `______ / 3`
- **Số lỗi P0:** `______`
- **Số lỗi P1:** `______`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Phạm vi cần cắt giảm:** `__________________________________`

---

## 6. Milestone 3 — Beta hoàn chỉnh nội dung

### Mục tiêu

Thay thế placeholder quan trọng, hoàn thiện nội dung văn hóa, ánh sáng, âm thanh và UI; sau đó kiểm tra khả năng tự sử dụng với người ngoài.

### Checklist công việc

- [ ] (GP) Sửa tất cả lỗi P0 và các lỗi P1 về di chuyển/tương tác của bản Alpha.
- [ ] (GP) Hoàn thiện chuyển đổi giữa đi lại, UI và viewer.
- [ ] (GP) Kiểm tra quay lại menu và vào lại bảo tàng.
- [ ] (GP) Bổ sung phản hồi khi tương tác thành công hoặc không thể tương tác.
- [ ] (ENV) Thay placeholder kiến trúc quan trọng.
- [ ] (ENV) Hoàn thiện material sàn, tường, bục và tủ kính.
- [ ] (ENV) Hoàn thiện ánh sáng cho cả 3 khu.
- [ ] (ENV) Bake lighting và light probe.
- [ ] (ENV) Thêm occlusion culling hoặc LOD nếu cần.
- [ ] (ENV) Kiểm tra polygon, texture và collider; đạt trung bình ≥ 45 FPS trên máy mục tiêu.
- [ ] (CONT) Kiểm tra lại tên gọi, dân tộc, địa bàn, chất liệu và hoàn cảnh sử dụng của 6 hiện vật.
- [ ] (CONT) Loại bỏ mọi diễn giải họa tiết/màu sắc không có nguồn; kiểm tra chính tả và tên riêng.
- [ ] (CONT) Hoàn thiện danh mục nguồn tham khảo.
- [ ] (CONT) Nhờ giảng viên/người am hiểu review và **khóa nội dung sau ngày 14**.
- [ ] (UITEST) Thu âm chính thức tối thiểu 3 đoạn thuyết minh (30–60 giây).
- [ ] (UITEST) Chuẩn hóa âm lượng, loại tạp âm; thêm âm nút bấm và âm môi trường.
- [ ] (UITEST) Kiểm tra UI ở 1920×1080, 1600×900 và 1366×768.
- [ ] (UITEST) Chuẩn bị kịch bản user test và mời 3–5 người ngoài trải nghiệm.

### Dữ liệu cần ghi trong user test

- [ ] Người dùng có hiểu cách điều khiển mà không được hướng dẫn trực tiếp không?
- [ ] Người dùng có tìm được cả 3 khu không?
- [ ] Người dùng có nhận ra đối tượng có thể tương tác không?
- [ ] Người dùng có đọc hết bảng thông tin hay bỏ qua vì quá dài?
- [ ] Người dùng có hoàn thành được quiz không?
- [ ] Thời gian hoàn thành trung bình: `______ phút`.
- [ ] Số người bị lạc hoặc mắc kẹt: `______ / ______`.
- [ ] Điểm quiz trung bình: `______ / 5`.
- [ ] Ba vấn đề được nhắc lại nhiều nhất:
  1. `__________________________________________________`
  2. `__________________________________________________`
  3. `__________________________________________________`

### Điều kiện nghiệm thu

- [ ] Không còn placeholder quan trọng trong luồng demo.
- [ ] Đủ 3 đoạn thuyết minh dài khoảng 30–60 giây.
- [ ] Nội dung của 6 hiện vật đã được review và có nguồn.
- [ ] Bảo tàng đạt hiệu năng tối thiểu trên máy mục tiêu.
- [ ] Người ngoài có thể tự hoàn thành trải nghiệm.
- [ ] Không còn lỗi P0; các lỗi P1 đều có kế hoạch sửa.
- [ ] Tính năng được đóng băng sau ngày 15.
- [ ] Có bản build `Beta_v0.5`.

### Tiêu chí Go/No-Go

- **Go:** Luồng hoàn chỉnh, nội dung đã khóa và user test không phát hiện lỗi chặn.
- **No-Go:** Còn placeholder lớn, nội dung chưa xác minh hoặc người ngoài không thể hoàn thành trải nghiệm.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Beta_v0.5`
- **Số người user test:** `______`
- **FPS trung bình:** `______ FPS`
- **Số lỗi P0/P1:** `______ / ______`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Danh sách sửa bắt buộc:** `________________________________`

---

## 7. Milestone 4 — Release và bảo vệ

### Mục tiêu

Biến bản Beta thành bản phát hành ổn định, đóng gói đầy đủ hồ sơ và chuẩn bị phương án thuyết trình an toàn.

### Checklist công việc

- [ ] (GP) Sửa toàn bộ lỗi P0/P1 còn lại.
- [ ] (GP) Kiểm thử lại menu, điều khiển, interaction, viewer và quiz.
- [ ] (GP) Tạo preset đồ họa phù hợp nếu cần.
- [ ] (GP) Tạo `Release Candidate 1` (ngày 17) và `Release Candidate 2` (ngày 19).
- [ ] (GP) Tạo bản build chính thức `Release_v1.0` (ngày 20) và kiểm tra trên máy không cài Unity.
- [ ] (ENV) Kiểm tra Unity Profiler cho CPU, GPU và memory.
- [ ] (ENV) Giảm texture/mesh vượt mức; loại bỏ vật thể và đèn không dùng.
- [ ] (ENV) Kiểm tra ánh sáng sau khi build; chụp ảnh màn hình chất lượng cao.
- [ ] (CONT) Kiểm tra lần cuối toàn bộ bảng thông tin, Credits và tài liệu tham khảo.
- [ ] (CONT) Ghi rõ nguồn của asset 3D, texture, ảnh, âm thanh và font.
- [ ] (CONT) Hoàn thiện phần nội dung trong báo cáo; chuẩn bị trả lời câu hỏi về tính chính xác và phạm vi văn hóa.
- [ ] (UITEST) Chạy toàn bộ test case hồi quy.
- [ ] (UITEST) Hoàn thiện README, báo cáo và slide thuyết trình.
- [ ] (UITEST) Quay video demo 3–5 phút và chuẩn bị video offline dự phòng.
- [ ] (UITEST) Ghi lại danh sách lỗi đã biết.

### Bộ kiểm thử Release bắt buộc

- [ ] File `.exe` mở được trên máy sạch.
- [ ] Tất cả nút menu hoạt động.
- [ ] Người chơi không rơi khỏi sàn hoặc mắc kẹt.
- [ ] Đủ 6 hiện vật tương tác đúng.
- [ ] Bảng thông tin không tràn chữ ở các độ phân giải mục tiêu.
- [ ] Xoay/zoom hiện vật và thoát viewer hoạt động.
- [ ] Các audio guide không phát chồng.
- [ ] Cài đặt âm lượng có hiệu lực.
- [ ] Quiz tính điểm đúng và chơi lại được.
- [ ] Pause/resume và quay về menu hoạt động.
- [ ] Chơi liên tục 20 phút không crash.
- [ ] FPS trung bình đạt ít nhất 45 trên máy mục tiêu.

### Điều kiện nghiệm thu

- [ ] Không còn lỗi P0 hoặc P1.
- [ ] Bản build chạy được trên máy thuyết trình.
- [ ] Source code được sao lưu và có thể mở lại.
- [ ] Báo cáo, slide và video đã hoàn tất.
- [ ] Toàn bộ nguồn và giấy phép được liệt kê.
- [ ] Có bản sao dự phòng trên USB và cloud.
- [ ] Đã diễn tập thuyết trình ít nhất 2 lần.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Release_v1.0`
- **FPS trung bình:** `______ FPS`
- **Kích thước build:** `______ MB/GB`
- **Số lỗi đã biết:** `______`
- **Kết quả:** `Sẵn sàng bảo vệ / Chưa sẵn sàng`

---

## 8. Backlog tính năng mở rộng

Chỉ nhận các task dưới đây sau khi Milestone 3 đã đạt và không còn lỗi P0/P1:

- [ ] Khu thứ 4 (M’nông) và hiện vật bổ sung.
- [ ] Chế độ VR.
- [ ] Phụ đề đồng bộ với thuyết minh.
- [ ] Song ngữ Việt–Anh.
- [ ] Hệ thống thu thập con dấu.
- [ ] Nhân vật hướng dẫn ảo.
- [ ] Mini-game ghép họa tiết.
- [ ] Video hoặc hoạt ảnh minh họa quy trình dệt.

Nếu một tính năng mở rộng có nguy cơ làm trễ `Release_v1.0`, lập tức đưa nó trở lại backlog.

## 9. Nhật ký tiến độ hằng ngày

Sao chép mẫu dưới đây cho mỗi ngày làm việc:

### Ngày \_**\_ — \_\_** / \_**\_ / \_\_\_\_**

- **Milestone hiện tại:** `M0 / M1 / M2 / M3 / M4`
- **Tiến độ milestone:** `______%`
- **Mục tiêu chính hôm nay:** `_________________________________`
- **Đã hoàn thành:** `_______________________________________`
- **Đang làm dở:** `_________________________________________`
- **Lỗi/rủi ro mới:** `______________________________________`
- **Task đang bị chặn + hướng xử lý:** `_____________________`
- **Mục tiêu ngày tiếp theo:** `_____________________________`

## 10. Nhật ký build

### Build 01

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh/tag:** `______________________________________`
- **Máy đã kiểm thử:** `_______________________________________`
- **FPS trung bình:** `________________________________________`
- **Lỗi nghiêm trọng:** `______________________________________`
- **Kết luận:** `Đạt / Không đạt`

### Build 02

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh/tag:** `______________________________________`
- **Máy đã kiểm thử:** `_______________________________________`
- **FPS trung bình:** `________________________________________`
- **Lỗi nghiêm trọng:** `______________________________________`
- **Kết luận:** `Đạt / Không đạt`

### Build 03

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh/tag:** `______________________________________`
- **Máy đã kiểm thử:** `_______________________________________`
- **FPS trung bình:** `________________________________________`
- **Lỗi nghiêm trọng:** `______________________________________`
- **Kết luận:** `Đạt / Không đạt`

## 11. Tình trạng dự án hiện tại

- **Milestone hiện tại:** `Milestone 0 — Khởi tạo dự án`
- **Trạng thái tổng thể:** `[ ] Chưa bắt đầu`
- **Tiến độ tổng thể:** `0%`
- **Số task đã hoàn thành:** `0 / ____`
- **Số lỗi P0:** `0`
- **Số lỗi P1:** `0`
- **Rủi ro lớn nhất:** `Chưa cập nhật`
- **Bản build mới nhất:** `Chưa có`
- **Ngày cập nhật gần nhất:** `____ / ____ / ______`

## 12. Quy tắc xử lý khi chậm tiến độ

Nếu milestone trễ hơn một ngày:

1. Dừng nhận tính năng mới.
2. Sửa P0/P1 trước các lỗi thẩm mỹ.
3. Giữ 3 khu và 6 hiện vật nhưng giảm độ chi tiết asset và tăng tỷ lệ dùng ảnh tư liệu nếu cần.
4. Bỏ lần lượt khu thứ 4, VR, song ngữ, mini-game, nhân vật hướng dẫn và các hiệu ứng nâng cao.
5. Dồn thời gian vào task chặn luồng chính; dời việc đánh bóng sang cuối tuần dự phòng.
6. Ghi rõ phạm vi bị cắt và lý do trong phần review milestone.

Không được cắt giảm việc kiểm duyệt nội dung văn hóa, nguồn tham khảo, kiểm thử bản build hoặc video dự phòng.
