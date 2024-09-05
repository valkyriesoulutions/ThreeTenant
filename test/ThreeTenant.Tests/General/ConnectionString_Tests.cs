using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace ThreeTenant.Tests.General
{
    // ReSharper disable once InconsistentNaming
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=ThreeTenant; Trusted_Connection=True;");
            csb["Database"].ShouldBe("ThreeTenant");
        }
    }
}
