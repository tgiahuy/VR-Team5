# KẾ HOẠCH DỰ ÁN UNITY TRONG 1 THÁNG

## 1. Thông tin chung

- **Tên đề tài:** Mô phỏng bảo tàng trưng bày trang phục truyền thống của đồng bào Tây Nguyên.
- **Thời gian thực hiện:** 4 tuần, tương đương 20 ngày làm việc chính; các ngày cuối tuần là thời gian dự phòng.
- **Nền tảng mục tiêu:** PC Windows, điều khiển bằng bàn phím và chuột.
- **Công cụ chính:** Unity LTS, Blender, Git/GitHub, Photoshop/GIMP/Krita, Audacity và một bảng công việc cá nhân (Trello/Notion/GitHub Projects).
- **Sản phẩm cuối:** Một ứng dụng bảo tàng ảo chạy độc lập, cho phép người dùng tham quan, xem mô hình trang phục, đọc/nghe thuyết minh và hoàn thành một hoạt động tương tác ngắn.

> **Lưu ý về việc làm một mình:** Toàn bộ khối lượng do một người đảm nhiệm nên mọi công việc diễn ra tuần tự, không song song. Vì vậy phạm vi được rút gọn có chủ đích (xem mục 3), ưu tiên dùng asset có giấy phép phù hợp và ảnh tư liệu thay cho việc tự dựng mọi mô hình. Nguyên tắc xuyên suốt: **hoàn thiện luồng end-to-end trước, bổ sung nội dung sau, đánh bóng cuối cùng.**

## 2. Mục tiêu dự án

### 2.1. Mục tiêu chính

Xây dựng một bảo tàng ảo 3D quy mô nhỏ, giới thiệu trang phục truyền thống của một số dân tộc tại Tây Nguyên theo cách trực quan, dễ sử dụng và tôn trọng giá trị văn hóa.

Người dùng có thể:

- Đi lại tự do trong không gian bảo tàng.
- Tham quan ít nhất 3 khu trưng bày.
- Quan sát trang phục dưới dạng mô hình 3D hoặc hình ảnh tư liệu từ nhiều góc độ.
- Đọc thông tin về tên trang phục, dân tộc, chất liệu, hoàn cảnh sử dụng và ý nghĩa văn hóa.
- Nghe thuyết minh ngắn hoặc xem hình ảnh tư liệu tại từng khu.
- Thực hiện một bài trắc nghiệm cuối hành trình.
- Quay lại sảnh chính, mở hướng dẫn hoặc thoát ứng dụng bất cứ lúc nào.

### 2.2. Mục tiêu học thuật

- Vận dụng Unity để xây dựng môi trường 3D và hệ thống tương tác.
- Áp dụng quy trình làm việc cá nhân có kỷ luật với Git.
- Nghiên cứu, chọn lọc và trình bày dữ liệu văn hóa có nguồn rõ ràng.
- Tối ưu ứng dụng để chạy ổn định trên máy tính tầm trung.
- Hoàn thiện hồ sơ dự án gồm báo cáo, video demo, slide thuyết trình và bản build.

### 2.3. Tiêu chí thành công

Dự án được xem là hoàn thành khi đáp ứng tất cả điều kiện sau:

- Có bản build Windows mở và chạy được mà không cần Unity Editor.
- Người dùng có thể hoàn thành luồng: menu → sảnh → 3 khu trưng bày → trắc nghiệm → màn hình kết quả.
- Có tối thiểu 6 hiện vật trang phục, trung bình 2 hiện vật cho mỗi khu.
- Mỗi hiện vật có mô hình hoặc hình ảnh minh họa, bảng thông tin và nguồn tham khảo.
- Có ít nhất 3 đoạn thuyết minh âm thanh, mỗi đoạn từ 30–60 giây.
- Không có lỗi nghiêm trọng làm người chơi mắc kẹt, rơi khỏi bản đồ hoặc không thể hoàn tất trải nghiệm.
- Ứng dụng đạt trung bình từ 45 FPS trở lên trên máy kiểm thử mục tiêu ở thiết lập mặc định.
- Có báo cáo, slide, poster hoặc ảnh đại diện, video demo 3–5 phút và hướng dẫn chạy.

