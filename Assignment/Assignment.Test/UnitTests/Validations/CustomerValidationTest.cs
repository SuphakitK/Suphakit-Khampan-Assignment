using Assignment.Services.Validations;
using System;
using Xunit;

namespace Assignment.Test.UnitTests.Validations
{
    public class CustomerValidationTest
    {
        [Fact]
        public void GetCustomerById_Should_Success_When_InputPositiveInteger()
        {
            //Arrange
            var customerId = 5;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerId(customerId);
            //Assert
            Assert.True(string.IsNullOrEmpty(result));
        }
    }
}
