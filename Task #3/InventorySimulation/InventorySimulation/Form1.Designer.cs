namespace InventorySimulation
{
    partial class Form1
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
            this.TestCases = new System.Windows.Forms.Button();
            this.OpenTestCases = new System.Windows.Forms.OpenFileDialog();
            this.Simulate = new System.Windows.Forms.Button();
            this.DemandData = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartLeadDays = new System.Windows.Forms.TextBox();
            this.StartInventoryQuantity = new System.Windows.Forms.TextBox();
            this.ReviewPeriod = new System.Windows.Forms.TextBox();
            this.OrderUpTo = new System.Windows.Forms.TextBox();
            this.texttt = new System.Windows.Forms.Label();
            this.textttt = new System.Windows.Forms.Label();
            this.TextStopping = new System.Windows.Forms.Label();
            this.TextOrder = new System.Windows.Forms.Label();
            this.NumberOfDays = new System.Windows.Forms.TextBox();
            this.StartOrderQuantity = new System.Windows.Forms.TextBox();
            this.texttttttt = new System.Windows.Forms.Label();
            this.Textttttttt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DemandData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeadData)).BeginInit();
            this.SuspendLayout();
            // 
            // TestCases
            // 
            this.TestCases.Location = new System.Drawing.Point(307, 107);
            this.TestCases.Name = "TestCases";
            this.TestCases.Size = new System.Drawing.Size(101, 58);
            this.TestCases.TabIndex = 1;
            this.TestCases.Text = "Test Cases";
            this.TestCases.UseVisualStyleBackColor = true;
            this.TestCases.Click += new System.EventHandler(this.TestCases_Click_1);
            // 
            // OpenTestCases
            // 
            this.OpenTestCases.FileName = "openFileDialog1";
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(324, 550);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(100, 58);
            this.Simulate.TabIndex = 2;
            this.Simulate.Text = "Simulation";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click_1);
            // 
            // DemandData
            // 
            this.DemandData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Probability});
            this.DemandData.Location = new System.Drawing.Point(12, 12);
            this.DemandData.Name = "DemandData";
            this.DemandData.RowHeadersWidth = 51;
            this.DemandData.RowTemplate.Height = 26;
            this.DemandData.Size = new System.Drawing.Size(264, 350);
            this.DemandData.TabIndex = 3;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.Width = 125;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.MinimumWidth = 6;
            this.Probability.Name = "Probability";
            this.Probability.Width = 125;
            // 
            // LeadData
            // 
            this.LeadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.LeadData.Location = new System.Drawing.Point(443, 12);
            this.LeadData.Name = "LeadData";
            this.LeadData.RowHeadersWidth = 51;
            this.LeadData.RowTemplate.Height = 26;
            this.LeadData.Size = new System.Drawing.Size(264, 350);
            this.LeadData.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "LeadTime";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // StartLeadDays
            // 
            this.StartLeadDays.Location = new System.Drawing.Point(531, 440);
            this.StartLeadDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartLeadDays.Name = "StartLeadDays";
            this.StartLeadDays.ReadOnly = true;
            this.StartLeadDays.Size = new System.Drawing.Size(161, 24);
            this.StartLeadDays.TabIndex = 16;
            // 
            // StartInventoryQuantity
            // 
            this.StartInventoryQuantity.Location = new System.Drawing.Point(165, 440);
            this.StartInventoryQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartInventoryQuantity.Name = "StartInventoryQuantity";
            this.StartInventoryQuantity.ReadOnly = true;
            this.StartInventoryQuantity.Size = new System.Drawing.Size(154, 24);
            this.StartInventoryQuantity.TabIndex = 15;
            // 
            // ReviewPeriod
            // 
            this.ReviewPeriod.Location = new System.Drawing.Point(531, 388);
            this.ReviewPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReviewPeriod.Name = "ReviewPeriod";
            this.ReviewPeriod.ReadOnly = true;
            this.ReviewPeriod.Size = new System.Drawing.Size(161, 24);
            this.ReviewPeriod.TabIndex = 14;
            // 
            // OrderUpTo
            // 
            this.OrderUpTo.Location = new System.Drawing.Point(165, 388);
            this.OrderUpTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderUpTo.Name = "OrderUpTo";
            this.OrderUpTo.ReadOnly = true;
            this.OrderUpTo.Size = new System.Drawing.Size(154, 24);
            this.OrderUpTo.TabIndex = 13;
            // 
            // texttt
            // 
            this.texttt.AutoSize = true;
            this.texttt.Location = new System.Drawing.Point(414, 443);
            this.texttt.Name = "texttt";
            this.texttt.Size = new System.Drawing.Size(106, 17);
            this.texttt.TabIndex = 12;
            this.texttt.Text = "Start Lead Days";
            // 
            // textttt
            // 
            this.textttt.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.textttt.AutoSize = true;
            this.textttt.Location = new System.Drawing.Point(-1, 443);
            this.textttt.Name = "textttt";
            this.textttt.Size = new System.Drawing.Size(160, 17);
            this.textttt.TabIndex = 11;
            this.textttt.Text = "Start Inventory Quantity";
            // 
            // TextStopping
            // 
            this.TextStopping.AutoSize = true;
            this.TextStopping.Location = new System.Drawing.Point(414, 391);
            this.TextStopping.Name = "TextStopping";
            this.TextStopping.Size = new System.Drawing.Size(93, 17);
            this.TextStopping.TabIndex = 10;
            this.TextStopping.Text = "Review Period";
            // 
            // TextOrder
            // 
            this.TextOrder.AutoSize = true;
            this.TextOrder.Location = new System.Drawing.Point(44, 395);
            this.TextOrder.Name = "TextOrder";
            this.TextOrder.Size = new System.Drawing.Size(84, 17);
            this.TextOrder.TabIndex = 9;
            this.TextOrder.Text = "Order Up To";
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.Location = new System.Drawing.Point(531, 485);
            this.NumberOfDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.ReadOnly = true;
            this.NumberOfDays.Size = new System.Drawing.Size(161, 24);
            this.NumberOfDays.TabIndex = 20;
            // 
            // StartOrderQuantity
            // 
            this.StartOrderQuantity.Location = new System.Drawing.Point(165, 485);
            this.StartOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartOrderQuantity.Name = "StartOrderQuantity";
            this.StartOrderQuantity.ReadOnly = true;
            this.StartOrderQuantity.Size = new System.Drawing.Size(154, 24);
            this.StartOrderQuantity.TabIndex = 19;
            // 
            // texttttttt
            // 
            this.texttttttt.AutoSize = true;
            this.texttttttt.Location = new System.Drawing.Point(414, 488);
            this.texttttttt.Name = "texttttttt";
            this.texttttttt.Size = new System.Drawing.Size(110, 17);
            this.texttttttt.TabIndex = 18;
            this.texttttttt.Text = "Number Of Days";
            // 
            // Textttttttt
            // 
            this.Textttttttt.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.Textttttttt.AutoSize = true;
            this.Textttttttt.Location = new System.Drawing.Point(12, 492);
            this.Textttttttt.Name = "Textttttttt";
            this.Textttttttt.Size = new System.Drawing.Size(134, 17);
            this.Textttttttt.TabIndex = 17;
            this.Textttttttt.Text = "Start Order Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 671);
            this.Controls.Add(this.NumberOfDays);
            this.Controls.Add(this.StartOrderQuantity);
            this.Controls.Add(this.texttttttt);
            this.Controls.Add(this.Textttttttt);
            this.Controls.Add(this.StartLeadDays);
            this.Controls.Add(this.StartInventoryQuantity);
            this.Controls.Add(this.ReviewPeriod);
            this.Controls.Add(this.OrderUpTo);
            this.Controls.Add(this.texttt);
            this.Controls.Add(this.textttt);
            this.Controls.Add(this.TextStopping);
            this.Controls.Add(this.TextOrder);
            this.Controls.Add(this.LeadData);
            this.Controls.Add(this.DemandData);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.TestCases);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DemandData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TestCases;
        private System.Windows.Forms.OpenFileDialog OpenTestCases;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.DataGridView DemandData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridView LeadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox StartLeadDays;
        private System.Windows.Forms.TextBox StartInventoryQuantity;
        private System.Windows.Forms.TextBox ReviewPeriod;
        private System.Windows.Forms.TextBox OrderUpTo;
        private System.Windows.Forms.Label texttt;
        private System.Windows.Forms.Label textttt;
        private System.Windows.Forms.Label TextStopping;
        private System.Windows.Forms.Label TextOrder;
        private System.Windows.Forms.TextBox NumberOfDays;
        private System.Windows.Forms.TextBox StartOrderQuantity;
        private System.Windows.Forms.Label texttttttt;
        private System.Windows.Forms.Label Textttttttt;
    }
}