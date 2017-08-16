using LogAn.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        [Category("LogAn")]
        public void IsValidFileName_GoodExtension_ReturnFalse()
        {
            LogAnalyzer logAnalyzer = MakeAnalyzer();
            bool result = logAnalyzer.IsValidLogFileName("filewithbadextension.foo");
            Assert.False(result);
        }

        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]
        [Category("LogAn")]
        public void IsValidFileName_GoodExtension_ReturnTrue(string fileName)
        {
            LogAnalyzer logAnalyzer = MakeAnalyzer();
            bool result = logAnalyzer.IsValidLogFileName(fileName);
            Assert.True(result);
        }


        [Test]
        [Category("LogAn")]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            LogAnalyzer logAnalyzer = MakeAnalyzer();
            ArgumentException ex = Assert.Catch<ArgumentException>(() => logAnalyzer.IsValidLogFileName(""));
            StringAssert.Contains("filename has to be provided", ex.Message);

        }

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        [Category("LogAn")]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string fileName,
            bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();
            la.IsValidLogFileName(fileName);
            Assert.AreEqual(expected, la.WasLastFileNameValid);
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }

    }
}
