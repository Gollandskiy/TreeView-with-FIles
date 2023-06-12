using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeView_with_FIles
{
    public partial class Form1 : Form
    {
       static string rootPath = @"D:\Visual Studio ШАГ\C#\TreeView with FIles";
       TreeNode rootNode = new TreeNode(Path.GetFileName(rootPath));

        public Form1()
        {
            InitializeComponent();
            BuildDirectoryTree(@"D:\Visual Studio ШАГ\C#\TreeView with FIles",rootNode);
        }
        private void BuildDirectoryTree(string path, TreeNode parentNode)
        {
            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories)
            {
                TreeNode node = new TreeNode(Path.GetFileName(directory));
                parentNode.Nodes.Add(node);

                BuildDirectoryTree(directory, node);
            }
            treeView1.Nodes.Add(rootNode);
            BuildDirectoryTree(rootPath, rootNode);
        }

    }
 }
