using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUnitExamTests
{
    internal class DataDrivenTests
    {
        //[TestCase("Sayyaf@sayaf.com", 20)]
        //[TestCase("Admin@sayaf.com", 22)]
        //public void VerifyEmail(string emailUser, int age)
        //{

        //}

        //[TestCaseSource(nameof(GetEmails))]
        public void EmailValidation(string emailAddress)
        {

        }

        public static List<string> GetEmails()
        {
            var filePath = @"C:\..\..\User Emails.txt";
            var content = File.ReadAllLines(filePath);
            return content.ToList();
        }

        [OneTimeTearDown]
        public void A()
        {
            MessageBox.Show("OneTimeTearDown");
        }

        [Test]
        public void B()
        {
            MessageBox.Show("B");
        }

        [Test]
        public void C()
        {
            MessageBox.Show("C");
        }

        [OneTimeSetUp]
        public void D()
        {
            MessageBox.Show("OneTimeSetUp");
        }

        [SetUp]
        public void E()
        {
            MessageBox.Show("SetUp");
        }

        [TearDown]
        public void F()
        {
            MessageBox.Show("TearDown");
        }


    }
}
