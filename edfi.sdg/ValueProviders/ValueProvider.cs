﻿using System;
using System.Linq;
using System.Xml.Serialization;

namespace EdFi.SampleDataGenerator.ValueProviders
{
    [Serializable]
    public abstract class ValueProvider
    {
        [XmlArray]
        public string[] Dependencies { get; set; }

        public abstract object GetValue(params string[] dependsOn);

        [XmlIgnore]
        public bool HasDependency { get { return Dependencies != null && Dependencies.Any(); } }
    }
}
