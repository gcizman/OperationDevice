using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class Operation
    {
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public Device Device { get; set; }
    }
}
