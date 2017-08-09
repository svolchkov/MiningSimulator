namespace MiningSimulator
{
    partial class QueueListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // QueueListBox
            // 
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Size = new System.Drawing.Size(90, 186);
            this.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.QueueListBox_DrawItem);
            this.DoubleClick += new System.EventHandler(this.QueueListBox_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
