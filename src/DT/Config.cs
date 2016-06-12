using System;
using System.Collections.Generic;

namespace DT
{
    public class Config
    {
        public List<Host> Hosts;
        public List<Service> Services;
    }

    public class Host
    {
        public string Name;
    }

    public class Service
    {
        public string Name;
    }
}
