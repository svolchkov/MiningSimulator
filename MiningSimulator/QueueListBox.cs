using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiningSimulator
{
    public partial class QueueListBox : ListBox
    {
        public QueueListBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        // dequeue the first truck
        private void QueueListBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.DataSource != null)
            {
                QueueList q = this.DataSource as QueueList;
                if (!q.Dequeue())
                {
                    MessageBox.Show("Queue is empty");
                }       
            }
        }

// this make the selected item in the queue look the same as other items
        // so that the user doesn't get the impression that they can select trucks
        // in any of the minor queues
        private void QueueListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || this.Items.Count == 0) return;
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
            Truck t = this.Items[e.Index] as Truck;
            e.Graphics.DrawString(t.Truck_ID.ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}
