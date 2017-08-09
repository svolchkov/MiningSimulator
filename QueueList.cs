using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningSimulator
{
    class QueueList : BindingList<Truck>
    {
        // the status of trucks assigned to this queue
        int qStatus;
        // the queue to which a truck is moved from this queue 
        public QueueList nextQueueList = null;

        public QueueList(int qs)
        {
            this.qStatus = qs;
        }

        public QueueList(List<Truck> list)
                : base(list)
        {

        }

        public void Sort(Func<Truck, IComparable> getProp)
        {
            // TODO: clear your "sort" variables (prop/order)

            Truck[] arr = new Truck[Count];
            CopyTo(arr, 0);
            Array.Sort(arr, (x, y) => getProp(x).CompareTo(getProp(y))); ;
            bool oldRaise = RaiseListChangedEvents;
            RaiseListChangedEvents = false; // <=== oops, added!
            try
            {
                ClearItems();
                foreach (Truck t in arr)
                {
                    Add(t);
                }
            }
            finally
            {
                RaiseListChangedEvents = oldRaise;
                ResetBindings();
            }
        }


        public new void Add(Truck t){
            t.Status = qStatus;
            base.Add(t);
            //this.queueBox.DataSource = null;
            //this.queueBox.DataSource = this;
            //this.queueBox.DisplayMember = "TruckInfo";
            //MiningSimulator.lbMain.DataSource = null;
            //this.queueBox.DataSource = this;
            //this.queueBox.DisplayMember = "TruckInfo";       
        }

        public bool Dequeue()
        {
            if (this.Count > 0)
            {
                Truck t = this[0];
                this.RemoveAt(0);
                this.nextQueueList.Add(t);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
