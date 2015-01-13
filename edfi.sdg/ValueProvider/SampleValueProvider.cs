using System.Xml.Serialization;

namespace EdFi.SampleDataGenerator.ValueProvider
{
    public class SampleValueProvider : ValueProviderBase
    {
        [XmlAttribute]
        public string MyValue { get; set; }

        public override object GetValue(params string[] lookupPropertyValues)
        {
            return MyValue;
        }
    }
}