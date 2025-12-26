using BridgePattern.Implementations;

namespace BridgePattern.Abstractions
{
    public class RemoteControl
    {
        protected readonly Device _device;

        public RemoteControl(Device device)
        {
            _device = device;
        }

        public virtual bool IsEnabled()
        {
            return _device.IsEnabled();
        }

        public virtual void TogglePower()
        {
            if (_device.IsEnabled())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        public virtual void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public virtual void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        public virtual void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        public virtual void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }
    }
}
