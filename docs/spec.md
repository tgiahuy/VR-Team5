# KẾ HOẠCH DỰ ÁN UNITY TRONG 1 THÁNG

## 1. Thông tin chung

- **Tên đề tài:** Mô phỏng bảo tàng trưng bày trang phục truyền thống của đồng bào Tây Nguyên.
- **Thời gian thực hiện:** 4 tuần, tương đương 20 ngày làm việc chính và các ngày cuối tuần làm thời gian dự phòng.
- **Nhân sự:** 4 thành viên.
- **Nền tảng mục tiêu:** PC Windows, điều khiển bằng bàn phím và chuột.
- **Công cụ chính:** Unity LTS, Blender, Git/GitHub, Photoshop/GIMP/Krita, Audacity và Trello/Notion.
- **Sản phẩm cuối:** Một ứng dụng bảo tàng ảo có thể chạy độc lập, cho phép người dùng tham quan, xem mô hình trang phục, đọc/nghe nội dung thuyết minh và hoàn thành một hoạt động tương tác ngắn.

## 2. Mục tiêu dự án

### 2.1. Mục tiêu chính

Xây dựng một bảo tàng ảo 3D có quy mô vừa phải, giới thiệu trang phục truyền thống của một số dân tộc tại Tây Nguyên theo cách trực quan, dễ sử dụng và tôn trọng giá trị văn hóa.

Người dùng có thể:

- Đi lại tự do trong không gian bảo tàng.
- Tham quan ít nhất 4 khu trưng bày.
- Quan sát trang phục dưới dạng mô hình 3D từ nhiều góc độ.
- Đọc thông tin về tên trang phục, dân tộc, chất liệu, hoàn cảnh sử dụng và ý nghĩa văn hóa.
- Nghe thuyết minh ngắn hoặc xem hình ảnh tư liệu tại từng khu.
- Thực hiện một bài trắc nghiệm cuối hành trình.
- Quay lại sảnh chính, mở hướng dẫn hoặc thoát ứng dụng bất cứ lúc nào.

### 2.2. Mục tiêu học thuật

- Vận dụng Unity để xây dựng môi trường 3D và hệ thống tương tác.
- Áp dụng quy trình làm việc nhóm với Git.
- Nghiên cứu, chọn lọc và trình bày dữ liệu văn hóa có nguồn rõ ràng.
- Tối ưu ứng dụng để chạy ổn định trên máy tính tầm trung.
- Hoàn thiện hồ sơ dự án gồm báo cáo, video demo, slide thuyết trình và bản build.

### 2.3. Tiêu chí thành công

Dự án được xem là hoàn thành khi đáp ứng tất cả điều kiện sau:

- Có bản build Windows mở và chạy được mà không cần Unity Editor.
- Người dùng có thể hoàn thành luồng: menu → sảnh → 4 khu trưng bày → trắc nghiệm → màn hình kết quả.
- Có tối thiểu 8 hiện vật trang phục, trung bình 2 hiện vật cho mỗi khu.
- Mỗi hiện vật có mô hình hoặc hình ảnh minh họa, bảng thông tin và nguồn tham khảo.
- Có ít nhất 4 đoạn thuyết minh âm thanh, mỗi đoạn từ 30–60 giây.
- Không có lỗi nghiêm trọng làm người chơi mắc kẹt, rơi khỏi bản đồ hoặc không thể hoàn tất trải nghiệm.
- Ứng dụng đạt trung bình từ 45 FPS trở lên trên máy kiểm thử mục tiêu ở thiết lập mặc định.
- Nhóm có báo cáo, slide, poster hoặc ảnh đại diện, video demo 3–5 phút và hướng dẫn chạy.

## 3. Phạm vi thực hiện

### 3.1. Phạm vi bắt buộc — MVP

Đây là phần phải hoàn thành trước khi làm các tính năng mở rộng:

1. Menu chính gồm Bắt đầu, Hướng dẫn, Giới thiệu và Thoát.
2. Một sảnh chính và 4 khu trưng bày đại diện cho Ê Đê, Ba Na, Gia Rai và M’nông.
3. Tối thiểu 8 hiện vật trang phục.
4. Hệ thống di chuyển góc nhìn thứ nhất bằng bàn phím và chuột.
5. Tương tác bằng tâm ngắm và phím `E` hoặc nhấp chuột.
6. Bảng thông tin hiện vật có ảnh, tên, mô tả ngắn và nguồn.
7. Chế độ xoay/phóng to mô hình trang phục tại điểm trưng bày.
8. Âm thanh nền nhẹ, âm thanh tương tác và ít nhất 4 đoạn thuyết minh.
9. Bản đồ sơ đồ bảo tàng hoặc biển chỉ dẫn.
10. Trắc nghiệm 5 câu và màn hình kết quả.
11. Menu tạm dừng, chỉnh âm lượng và quay lại menu chính.
12. Bản build Windows đã kiểm thử.

