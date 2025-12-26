
namespace BridgePattern.Implementations
{
    public abstract class Device
    {
        private int _channel = 1;
        private int _volume = 30;
        private bool _isEnabled = true;
        public bool IsEnabled() => true;
        public int GetVolume() => _volume;
        public void SetVolume(int percent)
        {
            _volume = percent;
        }
        public int GetChannel() => _channel;
        public void SetChannel(int channel)
        {
            _channel = channel;
        }

        public void Disable()
        {
            _isEnabled = false;
        }

        internal void Enable()
        {
            _isEnabled = true;
        }
    }
}
