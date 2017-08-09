using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace MiningSimulator
{
    [Serializable]
    class Truck : INotifyPropertyChanged
    {
        // Allowed truck statuses

        public const int INACTIVE = 0; 
        public const int TRANSIT = 1;
        public const int LOADING = 2;
        public const int TRANSIT_LOADED = 3;
        public const int UNLOADING = 4;
        public const int SERVICE = 5;

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private int truck_ID;

        public int Truck_ID
        {
            get { return truck_ID; }
            set { 
                truck_ID = value;
                this.TruckInfo = String.Format("{0}\t{1}", this.truck_ID, this._status);
            }
        }
        
        public int Capacity { get; set; }
        private int _status;

        public int Status
        {
            get { return _status; }
            set {
                if (_status == UNLOADING && value != UNLOADING)
                    TotalTransported += Capacity;
                _status = value;     
                this.TruckInfo = String.Format("{0}\t{1}", this.truck_ID, this._status);
            }
        }

        private string _truckInfo;

        public string TruckInfo 
        {
            get { return _truckInfo; }
            set
            {
                _truckInfo = value;
                NotifyPropertyChanged("TruckInfo");
            } 
        }

        public double TotalTransported { get; set; }


        // to keep track of Truck position in the minor queues
        public int QueuePosition { get; set; }

        // constructor
        public Truck(int ID, int capacity)
        {
            this.Truck_ID = ID;
            this.Capacity = capacity;
            this.Status = INACTIVE;
            this.TotalTransported = 0;
            this.QueuePosition = 0;
        }


        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


    } // end of Truck Class
}