Việc lựa chọn 4 dân tộc chỉ nhằm giới hạn khối lượng cho bản demo một tháng, không mang ý nghĩa đại diện đầy đủ cho toàn bộ cộng đồng các dân tộc ở Tây Nguyên. Trong phần giới thiệu cần nói rõ phạm vi này.

### 3.2. Tính năng mở rộng — chỉ làm khi MVP đã ổn định

- Chế độ VR.
- Nhân vật hướng dẫn ảo.
- Phụ đề đồng bộ với thuyết minh.
- Song ngữ Việt–Anh.
- Hệ thống thu thập con dấu sau mỗi khu.
- Hoạt ảnh dệt vải hoặc video tư liệu.
- Mini-game ghép họa tiết/trang phục.
- Hiệu ứng chuyển thời gian ngày–đêm.

### 3.3. Ngoài phạm vi trong tháng đầu

- Multiplayer hoặc tham quan trực tuyến nhiều người.
- Tự do thay trang phục cho nhân vật 3D.
- Mô phỏng vật lý vải thời gian thực chất lượng cao.
- Tái tạo chính xác một bảo tàng thực tế ở tỷ lệ 1:1.
- Xây dựng toàn bộ trang phục của tất cả các dân tộc Tây Nguyên.
- Phiên bản mobile, WebGL và PC đồng thời.
- Hệ thống tài khoản, cơ sở dữ liệu trực tuyến hoặc lưu tiến trình trên máy chủ.

## 4. Ý tưởng trải nghiệm

### 4.1. Luồng người dùng

1. Người dùng mở ứng dụng và xem menu chính.
2. Chọn **Bắt đầu tham quan**.
3. Xuất hiện tại sảnh, xem hướng dẫn điều khiển ngắn.
4. Quan sát sơ đồ và chọn một trong bốn khu trưng bày.
5. Đến gần hiện vật; hệ thống hiển thị lời nhắc tương tác.
6. Mở bảng thông tin, xoay mô hình hoặc nghe thuyết minh.
7. Tiếp tục tham quan các khu còn lại.
8. Khi đã xem đủ nội dung, người dùng đến khu trắc nghiệm.
9. Hoàn thành 5 câu hỏi và nhận kết quả.
10. Quay lại bảo tàng hoặc kết thúc trải nghiệm.

### 4.2. Bố cục không gian đề xuất

- **Sảnh chính:** tên dự án, lời giới thiệu, sơ đồ, hướng dẫn điều khiển và lối vào 4 khu.
- **Khu 1 – Ê Đê:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu 2 – Ba Na:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu 3 – Gia Rai:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu 4 – M’nông:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu cuối:** trắc nghiệm, lời cảm ơn và danh sách nguồn tham khảo.

Không gian nên sử dụng một hệ kiến trúc thống nhất, lấy cảm hứng từ vật liệu và không khí Tây Nguyên nhưng tránh trộn lẫn tùy tiện các biểu tượng văn hóa khác nhau. Họa tiết trang trí chỉ được dùng khi đã xác minh nguồn và ý nghĩa.

### 4.3. Phong cách hình ảnh

- Mức độ chi tiết trung bình, ưu tiên sạch, rõ và chạy ổn định.
- Màu nền trung tính để trang phục là điểm nhấn.
- Ánh sáng ấm, dịu; không lạm dụng hiệu ứng hậu kỳ.
- Kích thước chữ đủ lớn, độ tương phản tốt và khoảng đọc thuận tiện.
- Các khu được phân biệt bằng biển tên, bố cục và nội dung thay vì gán màu sắc tùy ý cho từng dân tộc.

## 5. Phân công 4 thành viên

### Thành viên 1 — Trưởng nhóm và lập trình gameplay

**Trách nhiệm chính:**

- Quản lý phạm vi, lịch làm việc và phiên bản Git.
- Tạo project Unity và cấu trúc thư mục.
- Lập trình di chuyển, camera, tương tác, quản lý trạng thái và chuyển scene.
- Tích hợp toàn bộ module vào scene chính.
- Theo dõi bug và tạo bản build định kỳ.

