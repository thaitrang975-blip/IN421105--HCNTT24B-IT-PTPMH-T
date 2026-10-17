using System;
using System.Collections.Generic;
namespace EduHub.Ch01.Domain;
// Đại diện cho một câu lạc bộ sinh viên
public class Club
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public List<Member> Members { get; private set; } = new List<Member>();

    private Club() { }
    // tạo mới CLB
    public static Club Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Tên câu lạc bộ không được để trống.");
        return new Club
        {
            Id = Guid.NewGuid(),
            Name = name,
            Description = description,
            CreatedAt = DateTime.Now
        };
    }
    // Thêm một thành viên vào câu lạc bộ
    public void AddMember(Member member)
    {
        if (member == null)
            throw new ArgumentNullException(nameof(member));
            
        Members.Add(member);
    }
    // Lấy tổng số lượng thành viên hiện tại
    public int MemberCount() => Members.Count;
}