﻿using System;
using System.Collections.Generic;
using System.Text;

public enum Corps
{
    Airforces,
    Marines
}       
public interface ISpecialisedSoldier
{
    
    Corps Corps { get; set; }
}
