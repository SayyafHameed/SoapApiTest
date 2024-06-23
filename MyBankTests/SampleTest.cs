using MyBankTests.Settings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankTests
{
    internal class SampleTest
    {
        [Test]
        public void ATest() 
        {
            var settings = ProjectEnvSettings.EnvConfig;
        }

    }
}
