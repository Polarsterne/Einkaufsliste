using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einkaufsliste
{
    public partial class Form1 : Form
    {
        private List<Item> einkaufsliste;
        public Form1()
        {
            InitializeComponent();
            einkaufsliste = new List<Item>();
            UpdateList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string itemName = textBoxNewItem.Text;
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                einkaufsliste.Add(new Item(itemName));
                textBoxNewItem.Clear();
                UpdateList();
            }
        }

        private void buttonMarkAsDone_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                einkaufsliste[listBoxItems.SelectedIndex].IsDone = true;
                UpdateList();
            }
        }

        private void UpdateList()
        {
            listBoxItems.Items.Clear();
            foreach (var item in einkaufsliste) 
            {
                string status = item.IsDone ? "[x]" : "[ ]";
                listBoxItems.Items.Add($"{status} {item.Name}");
            }
        }
        
    }
        public class Item
        {
            public string Name { get; }
            public bool IsDone { get; set; }

            public Item(string name)
            {
                Name = name;
                IsDone = false;
            }
    }
}
