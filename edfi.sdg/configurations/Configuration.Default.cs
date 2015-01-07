﻿using edfi.sdg.generators;
using edfi.sdg.models;

namespace edfi.sdg.configurations
{
    public partial class Configuration
    {
        public static Configuration DefaultConfiguration
        {
            get
            {
                return new Configuration
                {
                    MaxQueueWrites = 10,
                    NumThreads = 1,
                    WorkQueueName = @".\Private$\edfi.sdg",
                    Generators = new Generator[]
                    {
                        new TypeQuantityGenerator<Student> {QuantitySpecifier = new ConstantQuantity {Quantity = 200}},
                        new DistributedEnumValueGenerator<SexType> {Property = "Student.Sex"},
                        new DistributedEnumValueGenerator<OldEthnicityType> {Property = "Student.OldEthnicity"},
                        new StatTableValueGenerator {PropertyToSet = "Name", PropertiesToLook = new[] {"Student.OldEthnicity", "Student.Sex"}}
                    }
                };
            }
        }
    }
}
