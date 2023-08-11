namespace RemoteEmpoyeeManagementSystem.Models
{
    public class MockEmpAttendaceRepository : IEmpAttendaceRepository
    {
        private List<EmpAttendace> _empAttendaces;
        public MockEmpAttendaceRepository()
        {
            _empAttendaces = new List<EmpAttendace>()
             {
                new EmpAttendace {EmpName="omkar", AttendanceId = 1, EmpId = 1, OutTime = DateTime.Now, InTime = DateTime.Now },
                 new EmpAttendace() {EmpName="omkar", AttendanceId = 2, EmpId = 1, OutTime = DateTime.Now, InTime = DateTime.Now },
                 new EmpAttendace() {EmpName="omkar", AttendanceId = 3, EmpId = 1, InTime = DateTime.Now }    
             };

         }
        public List<EmpAttendace> GetEmpAttendace()
        {
            try
            {
                EmpAttendace lastRow = _empAttendaces.LastOrDefault();
                if (string.IsNullOrEmpty(Convert.ToString(lastRow.OutTime)))
                {
                    lastRow.IsChckInDisabled = true;
                }
                return _empAttendaces;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmpAttendace> MarkEmpAtendace(int id)
        { 
            EmpAttendace LastRow=_empAttendaces.LastOrDefault();
            if (LastRow.OutTime !=null && LastRow.OutTime <= DateTime.Now)
            {
                Random rnd = new Random();
                _empAttendaces.Add(new EmpAttendace { AttendanceId = rnd.Next(), EmpName = "omkar", InTime = DateTime.Now,IsChckInDisabled=true,OutTime=null });
                
                
            }
            else if(LastRow.InTime !=null && LastRow.OutTime==null)
            {
                LastRow.OutTime = DateTime.Now;
                LastRow.IschckOutDisabled = true;
                LastRow.IsChckInDisabled = false;
            }
            return _empAttendaces;
        }
    }
}
