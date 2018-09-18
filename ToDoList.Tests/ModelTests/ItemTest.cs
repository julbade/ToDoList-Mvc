using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Item.DeleteAll();
        }
        public ItemTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
        }

      [TestMethod]
      public void GetAll_DbStartsEmpty_0()
      {
        //Arrange
        //Act
        int result = Item.GetAll().Count;

      //Assert
      Assert.AreEqual(0, result);
      }
}
}

// [TestMethod]
// public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
// {
//   // Arrange, Act
//   Item firstItem = new Item("Mow the lawn");
//   Item secondItem = new Item("Mow the lawn");
//
//   // Assert
//   Assert.AreEqual(firstItem, secondItem);
// }
//
// [TestMethod]
// public void Save_AssignsIdToObject_Id()
// {
//   //Arrange
//   Item testItem = new Item("Mow the lawn");
//
//   //Act
//   testItem.Save();
//   Item savedItem = Item.GetAll()[0];
//
//   int result = savedItem.GetId();
//   int testId = testItem.GetId();
//
//   //Assert
//   Assert.AreEqual(testId, result);
// }
// public void Dispose()
//     {
//       Item.ClearAll();
//     }
//   }
// }
