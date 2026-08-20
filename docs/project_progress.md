# PROJECT PROGRESS — BẢO TÀNG TRANG PHỤC TÂY NGUYÊN

## 1. Cách sử dụng tài liệu

File này dùng để theo dõi tiến độ dự án trong 1 tháng. Nhóm cập nhật vào cuối mỗi ngày làm việc và review chính thức vào cuối mỗi milestone.

Quy ước trạng thái:

- `[ ]` Chưa bắt đầu.
- `[-]` Đang thực hiện.
- `[x]` Đã hoàn thành và được kiểm tra.
- `[!]` Đang bị chặn hoặc có rủi ro trễ.

Quy ước nhân sự:

- **TV1:** Trưởng nhóm, lập trình gameplay và tích hợp.
- **TV2:** Môi trường 3D, ánh sáng và tối ưu đồ họa.
- **TV3:** Trang phục 3D, nghiên cứu và kiểm duyệt nội dung.
- **TV4:** UI/UX, âm thanh, kiểm thử và hồ sơ dự án.

Nguyên tắc cập nhật:

1. Chỉ đánh dấu `[x]` khi sản phẩm đã được tích hợp hoặc có minh chứng kiểm tra.
2. Task bị chặn quá một ngày phải chuyển thành `[!]` và ghi rõ nguyên nhân.
3. Không bắt đầu milestone tiếp theo nếu còn tiêu chí bắt buộc của milestone hiện tại chưa đạt, trừ khi trưởng nhóm ghi nhận ngoại lệ.
4. Tính năng mở rộng không được ưu tiên hơn task MVP.
5. Cuối mỗi milestone phải tạo một bản build hoặc gói bàn giao có tên phiên bản rõ ràng.

## 2. Tổng quan milestone

### Milestone 0 — Khởi tạo dự án

- **Thời gian:** Ngày 1–2.
- **Mục tiêu:** Chốt phạm vi, công cụ, cách phối hợp và dữ liệu cần sản xuất.
- **Bản bàn giao:** Project Unity khởi tạo, repository Git, sơ đồ bảo tàng, wireframe UI và danh sách 8 hiện vật.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 1 — Prototype có thể chơi

- **Thời gian:** Ngày 3–5, kết thúc tuần 1.
- **Mục tiêu:** Người dùng vào được bảo tàng, đi lại và tương tác với một hiện vật mẫu.
- **Bản bàn giao:** `Prototype_v0.1`.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 2 — Alpha đầy đủ chức năng

- **Thời gian:** Ngày 6–10, kết thúc tuần 2.
- **Mục tiêu:** Hoàn thành toàn bộ luồng chức năng của MVP với đủ 4 khu và 8 hiện vật.
- **Bản bàn giao:** `Alpha_v0.1`.
- **Trạng thái:** `[ ]`
- **Tiến độ:** `0%`

### Milestone 3 — Beta hoàn chỉnh nội dung

- **Thời gian:** Ngày 11–15, kết thúc tuần 3.
- **Mục tiêu:** Hoàn thiện hình ảnh, âm thanh, nội dung và kiểm thử với người dùng ngoài nhóm.
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

Tạo nền tảng làm việc thống nhất để cả bốn thành viên có thể bắt đầu sản xuất mà không xung đột về phiên bản, phạm vi hoặc định dạng dữ liệu.

### Checklist công việc

#### Quản lý và kỹ thuật — TV1

- [ ] Chốt phiên bản Unity LTS và render pipeline.
- [ ] Tạo project Unity và kiểm tra project mở được trên cả 4 máy.
- [ ] Tạo repository Git và `.gitignore` dành cho Unity.
- [ ] Tạo các nhánh `main` và `develop`.
- [ ] Tạo cấu trúc thư mục trong `Assets/_Project`.
- [ ] Tạo các scene `Bootstrap`, `MainMenu` và `Museum`.
- [ ] Tạo bảng quản lý task trên Trello/Notion/GitHub Projects.

#### Thiết kế môi trường — TV2

- [ ] Vẽ sơ đồ mặt bằng gồm sảnh, 4 khu trưng bày và khu quiz.
- [ ] Xác định tỷ lệ, kích thước hành lang và vị trí hiện vật.
- [ ] Lập danh sách asset môi trường cần dựng hoặc tìm nguồn.
- [ ] Chốt phong cách ánh sáng và hình ảnh tham chiếu.

