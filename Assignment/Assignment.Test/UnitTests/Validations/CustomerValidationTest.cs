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
            var customerEmail = string.Empty;
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

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Success_When_InputPositiveInteger_RightFormatEmail()
        {
            //Arrange
            var customerId = 10;
            var customerEmail = "gabaysy@moixsy.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.True(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputPositiveInteger_EmptyEmail()
        {
            //Arrange
            var customerId = 8;
            var customerEmail = string.Empty;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]

        public void GetCustomerByIdAndEmail_Should_Fail_When_InputPositiveInteger_WorngFotmatEmail()
        {
            //Arrange
            var customerId = 6;
            var customerEmail = "rosesyJes.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputZeroNumber_RightFormatEmail()
        {
            //Arrange
            var customerId = 0;
            var customerEmail = "fagvycoll@cheese.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputZeroNumber_EmptyEmail()
        {
            //Arrange
            var customerId = 0;
            var customerEmail = string.Empty;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputZeroNumber_WorngFotmatEmail()
        {
            //Arrange
            var customerId = 0;
            var customerEmail = "b_basketb.com";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputNegativeInteger_RightFormatEmail()
        {
            //Arrange
            var customerId = -36;
            var customerEmail = "musicaly@central";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputNegativeInteger_EmptyEmail()
        {
            //Arrange
            var customerId = -64;
            var customerEmail = string.Empty;
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }

        [Fact]
        public void GetCustomerByIdAndEmail_Should_Fail_When_InputNegativeInteger_WrongFormatEmail()
        {
            //Arrange
            var customerId = -52;
            var customerEmail = "musicaly central";
            //Act
            var validationService = new CustomerValidation();
            var result = validationService.ValidationCustomerIdAndEmail(customerId, customerEmail);
            //Assert
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
