using System;
namespace EduHub.Ch01.Domain;
// Đại diện cho thành viên sinh viên của CLB
public class Member
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string StudentCode { get; private set; }
    public DateTime JoinedAt { get; private set; }

    // Constructor private 
    private Member() { }
    // tạo mới một thành viên có kèm kiểm tra hợp lệ
    public static Member Create(string name, string email, string studentCode)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên không được để trống.");
        
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Email không hợp lệ (phải chứa ký tự @).");

        return new Member
        {
            Id = Guid.NewGuid(),
            Name = name,
            Email = email,
            StudentCode = studentCode,
            JoinedAt = DateTime.Now
        };
    }

    // Kiểm tra thành viên có đang hoạt động không
    public bool IsActive() => true;
}