#### Nội dung và hiện vật — TV3

- [ ] Chọn 4 khu đại diện: Ê Đê, Ba Na, Gia Rai và M’nông.
- [ ] Lập danh sách sơ bộ 8 hiện vật.
- [ ] Tìm tối thiểu 2 nguồn đáng tin cậy cho mỗi khu.
- [ ] Tạo biểu mẫu lưu nguồn, giấy phép và ngày truy cập.
- [ ] Đánh giá độ khó khi dựng từng hiện vật.

#### UI/UX và kiểm thử — TV4

- [ ] Vẽ wireframe menu chính.
- [ ] Vẽ wireframe bảng thông tin hiện vật.
- [ ] Vẽ wireframe chế độ xem 3D và màn hình quiz.
- [ ] Tạo bản nháp hướng dẫn điều khiển.
- [ ] Tạo mẫu báo cáo bug và test case.

### Điều kiện nghiệm thu

- [ ] Cả 4 thành viên clone, mở và chạy được project.
- [ ] Không commit các thư mục cache như `Library`, `Temp`, `Logs` và `Obj`.
- [ ] Có sơ đồ bảo tàng được cả nhóm duyệt.
- [ ] Có danh sách 8 hiện vật khả thi và nguồn ban đầu.
- [ ] Có wireframe của tất cả màn hình chính.
- [ ] Vai trò và người review từng hạng mục đã rõ ràng.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Người chủ trì:** `____________________`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Vấn đề còn lại:** `________________________________________`
- **Quyết định:** `____________________________________________`

---

## 4. Milestone 1 — Prototype có thể chơi

### Mục tiêu

Chứng minh luồng kỹ thuật cốt lõi: mở game, vào bảo tàng, di chuyển, nhìn, tương tác và xem thông tin hiện vật.

### Checklist công việc

#### Gameplay và tích hợp — TV1

- [ ] Hoàn thiện di chuyển bằng `WASD`.
- [ ] Hoàn thiện điều khiển camera bằng chuột.
- [ ] Thêm va chạm và giới hạn để người chơi không rơi khỏi bản đồ.
- [ ] Thêm khóa/mở con trỏ đúng trạng thái.
- [ ] Tạo raycast tương tác và lời nhắc nhấn `E`.
- [ ] Mở/đóng được bảng thông tin của một hiện vật mẫu.
- [ ] Tạo menu tạm dừng cơ bản.

#### Môi trường — TV2

- [ ] Blockout sảnh chính.
- [ ] Blockout đủ 4 khu trưng bày.
- [ ] Tạo lối đi và vị trí khu quiz.
- [ ] Thêm collider cho toàn bộ sàn và tường.
- [ ] Đặt bục hoặc tủ trưng bày mẫu.

#### Nội dung và hiện vật — TV3

- [ ] Chuẩn hóa ít nhất 1 mannequin hoặc mô hình trang phục mẫu.
- [ ] Viết nội dung thử cho hiện vật mẫu.
- [ ] Chuẩn bị ảnh và nguồn minh họa của hiện vật mẫu.
- [ ] Hoàn thiện nội dung nháp cho 2 khu đầu tiên.

#### UI/UX — TV4

- [ ] Hoàn thiện menu Bắt đầu, Hướng dẫn, Giới thiệu và Thoát.
- [ ] Tạo prefab bảng thông tin hiện vật.
- [ ] Hiển thị đúng tên, ảnh, mô tả và nguồn.
- [ ] Kiểm tra cỡ chữ và độ tương phản ở 1920×1080.

### Điều kiện nghiệm thu

- [ ] Người dùng mở game từ menu và vào được scene Museum.
- [ ] Người dùng đi qua được sảnh và cả 4 khu blockout.
- [ ] Không đi xuyên tường hoặc rơi khỏi sàn trong luồng bình thường.
- [ ] Có ít nhất một hiện vật tương tác hoàn chỉnh.
- [ ] Bảng thông tin mở, hiển thị đúng dữ liệu và đóng được.
- [ ] Menu tạm dừng hoạt động.
- [ ] Có bản build `Prototype_v0.1` chạy trên ít nhất 2 máy.

### Tiêu chí Go/No-Go

- **Go:** Controller ổn định, interaction hoạt động và layout không gây mắc kẹt.
- **No-Go:** Chưa tạo được build hoặc người dùng không thể hoàn thành luồng menu → bảo tàng → tương tác mẫu.

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

