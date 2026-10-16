namespace EduHub.Ch01.Domain;
/// Trạng thái của phiếu đăng ký sự kiện.
public enum RegistrationStatus
{
    Pending,
    Confirmed,
    Cancelled
}
/// Hình thức Check-in
public enum CheckInMethod
{
    Manual,
    QRCode,
    RFID
}