﻿using Microsoft.Extensions.Logging;
using NUnit.Framework;
using Moq;
using LetsGoPark.WebSite.Pages;
using System.Collections.Generic;
using LetsGoPark.WebSite.Models;
using LetsGoPark.WebSite.Services;
using Microsoft.AspNetCore.Hosting;

namespace UnitTests.Pages
{
    public class ParksIndexModelTests
    {
        [Test]
        public void ModelIsRendered()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<ParksIndexModel>>();
            var envMock = new Mock<IWebHostEnvironment>();
            var parkService = new JsonFileParksService(envMock.Object);

            // Act
            var model = new ParksIndexModel(loggerMock.Object, parkService);

            // Assert
            Assert.NotNull(model);
        }

    }
}