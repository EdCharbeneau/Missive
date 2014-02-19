using NUnit.Framework;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Missive.Templates.Razor.Tests.Models;

namespace Missive.Templates.Razor.Tests
{
    [TestFixture]
    public class RazorTemplateTests
    {
        [Test]
        public void ToEmailBody_AppliesRazorTemplate_ToModelOfObject()
        {
            //arrange
            var model = new Person() { FirstName = "Walter", LastName = "White" };
            var template = "Hello, my name is @Model.FirstName, @Model.LastName";
            var expectedBody = "Hello, my name is Walter, White";

            //act
            var resultBody = model.ToEmailBody(template);

            //assert
            Console.Write(resultBody);
            resultBody.Should().Be(expectedBody);
        }

        [Test]
        public void ToEmailBody_AppliesRazorTemplate_ToModelOfAnonymousObject()
        {
            //arrange
            var model = new { FirstName = "Walter", LastName = "White" };
            var template = "Hello, my name is @Model.FirstName, @Model.LastName";
            var expectedBody = "Hello, my name is Walter, White";

            //act
            var resultBody = model.ToEmailBody(template);

            //assert
            Console.Write(resultBody);
            resultBody.Should().Be(expectedBody);
        }
    }
}
