using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }

    }
    public enum DeviceType
    {
        BarcodeScanner,
        Printer,
        Camera,
        SocketTray
    }
}
