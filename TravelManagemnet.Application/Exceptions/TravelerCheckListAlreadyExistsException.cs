﻿using TravelManagement.Shared.Abbstraction.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagemnet.Application.Exceptions
{
    public class TravelerCheckListAlreadyExistsException : TravelerCheckListException
    {
        public string Name { get; }

        public TravelerCheckListAlreadyExistsException(string name)
            : base($"Traveler Check List with name '{name}' already exists.")
        {
            Name = name;
        }
    }
}