**Bàn giao:** bộ điều khiển người chơi, hệ thống tương tác, scene tích hợp và các bản build.

### Thành viên 2 — 3D Environment và kỹ thuật hình ảnh

**Trách nhiệm chính:**

- Thiết kế mặt bằng bảo tàng.
- Dựng/modular hóa tường, sàn, bục, tủ kính, đèn và biển chỉ dẫn.
- Thiết lập vật liệu, ánh sáng, lightmap, collider và occlusion.
- Tối ưu polygon, texture và draw call.
- Hỗ trợ chỉnh sửa các mô hình trang phục.

**Bàn giao:** môi trường bảo tàng hoàn chỉnh, prefab kiến trúc và cấu hình ánh sáng.

### Thành viên 3 — Trang phục 3D và nghiên cứu nội dung

**Trách nhiệm chính:**

- Lập danh sách hiện vật và thu thập nguồn đáng tin cậy.
- Ghi lại nguồn ảnh, tác giả, giấy phép và ngày truy cập.
- Dựng, chỉnh sửa hoặc chuẩn hóa 8 mô hình trang phục/mannequin.
- Tạo texture và material phù hợp.
- Viết nội dung giới thiệu, mô tả hiện vật và kịch bản thuyết minh.
- Nhờ người có chuyên môn hoặc giảng viên kiểm tra nội dung nếu có thể.

**Bàn giao:** bộ hiện vật tối ưu, nội dung đã duyệt và danh mục tài liệu tham khảo.

### Thành viên 4 — UI/UX, âm thanh, kiểm thử và hồ sơ

**Trách nhiệm chính:**

- Thiết kế menu, HUD, bảng thông tin, cài đặt và màn hình trắc nghiệm.
- Lập trình hoặc phối hợp lập trình UI và quiz.
- Thu âm, xử lý tiếng, nhạc nền và âm thanh tương tác.
- Viết test case, tổ chức kiểm thử và tổng hợp bug.
- Chuẩn bị báo cáo, slide, video demo và hướng dẫn sử dụng.

**Bàn giao:** UI hoàn chỉnh, âm thanh, bộ test, tài liệu và video.

### Nguyên tắc phối hợp

- Mỗi hạng mục có đúng một người chịu trách nhiệm chính nhưng phải có ít nhất một người review.
- Thành viên 1 review mã nguồn và tích hợp.
- Thành viên 3 review mọi nội dung văn hóa trước khi đưa vào build.
- Thành viên 4 review trải nghiệm người dùng và chất lượng tài liệu.
- Khi một người bị chậm quá 1 ngày, trưởng nhóm phải giảm phạm vi hoặc chuyển người hỗ trợ ngay.

## 6. Kế hoạch 4 tuần

### Tuần 1 — Chốt phạm vi, nghiên cứu và dựng nguyên mẫu

**Mục tiêu tuần:** Có bản prototype đi lại được trong bảo tàng dạng khối xám và bộ dữ liệu nội dung ban đầu.

### Ngày 1 — Khởi động

- Cả nhóm thống nhất MVP, nền tảng, độ phân giải, phong cách và tiêu chí hoàn thành.
- Chia vai trò và tạo bảng công việc với các cột: Backlog, Tuần này, Đang làm, Chờ review, Hoàn thành.
- Tạo repository Git, file `.gitignore` cho Unity và quy tắc đặt tên.
- Chọn phiên bản Unity LTS; không đổi phiên bản giữa dự án.
- Thành viên 1 tạo project, scene Bootstrap, MainMenu và Museum.
- Thành viên 3 lập danh sách hiện vật dự kiến và biểu mẫu ghi nguồn.

**Kết quả cuối ngày:** project mở được trên cả 4 máy, mọi người commit/pull thành công.

### Ngày 2 — Thiết kế trải nghiệm

- Thành viên 1 viết luồng game và kiến trúc hệ thống.
- Thành viên 2 vẽ mặt bằng bảo tàng và blockout sảnh cùng 4 khu.
- Thành viên 3 xác định 8 hiện vật có đủ tài liệu tham khảo.
- Thành viên 4 tạo wireframe cho menu, bảng thông tin và quiz.
- Cả nhóm duyệt phạm vi nội dung, loại bỏ hiện vật không đủ nguồn hoặc quá khó dựng.

**Kết quả cuối ngày:** sơ đồ mặt bằng, wireframe UI và danh sách hiện vật phiên bản 1.

### Ngày 3 — Prototype điều khiển

