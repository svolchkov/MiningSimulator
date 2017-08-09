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
    public class MyBindingList<T> : BindingList<T>
    {
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            List<T> items = new List<T>(Items);

            int index = 0;

            // call SetItem again on each item  
            // to re-establish event hookups
            foreach (T item in items)
            {
                // explicitly call the base version 
                // in case SetItem is overridden
                base.SetItem(index++, item);
            }
        }
    }
}