## 3. Phạm vi thực hiện

### 3.1. Phạm vi bắt buộc — MVP (đã rút gọn cho một người)

Đây là phần phải hoàn thành trước khi làm bất kỳ tính năng mở rộng nào:

1. Menu chính gồm Bắt đầu, Hướng dẫn, Giới thiệu và Thoát.
2. Một sảnh chính và **3 khu trưng bày** đại diện cho Ê Đê, Ba Na và Gia Rai (chọn theo mức độ sẵn có của nguồn tư liệu).
3. Tối thiểu **6 hiện vật** trang phục (2 hiện vật/khu).
4. Hệ thống di chuyển góc nhìn thứ nhất bằng bàn phím và chuột.
5. Tương tác bằng tâm ngắm và phím `E` hoặc nhấp chuột.
6. Bảng thông tin hiện vật có ảnh, tên, mô tả ngắn và nguồn.
7. Chế độ xoay/phóng to mô hình trang phục tại điểm trưng bày.
8. Âm thanh nền nhẹ, âm thanh tương tác và ít nhất **3 đoạn thuyết minh**.
9. Bản đồ sơ đồ bảo tàng hoặc biển chỉ dẫn.
10. Trắc nghiệm 5 câu và màn hình kết quả.
11. Menu tạm dừng, chỉnh âm lượng và quay lại menu chính.
12. Bản build Windows đã kiểm thử.

Việc rút gọn còn 3 dân tộc chỉ nhằm giới hạn khối lượng cho một người trong một tháng, **không** mang ý nghĩa đại diện đầy đủ cho toàn bộ cộng đồng các dân tộc ở Tây Nguyên. Phần Giới thiệu phải nói rõ phạm vi và lý do này.

**Chiến lược tài sản (asset):** Ưu tiên tối đa việc dùng mannequin/asset có giấy phép phù hợp kết hợp ảnh tư liệu có nguồn rõ ràng; chỉ tự dựng trong Blender khi không có phương án thay thế và ở mức low-poly đơn giản. Mọi asset đều phải ghi nguồn và giấy phép.

### 3.2. Tính năng mở rộng — chỉ làm khi MVP đã ổn định và còn thời gian

- Khu thứ 4 (M’nông) và các hiện vật bổ sung.
- Chế độ VR.
- Nhân vật hướng dẫn ảo.
- Phụ đề đồng bộ với thuyết minh.
- Song ngữ Việt–Anh.
- Hệ thống thu thập con dấu sau mỗi khu.
- Hoạt ảnh dệt vải hoặc video tư liệu.
- Mini-game ghép họa tiết/trang phục.

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
4. Quan sát sơ đồ và chọn một trong ba khu trưng bày.
5. Đến gần hiện vật; hệ thống hiển thị lời nhắc tương tác.
6. Mở bảng thông tin, xoay mô hình hoặc nghe thuyết minh.
7. Tiếp tục tham quan các khu còn lại.
8. Khi đã xem đủ nội dung, người dùng đến khu trắc nghiệm.
9. Hoàn thành 5 câu hỏi và nhận kết quả.
10. Quay lại bảo tàng hoặc kết thúc trải nghiệm.

### 4.2. Bố cục không gian đề xuất

- **Sảnh chính:** tên dự án, lời giới thiệu, sơ đồ, hướng dẫn điều khiển và lối vào 3 khu.
- **Khu 1 – Ê Đê:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu 2 – Ba Na:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu 3 – Gia Rai:** 2 hiện vật, 1 bảng giới thiệu chung, 1 điểm nghe thuyết minh.
- **Khu cuối:** trắc nghiệm, lời cảm ơn và danh sách nguồn tham khảo.

Nếu tiến độ vượt kế hoạch, có thể bổ sung **Khu 4 – M’nông** theo đúng khuôn mẫu trên (xem mục 3.2).

