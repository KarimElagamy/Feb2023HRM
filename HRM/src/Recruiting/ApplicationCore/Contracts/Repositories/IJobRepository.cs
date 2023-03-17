using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IJobRepository
    {
        List<Job> GetAllJobs();
    }
}
