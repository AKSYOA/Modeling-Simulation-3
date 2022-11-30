
namespace InventorySimulation
{
    partial class Output
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AvergaeShortage = new System.Windows.Forms.TextBox();
            this.AvergaeEnding = new System.Windows.Forms.TextBox();
            this.averageWaitingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayWithin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Begining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomLead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AvergaeShortage
            // 
            this.AvergaeShortage.Location = new System.Drawing.Point(392, 559);
            this.AvergaeShortage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvergaeShortage.Name = "AvergaeShortage";
            this.AvergaeShortage.ReadOnly = true;
            this.AvergaeShortage.Size = new System.Drawing.Size(180, 24);
            this.AvergaeShortage.TabIndex = 25;
            // 
            // AvergaeEnding
            // 
            this.AvergaeEnding.Location = new System.Drawing.Point(48, 559);
            this.AvergaeEnding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvergaeEnding.Name = "AvergaeEnding";
            this.AvergaeEnding.ReadOnly = true;
            this.AvergaeEnding.Size = new System.Drawing.Size(166, 24);
            this.AvergaeEnding.TabIndex = 24;
            // 
            // averageWaitingTextBox
            // 
            this.averageWaitingTextBox.Location = new System.Drawing.Point(-189, 478);
            this.averageWaitingTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.averageWaitingTextBox.Name = "averageWaitingTextBox";
            this.averageWaitingTextBox.ReadOnly = true;
            this.averageWaitingTextBox.Size = new System.Drawing.Size(116, 24);
            this.averageWaitingTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Average Shortage Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Avergae Ending Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-193, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Average Waiting Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(29, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "System Performance Measures";
            // 
            // outputDataGridView
            // 
            this.outputDataGridView.AllowUserToAddRows = false;
            this.outputDataGridView.AllowUserToDeleteRows = false;
            this.outputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Cycle,
            this.DayWithin,
            this.Begining,
            this.RandomDemand,
            this.Demand,
            this.EndingInventory,
            this.ShortageQuantity,
            this.OrderQuantity,
            this.RandomLead,
            this.LeadTime});
            this.outputDataGridView.Location = new System.Drawing.Point(12, 13);
            this.outputDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputDataGridView.Name = "outputDataGridView";
            this.outputDataGridView.ReadOnly = true;
            this.outputDataGridView.RowHeadersWidth = 30;
            this.outputDataGridView.Size = new System.Drawing.Size(1307, 423);
            this.outputDataGridView.TabIndex = 18;
            this.outputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Customer No.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Cycle
            // 
            this.Cycle.HeaderText = "Cycle";
            this.Cycle.MinimumWidth = 6;
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Width = 80;
            // 
            // DayWithin
            // 
            this.DayWithin.HeaderText = "Day Within Cycle";
            this.DayWithin.MinimumWidth = 6;
            this.DayWithin.Name = "DayWithin";
            this.DayWithin.ReadOnly = true;
            this.DayWithin.Width = 125;
            // 
            // Begining
            // 
            this.Begining.HeaderText = "Begining Inventory";
            this.Begining.MinimumWidth = 6;
            this.Begining.Name = "Begining";
            this.Begining.ReadOnly = true;
            this.Begining.Width = 125;
            // 
            // RandomDemand
            // 
            this.RandomDemand.HeaderText = "Random Demand";
            this.RandomDemand.MinimumWidth = 6;
            this.RandomDemand.Name = "RandomDemand";
            this.RandomDemand.ReadOnly = true;
            this.RandomDemand.Width = 125;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            this.Demand.Width = 125;
            // 
            // EndingInventory
            // 
            this.EndingInventory.HeaderText = "Ending Inventory";
            this.EndingInventory.MinimumWidth = 6;
            this.EndingInventory.Name = "EndingInventory";
            this.EndingInventory.ReadOnly = true;
            this.EndingInventory.Width = 125;
            // 
            // ShortageQuantity
            // 
            this.ShortageQuantity.HeaderText = "Shortage Quantity";
            this.ShortageQuantity.MinimumWidth = 6;
            this.ShortageQuantity.Name = "ShortageQuantity";
            this.ShortageQuantity.ReadOnly = true;
            this.ShortageQuantity.Width = 125;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.HeaderText = "OrderQuantity";
            this.OrderQuantity.MinimumWidth = 6;
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.ReadOnly = true;
            this.OrderQuantity.Width = 125;
            // 
            // RandomLead
            // 
            this.RandomLead.HeaderText = "Random Lead Time";
            this.RandomLead.MinimumWidth = 6;
            this.RandomLead.Name = "RandomLead";
            this.RandomLead.ReadOnly = true;
            this.RandomLead.Width = 125;
            // 
            // LeadTime
            // 
            this.LeadTime.HeaderText = "Lead Time";
            this.LeadTime.MinimumWidth = 6;
            this.LeadTime.Name = "LeadTime";
            this.LeadTime.ReadOnly = true;
            this.LeadTime.Width = 125;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 720);
            this.Controls.Add(this.AvergaeShortage);
            this.Controls.Add(this.AvergaeEnding);
            this.Controls.Add(this.averageWaitingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputDataGridView);
            this.Name = "Output";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Output_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AvergaeShortage;
        private System.Windows.Forms.TextBox AvergaeEnding;
        private System.Windows.Forms.TextBox averageWaitingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView outputDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayWithin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Begining;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomLead;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTime;
    }
}