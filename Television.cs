using System;

namespace Tutorial
{
    public class Television
    {
        private const int widht = 20;
        private bool _status = false;
        private int _channel;

        public void TurnOn()
        {
            if (_status == true)
            {
                Console.WriteLine("Televisyon zaten açık");
            }
            else
            {
                _status = true;
                _channel = 1;
                Console.WriteLine($"Televizyon açıldı. Mevcut kanal {_channel}");
            }
        }

        public void TvInfo()
        {
            string sit = _status ? "Açık" : "Kapalı";
            Console.WriteLine($"Televizyon şu anda {sit} Boyutu: {widht} inç . Mevcut Kanal{_channel}");
            
        }

        public void ChannelChange()
        {
            _channel++;
        }
    }
}