Không gian nên dùng một hệ kiến trúc thống nhất, lấy cảm hứng từ vật liệu và không khí Tây Nguyên nhưng tránh trộn lẫn tùy tiện các biểu tượng văn hóa khác nhau. Họa tiết trang trí chỉ được dùng khi đã xác minh nguồn và ý nghĩa.

### 4.3. Phong cách hình ảnh

- Mức độ chi tiết trung bình, ưu tiên sạch, rõ và chạy ổn định.
- Màu nền trung tính để trang phục là điểm nhấn.
- Ánh sáng ấm, dịu; không lạm dụng hiệu ứng hậu kỳ.
- Kích thước chữ đủ lớn, độ tương phản tốt và khoảng đọc thuận tiện.
- Các khu được phân biệt bằng biển tên, bố cục và nội dung thay vì gán màu sắc tùy ý cho từng dân tộc.

## 5. Tổ chức công việc khi làm một mình

Vì chỉ có một người, thay cho việc phân vai là **các mảng công việc** được cùng một người đảm nhiệm luân phiên. Mục tiêu tổ chức là tránh làm dở dang nhiều thứ và luôn giữ được một bản chạy được.

### 5.1. Các mảng công việc

- **Gameplay & tích hợp:** di chuyển, camera, tương tác, quản lý trạng thái, chuyển scene, tạo build.
- **Môi trường 3D & hình ảnh:** mặt bằng, tường/sàn/bục/tủ kính/đèn/biển chỉ dẫn, vật liệu, ánh sáng, tối ưu.
- **Trang phục & nội dung:** danh sách hiện vật, thu thập nguồn/asset, chuẩn hóa mô hình, viết mô tả và kịch bản thuyết minh.
- **UI/UX, âm thanh, kiểm thử & hồ sơ:** menu, bảng thông tin, quiz, thu/xử lý âm thanh, test case, báo cáo, slide, video.

### 5.2. Nguyên tắc làm việc

- **Một hạng mục tại một thời điểm (WIP = 1):** làm xong và kiểm tra một việc rồi mới sang việc khác; tránh mở nhiều mảng dở dang.
- **End-to-end trước, nội dung sau, đánh bóng cuối:** ưu tiên có luồng đầy đủ (dù placeholder) rồi mới nâng chất lượng.
- **Tự review bằng checklist:** mỗi mảng có tiêu chí nghiệm thu riêng (xem `project_progress.md`); tự chạy thử trước khi đánh dấu hoàn thành.
- **Review nội dung văn hóa từ bên ngoài:** vì không có đồng đội review chéo, phải nhờ giảng viên hoặc người am hiểu kiểm tra nội dung trước khi khóa (mục 9).
- **Timebox:** nếu một hạng mục vượt quá thời lượng dự kiến, cắt độ chi tiết thay vì kéo dài vô hạn (mục 15).
- **Commit và build đều đặn:** commit nhỏ hằng ngày, tạo build ở cuối mỗi tuần để phát hiện lỗi sớm.

## 6. Kế hoạch 4 tuần

> Mỗi ngày nên có một mục tiêu duy nhất, rõ ràng. Nếu chậm, dời việc nhẹ (đánh bóng) sang cuối tuần dự phòng, không dời việc chặn luồng.

### Tuần 1 — Chốt phạm vi, nghiên cứu và dựng nguyên mẫu chơi được

**Mục tiêu tuần:** Có prototype đi lại được trong bảo tàng dạng khối xám, có 1 hiện vật tương tác mẫu và bộ dữ liệu nội dung ban đầu.

**Ngày 1 — Khởi động**

- Chốt MVP, nền tảng, độ phân giải, phong cách và tiêu chí hoàn thành.
- Chọn phiên bản Unity LTS và render pipeline; không đổi giữa dự án.
- Tạo repository Git, `.gitignore` cho Unity, quy tắc đặt tên và bảng công việc cá nhân.
- Tạo project và các scene `Bootstrap`, `MainMenu`, `Museum`; tạo cấu trúc thư mục `Assets/_Project`.
- Vẽ sơ đồ mặt bằng (sảnh + 3 khu + khu quiz) trên giấy hoặc Figma.
- Lập danh sách 6 hiện vật dự kiến và biểu mẫu ghi nguồn.
- **Kết quả:** project mở được, commit/pull thành công, có sơ đồ và danh sách hiện vật v1.

