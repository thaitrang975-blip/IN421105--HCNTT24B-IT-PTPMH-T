using System;
namespace EduHub.Ch01.Domain;
// Ghi nhận điểm danh tại Event
public class CheckIn
{
    public Guid Id { get; private set; }
    public Guid RegistrationId { get; private set; }
    public DateTime CheckedInAt { get; private set; }
    public CheckInMethod Method { get; private set; }

    private CheckIn() { }
    // tạo dữ liệu Check-in.
    public static CheckIn Create(Guid registrationId, CheckInMethod method)
    {
        return new CheckIn
        {
            Id = Guid.NewGuid(),
            RegistrationId = registrationId,
            CheckedInAt = DateTime.Now,
            Method = method
        };
    }

    /// Trả về chuỗi tóm tắt thông tin điểm danh.
    /// 
    public string Summary() => $"[Check-in ID: {Id}] - Thoi gian: {CheckedInAt:HH:mm dd/MM/yyyy} - Hinh thuc: {Method}";
}