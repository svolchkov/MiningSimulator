using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MiningSimulator
{
    public partial class MiningSIM : Form
    {
        static string truckFile = @"trucks.dat";
        const int MAX_SIZE = 100;
        MyBindingList<Truck> trucks = new MyBindingList<Truck>();
        BindingList<Truck> service = new BindingList<Truck>();
        // currently selected status
        RadioButton selectedStatus = null;

        QueueList transitLoading;
        QueueList loading;
        QueueList transitCrushing;
        QueueList crushing;

        List<QueueList> queues = new List<QueueList>(); 

        public MiningSIM()
        {
            InitializeComponent();
        
           // MessageBox.Show("The control named " + e.Control.Name + " has been added to the form.");

            // disable all radio buttons
            foreach (Control c in gbStatus.Controls)
            {
                    if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton r = c as RadioButton;
                    r.CheckedChanged += new EventHandler(rgStatusChecked);
                    r.AutoCheck = false;
                }
            }
            
            
// load the data from file or create a new truck fleet        
            if (File.Exists(truckFile))
            {
                FileStream inStr = new FileStream(truckFile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                trucks = (MyBindingList<Truck>)bf.Deserialize(inStr); 
                inStr.Close();
            }
            else
            {
                for (int i = 0; i < MAX_SIZE; i++)
                {
                    int ID = i + MAX_SIZE;
                    int capacity = 200;
                    trucks.Add(new Truck(ID, capacity));
                }
            }
// populate main listbox
            lbMain.DataSource = trucks;
            lbMain.SelectedItem = trucks[0];
// Bind QueueLists to QueueListBoxes
            transitLoading = new QueueList(Truck.TRANSIT);
            qlbTransitLoading.DataSource = transitLoading;
            qlbTransitLoading.DisplayMember = "Truck_ID";
            loading = new QueueList(Truck.LOADING);
            qlbLoading.DataSource = loading;
            qlbLoading.DisplayMember = "Truck_ID";
            transitCrushing = new QueueList(Truck.TRANSIT_LOADED);
            qlbTransitCrushing.DataSource = transitCrushing;
            qlbTransitCrushing.DisplayMember = "Truck_ID";
            crushing = new QueueList(Truck.UNLOADING);
            qlbCrushing.DataSource = crushing;
            qlbCrushing.DisplayMember = "Truck_ID";
//Set "next" Queuelists
            transitLoading.nextQueueList = loading;
            loading.nextQueueList = transitCrushing;
            transitCrushing.nextQueueList = crushing;
            crushing.nextQueueList = transitLoading;
//Bind service list to service listbox
            lbService.DataSource = service;
            lbService.DisplayMember = "Truck_ID";


            // populate the queues
            foreach (Truck t in trucks)
            {
                switch (t.Status)
                {
                    case (Truck.TRANSIT):
                        transitLoading.Add(t);
                        break;
                    case (Truck.LOADING):
                        loading.Add(t);
                        break;
                    case (Truck.TRANSIT_LOADED):
                        transitCrushing.Add(t);
                        break;
                    case (Truck.UNLOADING):
                        crushing.Add(t);
                        break;
                    case (Truck.SERVICE):
                        service.Add(t);
                        break;
                    default:
                        break;
                }
            }

            // restore the order of trucks in each queue

            queues.Add(transitLoading);
            queues.Add(loading);
            queues.Add(transitCrushing);
            queues.Add(crushing);

            //for (int i = 0; i < queues.Count(); i++)
            //{
            //    if (queues[i] != null)
            //    {
            //       // List<Truck> sortedQueue = queues[i].OrderBy(o => o.queuePosition).ToList();
            //        queues[i] = new QueueList(sortedQueue);
            //    }         
            //}

            foreach (QueueList q in queues)
            {
                q.Sort(t => t.QueuePosition);
            }

        }

        private void lbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Truck t = (Truck)lbMain.SelectedItem;
            if (t != null)
            {
                tbTruckID.Text = t.Truck_ID.ToString();
                tbLoadCapacity.Text = t.Capacity.ToString();
                tbTotal.Text = t.TotalTransported.ToString();
                //var checkedButton = gbStatus.Controls.OfType<RadioButton>()
                //                      .FirstOrDefault(r => r.Tag.ToString() == t.Status.ToString());
                //selectedStatus = checkedButton as RadioButton;
                //selectedStatus.Checked = true;
                foreach (Control c in gbStatus.Controls)
                {
                    if (c.GetType() == typeof(RadioButton))
                    {
                        RadioButton r = c as RadioButton;
                        if (r.Tag.ToString() == t.Status.ToString())
                        {
                            r.Checked = true;
                        }
                        else
                        {
                            r.Checked = false;
                        }
                    }
                }
            }
            
            

        }

// treat all buttons in the radio group as a single unit
// not currently used as changing truck status via the radio buttons is not allowed
        private void rgStatusChecked(object sender, EventArgs e)
        {
            selectedStatus = sender as RadioButton;
            if (selectedStatus.Checked)
            {
                if (lbMain.SelectedItem != null)
                {
                    Truck t = (Truck)lbMain.SelectedItem;
                    int s;
                    if (Int32.TryParse(selectedStatus.Tag.ToString(), out s))
                                    t.Status = s;
                    //lbMain.DataSource = null; 
                    //lbMain.DataSource = trucks;
                    //lbMain.DisplayMember = "TruckInfo";
                    //lbMain.SelectedItem = t;
                }
            }
        }

        private void MiningSimulator_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update queue position of trucks in any of the queues
            foreach (QueueList q in queues)
            {
                if (q != null)
                {
                    foreach (Truck t in q)
                    {
                        t.QueuePosition = q.IndexOf(t);
                    }
                }
            }
            // save data to file
            FileStream fs = new FileStream(truckFile, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            //bf.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            bf.Serialize(fs, trucks);
            fs.Close();
        }

        private void lbMain_DoubleClick(object sender, EventArgs e)
        {
            // add item to transit to loading queue
            if (lbMain.SelectedItem != null)
            {
                Truck t = (Truck)lbMain.SelectedItem;
                if (t.Status == Truck.INACTIVE)
                        transitLoading.Add(t);
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            // puts trucks in service
            if (lbMain.SelectedItem != null)
            {
                Truck t = (Truck)lbMain.SelectedItem;
                if (t.Status != Truck.TRANSIT)
                {
                    MessageBox.Show("Only trucks in transit to loading\ncan be diverted to service");
                    return;
                }
                else
                {
                    //var transitTruck = transitLoading.FirstOrDefault(truck => truck.Truck_ID
                    //    == t.Truck_ID);
                    transitLoading.Remove(t);
                    t.Status = Truck.SERVICE;
                    service.Add(t);
                }
            }
        }


        private void lbService_DrawItem(object sender, DrawItemEventArgs e)
        {
            // this to make sure no item is highlighted in the service listbox,
            // as that would be distracting
            if (e.Index < 0 || service.Count == 0) return;
            //if the item state is selected then change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.White);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            Truck t = service[e.Index] as Truck;
            e.Graphics.DrawString(t.Truck_ID.ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            // make a truck inactive
            if (lbMain.SelectedItem != null)
            {
                Truck t = (Truck)lbMain.SelectedItem;
                if (t.Status != Truck.UNLOADING && t.Status != Truck.SERVICE)
                {
                    MessageBox.Show("Only trucks at Crushing or Service\ncan be made inactive");
                    return;
                }
                else
                {
                    //var transitTruck = transitLoading.FirstOrDefault(truck => truck.Truck_ID
                    //    == t.Truck_ID);
                    if (t.Status == Truck.UNLOADING)
                        crushing.Remove(t);
                    else if (t.Status == Truck.SERVICE)
                        service.Remove(t);
                    t.Status = Truck.INACTIVE;
                    
                }
            }
        }

        private void MiningSIM_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        //private void gbStatus_ControlAdded(object sender, ControlEventArgs e)
        //{
        //   // MessageBox.Show("The control named " + e.Control.Name + " has been added to the form.");
        //    if (e.Control.GetType() == typeof(RadioButton))
        //    {
        //        RadioButton r = e.Control as RadioButton;
        //        r.CheckedChanged += new EventHandler(rgStatusChecked);
        //    }
            
        //}
    }
}