**Ngày 2 — Điều khiển người chơi + bắt đầu tìm nguồn**

- Hoàn thiện di chuyển `WASD`, camera chuột, va chạm, khóa/mở con trỏ và menu tạm dừng cơ bản.
- Tìm tối thiểu 2 nguồn tin cậy cho mỗi khu; đánh dấu hiện vật nào dùng được asset/ảnh có sẵn.
- **Kết quả:** người chơi đi và nhìn được trong scene trống; có danh mục nguồn ban đầu.

**Ngày 3 — Blockout môi trường**

- Dựng blockout toàn bộ bảo tàng bằng primitive/modular mesh (sảnh + 3 khu + khu quiz).
- Thêm collider cho sàn/tường, đặt bục hoặc tủ trưng bày mẫu.
- **Kết quả:** đi xuyên suốt bảo tàng không rơi/kẹt.

**Ngày 4 — Tương tác + dữ liệu hiện vật**

- Làm raycast tương tác, lời nhắc nhấn `E` và giao diện dữ liệu hiện vật.
- Tạo `ExhibitData` (ScriptableObject) và prefab bảng thông tin; gắn 1 hiện vật mẫu (ảnh + tên + mô tả + nguồn).
- **Kết quả:** tương tác và mở/đóng bảng thông tin với ít nhất 1 hiện vật placeholder.

**Ngày 5 — Ghép luồng + Review mốc 1**

- Hoàn thiện Main Menu (Bắt đầu/Hướng dẫn/Giới thiệu/Thoát) và màn hình hướng dẫn.
- Ghép Menu → Museum → tương tác thành một luồng liền mạch.
- Chạy thử trên ít nhất 2 máy, ghi bug, khóa layout chính, tạo bản build `Prototype_v0.1`.
- **Mốc nghiệm thu tuần 1:** menu hoạt động, đi lại được, 3 khu blockout, 1 hiện vật tương tác mẫu và danh mục nội dung có nguồn.

### Tuần 2 — Sản xuất tài sản và tính năng cốt lõi

**Mục tiêu tuần:** Đủ 6 hiện vật và toàn bộ chức năng bắt buộc ở mức alpha, luồng đi được từ đầu đến cuối.

**Ngày 6 — Chế độ xem hiện vật**

- Làm `ExhibitViewer`: khóa di chuyển khi mở, xoay và phóng to hiện vật.
- Hoàn thiện hiệu ứng mở/đóng panel thông tin.

**Ngày 7 — Khu 1 (Ê Đê)**

- Chuẩn bị/nhập hiện vật 1–2 (ưu tiên asset có sẵn + ảnh), đặt vào khu 1, viết nội dung nháp.

**Ngày 8 — Khu 2 (Ba Na) + âm thanh**

- Chuẩn bị hiện vật 3–4, đặt vào khu 2, viết nội dung nháp.
- Làm `AudioManager` và Audio Guide Controller; đánh dấu hiện vật đã xem.

**Ngày 9 — Khu 3 (Gia Rai) + cài đặt**

- Chuẩn bị hiện vật 5–6, đặt vào khu 3, viết nội dung nháp.
- Làm cài đặt âm lượng và độ nhạy chuột.

**Ngày 10 — Quiz + Review mốc 2**

- Xây quiz 5 câu, tính điểm và màn hình kết quả; tích hợp vào luồng.
- Kiểm tra kích thước mô hình, collider, hướng đặt và ánh sáng thử.
- Tạo bản build `Alpha_v0.1`, chơi từ đầu đến cuối và phân loại bug P0/P1/P2/P3.
- **Mốc nghiệm thu tuần 2:** đủ 3 khu, 6 hiện vật, bảng thông tin, xoay mô hình, audio guide mẫu và quiz hoạt động. Hình ảnh có thể chưa hoàn thiện nhưng luồng phải đầy đủ.

### Tuần 3 — Hoàn thiện nội dung, hình ảnh và trải nghiệm