#### Gameplay và dữ liệu — TV1

- [ ] Tạo `ExhibitData` bằng ScriptableObject hoặc cấu trúc dữ liệu tương đương.
- [ ] Mỗi hiện vật đọc dữ liệu độc lập, không hard-code nội dung trong UI.
- [ ] Hoàn thiện chế độ xem hiện vật 3D.
- [ ] Người dùng có thể xoay và zoom hiện vật.
- [ ] Khóa di chuyển đúng cách khi panel hoặc viewer đang mở.
- [ ] Hoàn thiện hệ thống audio guide.
- [ ] Tích hợp hệ thống quiz và màn hình kết quả.
- [ ] Tích hợp cài đặt âm lượng và độ nhạy chuột.

#### Môi trường — TV2

- [ ] Hoàn thiện kiến trúc sảnh chính.
- [ ] Hoàn thiện khu Ê Đê.
- [ ] Hoàn thiện khu Ba Na.
- [ ] Hoàn thiện khu Gia Rai.
- [ ] Hoàn thiện khu M’nông.
- [ ] Hoàn thiện khu quiz.
- [ ] Thêm biển tên và chỉ dẫn giữa các khu.
- [ ] Thiết lập ánh sáng thử cho toàn bộ bảo tàng.

#### Hiện vật và nội dung — TV3

- [ ] Hoàn thiện hiện vật 1–2.
- [ ] Hoàn thiện hiện vật 3–4.
- [ ] Hoàn thiện hiện vật 5–6.
- [ ] Hoàn thiện hiện vật 7–8.
- [ ] Chuẩn hóa tỷ lệ mannequin và hướng đặt hiện vật.
- [ ] Hoàn thiện nội dung nháp của cả 4 khu.
- [ ] Hoàn thiện kịch bản cho ít nhất 4 đoạn thuyết minh.
- [ ] Kiểm tra nguồn và giấy phép của toàn bộ asset nội dung.

#### UI, âm thanh và quiz — TV4

- [ ] Hoàn thiện bảng thông tin cho đủ 8 hiện vật.
- [ ] Hoàn thiện hướng dẫn điều khiển.
- [ ] Hoàn thiện menu cài đặt.
- [ ] Thu và xử lý ít nhất 1 đoạn thuyết minh mẫu.
- [ ] Hoàn thiện quiz 5 câu.
- [ ] Kiểm tra tính điểm và chơi lại quiz.
- [ ] Tạo màn hình kết quả và nút quay lại bảo tàng.

### Điều kiện nghiệm thu

- [ ] Có đủ 4 khu trưng bày và 8 hiện vật.
- [ ] Cả 8 hiện vật đều mở đúng bảng thông tin.
- [ ] Tất cả hiện vật có thể xoay và zoom trong viewer.
- [ ] Audio guide mẫu phát, dừng và điều chỉnh âm lượng đúng.
- [ ] Quiz có 5 câu, tính điểm chính xác và chơi lại được.
- [ ] Người dùng hoàn thành được toàn bộ hành trình mà không cần Unity Editor.
- [ ] Có bản build `Alpha_v0.1` chạy trên ít nhất 3 máy.

### Tiêu chí Go/No-Go

