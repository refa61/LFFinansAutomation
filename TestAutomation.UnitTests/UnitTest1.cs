using NUnit.Framework;
using TestAutomation.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using Allure.Commons;
using System;

namespace TestAutomation.UnitTests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Book")]
    [AllureOwner("Alex")]
    public class BookTests
    {
        public string title;
        public int pages;
        public string author;

        [SetUp]
        public void Setup()
        {
            Book book = new Book("Pippi", 100, "Astrid");
            book.setTitle("Testautomation");
            title = book.getTitle();

            book.setPages(200);
            pages = book.getPages();

            book.setAuthor("Selma");
            author = book.getAuthor();
        }

        [Test]
        [AllureTag("smoke")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("GetTitle")]
        public void Test1()
        {
            Assert.AreEqual("Testautomation", title);
            TestContext.WriteLine("Title är: " + title);
        }

        [Test]
        [AllureTag("smoke")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("GetPages")]
        public void Test2()
        {
            Assert.AreEqual(200, pages);
            TestContext.WriteLine("Pages: " + pages);
        }

        [Test]
        [AllureTag("smoke")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("GetAuthor")]
        public void Test3()
        {
            Assert.AreEqual("Selma", author);
            TestContext.WriteLine("Author: " + author);
        }

        [Test]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureSubSuite("Validation")]
        public void SetTitle_ShouldThrow_WhenEmptyString()
        {
            var book = new Book("Initial", 10, "Author");
            var ex = Assert.Throws<ArgumentException>(() => book.setTitle(""));
            Assert.That(ex.Message, Is.EqualTo("Title must include charachters"));
        }
    }
}
