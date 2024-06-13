using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electrigreen.Functional
{
    public enum ElectronicState
    {
        BelumDitambahSmarthome,
        BelumDitambahNonSmarthome,
        TelahDitambahSmarhome,
        TelahDitambahNonSmarthome
    }

    public enum Trigger
    {
        TombolAdd,
        SmarthomeTercentang,
        SmarthomeTidakTercentang
    }
    public class kondisiElectronics
    {
        public ElectronicState stateAwal;
        public ElectronicState stateAkhir;
        public Trigger trigger;

        public kondisiElectronics(ElectronicState stateAwal, ElectronicState stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.trigger = trigger;
        }
    }

    public class Electronics
    {

        private bool tombolAddTrigered = false;
        public ElectronicsConfig config;
        private IElectronicsMediator mediator;

        public Electronics(ElectronicsConfig config, IElectronicsMediator mediator)
        {
            this.config = config;
            this.mediator = mediator;
        }

        kondisiElectronics[] transisi =
        {
        new kondisiElectronics(ElectronicState.BelumDitambahNonSmarthome, ElectronicState.BelumDitambahSmarthome, Trigger.SmarthomeTercentang),
        new kondisiElectronics(ElectronicState.BelumDitambahNonSmarthome, ElectronicState.TelahDitambahNonSmarthome, Trigger.TombolAdd),
        new kondisiElectronics(ElectronicState.BelumDitambahSmarthome, ElectronicState.TelahDitambahSmarhome,Trigger.TombolAdd),
        new kondisiElectronics(ElectronicState.BelumDitambahSmarthome, ElectronicState.BelumDitambahNonSmarthome,Trigger.SmarthomeTidakTercentang),
        new kondisiElectronics(ElectronicState.TelahDitambahNonSmarthome, ElectronicState.TelahDitambahSmarhome,Trigger.SmarthomeTercentang),
        new kondisiElectronics(ElectronicState.TelahDitambahSmarhome, ElectronicState.TelahDitambahNonSmarthome, Trigger.SmarthomeTidakTercentang)
    };
        public ElectronicState currentState = ElectronicState.BelumDitambahNonSmarthome;

        public ElectronicState GetNextState(ElectronicState stateAwal, Trigger trigger)
        {
            ElectronicState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                kondisiElectronics perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActivateTrigger(Trigger trigger)
        {
            if (IsAddTriggerLocked(trigger))
            {
                Console.WriteLine("Tombol Add telah tertekan, anda tidak bisa mengubah status smarthome lagi.");
                return;
            }
            HandleTrigger(trigger);
            UpdateState(trigger);
            DisplayStateMessage();
        }

        private bool IsAddTriggerLocked(Trigger trigger)
        {
            return (trigger == Trigger.SmarthomeTercentang || trigger == Trigger.SmarthomeTidakTercentang) && tombolAddTrigered;
        }

        private void HandleTrigger(Trigger trigger)
        {
            if (trigger == Trigger.TombolAdd)
            {
                tombolAddTrigered = true;
            }
        }

        private void UpdateState(Trigger trigger)
        {
            currentState = GetNextState(currentState, trigger);
        }

        private void DisplayStateMessage()
        {
            if (currentState == ElectronicState.TelahDitambahNonSmarthome)
            {
                Console.WriteLine($"Perangkat {config.config.jenis} Dengan Nama {config.config.nama} dan Voltase {config.config.voltase} berhasil ditambahkan");
            }
            else if (currentState == ElectronicState.TelahDitambahSmarhome)
            {
                Console.WriteLine($"{config.config.nama} berhasil ditambahkan sebagai perangkat Smarthome");
            }
            else if (currentState == ElectronicState.BelumDitambahNonSmarthome)
            {
                Console.WriteLine($"{config.config.nama} tidak terhubung ke Smarthome");
                config.config.isSmarthome = false;
            }
            else if (currentState == ElectronicState.BelumDitambahSmarthome)
            {
                Console.WriteLine($"{config.config.nama} terhubung ke Smarthome");
                config.config.isSmarthome = true;
            }
            Console.WriteLine($"Status perangkat ini: {currentState}");
        }

    }
}
