using System.Collections.Generic;
using System.Linq;
using DeviceManagement.Models;

namespace DeviceManagement.Services
{
    public class DevicesService
    {
        //declare variables.
        private readonly List<Device> _devices = new List<Device>();

        //constructor.
        public List<Device> GetDevices()
        {
            return _devices;
        }

        // add devices
        public void AddDevice(Device device)
        {
            _devices.Add(device);
        }


        //get devices.
        public Device GetDevice(int deviceId)
        {
            return _devices.FirstOrDefault(d => d.DeviceID == deviceId);
        }
    }
}
