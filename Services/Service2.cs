using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningDI.Interfaces;

namespace LearningDI.Services
{
    class Service2 : IService2
    {
        string name;
        public bool isLong(string name)
        {
            return name.Length > 10;
        }
    }
}
