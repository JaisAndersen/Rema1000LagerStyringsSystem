﻿using Rema1000LagerStyringsSystem.Models;
using System.Collections.Generic;

namespace Rema1000LagerStyringsSystem.Interface
{
    public interface IItem
    {
        List<Item> GetItems();
    }
}
