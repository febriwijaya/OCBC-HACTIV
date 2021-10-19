using Moq;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Model;
using UnitTest_Mock.Services;
using System;
using Xunit;

namespace UnitTesting1
{
    public class EmployeeTest
    {

        #region Property
        public Mock<IEmployeeService> mock = new Mock<IEmployeeService>();
        #endregion

        [Fact]
        public async void GetEmployeebyId()
        {
            mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("Febri");
            UnitTestController emp = new UnitTestController(mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("Febri", result);
        }

        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "Febri",
                Designation = "Febri"
            };
            mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            UnitTestController emp = new UnitTestController(mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}