**Mục tiêu tuần:** Đưa alpha thành beta hoàn chỉnh về nội dung và gần đạt chất lượng trình bày cuối.

**Ngày 11 — Sửa lỗi + thay placeholder**

- Sửa toàn bộ lỗi P0/P1 của `Alpha_v0.1`.
- Thay các asset placeholder quan trọng; rà soát tên gọi, chính tả, nguồn và tính nhất quán.

**Ngày 12 — Vật liệu + thu âm**

- Hoàn thiện vật liệu tủ kính, sàn, tường và trang phục; tối ưu thao tác xem và khoảng cách tương tác.
- Thu âm chính thức cho các đoạn thuyết minh (tối thiểu 3 đoạn 30–60 giây).

**Ngày 13 — Ánh sáng + tối ưu**

- Bake lighting và light probe; cấu hình occlusion culling, LOD hoặc giảm mesh cho vật thể nặng.
- Chuẩn hóa texture (ưu tiên 1K–2K), nén âm thanh; hoàn thiện âm thanh môi trường, nút bấm và tương tác.

**Ngày 14 — Biển chỉ dẫn, nội dung phụ trợ + khóa nội dung**

- Thêm biển chỉ dẫn, hướng dẫn điều khiển và phản hồi khi tương tác.
- Hoàn thiện trang Giới thiệu, Credits và Tài liệu tham khảo.
- **Kiểm tra nội dung văn hóa lần cuối với giảng viên/người am hiểu và KHÓA nội dung.**
- Kiểm tra UI ở 1920×1080, 1600×900 và 1366×768.

**Ngày 15 — Beta + user test + Review mốc 3**

- Đóng băng tính năng: không thêm tính năng mới sau ngày này.
- Tạo bản `Beta_v0.5`, kiểm thử trên ít nhất 2–3 máy.
- Mời 3–5 người ngoài trải nghiệm mà không hướng dẫn trực tiếp; ghi thời gian hoàn thành, điểm bị lạc, nội dung khó đọc và lỗi.
- **Mốc nghiệm thu tuần 3:** nội dung đã có và đã khóa, không còn placeholder quan trọng, ánh sáng và âm thanh gần hoàn chỉnh, người mới tự hoàn thành được trải nghiệm.

### Tuần 4 — Kiểm thử, tối ưu và đóng gói

**Mục tiêu tuần:** Có bản Release ổn định cùng đầy đủ hồ sơ bảo vệ.

**Ngày 16 — Sửa lỗi user test**

- Sửa P0/P1 từ user test; điều chỉnh chỉ dẫn ở nơi người dùng hay bị lạc.
- Rút gọn đoạn văn dài (đọc được trong 20–40 giây); kiểm tra mọi liên kết nguồn và credits.

**Ngày 17 — Tối ưu hiệu năng**

- Dùng Unity Profiler kiểm tra CPU, GPU, memory và draw call.
- Giảm texture quá lớn, vật thể/đèn realtime không cần thiết; kiểm tra rò rỉ âm thanh, scene load và nút thoát.
- Tạo `Release Candidate 1`.

**Ngày 18 — Hồi quy + tài liệu**

- Chạy lại toàn bộ test case trên máy sạch; sửa P1 còn lại và P2 ảnh hưởng rõ đến trình bày.
- Hoàn thiện README/hướng dẫn chạy; chụp ảnh màn hình chất lượng cao cho báo cáo và slide.

**Ngày 19 — Video + báo cáo + slide**

- Tạo video demo 3–5 phút: mở đầu, mục tiêu, luồng tham quan, hiện vật, quiz và kết luận.
- Hoàn thành báo cáo và slide; tạo `Release Candidate 2` và thử trên thiết bị trình chiếu.

**Ngày 20 — Đóng gói và diễn tập**

