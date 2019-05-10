using Microsoft.Extensions.Configuration;

namespace Tasks.Infra
{
    public sealed class ConnectionString
    {
        public ConnectionString(IConfiguration configuration)
        {
            Tasks = configuration.GetConnectionString("Tasks");
        }

        public string Tasks { get; }
    }
}
