namespace MauiApp5
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string? EquipmentName { get; set; }
        public int Quantity { get; set; }
        public DateTime? LastMaintenance { get; set; }
        public DateTime? NextMaintenance { get; set; }
    }
}

public class Staff
{
    public int StaffID { get; set; }
    public string? FirstName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string? Role { get; set; }
    public string? ClockInTime { get; set; }
    public string? ClockOutTime { get; set; }
}
public class Attendance
{
    public int AttendanceID { get; set; }
    public int MemberID { get; set; }
    public int ClassID { get; set; }
    public string? AttendanceDate { get; set; }
}
public class Billing
{
    public int BillingID { get; set; }
    public int MemberID { get; set; }
    public int Amount { get; set; }
    public string? PaymentDate { get; set; }
}
public class Classes
{
    public int ClassID { get; set; }
    public string? ClassName { get; set; }
    public int ScheduleTime { get; set; }
    public int InstructorID { get; set; }
}
public class Members
{ 
    public int MemberID { get; set; }
    public string? First_Name { get; set; }
    public int Last_Name { get; set; }
    public int PhoneNUmber { get; set; }
    public string? Email { get; set; }
    public string? MembershipType { get; set; }
}