- Chỉ sửa lỗi nghiêm trọng; không thay đổi kiến trúc hoặc nội dung lớn.
- Đóng gói `Release_v1.0`, source code, báo cáo, slide, video và tài liệu tham khảo.
- Kiểm tra file sau khi sao chép sang USB và tải từ cloud; diễn tập thuyết trình 2 lần (đúng kịch bản và xử lý tình huống lỗi).
- Chuẩn bị video demo offline làm phương án dự phòng.
- **Mốc nghiệm thu tuần 4:** `Release_v1.0` chạy ổn định, đầy đủ tài liệu, video và phương án trình bày dự phòng.

## 7. Kiến trúc kỹ thuật đề xuất

### 7.1. Scene

- `Bootstrap`: khởi tạo các manager và tải cấu hình.
- `MainMenu`: menu, hướng dẫn, credits và thoát.
- `Museum`: toàn bộ không gian bảo tàng và các khu trưng bày.

Giữ toàn bộ bảo tàng trong một scene vì quy mô nhỏ, giảm rủi ro chuyển scene. Chỉ tách scene nếu thời gian tải hoặc dung lượng thật sự trở thành vấn đề.

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

## 8. Quy trình Git khi làm một mình

Không còn xung đột nhiều người nên quy trình được tinh gọn, nhưng vẫn giữ kỷ luật để có thể quay lui an toàn.

### 8.1. Nhánh làm việc

- `main`: chỉ chứa phiên bản đã ổn định và có thể build; tag mỗi mốc (`Prototype_v0.1`, `Alpha_v0.1`, `Beta_v0.5`, `Release_v1.0`).
- `develop`: nơi làm việc hằng ngày; merge vào `main` ở mỗi mốc.
- `feature/<ten-tinh-nang>` hoặc `fix/<ten-loi>`: tùy chọn cho các thay đổi lớn/rủi ro để dễ hoàn tác.

### 8.2. Quy tắc commit

- Commit nhỏ, mô tả rõ: `feat: add exhibit interaction`, `fix: prevent player falling`, `art: add Ede exhibit textures`.
- Mỗi ngày commit và đẩy ít nhất một lần khi phần đang làm ở trạng thái an toàn.
- Tag và tạo build ở mỗi mốc; sao lưu build ở hai nơi (USB + cloud).
- Không commit thư mục `Library`, `Temp`, `Logs`, `Obj`, `Build` và file build lớn.

### 8.3. Nhịp làm việc cá nhân

- Đầu ngày: xem lại bảng công việc, chọn đúng một mục tiêu chính cho ngày.
- Cuối ngày: cập nhật `project_progress.md`, commit và ghi lại việc còn dở.
- Cuối tuần: tạo build của mốc, tự review theo checklist và điều chỉnh phạm vi nếu cần.
- Mỗi task nên hoàn thành trong 0,5–1 ngày; task lớn hơn phải chia nhỏ.

## 9. Quy trình nghiên cứu và kiểm duyệt văn hóa

Đây là phần có mức ưu tiên ngang với kỹ thuật. Nội dung đẹp nhưng sai hoặc gán nhầm dân tộc sẽ làm giảm nghiêm trọng chất lượng đề tài. Khi làm một mình, **không có review chéo nội bộ**, nên bắt buộc phải có ít nhất một lần kiểm tra từ người bên ngoài.

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
- Người viết và người kiểm tra nội dung (ghi rõ người bên ngoài đã review).

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
4. Tương tác được với đủ 6 hiện vật.
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

### Rủi ro 1 — Quá tải vì làm một mình

- **Khả năng:** cao; **ảnh hưởng:** cao.
- **Xử lý:** giữ WIP = 1, bám sát mục tiêu ngày, ưu tiên luồng MVP; dùng asset/ảnh có sẵn thay vì tự dựng; cắt độ chi tiết trước khi cắt luồng.
- **Mốc quyết định:** cuối mỗi tuần, nếu trễ mốc thì áp dụng ngay mục 15.

### Rủi ro 2 — Không kịp dựng đủ trang phục

- **Khả năng:** cao.
- **Xử lý:** ưu tiên mannequin chung + asset có giấy phép + ảnh tư liệu; mỗi khu chỉ cần 2 hiện vật; chấp nhận mô hình đơn giản kết hợp ảnh nếu được ghi rõ.
- **Mốc quyết định:** cuối ngày 9. Nếu chưa đủ 6 hiện vật, giảm độ chi tiết thay vì tăng giờ làm vô hạn.

