using _01.SimpleParserProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimpleParserTestProjectUpdate
{
    class SimpleParserTests
    {
        public class TestUtil
        {
            public static void ShowProblem(string test, string message)
            {
                string msg = string.Format(@"
                ---{0}---{1}
                --------------------
                ", test, message);
                Console.WriteLine(msg);
            }
        }
        public static void TestReturnsZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil.ShowProblem(testName,
                        "Parse and sum should have returned 0 on an empty string.");
                }
            }
            catch (Exception e)
            {

                TestUtil.ShowProblem(testName, e.ToString());
            }
        }
    }
}