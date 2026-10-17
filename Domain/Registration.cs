using System;
namespace EduHub.Ch01.Domain;
// Phiếu đăng ký của Member tham dự Event
public class Registration
{
    public Guid Id { get; private set; }
    public Guid MemberId { get; private set; }
    public Guid EventId { get; private set; }
    public DateTime RegisteredAt { get; private set; }
    public RegistrationStatus Status { get; private set; }

    private Registration() { }
    // tạo phiếu đăng ký mới( Pending)
      public static Registration Create(Guid memberId, Guid eventId)
    {
        return new Registration
        {
            Id = Guid.NewGuid(),
            MemberId = memberId,
            EventId = eventId,
            RegisteredAt = DateTime.Now,
            Status = RegistrationStatus.Pending
        };
    }

    // Chuyển trạng thái sang Đã xác nhận
    public void Confirm() => Status = RegistrationStatus.Confirmed;

    // Hủy phiếu đăng ký
    public void Cancel() => Status = RegistrationStatus.Cancelled;
}