# Danh sách User Stories - Hệ thống EduHub (Câu lạc bộ Cờ vua)
**Sinh viên:** Thái Thị Hồng Trang - 0024419352
## 1. Actor: Sinh viên
### User Story 1: Sinh viên tham gia câu lạc bộ cờ vua
**As a** sinh viên,
**I want** tham gia vào câu lạc bộ cờ vua,
**So that** tôi có thể trở thành thành viên chính thức của câu lạc bộ.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Sinh viên tham gia thành viên mới -> nhập đầy đủ thông tin -> hệ thống kiểm tra thông tin -> Thông tin đăng ký thành công.
- Trạng thái 2: Sinh viên đã tham gia -> nhập đầy đủ thông tin -> hệ thống kiểm tra thông tin -> Thông tin báo “Đã là thành viên câu lạc bộ”.
### User Story 2: Sinh viên đăng ký sự kiện giải đấu
**As a** sinh viên (thành viên CLB),
**I want** đăng ký tham gia sự kiện giải đấu,
**So that** tôi có suất thi đấu chính thức.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Sinh viên đăng ký còn suất -> lập phiếu đăng ký -> chờ xác nhận -> Hợp lệ -> Đã đăng ký.
- Trạng thái 2: Sinh viên đăng ký hết suất -> lập phiếu đăng ký -> chờ xác nhận -> Không hợp lệ -> Báo “Đã hết suất thi đấu”.
### User Story 3: Sinh viên check-in sự kiện giải đấu
**As a** sinh viên đã đăng ký giải đấu,
**I want** check-in tại điểm thi đấu,
**So that** tôi được xác nhận sự có mặt và bắt đầu thi đấu.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Sinh viên check-in điểm thi đấu -> Phiếu đăng ký hợp lệ -> Quét mã QR -> Thông báo “Đã check-in thành công”.
- Trạng thái 2: Sinh viên check-in không có tên trong danh sách -> Quét mã QR lỗi -> Thông báo “Bị từ chối”.
## 2. Actor: Ban CLB 
### User Story 4: Ban CLB tạo sự kiện giải đấu
**As a** Ban CLB,
**I want** tạo một sự kiện giải đấu mới,
**So that** sinh viên có thể xem thông tin và đăng ký.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Điền thông tin giải đấu đầy đủ -> lưu thông tin -> tạo thành công.
- Trạng thái 2: Bỏ trống thông tin bắt buộc -> lưu thông tin -> báo lỗi.
### User Story 5: Ban CLB cập nhật kết quả giải đấu
**As a** Ban CLB,
**I want** cập nhật kết quả thi đấu của sinh viên,
**So that** hệ thống lưu lại điểm số và thành tích.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Hai sinh viên đã check-in và tham gia đấu giải -> nhập kết quả giải đấu -> cập nhật lưu điểm số.
- Trạng thái 2: Hai sinh viên không check-in -> nhập kết quả -> bị từ chối, báo lỗi.
## 3. Actor: Admin
### User Story 6: Admin cấp quyền trọng tài cho thành viên
**As a** Admin,
**I want** cấp quyền trọng tài cho một thành viên,
**So that** thành viên đó có thể hỗ trợ điều hành giải đấu.

**Tiêu chí nghiệm thu:**
- Trạng thái 1: Sinh viên đang hoạt động bình thường -> cấp quyền -> cập nhật vai trò thành công.
- Trạng thái 2: Sinh viên bị khóa tài khoản -> cấp quyền -> bị từ chối.