### Rủi ro 3 — Nội dung văn hóa sai hoặc thiếu nguồn

- **Khả năng:** trung bình; **ảnh hưởng:** rất cao.
- **Xử lý:** tạo danh mục nguồn từ tuần 1, nhờ giảng viên/người am hiểu review, loại bỏ khẳng định không xác minh được.
- **Mốc quyết định:** khóa nội dung vào ngày 14.

### Rủi ro 4 — Hiệu năng thấp

- **Khả năng:** trung bình.
- **Xử lý:** giới hạn polygon/texture từ đầu, dùng baked lighting, kiểm tra profiler ở tuần 2 và tuần 4, có preset Low/Medium.

### Rủi ro 5 — Thêm quá nhiều tính năng

- **Khả năng:** cao.
- **Xử lý:** ưu tiên MVP; đóng băng tính năng ngày 15; mọi ý tưởng mới đưa vào danh sách mở rộng thay vì làm ngay.

### Rủi ro 6 — Mất dữ liệu hoặc máy hỏng (không có người backup thay)

- **Khả năng:** trung bình; **ảnh hưởng:** rất cao.
- **Xử lý:** đẩy Git hằng ngày, giữ bản sao ở hai nơi (USB + cloud); tag build ở mỗi mốc.

### Rủi ro 7 — Máy thuyết trình không chạy được

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
- Danh mục nguồn nội dung, hình ảnh, âm thanh, font và asset 3D (kèm giấy phép).
- Danh sách lỗi đã biết nếu còn.
- File dự phòng trên ít nhất hai nơi lưu trữ khác nhau.

## 13. Kịch bản thuyết trình đề xuất

Vì trình bày một mình, tổng thời lượng nên gọn 8–10 phút:

1. **Mở đầu — 1,5 phút:** vấn đề, mục tiêu và phạm vi (nói rõ giới hạn 3 dân tộc).
2. **Kỹ thuật & môi trường — 2 phút:** kiến trúc hệ thống, thiết kế không gian và tối ưu.
3. **Nội dung & kiểm duyệt văn hóa — 2 phút:** nghiên cứu trang phục, nguồn tư liệu và quy trình kiểm tra với người am hiểu.
4. **Demo trực tiếp — 3 phút:** menu, một khu trưng bày, thao tác xem hiện vật, audio guide và quiz.
5. **Kết luận — 1 phút:** kết quả, hạn chế và hướng phát triển (khu thứ 4, VR, mở rộng nội dung).

## 14. Việc cần làm ngay trong buổi đầu tiên

- Xác nhận cấu hình máy phát triển và máy dùng để thuyết trình.
- Chọn chính xác phiên bản Unity LTS và render pipeline.
- Tạo repository, `.gitignore`, bảng task cá nhân.
- Chốt 3 khu và duyệt danh sách 6 hiện vật sơ bộ.
- Vẽ mặt bằng bảo tàng trên một trang giấy hoặc Figma.
- Tạo build rỗng đầu tiên để phát hiện sớm vấn đề môi trường.
- Đặt lịch cố định cho review cuối mỗi tuần.

## 15. Nguyên tắc ưu tiên khi thiếu thời gian

Nếu tiến độ bị chậm, giảm phạm vi theo thứ tự sau:

1. Bỏ tính năng mở rộng như khu thứ 4, VR, song ngữ và mini-game.
2. Giảm đồ trang trí và hiệu ứng môi trường.
3. Dùng một layout bảo tàng đơn giản hơn.
4. Giảm số đoạn voice-over (nhưng giữ tối thiểu 3) nhưng vẫn giữ bảng thông tin.
5. Giảm độ chi tiết mô hình, tăng tỷ lệ dùng ảnh tư liệu, nhưng vẫn giữ đủ 6 hiện vật.

Không được cắt các phần: tính chính xác và nguồn của nội dung, luồng tham quan hoàn chỉnh, khả năng tương tác cơ bản, kiểm thử bản build và tài liệu bàn giao.
