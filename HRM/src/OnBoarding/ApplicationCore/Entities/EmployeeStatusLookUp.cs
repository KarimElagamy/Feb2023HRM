namespace ApplicationCore.Entities;

// Hired, Terminated, Pending (from candidate to employee)
public class EmployeeStatus
{
    public int Id { get; set; }
    public string EmployeeStatusCode { get; set; }
    public string EmployeeStatusDescription { get; set; }

}