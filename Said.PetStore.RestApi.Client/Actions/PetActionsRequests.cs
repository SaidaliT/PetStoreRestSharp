using FluentAssertions;
using Newtonsoft.Json;
using RestSharp;
using Said.PetStore.RestApi.Client.Models.PetModel;
using Said.PetStore.RestApi.Client.Requests.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Said.PetStore.RestApi.Client.Actions
{
    public class PetActionsRequests
    {
        public static PetApiModelV2 CreateNewPet(string baseUrl)
        {
            var petBody = new PetApiModelV2
            {
                Id = 1,
                Category = new Category
                {
                    Id = 1,
                    Name = "Test",
                },
                Name = "Arjun",
                PhotoUrls = new List<string>
                {
                    "https://www.google"
                },
                Tags = new List<Tag>
                {
                    new Tag
                    {
                        Id = 1,
                        Name = "dog"
                    }
                },

                Status = "available"
            };

            // Act
            RestResponse response = new PetApiRequests(baseUrl)!
                .ExecuteApiPostPetRequest(petBody);

            // Assert
            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody
                .Should()
                .NotBeNull();

            return responseBody!;
        }
    }
}