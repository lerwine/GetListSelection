namespace GetListSelection
{
    partial class MainForm
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
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ItemSelectionDataGridView = new System.Windows.Forms.DataGridView();
            this.ValueTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherValueCheckBox = new System.Windows.Forms.CheckBox();
            this.OtherValueTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.Controls.Add(this.MessageLabel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ItemSelectionDataGridView, 0, 1);
            this.MainTableLayoutPanel.Controls.Add(this.OtherValueCheckBox, 0, 2);
            this.MainTableLayoutPanel.Controls.Add(this.OtherValueTextBox, 0, 3);
            this.MainTableLayoutPanel.Controls.Add(this.OKButton, 0, 5);
            this.MainTableLayoutPanel.Controls.Add(this.FormCancelButton, 1, 5);
            this.MainTableLayoutPanel.Controls.Add(this.ErrorMessageLabel, 0, 4);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 6;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(784, 561);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MainTableLayoutPanel.SetColumnSpan(this.MessageLabel, 2);
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageLabel.Location = new System.Drawing.Point(3, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(778, 13);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Message Text";
            // 
            // ItemSelectionDataGridView
            // 
            this.ItemSelectionDataGridView.AllowUserToAddRows = false;
            this.ItemSelectionDataGridView.AllowUserToDeleteRows = false;
            this.ItemSelectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemSelectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueTextBoxColumn,
            this.DescriptionTextBoxColumn});
            this.MainTableLayoutPanel.SetColumnSpan(this.ItemSelectionDataGridView, 2);
            this.ItemSelectionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSelectionDataGridView.Location = new System.Drawing.Point(3, 16);
            this.ItemSelectionDataGridView.Name = "ItemSelectionDataGridView";
            this.ItemSelectionDataGridView.ReadOnly = true;
            this.ItemSelectionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemSelectionDataGridView.Size = new System.Drawing.Size(778, 451);
            this.ItemSelectionDataGridView.TabIndex = 1;
            this.ItemSelectionDataGridView.VirtualMode = true;
            // 
            // ValueTextBoxColumn
            // 
            this.ValueTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ValueTextBoxColumn.DataPropertyName = "Key";
            this.ValueTextBoxColumn.HeaderText = "Value";
            this.ValueTextBoxColumn.Name = "ValueTextBoxColumn";
            this.ValueTextBoxColumn.ReadOnly = true;
            this.ValueTextBoxColumn.Width = 59;
            // 
            // DescriptionTextBoxColumn
            // 
            this.DescriptionTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionTextBoxColumn.DataPropertyName = "Value";
            this.DescriptionTextBoxColumn.HeaderText = "Description";
            this.DescriptionTextBoxColumn.Name = "DescriptionTextBoxColumn";
            this.DescriptionTextBoxColumn.ReadOnly = true;
            // 
            // OtherValueCheckBox
            // 
            this.OtherValueCheckBox.AutoSize = true;
            this.OtherValueCheckBox.Location = new System.Drawing.Point(3, 473);
            this.OtherValueCheckBox.Name = "OtherValueCheckBox";
            this.OtherValueCheckBox.Size = new System.Drawing.Size(85, 17);
            this.OtherValueCheckBox.TabIndex = 2;
            this.OtherValueCheckBox.Text = "Other Value:";
            this.OtherValueCheckBox.UseVisualStyleBackColor = true;
            this.OtherValueCheckBox.CheckedChanged += new System.EventHandler(this.OtherValueCheckBox_CheckedChanged);
            // 
            // OtherValueTextBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.OtherValueTextBox, 2);
            this.OtherValueTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OtherValueTextBox.Location = new System.Drawing.Point(3, 496);
            this.OtherValueTextBox.Name = "OtherValueTextBox";
            this.OtherValueTextBox.ReadOnly = true;
            this.OtherValueTextBox.Size = new System.Drawing.Size(778, 20);
            this.OtherValueTextBox.TabIndex = 3;
            this.OtherValueTextBox.TextChanged += new System.EventHandler(this.OtherValueTextBox_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(625, 535);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FormCancelButton.CausesValidation = false;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(706, 535);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 5;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(3, 519);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(119, 13);
            this.ErrorMessageLabel.TabIndex = 6;
            this.ErrorMessageLabel.Text = "Value cannot be empty.";
            this.ErrorMessageLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Select from List";
            this.TopMost = true;
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSelectionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.CheckBox OtherValueCheckBox;
        private System.Windows.Forms.TextBox OtherValueTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionTextBoxColumn;
        private System.Windows.Forms.DataGridView ItemSelectionDataGridView;
    }
}

