using Microsoft.Extensions.Configuration;

namespace Tasks.Infra
{
    public sealed class ConnectionStrings
    {
        public ConnectionStrings(IConfiguration configuration)
        {
            Tasks = configuration.GetConnectionString("Tasks");
        }

        public string Tasks { get; }
    }
}
