using System;
using System.Collections.Generic;
using System.Text;

public interface IBrowseable
{
    string Url { get; set; }
    void Browse();
}
