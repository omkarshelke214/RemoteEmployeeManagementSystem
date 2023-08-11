namespace RemoteEmpoyeeManagementSystem.Models
{
    public interface IEmpAttendaceRepository
    {
        List<EmpAttendace> GetEmpAttendace();
        List<EmpAttendace> MarkEmpAtendace(int id);

    }
}
