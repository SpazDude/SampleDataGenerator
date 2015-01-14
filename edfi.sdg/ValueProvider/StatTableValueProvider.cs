﻿using System;
using EdFi.SampleDataGenerator.Repository;

namespace EdFi.SampleDataGenerator.ValueProvider
{
    [Serializable]
    public class StatTableValueProvider : ValueProvider
    {
        public StatDataRepository DataRepository { get; set; }

        public override object GetValue(params string[] lookupPropertyValues)
        {
            return DataRepository.GetNextValue(lookupPropertyValues);
        }
    }
}
