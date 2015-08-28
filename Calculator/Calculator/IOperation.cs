using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{
    public interface IOperation: IOperand
    {
        IOperand Left { get; }
        IOperand Right { get; }
        int Value();
    }
}
