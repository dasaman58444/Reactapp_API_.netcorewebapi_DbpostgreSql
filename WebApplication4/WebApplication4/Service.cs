namespace WebApplication4
{
    public class Service : IService
    {
        IRepo repo;
        public Service(IRepo repo)
        {
            this.repo = repo;
        }
        public string Insert()
        {
            repo.Insert();
            return "From Service";
        }
    }
}
