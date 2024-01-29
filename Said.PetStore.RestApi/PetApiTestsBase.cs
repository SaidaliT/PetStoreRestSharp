using NUnit.Framework;
using Said.PetStore.RestApi.Client.Requests.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Said.PetStore.RestApi
{
    public abstract class PetApiTestsBase
    {
        protected string? _baseUrl;
        protected  PetApiRequests? _petApiRequests;     

        [OneTimeSetUp]
        public void BeforeFixture()
        {
            _petApiRequests = new PetApiRequests(_baseUrl!);
            _baseUrl = TestContext.Parameters["baseUrl"]!;
        }
    }
}