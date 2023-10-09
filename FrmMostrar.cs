using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryDamonteLab
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
            PopulateTreeView();

            this.TreeViewMostrar.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.TreeViewMostrar_NodeMouseClick);

        }

        private void PopulateTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Proveedores");
            if ( info.Exists ==true)
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                TreeViewMostrar.Nodes.Add(nodoMadre);

            }
        }

        private void ObtenerCarpetas(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length !=0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);

            }
        }

        void TreeViewMostrar_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listMostrar.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            //Busca las carpetas
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listMostrar.Items.Add(item);
            }

            //Busca los archivos
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listMostrar.Items.Add(item);
            }

            listMostrar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }

        
    
}
