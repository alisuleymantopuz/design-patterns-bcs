using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.DecoratorPattern
{
    
    public interface Vehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }
}
