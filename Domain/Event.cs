using System;
namespace EduHub.Ch01.Domain;
// Đại diện cho một sự kiện do CLB tổ chức
public class Event
{
    public Guid Id { get; private set; }
    public Guid ClubId { get; private set; }
    public string Title { get; private set; }
    public DateTime Date { get; private set; }
    public int Capacity { get; private set; }
    public bool IsOnline { get; private set; }

    private Event() { }
    // tạo mới sự kiện
    public static Event Create(Guid clubId, string title, DateTime date, int capacity, bool isOnline)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Tiêu đề sự kiện không được trống.");
            
        if (capacity <= 0)
            throw new ArgumentException("Sức chứa (Capacity) phải lớn hơn 0.");

        return new Event
        {
            Id = Guid.NewGuid(),
            ClubId = clubId,
            Title = title,
            Date = date,
            Capacity = capacity,
            IsOnline = isOnline
        };
    }
    // Kiểm tra sự kiện còn sức chứa hay không dựa trên số lượng đã đăng ký
    public bool HasCapacity(int registeredCount) => registeredCount < Capacity;
}