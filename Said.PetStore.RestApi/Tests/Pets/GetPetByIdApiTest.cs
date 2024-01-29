using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using Said.PetStore.RestApi.Client.Actions;
using Said.PetStore.RestApi.Client.Models.PetModel;
using Said.PetStore.RestApi.Client.Requests.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Said.PetStore.RestApi.Tests.Pets
{
    [TestFixture]
    public class GetPetByIdApiTest : PetApiTestsBase
    {
        [Test]
        public void GetFirstPet_IdExists_ShouldBeReturned()
        {
            // Arrange
            PetApiModelV2 expectedResponse = PetActionsRequests.CreateNewPet(_baseUrl);
            
            // Act
            RestResponse response = _petApiRequests!.ExecuteApiGetPetByIdRequest(expectedResponse.Id!.Value);

            // Assert
            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody.Should().NotBeNull();
            responseBody
                .Should()
                .BeEquivalentTo(expectedResponse);
        }
    }
}