- Thành viên 1 hoàn thiện đi, nhìn, va chạm, khóa con trỏ và menu tạm dừng.
- Thành viên 2 dựng blockout toàn bộ bảo tàng bằng primitive/modular mesh.
- Thành viên 3 bắt đầu chuẩn hóa 2 hiện vật đầu tiên.
- Thành viên 4 dựng Main Menu và màn hình hướng dẫn.

**Kết quả cuối ngày:** người dùng vào được scene và đi qua các khu.

### Ngày 4 — Prototype tương tác

- Thành viên 1 làm raycast tương tác, lời nhắc và giao diện dữ liệu hiện vật.
- Thành viên 2 thêm bục trưng bày, khoảng cách quan sát và collider.
- Thành viên 3 hoàn thiện nội dung nháp cho 2 khu đầu.
- Thành viên 4 tạo prefab bảng thông tin và kiểm tra khả năng đọc.

**Kết quả cuối ngày:** tương tác thử với ít nhất 1 hiện vật placeholder.

### Ngày 5 — Review mốc 1

- Ghép Main Menu, scene Museum, controller và panel thông tin.
- Chạy thử trên ít nhất 2 máy khác nhau.
- Ghi bug và đánh giá khối lượng còn lại.
- Khóa layout chính; chỉ sửa nếu có lỗi luồng hoặc hiệu năng.
- Sao lưu một bản build nội bộ.

**Mốc nghiệm thu tuần 1:** menu hoạt động, đi lại được, có 4 khu dạng blockout, 1 hiện vật tương tác mẫu và danh mục nội dung có nguồn.

### Tuần 2 — Sản xuất tài sản và tính năng cốt lõi

**Mục tiêu tuần:** Hoàn thiện phần lớn môi trường, đủ 8 hiện vật và toàn bộ chức năng bắt buộc ở mức alpha.

### Ngày 6

- Thành viên 1 chuyển hệ thống hiện vật sang cấu trúc dữ liệu dùng ScriptableObject hoặc JSON nội bộ.
- Thành viên 2 hoàn thiện kiến trúc sảnh và khu 1.
- Thành viên 3 xử lý hiện vật 1–2 và texture.
- Thành viên 4 hoàn thiện panel thông tin và hiệu ứng mở/đóng.

### Ngày 7

- Thành viên 1 làm chế độ xem hiện vật: khóa di chuyển, xoay và phóng to.
- Thành viên 2 hoàn thiện khu 2 và hệ thống biển chỉ dẫn.
- Thành viên 3 xử lý hiện vật 3–4, rà soát tỷ lệ mannequin.
- Thành viên 4 làm cài đặt âm lượng, độ nhạy chuột và phụ đề tĩnh nếu cần.

### Ngày 8

- Thành viên 1 làm Audio Guide Controller và đánh dấu hiện vật đã xem.
- Thành viên 2 hoàn thiện khu 3, vật liệu và ánh sáng thử.
- Thành viên 3 xử lý hiện vật 5–6 và viết kịch bản thuyết minh.
- Thành viên 4 thu thử giọng, xử lý tạp âm và xuất file chuẩn.

### Ngày 9

- Thành viên 1 hỗ trợ tích hợp quiz và dữ liệu nội dung.
- Thành viên 2 hoàn thiện khu 4 và khu trắc nghiệm.
- Thành viên 3 xử lý hiện vật 7–8, hoàn thiện mô tả ngắn.
- Thành viên 4 xây hệ thống quiz 5 câu, tính điểm và màn hình kết quả.

### Ngày 10 — Review mốc 2

- Tích hợp đủ 8 hiện vật vào đúng khu.
- Kiểm tra kích thước mô hình, collider, hướng đặt và ánh sáng.
- Kiểm tra tất cả panel và đường dẫn âm thanh.
- Tạo bản build Alpha 0.1.
- Cả nhóm chơi từ đầu đến cuối và phân loại bug theo P0/P1/P2/P3.

**Mốc nghiệm thu tuần 2:** đủ 4 khu, 8 hiện vật, bảng thông tin, xoay mô hình, audio guide mẫu và quiz hoạt động. Hình ảnh có thể chưa hoàn thiện nhưng luồng trải nghiệm phải đầy đủ.

### Tuần 3 — Hoàn thiện nội dung, hình ảnh và trải nghiệm

**Mục tiêu tuần:** Đưa bản alpha thành bản beta hoàn chỉnh về nội dung và gần đạt chất lượng trình bày cuối.

### Ngày 11

