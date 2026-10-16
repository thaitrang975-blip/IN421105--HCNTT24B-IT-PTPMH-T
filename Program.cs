using System;
using EduHub.Ch01.Domain;
Console.WriteLine("==================================================");
Console.WriteLine("    HỆ THỐNG QUẢN LÝ CLB EDUHUB - CHESS CLUB");
Console.WriteLine("==================================================");

// Bước 1: Tạo CLB
Console.WriteLine("BUOC 1: Tao Cau lac bo");
var chessClub = Club.Create("Chess Club", "Câu lạc bộ Cờ vua sinh viên ĐH Đồng Tháp");
Console.WriteLine($"> Đã tạo CLB: {chessClub.Name} ({chessClub.Description})");
Console.WriteLine("--------------------------------------------------");

// Bước 2: Thêm 3 thành viên vào CLB
Console.WriteLine("BUOC 2: Them 3 thanh vien vao CLB");
var member1 = Member.Create("Nguyen Van Phi", "nva@gmail.com", "24B001");
var member2 = Member.Create("Tran Thi Lam", "ttb@gmail.com", "24B002");
var member3 = Member.Create("Le Van Cuong", "lvc@gmail.com", "24B003");

chessClub.AddMember(member1);
chessClub.AddMember(member2);
chessClub.AddMember(member3);
Console.WriteLine($"> Đã thêm thành công. Tổng số thành viên CLB hiện tại: {chessClub.MemberCount()}");
Console.WriteLine("--------------------------------------------------");

// Bước 3: Tạo 1 sự kiện cho CLB
Console.WriteLine("BUOC 3: Tao su kien giai dau");
// Tạo sự kiện giải đấu Cờ vua mở rộng, thành viên 32 người, tổ chức trực tiếp
var chessTournament = Event.Create(chessClub.Id, "Giải đấu Cờ vua mở rộng 2026", DateTime.Now.AddDays(14), 32, false);
Console.WriteLine($"> Sự kiện tạo thành công: '{chessTournament.Title}' - Thành viên: {chessTournament.Capacity} người");
Console.WriteLine("--------------------------------------------------");

// Bước 4: 2 thành viên đăng ký tham dự sự kiện -> Status = "Pending" -> gọi Confirm()
Console.WriteLine("BUOC 4: Dang ky tham gia su kien va xac nhan");
var reg1 = Registration.Create(member1.Id, chessTournament.Id);
var reg2 = Registration.Create(member2.Id, chessTournament.Id);

Console.WriteLine($"> {member1.Name} vừa đăng ký, trạng thái ban đầu: {reg1.Status}");
// Ban tổ chức xác nhận đơn
reg1.Confirm();
reg2.Confirm();
Console.WriteLine($"> Đã xác nhận đơn đăng ký. Trạng thái mới của {member1.Name}: {reg1.Status}");
Console.WriteLine("--------------------------------------------------");

// Bước 5: 1 thành viên thực hiện check-in -> tạo CheckIn record
Console.WriteLine("BUOC 5: Thuc hien Check-in tai diem thi dau");
// Thành viên 1 check-in bằng cách quét mã QRCode
var checkInA = CheckIn.Create(reg1.Id, CheckInMethod.QRCode);
Console.WriteLine($"> {member1.Name} đã điểm danh: {checkInA.Summary()}");
Console.WriteLine("--------------------------------------------------");

// Bước 6: In báo cáo tham dự
Console.WriteLine("BUOC 6: Bao cao tom tat su kien");
Console.WriteLine($"Sự kiện: {chessTournament.Title}");
Console.WriteLine($"- Tổng số lượng đăng ký: 2");
Console.WriteLine($"- Tổng số lượng check-in: 1");
Console.WriteLine($"- Danh sách đã đăng ký: {member1.Name}, {member2.Name}");
Console.WriteLine("==================================================");

// Bước tùy chọn: Thử một thao tác vi phạm luật nghiệp vụ để bắt lỗi
Console.WriteLine("BUOC 8: Thu test bat loi nghiep vu (Tao Member sai thong tin)");
try
{
    // Cố tình tạo Member không có ký tự @ trong email
    var errorMember = Member.Create("Thanh vien Loi", "emailkhonghople.com", "12345");
}
catch (Exception ex)
{
    Console.WriteLine($"> Hệ thống đã bắt lỗi đúng yêu cầu: {ex.Message}");
}