- **Go:** Đã hoàn thành toàn bộ chức năng MVP, dù còn placeholder thẩm mỹ.
- **No-Go:** Thiếu khu, thiếu hiện vật, quiz chưa chạy hoặc có lỗi chặn luồng.
- Nếu No-Go ở ngày 10, dừng mọi tính năng mở rộng và giảm độ chi tiết đồ họa để bảo vệ luồng MVP.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Alpha_v0.1`
- **Số hiện vật hoàn tất:** `______ / 8`
- **Số khu hoàn tất:** `______ / 4`
- **Số lỗi P0:** `______`
- **Số lỗi P1:** `______`
- **Kết quả:** `Đạt / Đạt có điều kiện / Chưa đạt`
- **Phạm vi cần cắt giảm:** `__________________________________`

---

## 6. Milestone 3 — Beta hoàn chỉnh nội dung

### Mục tiêu

Thay thế placeholder quan trọng, hoàn thiện nội dung văn hóa, ánh sáng, âm thanh và UI; sau đó kiểm tra khả năng tự sử dụng với người ngoài nhóm.

### Checklist công việc

#### Sửa lỗi và trải nghiệm — TV1

- [ ] Sửa tất cả lỗi P0 của bản Alpha.
- [ ] Sửa các lỗi P1 liên quan đến di chuyển và tương tác.
- [ ] Hoàn thiện trạng thái chuyển đổi giữa đi lại, UI và viewer.
- [ ] Kiểm tra quay lại menu và vào lại bảo tàng.
- [ ] Bổ sung phản hồi khi tương tác thành công hoặc không thể tương tác.

#### Hình ảnh và tối ưu — TV2

- [ ] Thay placeholder kiến trúc quan trọng.
- [ ] Hoàn thiện material sàn, tường, bục và tủ kính.
- [ ] Hoàn thiện ánh sáng cho cả 4 khu.
- [ ] Bake lighting và light probe.
- [ ] Thêm occlusion culling hoặc LOD nếu cần.
- [ ] Kiểm tra polygon, texture và collider.
- [ ] Đạt trung bình tối thiểu 45 FPS trên máy mục tiêu.

#### Nội dung và kiểm duyệt — TV3

- [ ] Kiểm tra lại tên gọi của 8 hiện vật.
- [ ] Kiểm tra dân tộc, địa bàn, chất liệu và hoàn cảnh sử dụng.
- [ ] Loại bỏ mọi diễn giải họa tiết hoặc màu sắc không có nguồn.
- [ ] Kiểm tra chính tả và cách viết tên riêng.
- [ ] Hoàn thiện danh mục nguồn tham khảo.
- [ ] Nhờ giảng viên/người am hiểu review nếu có thể.
- [ ] Khóa nội dung sau ngày 14.

#### UI, âm thanh và user test — TV4

- [ ] Thu âm chính thức cho khu 1–2.
- [ ] Thu âm chính thức cho khu 3–4.
- [ ] Chuẩn hóa âm lượng và loại bỏ tạp âm.
- [ ] Thêm âm thanh nút bấm và âm thanh môi trường.
- [ ] Kiểm tra UI ở 1920×1080.
- [ ] Kiểm tra UI ở 1600×900.
- [ ] Kiểm tra UI ở 1366×768.
- [ ] Chuẩn bị kịch bản user test.
- [ ] Mời 3–5 người ngoài nhóm trải nghiệm.

### Dữ liệu cần ghi trong user test

- [ ] Người dùng có hiểu cách điều khiển mà không được hướng dẫn trực tiếp không?
- [ ] Người dùng có tìm được cả 4 khu không?
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
- [ ] Đủ 4 đoạn thuyết minh dài khoảng 30–60 giây.
- [ ] Nội dung của 8 hiện vật đã được review và có nguồn.
- [ ] Bảo tàng đạt hiệu năng tối thiểu trên máy mục tiêu.
- [ ] Người ngoài nhóm có thể tự hoàn thành trải nghiệm.
- [ ] Không còn lỗi P0; các lỗi P1 đều có người nhận sửa.
- [ ] Tính năng được đóng băng sau ngày 15.
- [ ] Có bản build `Beta_v0.5`.

### Tiêu chí Go/No-Go

- **Go:** Luồng hoàn chỉnh, nội dung đã khóa và user test không phát hiện lỗi chặn.
- **No-Go:** Còn placeholder lớn, nội dung chưa xác minh hoặc người dùng ngoài nhóm không thể hoàn thành trải nghiệm.

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

#### Ổn định và build — TV1

- [ ] Sửa toàn bộ lỗi P0/P1 còn lại.
- [ ] Kiểm thử lại menu, điều khiển, interaction, viewer và quiz.
- [ ] Tạo preset đồ họa phù hợp nếu cần.
- [ ] Tạo `Release Candidate 1` vào ngày 17.
- [ ] Tạo `Release Candidate 2` vào ngày 19.
- [ ] Tạo bản build chính thức `Release_v1.0` vào ngày 20.
- [ ] Kiểm tra ứng dụng trên máy không cài Unity.

#### Tối ưu và hình ảnh — TV2

- [ ] Kiểm tra Unity Profiler cho CPU, GPU và memory.
- [ ] Giảm texture hoặc mesh vượt mức cần thiết.
- [ ] Loại bỏ vật thể và đèn không sử dụng.
- [ ] Kiểm tra ánh sáng sau khi build.
- [ ] Chụp ảnh màn hình chất lượng cao cho báo cáo và slide.

#### Nội dung và tài liệu nguồn — TV3

- [ ] Kiểm tra lần cuối toàn bộ bảng thông tin.
- [ ] Kiểm tra Credits và tài liệu tham khảo.
- [ ] Ghi rõ nguồn của asset 3D, texture, ảnh, âm thanh và font.
- [ ] Hoàn thiện phần nội dung trong báo cáo.
- [ ] Chuẩn bị trả lời câu hỏi về tính chính xác và phạm vi văn hóa.

#### Kiểm thử và hồ sơ — TV4

- [ ] Chạy toàn bộ test case hồi quy.
- [ ] Hoàn thiện README và hướng dẫn điều khiển.
- [ ] Hoàn thiện báo cáo.
- [ ] Hoàn thiện slide thuyết trình.
- [ ] Quay video demo 3–5 phút.
- [ ] Chuẩn bị video offline dự phòng.
- [ ] Ghi lại danh sách lỗi đã biết.

### Bộ kiểm thử Release bắt buộc

- [ ] File `.exe` mở được trên máy sạch.
- [ ] Tất cả nút menu hoạt động.
- [ ] Người chơi không rơi khỏi sàn hoặc mắc kẹt.
- [ ] Đủ 8 hiện vật tương tác đúng.
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
- [ ] Cả nhóm diễn tập ít nhất 2 lần.
- [ ] Mỗi thành viên biết phần trình bày và câu hỏi mình phụ trách.

### Review milestone

- **Ngày review:** `____ / ____ / ______`
- **Build:** `Release_v1.0`
- **FPS trung bình:** `______ FPS`
- **Kích thước build:** `______ MB/GB`
- **Số lỗi đã biết:** `______`
- **Kết quả:** `Sẵn sàng bảo vệ / Chưa sẵn sàng`
- **Người xác nhận:** `______________________________________`

---

## 8. Backlog tính năng mở rộng

Chỉ nhận các task dưới đây sau khi Milestone 3 đã đạt và không còn lỗi P0/P1:

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

### Ngày ____ — ____ / ____ / ______

- **Milestone hiện tại:** `M0 / M1 / M2 / M3 / M4`
- **Tiến độ milestone:** `______%`
- **TV1 đã hoàn thành:** `_____________________________________`
- **TV2 đã hoàn thành:** `_____________________________________`
- **TV3 đã hoàn thành:** `_____________________________________`
- **TV4 đã hoàn thành:** `_____________________________________`
- **Lỗi/rủi ro mới:** `________________________________________`
- **Task đang bị chặn:** `______________________________________`
- **Người xử lý:** `___________________________________________`
- **Mục tiêu ngày tiếp theo:** `_________________________________`

## 10. Nhật ký build

### Build 01

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh:** `__________________________________________`
- **Người tạo:** `_____________________________________________`
- **Máy đã kiểm thử:** `_______________________________________`
- **FPS trung bình:** `________________________________________`
- **Lỗi nghiêm trọng:** `______________________________________`
- **Kết luận:** `Đạt / Không đạt`

### Build 02

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh:** `__________________________________________`
- **Người tạo:** `_____________________________________________`
- **Máy đã kiểm thử:** `_______________________________________`
- **FPS trung bình:** `________________________________________`
- **Lỗi nghiêm trọng:** `______________________________________`
- **Kết luận:** `Đạt / Không đạt`

### Build 03

- **Tên build:** `_____________________________________________`
- **Ngày tạo:** `____ / ____ / ______`
- **Commit/nhánh:** `__________________________________________`
- **Người tạo:** `_____________________________________________`
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
- **Người cập nhật:** `________________________________________`

## 12. Quy tắc xử lý khi chậm tiến độ

Nếu milestone trễ hơn một ngày:

1. Dừng nhận tính năng mới.
2. Sửa P0/P1 trước các lỗi thẩm mỹ.
3. Giữ nguyên 4 khu và 8 hiện vật nhưng giảm độ chi tiết asset nếu cần.
4. Bỏ lần lượt VR, song ngữ, mini-game, nhân vật hướng dẫn và các hiệu ứng nâng cao.
5. Chuyển thành viên đang rảnh sang task chặn luồng chính.
6. Ghi rõ phạm vi bị cắt và lý do trong phần review milestone.

Không được cắt giảm việc kiểm duyệt nội dung văn hóa, nguồn tham khảo, kiểm thử bản build hoặc video dự phòng.
