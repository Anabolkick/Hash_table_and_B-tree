using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private B_tree bTree = new B_tree(3);
        private List<Diary> diaries = new List<Diary>();
        private Random gen = new Random();
        private DateTime RandomDay()
        {
            DateTime start = new DateTime(2021, 1, 1);
            DateTime end = new DateTime(2021, 12, 31);
            int range = (end - start).Days;
            return start.AddDays(gen.Next(range));
        }

        private void CreateTree(B_tree.Property prop)
        {
            bTree = new B_tree(3);
            Random rand = new Random();

            if (diaries.Count == 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    diaries.Add(new Diary()
                    {
                        Date = RandomDay(),
                        Humidity = rand.Next(0, 100)+ Math.Round(rand.NextDouble(),1),
                        Pressure = rand.Next(650, 950) + Math.Round(rand.NextDouble(), 1),
                        Temperature = rand.Next(-20, 40) + Math.Round(rand.NextDouble(), 1),
                        PrecipitationLvl = rand.Next(20, 65) + Math.Round(rand.NextDouble(), 1),
                        Wind = "no information",
                        AtmosphericVenoms = "no information"
                    });
                }

                diaries.Add(new Diary()
                {
                    Date = new DateTime(2021, 11, 03),
                    Humidity = 93.2,
                    Pressure = 750.5,
                    Temperature = 13.6,
                    PrecipitationLvl = 12.8,
                    Wind = "no information",
                    AtmosphericVenoms = "no information"
                });
            }
 
            foreach (var diary in diaries)
            {
                bTree.Add(diary, prop);
            }
        }

        private void create_date_btn_Click(object sender, EventArgs e)
        {
            CreateTree(B_tree.Property.date);
           
            richTextBox1.Text = "";
            B_node node = bTree.Root_node;
            bool last = false;
            var curr_nodes_list = new List<B_node>();
            curr_nodes_list.Add(node);

            write:
            foreach (var curr_node in curr_nodes_list)
            {
                richTextBox1.Text += "||";
                foreach (var key in curr_node.Keys)
                {
                    //  label1.Text += $" {new DateTime((long)key.Value).ToShortDateString()}";
                    if (key.Value != null)
                    {
                        richTextBox1.Text += $" {new DateTime((long)key.Value).ToShortDateString()}";
                    }
                }
            }

            richTextBox1.Text += "||";
            richTextBox1.Text += Environment.NewLine;
            if (!curr_nodes_list[0].isLeaf)
            {
                List<B_node> childBNodes = new List<B_node>();
                foreach (var bNode in curr_nodes_list)
                {
                    childBNodes.AddRange(bNode.Children_nodes);
                }
                curr_nodes_list.Clear();
                curr_nodes_list = childBNodes;
                goto write;
            }
        }

        private void find_date_btn_Click(object sender, EventArgs e)
        {
            var node = bTree.Find(dateTimePicker1.Value.Ticks);
            // var node = bTree.Find(Convert.ToDouble(textBox1.Text));
            if (node != null)
            {
                label2.Text = $"Temperature: {node.Temperature}, Wind: {node.Wind}, Humidity: {node.Humidity}, Precipitation: {node.AtmosphericVenoms}, " +
                              $"Pressure: {node.Pressure}, Date: {node.Date.ToShortDateString()}";
            }
            else
            {
                label2.Text = "Can`t find element";
            }

        }

        private void create_check_btn_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            B_tree.Property prop = B_tree.Property.temperature;

            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "temperature":
                        prop = B_tree.Property.temperature;
                        break;
                    case "humidity":
                        prop = B_tree.Property.humidity;
                        break;
                    case "pressure":
                        prop = B_tree.Property.pressure;
                        break;
                    case "precipitation":
                        prop = B_tree.Property.precipitation;
                        break;
                }
            }
       
            CreateTree(prop);
            
            richTextBox1.Text = "";
            B_node node = bTree.Root_node;
            bool last = false;
            var curr_nodes_list = new List<B_node>();
            curr_nodes_list.Add(node);

            write:
            foreach (var curr_node in curr_nodes_list)
            {
                richTextBox1.Text += "||";
                foreach (var key in curr_node.Keys)
                {
                    richTextBox1.Text += $" {key.Value}";
                }
            }
            richTextBox1.Text += "||";
            richTextBox1.Text += Environment.NewLine;

            if (!curr_nodes_list[0].isLeaf)
            {
                List<B_node> childBNodes = new List<B_node>();
                foreach (var bNode in curr_nodes_list)
                {
                    childBNodes.AddRange(bNode.Children_nodes);
                }
                curr_nodes_list.Clear();
                curr_nodes_list = childBNodes;
                goto write;
            }
        }

        private void find_check_btn_Click(object sender, EventArgs e)
        {
            var node = bTree.Find(Convert.ToDouble(textBox1.Text));
            // var node = bTree.Find(Convert.ToDouble(textBox1.Text));
            if (node != null)
            {
                label2.Text = $"Temperature: {node.Temperature}, Wind: {node.Wind}, Humidity: {node.Humidity}, Precipitation: {node.AtmosphericVenoms}, " +
                              $"Pressure: {node.Pressure}, Date: {node.Date.ToShortDateString()}";
            }
            else
            {
                label2.Text = "Can`t find element";
            }
        }

        private void prec_lvl_btn_Click(object sender, EventArgs e)
        {
            CreateTree(B_tree.Property.precipitation);

            var node = bTree.Root_node;

            while (true)
            {
               
                if (node.Children_nodes.Count>0)
                {
                    node = node.Children_nodes[node.Children_nodes.Count-1];
                }
                else
                {
                    label2.Text = $"Рівень опадів був найвищий у {node.Keys[node.KeysUsed-1].Data.Date.ToShortDateString()} ({node.Keys[node.KeysUsed - 1].Data.PrecipitationLvl})";
                    return;
                }
            }
        }
    }
}