- Sửa toàn bộ lỗi P0/P1 của bản Alpha 0.1.
- Thành viên 2 thay các asset placeholder quan trọng.
- Thành viên 3 kiểm tra lại tên gọi, chính tả, nguồn và tính nhất quán.
- Thành viên 4 thu âm chính thức cho khu 1–2.

### Ngày 12

- Tối ưu thao tác xem hiện vật và khoảng cách tương tác.
- Hoàn thiện vật liệu tủ kính, sàn, tường và trang phục.
- Thu âm chính thức cho khu 3–4.
- Thêm phụ đề cho nội dung thuyết minh nếu tiến độ cho phép.

### Ngày 13

- Bake lighting và light probe.
- Cấu hình occlusion culling, LOD hoặc giảm mesh đối với vật thể nặng.
- Chuẩn hóa texture, nén âm thanh và kích thước file.
- Hoàn thiện âm thanh môi trường, nút bấm và tương tác.

### Ngày 14

- Thêm biển chỉ dẫn, hướng dẫn điều khiển và phản hồi khi tương tác.
- Hoàn thiện trang Giới thiệu, Credits và Tài liệu tham khảo.
- Kiểm tra nội dung văn hóa lần cuối với giảng viên/người am hiểu nếu có.
- Kiểm tra UI ở các độ phân giải 1920×1080, 1600×900 và 1366×768.

### Ngày 15 — Review mốc 3

- Đóng băng tính năng: không thêm tính năng mới sau ngày này.
- Tạo bản Beta 0.5 và kiểm thử trên ít nhất 3 máy.
- Mời 3–5 người ngoài nhóm trải nghiệm mà không được hướng dẫn trực tiếp.
- Ghi thời gian hoàn thành, điểm bị lạc, nội dung khó đọc và lỗi gặp phải.
- Chốt danh sách sửa cho tuần cuối.

**Mốc nghiệm thu tuần 3:** toàn bộ nội dung đã có, không còn placeholder quan trọng, ánh sáng và âm thanh gần hoàn chỉnh, người mới có thể tự hoàn thành trải nghiệm.

### Tuần 4 — Kiểm thử, tối ưu và đóng gói

**Mục tiêu tuần:** Có bản Release ổn định cùng đầy đủ hồ sơ bảo vệ.

### Ngày 16

- Sửa lỗi P0/P1 từ buổi user test.
- Điều chỉnh luồng chỉ dẫn ở các vị trí người dùng thường bị lạc.
- Rút gọn đoạn văn dài; bảo đảm bảng thông tin dễ đọc trong 20–40 giây.
- Kiểm tra mọi liên kết nguồn và credits.

### Ngày 17

- Dùng Unity Profiler kiểm tra CPU, GPU, memory và số draw call.
- Giảm texture quá lớn, vật thể không cần thiết và ánh sáng thời gian thực.
- Kiểm tra rò rỉ âm thanh, scene load và nút thoát.
- Tạo build Release Candidate 1.

### Ngày 18

- Kiểm thử hồi quy toàn bộ test case trên máy sạch.
- Sửa lỗi P1 còn lại và các lỗi P2 có ảnh hưởng rõ đến trình bày.
- Hoàn thiện README/hướng dẫn chạy và danh sách cấu hình máy.
- Chụp ảnh màn hình chất lượng cao cho báo cáo và slide.

### Ngày 19

- Tạo video demo 3–5 phút: mở đầu, mục tiêu, luồng tham quan, hiện vật, quiz và kết luận.
- Hoàn thành báo cáo và slide.
- Phân chia phần thuyết trình cho 4 thành viên.
- Tạo build Release Candidate 2 và thử trên thiết bị trình chiếu.

### Ngày 20 — Đóng gói và diễn tập

- Chỉ sửa lỗi nghiêm trọng; không thay đổi kiến trúc hoặc nội dung lớn.
- Đóng gói bản Release 1.0, source code, báo cáo, slide, video và tài liệu tham khảo.
- Kiểm tra file sau khi sao chép sang USB hoặc tải xuống từ cloud.
- Cả nhóm diễn tập 2 lần, một lần đúng kịch bản và một lần xử lý tình huống lỗi.
- Chuẩn bị video demo offline làm phương án dự phòng.

**Mốc nghiệm thu tuần 4:** bản Release 1.0 chạy ổn định, đầy đủ tài liệu, video và phương án trình bày dự phòng.

## 7. Kiến trúc kỹ thuật đề xuất

### 7.1. Scene

