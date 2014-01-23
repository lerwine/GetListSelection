using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;

namespace GetListSelection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        static string quotifyString(string value)
        {
            if (value.Length == 0 || value.Trim().Length != value.Length)
                return String.Format("'{0}'", value);

            return value;
        }

        public static object GetSelectionFromList(string[] options, string caption, string message, bool allowOtherValue, string otherValueLabelText, string emptyValueText)
        {
            Hashtable hashTable = new Hashtable();
            foreach (string opt in options.Where(s => s.Length > 0))
            {
                hashTable.Add(opt, "");
            }

            return GetSelectionFromList(hashTable, caption, message, allowOtherValue, otherValueLabelText, emptyValueText, true, false);
        }

        public class SelectionInfo
        {
            public object Value { get; set; }
            public string DisplayText { get; set; }
            public string DescriptionText { get; set; }
            public bool DescriptionIsValue { get; set; }
        }

        public static object GetSelectionFromList(Hashtable options, string caption, string message, bool allowOtherValue, string otherValueLabelText, string emptyValueText,
            bool keyIsDisplayText, bool returnsItemValue)
        {
            MainForm form = new MainForm();
            form.Text = (String.IsNullOrWhiteSpace(caption)) ? "Item Selection" : caption.Trim();
            if (String.IsNullOrWhiteSpace(message))
            {
                form.MessageLabel.Visible = false;
            }
            else
            {
                form.MessageLabel.Visible = true;
                form.MessageLabel.Text = message.Trim();
            }

            if (allowOtherValue)
            {
                form.OtherValueCheckBox.Visible = true;
                form.OtherValueCheckBox.Text = (String.IsNullOrWhiteSpace(otherValueLabelText)) ? "Other Value:" : otherValueLabelText;
                form.OtherValueCheckBox.Checked = false;
                form.OtherValueTextBox.Visible = true;
                form.OKButton.Visible = true;
                form.OKButton.Enabled = false;
            }
            else
            {
                form.OtherValueCheckBox.Visible = false;
                form.OtherValueTextBox.Visible = false;
                form.OKButton.Visible = false;
            }

            List<SelectionInfo> selectionItems = new List<SelectionInfo>();

            foreach (string k in options.Keys)
            {
                SelectionInfo item = new SelectionInfo
                {
                    Value = (returnsItemValue) ? options[k] : k,
                    DisplayText = (keyIsDisplayText) ? k.ToString() : options[k].ToString(),
                    DescriptionText = (keyIsDisplayText) ? options[k].ToString() : k.ToString(),
                    DescriptionIsValue = (returnsItemValue) ? keyIsDisplayText : !keyIsDisplayText
                };
                selectionItems.Add(item);
                if (item.DisplayText.Length == 0)
                {
                    string returnText = ((returnsItemValue) ? options[k] : k).ToString();
                    item.DisplayText = (returnText.Length > 0) ? returnText : emptyValueText;
                }

                if (item.DisplayText == item.DescriptionText) { 
                    item.DescriptionText = "";
                    item.DescriptionIsValue = false;
                }

                if (item.DescriptionText.Length == 0)
                {
                    string descriptionText = ((returnsItemValue) ? options[k] : k).ToString();
                    if (item.DisplayText != descriptionText)
                    {
                        item.DescriptionText = descriptionText;
                        item.DescriptionIsValue = true;
                    }
                }
            }

            bool hasNonEmptyDescription = false;
            foreach (SelectionInfo item in selectionItems)
            {
                if (item.DescriptionText.Length > 0)
                    hasNonEmptyDescription = true;

                if (item.DisplayText.Length == 0 || item.DisplayText.Trim().Length != item.DisplayText.Length)
                    item.DisplayText = String.Format("'{0}'", item.DisplayText);

                if (item.DescriptionIsValue)
                {
                    if (item.DescriptionText.Length == 0)
                        item.DescriptionText = String.Format("Value is empty", item.DescriptionText);
                    else if (item.DescriptionText.Trim().Length != item.DescriptionText.Length)
                        item.DescriptionText = String.Format("Value = '{0}'", item.DescriptionText);
                    else
                        item.DescriptionText = String.Format("Value = {0}", item.DescriptionText);
                }
            }

            if (hasNonEmptyDescription)
            {
                form.DescriptionTextBoxColumn.Visible = true;
                form.DescriptionTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                form.ValueTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
            {
                form.DescriptionTextBoxColumn.Visible = false;
                form.ValueTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            form.ItemSelectionDataGridView.AutoGenerateColumns = false;
            form.ItemSelectionDataGridView.DataSource = selectionItems;

            form.Shown += new EventHandler(form_Shown);
            if (form.ShowDialog() == DialogResult.OK)
                return form.SelectedValue;

            return null;
        }

        static void form_Shown(object sender, EventArgs e)
        {
            (sender as Form).Activate();

            (sender as MainForm).ItemSelectionDataGridView.ClearSelection();

            (sender as MainForm).ItemSelectionDataGridView.SelectionChanged += new EventHandler((sender as MainForm).ItemSelectionDataGridView_SelectionChanged);
        }

        private void ItemSelectionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.ItemSelectionDataGridView.SelectedRows.Count == 0)
                return;

            SelectionInfo item = this.ItemSelectionDataGridView.SelectedRows[0].DataBoundItem as SelectionInfo;

            this.SelectedValue = item.Value;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void OtherValueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OtherValueCheckBox.Checked)
            {
                this.OtherValueTextBox.ReadOnly = false;
                this.OKButton.Enabled = (this.OtherValueTextBox.Text.Trim().Length > 0);
            }
            else
            {
                this.OtherValueTextBox.Enabled = false;
                this.OKButton.Enabled = false;
            }
        }

        private void OtherValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.OtherValueCheckBox.Checked)
            {
                this.OtherValueTextBox.ReadOnly = false;
                this.OKButton.Enabled = (this.OtherValueTextBox.Text.Trim().Length > 0);
            }
            else
            {
                this.OtherValueTextBox.Enabled = false;
                this.OKButton.Enabled = false;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.SelectedValue = this.OtherValueTextBox.Text.Trim();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        public object SelectedValue { get; set; }
    }
}
