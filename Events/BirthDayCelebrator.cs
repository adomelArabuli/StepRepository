using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class CakeCutEventArgs : EventArgs
    {
        public string Message { get;}

        public CakeCutEventArgs(string message)
        {
            Message = message;
        }
    }

    public class BirthDayCelebrator
    {
        public event EventHandler<CakeCutEventArgs> CakeCutEvent;

        protected virtual void OnCakeCut(string message)
        {
            CakeCutEventArgs args = new CakeCutEventArgs(message);
            CakeCutEvent?.Invoke(this, args);
        }

        public void CelebrateBirthDay()
        {
            OnCakeCut("Birthday cake cutting");
        }
    }

    public class PartySubscriber
    {
        public bool IsSucbscibed { get; set; }
        private void CakeCutEventHandler(object sender, CakeCutEventArgs e)
        {
            Console.WriteLine($"Cool! there is and {e.Message} happening!");
        }

        private void CakeCutEventHandler2(object sender, CakeCutEventArgs e)
        {
            Console.WriteLine($"Cool! there is and {e.Message} happening! + log");
        }

        public void Subscribe(BirthDayCelebrator birthDayCelebrator)
        {
            birthDayCelebrator.CakeCutEvent += CakeCutEventHandler;
            birthDayCelebrator.CakeCutEvent += CakeCutEventHandler2;
            IsSucbscibed = true;
        }

        public void UnSubscribe(BirthDayCelebrator birthDayCelebrator)
        {
            birthDayCelebrator.CakeCutEvent -= CakeCutEventHandler;
            birthDayCelebrator.CakeCutEvent -= CakeCutEventHandler2;
            IsSucbscibed = false;
        }
    }
}
