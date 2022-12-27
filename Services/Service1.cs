using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningDI.Interfaces;

namespace LearningDI.Services
{
    class Service1 : IService1
    {
        string name;
        public bool isShort(string name)
        {
            return name.Length < 5;
        }
    }
}
