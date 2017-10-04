using dotnetcore_hoved.options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace dotnetcore_hoved.services
{
    public interface IDatabaseService
    {
        string GetSomething();
    }

	public class DatabaseService : IDatabaseService
	{
        private readonly MyOptions _options;

        public DatabaseService(IOptions<MyOptions> optionsAccessor)
        {
            _options = optionsAccessor.Value;
        }
		public string GetSomething()
		{
			 return _options.TorpedoHoved;
		}
	}
}