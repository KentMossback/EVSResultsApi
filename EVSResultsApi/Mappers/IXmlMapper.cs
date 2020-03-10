using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using EVSResultsApi.Models;

namespace EVSResultsApi.Mappers
{
    public interface IXmlMapper
    {

        MatchResult MatchXmlConvert(string xmlFile);
    }
}
