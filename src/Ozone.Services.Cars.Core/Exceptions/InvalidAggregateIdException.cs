﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ozone.Services.Cars.Core.Exceptions
{
    public class InvalidAggregateIdException : DomainException
    {
        public override string Code { get; } = "invalid_aggregate_id";
        public InvalidAggregateIdException() : base("Invalid aggregate id.")
        {
        }
    }
}
