using System;
using System.Collections.Generic;
using System.Text;

public interface ICallable
{
    string Number { get; set; }
    void Call();
}