﻿namespace edfi.sdg.generators
{
    using System;
    using System.Xml.Serialization;

    [System.SerializableAttribute()]
    public class Weighting<T>
    {
        [XmlAttribute]
        public T Value { get; set; }
        [XmlAttribute]
        public Double Weight { get; set; }
    }
}