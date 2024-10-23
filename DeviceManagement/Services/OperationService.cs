using System.Collections.Generic;
using System.Linq;
using DeviceManagement.Models;

namespace DeviceManagement.Services
{
    public class OperationService
    {
        //declare variable for memory allocation
        private readonly List<Operation> _operations = new List<Operation> ();

        //constructor.
        public List<Operation> GetOperations()
        {
            return _operations;
        }

        // add operation
        public void AddOperation(Operation operation)
        {
            _operations.Add(operation);
        }

        //remove operation
        public void RemoveOperation(int operationId)
        {
            var operation = _operations.FirstOrDefault(op => op.OperationID == operationId);
            if (operation != null)
            {
                _operations.Remove(operation);
            }

        }

        // add device to the operation list.
        public void AddDeviceToOperation(int operationId, Device device)
        {
            var operation = _operations.FirstOrDefault(op => op.OperationID == operationId);
            if(operation !=null)
            {
                operation.Device = device;
            }
        }
    }


}