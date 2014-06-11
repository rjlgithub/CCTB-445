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
    public class CRUD_Product
    {

        [Fact]  //Indicates that this is a test
        [AutoRollback]
        public void Should_Add_Product()
        {
            //Arrange
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            var expected = new Product()
            {
                ProductName = "Double Double",
                UnitsInStock = 777
            };

            //Act
            var actualId = sut.AddProduct(expected);

            //Assert
            Assert.True(actualId > 0);
            Product actual = sut.GetProduct(actualId);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.UnitsInStock, actual.UnitsInStock);
            Assert.Equal(actualId, actual.ProductID);

        }

        [Theory]  //Indicates that this is a test with (potentially) external data
        [PropertyData("CurrentProducts")]
        [AutoRollback]
        public void Should_Update_Product(Product existing)
        {
            //Arrange
            existing.UnitsInStock = 777;
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            existing.UnitsInStock = 999;

            //Act
            sut.UpdateProduct(existing);

            //Assert
            var actual = sut.GetProduct(existing.ProductID);
            Assert.NotNull(actual);
            Assert.Equal(existing.ProductName, actual.ProductName);
            Assert.Equal(existing.UnitsInStock, actual.UnitsInStock);
        }

        [Fact]  //Indicates that this is a test
        [AutoRollback]
        public void Should_Delete_Product()
        {
            //Arrange
            var sut = new NorthwindManager();  //sut is short for 'Scenario Under Test'
            var expected = new Product()
            {
                ProductName = "Double Double",
                UnitsInStock = 777
            };

            expected.ProductID = sut.AddProduct(expected);

            //Act
            sut.DeleteProduct(expected);

            //Assert
            Shipper actual = sut.GetShipper(expected.ProductID);
            Assert.Null(actual);

        }

        #region Properties for Test Data
        //backing field
        private static IEnumerable<object[]> _CurrentProducts = null;
        public static IEnumerable<object[]> CurrentProducts
        {
            get
            {
                if (_CurrentProducts == null)  //lazy loading
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>();  //empty list
                    foreach (Product product in controller.ListProducts())
                    {
                        temp.Add(new object[] { product });
                    }
                    _CurrentProducts = temp;
                }
                return _CurrentProducts;
            }
        }
        #endregion

    }
}
