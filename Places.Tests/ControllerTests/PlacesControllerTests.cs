using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Travel.Controllers;
using Travel.Models;

namespace Travel.Tests
{
  [TestClass]
  public class PlacesControllerTest
  {
    [TestMethod]
    public void Index_HasCorrectModelType_PlacesList()
    {
      //Arrange
      PlacesController controller = new PlacesController();
      ViewResult indexView = controller.Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Places>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      PlacesController controller = new PlacesController();

      //Act
      IActionResult view = controller.Create("Portland");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
    //
    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      PlacesController controller = new PlacesController();
      RedirectToActionResult actionResult = controller.Create("Portland") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }
  }
}
