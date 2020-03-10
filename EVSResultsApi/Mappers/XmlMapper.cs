using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EVSResultsApi.Models;

namespace EVSResultsApi.Mappers
{
    public class XmlMapper : IXmlMapper
    {
        public MatchResult MatchXmlConvert(string xmlFile)
        {
            MatchResult matchResult;
            var serializer = new XmlSerializer(typeof(MatchResult));
            using (var reader = new StringReader(xmlFile))
            {
                matchResult = (MatchResult)serializer.Deserialize(reader);
            }


            //XmlSerializer deserializer = new XmlSerializer(typeof(List<MatchResult>));
            //TextReader textReader = new StreamReader(xmlFile);
            //List<MatchResult> matchResults;
            //matchResults = (List<MatchResult>)deserializer.Deserialize(textReader);
            //textReader.Close();
            return matchResult;
        }
    }
}
