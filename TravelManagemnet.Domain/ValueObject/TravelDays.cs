﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Exceptios;

namespace TravelManagemnet.Domain.ValueObject
{
    public class TravelDays
    {
        public ushort Value { get; }
        public TravelDays(ushort value)
        {
            if (value is 0 or > 100)
            {
                throw new InvalidTravelDaysException(value);
            }
            Value = value;
        }
        public static implicit operator ushort(TravelDays daye)
          => daye.Value;

        public static implicit operator TravelDays(ushort days)
          => new(days);
    }
}
