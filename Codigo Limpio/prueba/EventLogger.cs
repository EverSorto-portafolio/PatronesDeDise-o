using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_Limpio.prueba
{
    public class EventLogger
    {
        private static EventLogger _instance;
        private List<string> _events;

        private EventLogger()
        {
            _events = new List<string>();
        }

        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }
            return _instance;
        }

        public void LogEvent(string eventMessage)
        {
            string horaDelRegistro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ff");
            _events.Add($"{horaDelRegistro} - {eventMessage}");

        }

        public void MostrarLogs()
        {
            foreach (var log in _events)
            {
                Console.WriteLine(log);
            }
        }
    }
}
