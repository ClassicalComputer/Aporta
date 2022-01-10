using System;
using System.Threading.Tasks;
using Aporta.Extensions.Endpoint;
using Aporta.Drivers.OSDP.Shared;

namespace Aporta.Drivers.OSDP
{
    public class OSDPAccessPoint : IAccessPoint
    {
        private readonly Device _device;
        private readonly Reader _reader;

        public OSDPAccessPoint(Guid extensionId, Device device, Reader reader)
        {
            _device = device;
            _reader = reader;
            ExtensionId = extensionId;
        }

        public string Name => _reader.Name;

        public Guid ExtensionId { get; }
        
        public string Id => $"{_device.Address}:R{_reader.Number}";
        public Task<bool> GetOnlineStatus()
        {
            return Task.FromResult(true);
        }
    }
}