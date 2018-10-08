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

        [Test] //originally asked to return 5 but had to change because we changed return type
        public void Test_Total_Travel_Time_Method()
        {
            var underTest = new Travel();
            var result = underTest.TtlTravel(9, 13, 2018);
            Assert.That(result, Is.EqualTo("Cali"));
        }

        [Test]
        public void Test_Void_Selection_Method()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(5);
            Assert.That(result, Is.EqualTo("Cali"));
        }

        [Test]
        public void Selection_Method_4_Georgia()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(4);
            Assert.That(result, Is.EqualTo("Georgia"));
        }

        [Test]
        public void Selection_Method_3_Florida()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(3);
            Assert.That(result, Is.EqualTo("Florida"));
        }

        [Test]
        public void Selection_Method_2_Nashville()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(2);
            Assert.That(result, Is.EqualTo("Nashville"));
        }

        [Test]
        public void Selection_Method_1_PutInBay()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(1);
            Assert.That(result, Is.EqualTo("Put In Bay"));
        }

        [Test]
        public void Selection_Method_0_Stay_Home()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(0);
            Assert.That(result, Is.EqualTo("Stay Home"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(6);
            Assert.That(result, Is.EqualTo("The World is Yours"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5_Destination()
        {
            var underTest = new Travel();
            var result = underTest.GetSelection(6);
            Assert.That(result, Is.EqualTo("The World is Yours"));
        }

        [Test]
        public void Selection_Method_5_Destination_TTT_Method_Input()
        {
            var underTest = new Travel();
            var result = underTest.TtlTravel(9,14,2018);
            Assert.That(result, Is.EqualTo("The World is Yours"));
        }

        [Test]
        public void Selection_Method_5_Destination_TTT_Method_Input2()
        {
            var underTest = new Travel();
            var result = underTest.TtlTravel(9, 13, 2018);
            Assert.That(result, Is.EqualTo("Cali"));
        }
    }
}
