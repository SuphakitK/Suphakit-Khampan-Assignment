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

        [Fact]
        public void GetCustomerById_Should_Fail_When_InputZeroNumber()
        {
            //Arrange
            var customerId = 0;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerId(customerId);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]

        public void GetCustomerById_Should_Fail_When_InputNegativeInteger()
        {
            //Arrange
            var customerId = -2;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerId(customerId);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByEmail_Should_Success_When_InputRightFormatEmail()
        {
            //Arrange
            var customerEmail = "abcde@maosy.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerEmail(customerEmail);
            //Assert
            Assert.True(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByEmail_Should_Fail_When_InputEmptyEmail()
        {
            //Arrange
            var customerEmail = "";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerEmail(customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]

        public void GetCustomerByEmail_Should_Fail_When_InputWorngFotmatEmail()
        {
            //Arrange
            var customerEmail = "asfgvzxc.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerEmail(customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
