﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Shared.Abbstraction.Exeptions
{
    public abstract class TravelerCheckListException : Exception
    {
        protected TravelerCheckListException( string message) :base (message) 
        {

        }
    }
}
