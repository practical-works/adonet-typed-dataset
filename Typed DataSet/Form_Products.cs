using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace GroceryManager
{
    public partial class Form_Products : Form
    {
        public Form_Products()
        {
            InitializeComponent();
            Retrieve();
            DisplayCurrent();
        }

        #region Common
        public void Retrieve()
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

        public void Filter(bool clear = false)
        {
            string keyword = textBox_search.Text.ToLower();
            if (clear || string.IsNullOrWhiteSpace(keyword))
            {
                textBox_search.Clear();
                bindingSource_product.RemoveFilter();
                return;
            }
            bindingSource_product.Filter = string
                .Format("ISNULL({0},'') + ISNULL({1},'') LIKE '%{2}%'",
                database.product.titleColumn.ColumnName,
                database.product.descriptionColumn.ColumnName,
                keyword);
            DisplayStatus("{0} results found for: {1}.",
                bindingSource_product.Count, keyword);
        }

        public void DisplayStatus(string text = null, params object[] args)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                text = "Ready.";
            }
            statusLabel_status.Text = string.Format(text, args);
        }

        public void SetCurrent()
        {
            int position = -1;
            if (int.TryParse(textBox_position.Text, out position))
            {
                bindingSource_product.Position = position - 1;
            }
            else
            {
                textBox_position.Text = bindingSource_product.Position.ToString() + 1;
            }
        }

        public void DisplayCurrent()
        {
            if (bindingSource_product.Current == null)
            {
                splitContainer_main.Panel1.Enabled = false;
                textBox_position.Enabled = false;

                textBox_position.Text = string.Empty;
                label_count.Text = "0";
                statusLabel_current.Text = "(No current)";
                statusLabel_positionAndCount.Text = "No items.";
            }
            else
            {
                splitContainer_main.Panel1.Enabled = true;
                textBox_position.Enabled = true;

                string position = (bindingSource_product.Position + 1).ToString();
                string count = bindingSource_product.Count.ToString();
                textBox_position.Text = position;
                label_count.Text = count;
                statusLabel_current.Text = GetCurrentAsString();
                statusLabel_positionAndCount.Text = string.Format("{0} of {1}", position, count);
            }
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

        #region Menu
        private void menuItem_new_Click(object sender, EventArgs e)
        {
            bindingSource_product.AddNew();
        }

        private void menuItem_delete_Click(object sender, EventArgs e)
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

        private void menuItem_save_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayStatus("Saving...");
                Validate();
                bindingSource_product.EndEdit();
                tableAdapterManager.UpdateAll(database);
                DisplayStatus("Saved.");
            }
            catch (Exception exception)
            {
                DisplayStatus("Error: {0}", exception.Message);
            }
        }

        private void menuItem_refresh_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void menuItem_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItem_next_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveNext();
        }

        private void menuItem_previous_Click(object sender, EventArgs e)
        {
            bindingSource_product.MovePrevious();
        }

        private void menuItem_first_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveFirst();
        }

        private void menuItem_last_Click(object sender, EventArgs e)
        {
            bindingSource_product.MoveLast();
        }

        private void menuItem_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\n\nHere you can manage products of the store.\n\n\n", Text);
        }

        private void menuItem_undo_Click(object sender, EventArgs e)
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

        private void menuItem_search_Click(object sender, EventArgs e)
        {
            textBox_search.Focus();
        }
        #endregion

        private void bindingSource_product_CurrentChanged(object sender, EventArgs e)
        {
            DisplayCurrent();
        }

        private void bindingSource_product_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            DisplayStatus("Data Error: {0}", e.Exception.Message);
        }

        private void bindingSource_product_AddingNew(object sender, AddingNewEventArgs e)
        {
            DisplayStatus("Adding New...");
            DataRowView newRowView = (bindingSource_product.List as DataView).AddNew();
            Database.productRow newProductRow = newRowView.Row as Database.productRow;
            newProductRow.upc = Guid.NewGuid().ToString();
            newProductRow.create_date = DateTime.Now;
            e.NewObject = bindingSource_product.Current;
            bindingSource_product.MoveLast();
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
        }

        private void button_clearSearch_Click(object sender, EventArgs e)
        {
            Filter(clear: true);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBox_position_Validated(object sender, EventArgs e)
        {
            SetCurrent();
        }

        private void textBox_position_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCurrent();
            }
        }

        private void bindingSource_product_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                database.product[e.NewIndex].update_date = DateTime.Now;
            }
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }
    }
}
