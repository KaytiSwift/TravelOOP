using GroupProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOOP.Tests
{
    [TestFixture]
    public class TravelOOPTests
    {

        [Test]
        public void Test_Default_CTR()
        {
            var underTest = new Travel();
            underTest.FName = "FName";
            var result = underTest.FName;
            Assert.That(result, Is.EqualTo("FName"));
        }

        [Test]
        public void Test_LastName_Prop()
        {
            var underTest = new Travel();
            underTest.LName = "LName";
            var result = underTest.LName;
            Assert.That(result, Is.EqualTo("LName"));
        }

        [Test]
        public void Test_Address_Prop()
        {
            var underTest = new Travel();
            underTest.Address = "";
            var result = underTest.Address;
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void Test__EmailAddress_Prop()
        {
            var underTest = new Travel();
            underTest.EmailAddress = "";
            var result = underTest.EmailAddress;
            Assert.That(result, Is.EqualTo(""));
        }
    }
}
