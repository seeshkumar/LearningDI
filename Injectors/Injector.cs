using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningDI.Interfaces;

namespace LearningDI.Injectors
{
    class Injector
    {
        IService1 service1Obj;
        IService2 service2Obj;

        public Injector(IService1 service1Obj, IService2 service2Obj)
        {
            this.service1Obj = service1Obj;
            this.service2Obj = service2Obj;
        }
        public bool isShort(string name)
        {
            return service1Obj.isShort(name);
        }

        public bool isLong(string name)
        {
            return service2Obj.isLong(name);
        }
    }
}
