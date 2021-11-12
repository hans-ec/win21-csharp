using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Constructor
{
    public class Device
    {
        public Device(string name)
        {
            DeviceId = Guid.NewGuid();
            Name = name;
        }

        public Device(Guid deviceId, string name)
        {
            DeviceId = deviceId;
            Name = name;
        }

        public Guid DeviceId { get; set; }
        public string Name { get; set; }
    }
}
