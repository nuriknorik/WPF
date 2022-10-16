namespace WinFormsApp6.View
{
    partial class OilPaymentHistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OilPaymentHistoryView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClearOilHistory_button = new System.Windows.Forms.Button();
            this.SelectDeleteOil_Button = new System.Windows.Forms.Button();
            this.Print_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OilHistoryPayment_listBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.ClearOilHistory_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectDeleteOil_Button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Print_button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClearOilHistory_button
            // 
            this.ClearOilHistory_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearOilHistory_button.Location = new System.Drawing.Point(238, 25);
            this.ClearOilHistory_button.Name = "ClearOilHistory_button";
            this.ClearOilHistory_button.Size = new System.Drawing.Size(115, 50);
            this.ClearOilHistory_button.TabIndex = 0;
            this.ClearOilHistory_button.Text = "Clear";
            this.ClearOilHistory_button.UseVisualStyleBackColor = true;
            this.ClearOilHistory_button.Click += new System.EventHandler(this.ClearOilHistory_button_Click);
            // 
            // SelectDeleteOil_Button
            // 
            this.SelectDeleteOil_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectDeleteOil_Button.Location = new System.Drawing.Point(3, 25);
            this.SelectDeleteOil_Button.Name = "SelectDeleteOil_Button";
            this.SelectDeleteOil_Button.Size = new System.Drawing.Size(111, 50);
            this.SelectDeleteOil_Button.TabIndex = 1;
            this.SelectDeleteOil_Button.Text = "Delete";
            this.SelectDeleteOil_Button.UseVisualStyleBackColor = true;
            this.SelectDeleteOil_Button.Click += new System.EventHandler(this.SelectDeleteOil_Button_Click);
            // 
            // Print_button
            // 
            this.Print_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Print_button.Location = new System.Drawing.Point(120, 25);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(111, 50);
            this.Print_button.TabIndex = 2;
            this.Print_button.Text = "Print";
            this.Print_button.UseVisualStyleBackColor = true;
            this.Print_button.Click += new System.EventHandler(this.Print_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OilHistoryPayment_listBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 350);
            this.panel1.TabIndex = 1;
            // 
            // OilHistoryPayment_listBox
            // 
            this.OilHistoryPayment_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OilHistoryPayment_listBox.FormattingEnabled = true;
            this.OilHistoryPayment_listBox.ItemHeight = 15;
            this.OilHistoryPayment_listBox.Location = new System.Drawing.Point(0, 0);
            this.OilHistoryPayment_listBox.Name = "OilHistoryPayment_listBox";
            this.OilHistoryPayment_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.OilHistoryPayment_listBox.Size = new System.Drawing.Size(357, 350);
            this.OilHistoryPayment_listBox.TabIndex = 0;
            // 
            // OilPaymentHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OilPaymentHistoryView";
            this.Text = "Oil history";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OilPaymentHistoryView_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ListBox OilHistoryPayment_listBox;
        private Button ClearOilHistory_button;
        private Button SelectDeleteOil_Button;
        private Button Print_button;
    }
}