- `Bootstrap`: khởi tạo các manager và tải cấu hình.
- `MainMenu`: menu, hướng dẫn, credits và thoát.
- `Museum`: toàn bộ không gian bảo tàng và các khu trưng bày.

Nên giữ bảo tàng trong một scene nếu quy mô nhỏ để giảm rủi ro chuyển scene. Chỉ tách scene khi thời gian tải hoặc dung lượng thật sự trở thành vấn đề.

### 7.2. Module chính

- `GameManager`: quản lý trạng thái chung.
- `PlayerController`: di chuyển, nhìn và khóa điều khiển.
- `InteractionController`: raycast và gọi hành vi của đối tượng.
- `ExhibitData`: tên, dân tộc, mô tả, ảnh, âm thanh, nguồn và prefab.
- `ExhibitViewer`: hiển thị, xoay và zoom hiện vật.
- `UIManager`: mở/đóng panel, menu và thông báo.
- `AudioManager`: nhạc nền, hiệu ứng và thuyết minh.
- `QuizManager`: câu hỏi, đáp án, điểm và kết quả.
- `SettingsManager`: âm lượng, độ nhạy và chất lượng đồ họa.

### 7.3. Cấu trúc thư mục Unity

```text
Assets/
├── _Project/
│   ├── Art/
│   │   ├── Characters/
│   │   ├── Costumes/
│   │   ├── Environment/
│   │   ├── Materials/
│   │   └── Textures/
│   ├── Audio/
│   │   ├── Music/
│   │   ├── SFX/
│   │   └── VoiceOver/
│   ├── Data/
│   ├── Prefabs/
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

### 7.4. Quy tắc asset

- Mô hình: `SM_TenDoiTuong` cho static mesh, `SK_TenDoiTuong` cho skinned mesh.
- Material: `M_TenVatLieu`.
- Texture: `T_TenDoiTuong_Loai`, ví dụ `T_Ao_EDe_BaseColor`.
- Prefab: `PF_TenDoiTuong`.
- Scene: `SC_TenScene`.
- Script C#: tên PascalCase và trùng tên class.
- Audio: `VO_`, `SFX_`, `BGM_` theo loại.
- Không dùng tên file như `new`, `final`, `final2` hoặc tiếng Việt có dấu trong tên asset.

## 8. Quy trình Git và quản lý công việc

### 8.1. Nhánh làm việc

- `main`: chỉ chứa phiên bản đã ổn định và có thể build.
- `develop`: nơi tích hợp công việc hằng ngày.
- `feature/<ten-tinh-nang>`: mỗi tính năng hoặc nhóm asset có một nhánh riêng.
- `fix/<ten-loi>`: dành cho sửa lỗi.

### 8.2. Quy tắc commit

- Commit nhỏ, mô tả rõ: `feat: add exhibit interaction`, `fix: prevent player falling`, `art: add Ede exhibit textures`.
- Pull trước khi bắt đầu làm và trước khi merge.
- Không để hai người cùng sửa một scene hoặc prefab lớn trong cùng thời điểm.
- Khi làm scene, thông báo trên nhóm và dùng prefab để giảm xung đột.
- Mỗi ngày đẩy code ít nhất một lần khi phần đang làm ở trạng thái an toàn.
- Không commit thư mục `Library`, `Temp`, `Logs`, `Obj`, `Build` và file build lớn.

### 8.3. Nhịp làm việc

- Họp đứng 10–15 phút đầu ngày: hôm qua làm gì, hôm nay làm gì, đang vướng gì.
- Cuối ngày cập nhật bảng công việc và gửi ảnh/video ngắn về phần đã hoàn thành.
- Chiều thứ Sáu tạo build và review chung.
- Mỗi task nên hoàn thành trong 0,5–2 ngày; task lớn hơn phải chia nhỏ.

## 9. Quy trình nghiên cứu và kiểm duyệt văn hóa

Đây là phần có mức ưu tiên ngang với kỹ thuật. Nội dung đẹp nhưng sai hoặc gán nhầm dân tộc sẽ làm giảm nghiêm trọng chất lượng đề tài.

### 9.1. Thứ tự ưu tiên nguồn

1. Bảo tàng, cơ quan văn hóa, thư viện hoặc cơ sở dữ liệu chính thức.
2. Sách, bài báo khoa học, luận văn và tài liệu của nhà nghiên cứu có chuyên môn.
3. Tài liệu từ cộng đồng, nghệ nhân hoặc phỏng vấn có ghi rõ người cung cấp.
4. Báo chí uy tín.
5. Blog và mạng xã hội chỉ dùng để tìm đầu mối, không dùng làm nguồn duy nhất.

### 9.2. Thông tin cần lưu cho mỗi hiện vật

- Mã hiện vật nội bộ.
- Tên gọi và các cách viết khác nếu có.
- Dân tộc/cộng đồng liên quan.
- Giới tính hoặc đối tượng sử dụng nếu nguồn có nêu.
- Dịp sử dụng.
- Chất liệu và kỹ thuật chế tác.
- Ý nghĩa họa tiết chỉ khi có nguồn xác nhận.
- Địa bàn và giai đoạn tư liệu.
- Nguồn văn bản, nguồn ảnh, giấy phép và ngày truy cập.
- Người viết và người kiểm tra nội dung.

### 9.3. Nguyên tắc trình bày

- Không khẳng định mọi thành viên của một dân tộc đều mặc giống nhau.
- Ghi rõ biến thể theo địa phương hoặc thời kỳ nếu tài liệu cho phép.
- Không tự suy diễn ý nghĩa màu sắc và họa tiết.
- Không dùng hình ảnh hoặc mô hình tải trên mạng khi chưa rõ quyền sử dụng.
- Không trộn trang phục, nhạc cụ, kiến trúc và họa tiết của các cộng đồng khác nhau chỉ để trang trí.
- Nếu chưa xác minh được chi tiết, dùng mô tả trung tính hoặc loại bỏ chi tiết đó.

## 10. Kiểm thử và tiêu chuẩn nghiệm thu

### 10.1. Mức độ lỗi

- **P0 – Chặn hoàn toàn:** không mở được game, crash, mất scene hoặc hỏng dữ liệu. Sửa ngay.
- **P1 – Nghiêm trọng:** không thể tương tác, mắc kẹt, không hoàn thành quiz, âm thanh không dừng. Phải sửa trước release.
- **P2 – Trung bình:** UI lệch, sai ánh sáng, animation không mượt, lỗi chính tả. Sửa nếu còn thời gian sau P0/P1.
- **P3 – Nhỏ:** chi tiết thẩm mỹ ít ảnh hưởng. Ghi nhận nhưng không được làm trễ release.

### 10.2. Test case bắt buộc

1. Mở ứng dụng từ file `.exe` trên máy không cài Unity.
2. Tất cả nút menu hoạt động đúng.
3. Người dùng không đi xuyên tường, rơi khỏi sàn hoặc bị kẹt.
4. Tương tác được với đủ 8 hiện vật.
5. Bảng thông tin đúng hiện vật, không tràn chữ và đóng được.
6. Khi xem hiện vật, người dùng xoay/zoom được và quay lại chế độ đi lại được.
7. Mỗi thuyết minh phát đúng, không phát chồng và chịu ảnh hưởng của âm lượng.
8. Quiz hiển thị đủ câu, tính điểm đúng và có thể chơi lại.
9. Pause/resume không làm mất chuột hoặc khóa điều khiển sai.
10. Quay lại menu rồi vào lại bảo tàng không gây lỗi trạng thái.
11. Giao diện hiển thị tốt ở ba độ phân giải mục tiêu.
12. Chơi liên tục 15–20 phút không crash hoặc tăng bộ nhớ bất thường.

### 10.3. Chỉ tiêu hiệu năng

- Mục tiêu: 60 FPS; ngưỡng chấp nhận: trung bình 45 FPS trên máy kiểm thử.
- Không dùng texture 4K trừ một số hiện vật thật sự cần thiết; ưu tiên 1K–2K.
- Hạn chế đèn realtime; ưu tiên baked lighting.
- Dùng collider đơn giản thay vì Mesh Collider khi có thể.
- Nén audio phù hợp và tránh nạp đồng thời toàn bộ file dài.
- Kiểm tra profiler trước khi giảm chất lượng hình ảnh một cách cảm tính.

## 11. Quản lý rủi ro

### Rủi ro 1 — Không kịp dựng đủ trang phục

- **Khả năng:** cao.
- **Xử lý:** dùng mannequin chung; ưu tiên chỉnh sửa asset có giấy phép phù hợp; mỗi khu chỉ cần 2 hiện vật; chấp nhận một số hiện vật trình bày bằng mô hình đơn giản kết hợp ảnh tư liệu nếu được ghi rõ.
- **Mốc quyết định:** cuối ngày 7. Nếu chưa có 4 hiện vật, phải giảm độ chi tiết thay vì tăng giờ làm vô hạn.

### Rủi ro 2 — Nội dung văn hóa sai hoặc thiếu nguồn

- **Khả năng:** trung bình; **ảnh hưởng:** rất cao.
- **Xử lý:** tạo danh mục nguồn từ tuần 1, review chéo, xin ý kiến giảng viên/người am hiểu và loại bỏ khẳng định không xác minh được.
- **Mốc quyết định:** khóa nội dung vào ngày 14.

### Rủi ro 3 — Xung đột scene/prefab trên Git

- **Khả năng:** cao.
- **Xử lý:** chia scene/prefab theo khu, thông báo trước khi sửa, merge hằng ngày và chỉ để một người tích hợp scene chính.

### Rủi ro 4 — Hiệu năng thấp

- **Khả năng:** trung bình.
- **Xử lý:** giới hạn polygon/texture từ đầu, dùng baked lighting, kiểm tra profiler ở tuần 2 và tuần 4, có preset Low/Medium.

### Rủi ro 5 — Thêm quá nhiều tính năng

- **Khả năng:** cao.
- **Xử lý:** ưu tiên MVP; đóng băng tính năng ngày 15; mọi ý tưởng mới đưa vào danh sách mở rộng thay vì làm ngay.

### Rủi ro 6 — Máy thuyết trình không chạy được

- **Khả năng:** trung bình.
- **Xử lý:** thử build trên máy trình chiếu trước ngày 19; mang theo build ở USB và cloud; chuẩn bị video demo offline.

## 12. Danh sách bàn giao cuối dự án

- `MuseumTayNguyen_v1.0_Windows.zip` chứa bản build.
- Source Unity đã loại bỏ thư mục cache không cần thiết.
- File README hướng dẫn cài đặt, điều khiển và cấu hình.
- Báo cáo dự án.
- Slide thuyết trình.
- Video demo 3–5 phút.
- Ảnh chụp màn hình/poster.
- Danh sách thành viên và phần đóng góp.
- Danh mục nguồn nội dung, hình ảnh, âm thanh, font và asset 3D.
- Danh sách lỗi đã biết nếu còn.
- File dự phòng trên ít nhất hai nơi lưu trữ khác nhau.

## 13. Kịch bản thuyết trình đề xuất

Tổng thời lượng nên từ 10–12 phút:

1. **Thành viên 1 — 2 phút:** vấn đề, mục tiêu, phạm vi và kiến trúc hệ thống.
2. **Thành viên 2 — 2 phút:** thiết kế không gian, quy trình dựng môi trường và tối ưu.
3. **Thành viên 3 — 2 phút:** nghiên cứu trang phục, nguồn tư liệu và quy trình kiểm duyệt văn hóa.
4. **Thành viên 4 — 2 phút:** UI/UX, âm thanh, kiểm thử và kết quả user test.
5. **Demo trực tiếp — 3 phút:** menu, một khu trưng bày, thao tác xem hiện vật, audio guide và quiz.
6. **Kết luận — 1 phút:** kết quả, hạn chế và hướng phát triển VR/mở rộng nội dung.

## 14. Việc cần làm ngay trong buổi đầu tiên

- Chốt tên 4 thành viên tương ứng với 4 vai trò.
- Xác nhận cấu hình máy yếu nhất trong nhóm và máy dùng để thuyết trình.
- Chọn chính xác phiên bản Unity LTS và render pipeline.
- Tạo repository, `.gitignore`, bảng task và kênh trao đổi.
- Duyệt danh sách 8 hiện vật sơ bộ.
- Vẽ mặt bằng bảo tàng trên một trang giấy hoặc Figma.
- Tạo build rỗng đầu tiên để phát hiện sớm vấn đề môi trường.
- Đặt lịch cố định cho review cuối mỗi tuần.

## 15. Nguyên tắc ưu tiên khi thiếu thời gian

Nếu tiến độ bị chậm, giảm phạm vi theo thứ tự sau:

1. Bỏ tính năng mở rộng như VR, song ngữ và mini-game.
2. Giảm đồ trang trí và hiệu ứng môi trường.
3. Dùng một layout bảo tàng đơn giản hơn.
4. Giảm số đoạn voice-over nhưng vẫn giữ bảng thông tin.
5. Giảm độ chi tiết mô hình nhưng vẫn giữ đủ 8 hiện vật.

Không được cắt các phần: tính chính xác và nguồn của nội dung, luồng tham quan hoàn chỉnh, khả năng tương tác cơ bản, kiểm thử bản build và tài liệu bàn giao.
