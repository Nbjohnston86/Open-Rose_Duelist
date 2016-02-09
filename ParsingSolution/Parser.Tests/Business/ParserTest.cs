using System;
using System.Linq;
using Xunit;
using Parser.BusinessLogic;
using Parser.BusinessLogic.Enums;
using Parser.BusinessLogic.Interfaces;

namespace Parser.Tests.Business
{
    public class ParserTest
    {
        [Fact]
        public void TestMethod1()
        {
            IRoseParser testParser = new RoseParser();
            testParser.ConvertToJson(new);
        }
    }

    internal class TestParsable : IRoseParsable
    {
        TestParsable(){

            FilePath = "TestPath";
            FileType = ParsableEnum.Card;
        }

        public string FilePath
        {
            get; set;
        }

        public ParsableEnum FileType
        {
            get; set;
        }
    }
}
