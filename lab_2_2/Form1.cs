﻿using System;
using System.Collections.Generic;
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
        }
        B_tree bTree = new B_tree(3);
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            //for (int i = 0; i < 25; i++)
            //{
            //    // bTree.Add(rand.Next(0,20));
            //    bTree.Add(i + 1);
            //}


            bTree.Add(new Diary() { Date = 5, Wind = "5" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 7, Wind = "7"}, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 8, Wind = "8" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 15, Wind = "15" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 1, Wind = "1" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 13, Wind = "13" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 9, Wind = "9" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 7, Wind = "7" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 2, Wind = "2" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 1, Wind = "1" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 15, Wind = "15" }, B_tree.Property.date);
            bTree.Add(new Diary() { Date = 15, Wind = "15" }, B_tree.Property.date);



            //bTree.Add(7);
            //bTree.Add(8);
            //bTree.Add(15);
            //bTree.Add(1);
            //bTree.Add(9);
            //bTree.Add(9);
            //bTree.Add(7);
            //bTree.Add(2);
            //bTree.Add(1);
            //bTree.Add(15);
            //bTree.Add(15);

            label1.Text = "";
            B_node node = bTree.Root_node;
            bool last = false;

            var curr_nodes_list = new List<B_node>();
            curr_nodes_list.Add(node);

            write:

            foreach (var curr_node  in curr_nodes_list)
            {
                label1.Text += "||";
                foreach (var key in curr_node.Keys)
                {
                    label1.Text += $" {key.Value}";
                }
            }
            label1.Text += "||";

            label1.Text += Environment.NewLine;

            if (!curr_nodes_list[0].isLeaf)
            {
                List<B_node> childBNodes = new List<B_node>();
                foreach (var bNode in curr_nodes_list)
                {
                    childBNodes.AddRange(bNode.Children_nodes);
                } 
                curr_nodes_list.Clear();
                curr_nodes_list = childBNodes;
                goto  write;
            }

            Console.WriteLine(bTree.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var node = bTree.Find((int)numericUpDown1.Value);
            if (node != null)
            {
                label1.Text = node.Wind;
            }
            else
            {
                label1.Text = "Can`t find element";
            }
           
        }
    }
}


