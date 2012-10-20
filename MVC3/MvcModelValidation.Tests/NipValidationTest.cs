using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcModelValidation.Validation;

namespace MvcModelValidation.Tests
{
    [TestClass]
    public class NipValidationTest
    {
        NipValidationAttribute target;

        [TestInitialize]
        public void Init()
        {
            target = new NipValidationAttribute();
        }

        [TestMethod]
        public void TestValid()
        {
            // Act
            bool valid1 = target.IsValid(null);
            bool valid2 = target.IsValid("9919731675");
            bool valid3 = target.IsValid("9957153453");
            bool valid4 = target.IsValid("9797585645");

            // Assert
            Assert.AreEqual(true, valid1);
            Assert.AreEqual(true, valid2);
            Assert.AreEqual(true, valid3);
            Assert.AreEqual(true, valid4);
        }

        [TestMethod]
        public void TestInvalid()
        {
            // Act
            bool invalid1 = target.IsValid("");
            bool invalid2 = target.IsValid("979-758-5645");
            bool invalid3 = target.IsValid("666");
            bool invalid4 = target.IsValid("348982233");
            bool invalid5 = target.IsValid(9797585645);
            bool invalid6 = target.IsValid("99797585645");

            // Assert
            Assert.AreEqual(false, invalid1);
            Assert.AreEqual(false, invalid2);
            Assert.AreEqual(false, invalid3);
            Assert.AreEqual(false, invalid4);
            Assert.AreEqual(false, invalid5);
            Assert.AreEqual(false, invalid6);
        }
    }
}
