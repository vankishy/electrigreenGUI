using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrigreen.Functional
{
    public interface IElectronicsMediator
    {
        void AddElectronic(Electronics electronics);
        void ActivateTrigger(Electronics electronic, Trigger trigger);
    }

    public class ElectronicsMediator : IElectronicsMediator
    {
        private List<Electronics> electronicsList;

        public ElectronicsMediator()
        {
            electronicsList = new List<Electronics>();
        }

        public void AddElectronic(Electronics electronic)
        {
            electronicsList.Add(electronic);
        }

        public void ActivateTrigger(Electronics electronic, Trigger trigger)
        {
            electronic.ActivateTrigger(trigger);
        }

        public List<Electronics> GetElectronicsList()
        {
            return electronicsList;
        }

    }
}
