using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindSystem.BusinessLogicLayer;  //for access to my system
using NorthwindSystem.Entities;  //for my Entity Framework entities
using Xunit;  //the core for testing
using Xunit.Extensions;  //for Theories, AutoRollback, etc.

namespace NorthwindSystem.Requirements.UnitTests.CreateReadUpdateDelete
{
    public class CRUD_Shipper
    {
        [Fact]  //Indicates that this is a test
        public void Should_Add_Numbers()
        {
            //Arrange
            int first = 5, second = 7;

            //Act
            int actual = first + second;

            //Assert
            Assert.Equal(12, actual);
        }

        [Fact]  //Indicates that this is a test
        [AutoRollback]
        public void Should_Add_Shipper()
        {
            //Arrange
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };

            //Act
            var actualId = sut.AddShipper(expected);

            //Assert
            Assert.True(actualId > 0);
            Shipper actual = sut.GetShipper(actualId);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(actualId, actual.ShipperID);

        }

        [Theory]  //Indicates that this is a test with (potentially) external data
        [PropertyData("CurrentShippers")]
        [AutoRollback]
        public void Should_Update_Shipper(Shipper existing)
        {
            //Arrange
            existing.Phone = "780.999.999";
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            existing.Phone = "780.555.1212";

            //Act
            sut.UpdateShipper(existing);

            //Assert
            var actual = sut.GetShipper(existing.ShipperID);
            Assert.NotNull(actual);
            Assert.Equal(existing.CompanyName, actual.CompanyName);
            Assert.Equal(existing.Phone, actual.Phone);
        }

        [Fact]  //Indicates that this is a test
        [AutoRollback]
        public void Should_Delete_Shipper()
        {
            //Arrange
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };

            expected.ShipperID = sut.AddShipper(expected);

            //Act
            sut.DeleteShipper(expected);

            //Assert
            Shipper actual = sut.GetShipper(expected.ShipperID);
            Assert.Null(actual);

        }

        #region Properties for Test Data
        //backing field
        private static IEnumerable<object[]> _CurrentShippers = null;
        public static IEnumerable<object[]> CurrentShippers
        {
            get
            {
                if (_CurrentShippers == null)  //lazy loading
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>();  //empty list
                    foreach (Shipper company in controller.ListShippers())
                    {
                        temp.Add(new object[] { company });
                    }
                    _CurrentShippers = temp;
                }
                return _CurrentShippers;
            }
        }
        #endregion

    }
}
