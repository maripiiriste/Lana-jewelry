using Microsoft.AspNetCore.Mvc.Testing;

namespace Lana_jewelry.Tests {
    public class TestHost<TProgram> : WebApplicationFactory<TProgram> where TProgram : class { }
}
