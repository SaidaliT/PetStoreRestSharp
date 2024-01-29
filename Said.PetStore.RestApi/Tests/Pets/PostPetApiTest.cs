using FluentAssertions;
using FluentAssertions.Execution;
using Newtonsoft.Json;
using NUnit.Framework;
using Said.PetStore.RestApi.Client.Models.PetModel;
using Said.PetStore.RestApi.Client.Requests.Pet;
using System.Net;

namespace Said.PetStore.RestApi.Tests.Pets
{
    [TestFixture]
    public class PostPetApiTest : PetApiTestsBase
    {

        /// <summary>
        /// Create pet with correct data should be created
        /// </summary>
        [Test]
        public void CreatePet_WithCorrectData_ShouldBeCreated()
        {
            // Arrange
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
            var response =_petApiRequests!
                .ExecuteApiPostPetRequest(petBody);

            // Assert
            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            responseBody
                .Should()
                .BeEquivalentTo(petBody, ex => ex.Excluding(ex =>ex.Id));
        }

        /// <summary>
        /// Create pet with category does not exist should be created
        /// </summary>
        [Test]
        public void CreatePet_WithCategoryDoesNotExist_ShouldBeCreated()
        {
            // Arrange
            var petBody = new PetApiModelV2
            {
                Id = 1,
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
            var response = _petApiRequests!
                .ExecuteApiPostPetRequest(petBody);

            // Assert
            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
            var responseBody = JsonConvert.DeserializeObject<PetApiModelV2>(response.Content!);
            using (new AssertionScope())
            {
                responseBody
               .Should()
               .BeEquivalentTo(petBody, ex => ex.Excluding(ex => ex.Id));
                responseBody
                    .Should()
                    .NotBeNull()
                    .And
                    .NotBe(0);
            }          
        }
    }
}