using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace GroceryManager
{
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
            LoadTable();
            DisplayCurrent();
        }

        #region Common
        public void LoadTable()
        {
            try
            {
                DisplayStatus("Retrieving data...");
                tableAdapter_product.Fill(database.product);
                DisplayStatus("Data retrieved.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Filter(bool enable = true)
        {
            if (enable)
            {
                bindingSource_product.RemoveFilter();
                string keyword = textBox_search.Text;
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    DisplayStatus("Searching for: {0}.", keyword);
                    bindingSource_product.Filter = string.Format("{0}+{1} LIKE '%{2}%'", 
                        database.product.titleColumn.ColumnName,
                        database.product.descriptionColumn.ColumnName, 
                        keyword);
                }
            }
            else
            {
                bindingSource_product.RemoveFilter();
            }
        }

        public void DisplayStatus(string text = null, params object[] args)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                text = "Ready.";
            }
            label_status.Text = string.Format(text, args);
        }

        public void DisplayCurrent()
        {
            if (bindingSource_product.Current == null)
            {
                ToggleControls(this, enable: false);
                label_current.Text = "(No current)";
                label_currentIndex.Text = "No items.";
            }
            else
            {
                ToggleControls(this, enable: true);
                label_current.Text = GetCurrentAsString();
                label_currentIndex.Text = string.Format("{0} of {1}",
                   bindingSource_product.Position + 1, bindingSource_product.Count);
            }
        }

        public void ToggleControls(Control parent, bool enable)
        {
            if (parent.HasChildren)
            {
                foreach (Control child in parent.Controls)
                {
                    if (child is TextBox || child is DateTimePicker)
                    {
                        child.Enabled = enable;
                    }
                    else
                    {
                        ToggleControls(child, enable);
                    }
                }
            }
            textBox_search.Enabled = true;
        }

        public string GetCurrentAsString()
        {
            DataRowView row = bindingSource_product.Current as DataRowView;
            if (row == null)
            {
                return "NULL";
            }
            string title = row[database.product.titleColumn.ColumnName].ToString();
            return string.IsNullOrWhiteSpace(title) ? "(Untitled)" : title;
        }
        #endregion

        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource_product.AddNew();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bindingSource_product.Current != null)
            {
                string title = GetCurrentAsString();

                DialogResult confirmDelete = MessageBox.Show(
                    string.Format("Delete product \"{0}\" ?", title),
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    DisplayStatus("Deleting...");
                    bindingSource_product.RemoveCurrent();
                    DisplayStatus("Product \"{0}\" deleted.", title);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayStatus("Saving...");
                this.Validate();
                this.bindingSource_product.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database);
                DisplayStatus("Saved.");
            }
            catch (Exception exception)
            {
                DisplayStatus("Error: {0}", exception.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveNext();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource_product.MovePrevious();
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveFirst();
        }

        private void lastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveLast();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can manage products of the store.");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database.HasChanges())
            {
                DisplayStatus("Undoing...");
                database.RejectChanges();
                DisplayStatus("Changes undone.");
            }
            else
            {
                DisplayStatus("No changes to undo!");
            }
        }

        private void bindingSource_product_CurrentChanged(object sender, EventArgs e)
        {
            DisplayCurrent();
        }

        private void bindingSource_product_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            DisplayStatus("Data Error: {0}", e.Exception.Message);
        }

        private void bindingSource_product_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            DisplayStatus("Adding New...");
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filter();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Filter(enable: false);
            }
        }
    }
}
