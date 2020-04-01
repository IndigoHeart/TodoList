using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TodoList
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private List<Korespondent> korespondenci { get; set; }


        public MainForm()
        {
            InitializeComponent();


            korespondenci = new List<Korespondent>();

            //listBox.Items.Add(new Korespondent() { MailAddress = "rafal@małpa.pl", Name = "Rafałeeek" });
            //listBox.Items.Add(new Korespondent() { MailAddress = "michał@małpa.pl", Name = "Michał" });
            //listBox.Items.Add(new Korespondent() { MailAddress = "daniel@małpa.pl", Name = "Daniel" });

            korespondenci.Add(new Korespondent() { MailAddress = "rafal@małpa.pl", Name = "Rafałeeek" });
            korespondenci.Add(new Korespondent() { MailAddress = "michał@małpa.pl", Name = "Michał" });
            korespondenci.Add(new Korespondent() { MailAddress = "daniel@małpa.pl", Name = "Daniel" });


            listBox.DataSource = korespondenci;
            listBox.DisplayMember = "FullName";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(TaskEditField.Text);
            TaskEditField.Text = null;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.Remove(listBox.GetItem(listBox.SelectedIndex));
            }
            catch (Exception newException)
            {
                MessageBox.Show(newException.Message);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem.ToString().StartsWith("&"))
            {
                listBox.SetItemValue(listBox.SelectedItem.ToString().Substring(2), listBox.SelectedIndex);
            }
            else
            {
                listBox.SetItemValue("& " + listBox.SelectedItem, listBox.SelectedIndex);
            }

        }

        private void listBox_Click(object sender, EventArgs e)
        {
            TaskEditField.Text = korespondenci[listBox.SelectedIndex].Name;
            EmailEditField.Text = korespondenci[listBox.SelectedIndex].MailAddress;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            listBox.SetItemValue(TaskEditField.Text, listBox.SelectedIndex);
        }
        private void SlideUpBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                int index = listBox.SelectedIndex;
                //var tmp = listBox.Items[listBox.SelectedIndex];
                //listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex - 1];
                //listBox.Items[listBox.SelectedIndex - 1] = tmp;
                //listBox.SelectedIndex -= 1;
                Korespondent tmp = korespondenci[index];
                korespondenci[index] = korespondenci[index - 1];
                korespondenci[index - 1] = tmp;
                listBox.SelectedIndex -= 1;
            }
        }

        private void SlideDownBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.ItemCount - 1)
            {
                //var tmp = listBox.Items[listBox.SelectedIndex];
                //listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.SelectedIndex + 1];
                //listBox.Items[listBox.SelectedIndex + 1] = tmp;
                //listBox.SelectedIndex += 1;
                int index = listBox.SelectedIndex;

                Korespondent tmp = korespondenci[index];
                korespondenci[index] = korespondenci[index + 1];
                korespondenci[index + 1] = tmp;
                listBox.SelectedIndex += 1;
            }
        }

    }
}