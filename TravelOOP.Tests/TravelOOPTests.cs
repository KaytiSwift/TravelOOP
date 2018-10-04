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

        [Test]
        public void Test_Date_Travel_Method()
        {
            var underTest = new Travel();
            var result = underTest.GetDate(9,8,2018);
            Assert.That(result, Is.EqualTo("9/8/2018"));
        }

        [Test]
        public void Test_Total_Travel_Time_Method()
        {
            var underTest = new Travel();
            var result = underTest.TotalTravelTime(9, 13, 2018);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test_Void_Selection_Method()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(5);
            Assert.That(result, Is.EqualTo("Cali"));
        }



    }
}
