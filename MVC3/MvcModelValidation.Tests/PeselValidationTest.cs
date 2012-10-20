using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcModelValidation.Validation;

namespace MvcModelValidation.Tests
{
[TestClass]
public class PeselValidationTest
{
    PeselValidationAttribute target;

    [TestInitialize]
    public void Init()
    {
        target = new PeselValidationAttribute();
    }

    [TestMethod]
    public void TestValid()
    {
        // Act
        bool valid1 = target.IsValid("13040659673");
        bool valid2 = target.IsValid("03281336758");
        bool valid3 = target.IsValid("23210899855");
        bool valid4 = target.IsValid(null);

        // Assert
        Assert.AreEqual(true, valid1);
        Assert.AreEqual(true, valid2);
        Assert.AreEqual(true, valid3);
    }

    [TestMethod]
    public void TestInvalid()
    {
        // Act
        bool invalid1 = target.IsValid("");
        bool invalid2 = target.IsValid("abc");
        bool invalid3 = target.IsValid("86031212134");
        bool invalid4 = target.IsValid("5464");
        bool invalid5 = target.IsValid(23210899855);
        bool invalid6 = target.IsValid("232108998555");

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
