namespace RemoteEmpoyeeManagementSystem.Models
{
    public class EmpAttendace
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }

        public DateTime? InTime { get; set; }
        public bool IsChckInDisabled { get; set; }

        public DateTime? OutTime { get; set; }
        public bool IschckOutDisabled { get; set; }

        public int AttendanceId { get;  set; }
        
    }
}
