using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Laba4_OS
{
    public partial class FormFileSystem : Form
    {
        //������ �������� ����� ������
        public int[] treeNodesArr = new int[749];
        Random r = new Random();

        List<int> listIndexs = new List<int>();
        List<TreeNode> Nodes = new List<TreeNode>();

        //������� ��� �������� �������������� ��������
        Catalog supportCatalog;

        //���� ��� �������� �������������� �����
        File supportFile = null;

        public FormFileSystem()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(0x27, 0x27, 0x27);

            label.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);

            label2.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);

            buttonAddCatalog.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            buttonAddCatalog.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);
            buttonAddCatalog.FlatAppearance.BorderColor = Color.FromArgb(0xcf, 0xff, 0x04);

            buttonAddFile.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            buttonAddFile.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);
            buttonAddFile.FlatAppearance.BorderColor = Color.FromArgb(0xcf, 0xff, 0x04);

            buttonCopy.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            buttonCopy.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);
            buttonCopy.FlatAppearance.BorderColor = Color.FromArgb(0xcf, 0xff, 0x04);

            buttonDeleteFile.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            buttonDeleteFile.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);
            buttonDeleteFile.FlatAppearance.BorderColor = Color.FromArgb(0xcf, 0xff, 0x04);

            buttonPaste.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            buttonPaste.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);
            buttonPaste.FlatAppearance.BorderColor = Color.FromArgb(0xcf, 0xff, 0x04);

            treeView.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            treeView.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);

            textBoxName_Catalog.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            textBoxName_Catalog.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);

            textBoxName_File.BackColor = Color.FromArgb(0x27, 0x27, 0x27);
            textBoxName_File.ForeColor = Color.FromArgb(0xcf, 0xff, 0x04);

            for (int i = 0; i < treeNodesArr.Length; i++)
            {
                treeNodesArr[i] = -2;
            }

            Draw();
        }

        //����� ���������� ��������
        public void AddCatalog()
        {
            if (treeView.SelectedNode is File)
            {
                return;
            }

            if (treeView.SelectedNode == null)
            {
                treeView.Nodes.Add(new Catalog(textBoxName_Catalog.Text));
                return;
            }

            treeView.SelectedNode.Nodes.Add(new Catalog(textBoxName_Catalog.Text));
        }

        //������ ���������� ��������
        private void ButtonAddCatalog_Click(object sender, EventArgs e)
        {
            AddCatalog();
        }

        //�������� ������� ��� ���������
        public void Draw()
        {
            Bitmap bmp = new(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            DrawTable(gr);
            pictureBox.Image = bmp;
        }

        //����� ���������
        public void DrawTable(Graphics gr)
        {
            SelectFile(treeView.SelectedNode);
            int x = 0;
            int y = 0;

            for (int i = 0; i < treeNodesArr.Length; ++i)
            {
                if (treeNodesArr[i] == -2)
                {
                    gr.FillRectangle(Brushes.Gray, x, y, 25, 25);
                    gr.DrawRectangle(Pens.Black, x, y, 25, 25);
                    x += 25;
                }
                else
                {
                    try
                    {
                        var temp = listIndexs.First(index => index == i);
                        gr.FillRectangle(Brushes.Red, x, y, 25, 25);
                        gr.DrawRectangle(Pens.Black, x, y, 25, 25);
                        x += 25;
                    }
                    catch
                    {
                        gr.FillRectangle(Brushes.Blue, x, y, 25, 25);
                        gr.DrawRectangle(Pens.Black, x, y, 25, 25);
                        x += 25;
                    }
                }

                if ((i + 1) % 33 == 0)
                {
                    x = 0;
                    y += 25;
                }
            }

            Nodes.Clear();
            listIndexs.Clear();
        }

        //������ ��� ��������� �������� ���������� ������ � �����
        private List<int> SelectFile(TreeNode selectFile)
        {
            if (selectFile is File)
            {
                File file = (File)selectFile;
                int i = file.iniat_index;
                if (treeNodesArr[i] == -1)
                {
                    listIndexs.Add(i);
                }
                while (treeNodesArr[i] != -1)
                {
                    listIndexs.Add(i);
                    i = treeNodesArr[i];
                    if (treeNodesArr[i] == -1)
                    {
                        listIndexs.Add(i);
                        break;
                    }
                }
            }

            if (selectFile is Catalog catalog)
            {
                foreach (TreeNode thisNode in catalog.Nodes)
                {
                    catalog.AddElem(thisNode);
                    SelectFile(thisNode);
                }
            }

            return listIndexs;
        }

        //��������
        private void Delete(TreeNode selectFile)
        {
            if (selectFile is File)
            {
                File file = (File)selectFile;
                int i = file.iniat_index;
                int sup_indx;
                if (treeNodesArr[i] == -1)
                {
                    treeNodesArr[i] = -2;
                }
                else
                {
                    while (treeNodesArr[i] != -1)
                    {
                        sup_indx = treeNodesArr[i];
                        treeNodesArr[i] = -2;
                        i = sup_indx;
                        if (treeNodesArr[i] == -1)
                        {
                            treeNodesArr[i] = -2;
                            break;
                        }
                    }
                }
            }

            if (selectFile is Catalog)
            {
                foreach (TreeNode thisNode in selectFile.Nodes)
                {
                    Delete(thisNode);
                }
            }
        }

        //�������� �����
        public void AddFile()
        {
            if (treeView.SelectedNode is Catalog)
            {
                int size = r.Next(1, 5);

                Console.WriteLine(size);
                File file = new File(textBoxName_File.Text, size);
                treeView.SelectedNode.Nodes.Add(file);

                int count = size;
                int Useindx = 0;

                for (int i = 0; i < treeNodesArr.Length; i++)
                {
                    if (treeNodesArr[i] == -2 && count == size)
                    {
                        file.iniat_index = i;
                        count--;
                        Useindx = i;

                        if (size == 1)
                        {
                            treeNodesArr[i] = -1;
                            break;
                        }
                        else
                        {
                            for (int j = Useindx + 1; j < treeNodesArr.Length; ++j)
                            {
                                if (count <= 0)
                                {
                                    treeNodesArr[Useindx] = -1;
                                    break;
                                }

                                if (treeNodesArr[j] == -2)
                                {
                                    treeNodesArr[Useindx] = j;
                                    Useindx = j;
                                    count--;
                                }

                            }
                        }
                    }
                }

                Draw();
            }
        }

        //���������� ������ �����
        public void AddSimpleFile(File file)
        {
            int count = file._size;
            int Useindx = 0;

            for (int i = 0; i < treeNodesArr.Length; i++)
            {
                if (treeNodesArr[i] == -2 && count == file._size)
                {
                    file.iniat_index = i;
                    count--;
                    Useindx = i;

                    if (file._size == 1)
                    {
                        treeNodesArr[i] = -1;
                        break;
                    }
                    else
                    {
                        for (int j = Useindx + 1; j < treeNodesArr.Length; ++j)
                        {
                            if (count <= 0)
                            {
                                treeNodesArr[Useindx] = -1;
                                break;
                            }

                            if (treeNodesArr[j] == -2)
                            {
                                treeNodesArr[Useindx] = j;
                                Useindx = j;
                                count--;
                            }

                        }
                    }
                }
            }

            //����� ������� ��� �������� ����������
            int _count = 0;
            for(int i = 0; i < treeNodesArr.Length; i++)
            {
                Console.Write(treeNodesArr[i] + " ");
                _count++;

                if(_count == 33)
                {
                    _count = 0;
                    Console.WriteLine();
                }
            }
        }

        //������ ���������� �����
        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            AddFile();
        }

        //������ �������� �����
        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            if (treeView.Nodes.Count > 0)
            {
                Delete(treeView.SelectedNode);
                treeView.SelectedNode.Remove();
                Draw();
            }

        }

        //��� �������������� ������ � ���������
        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        //��� �������������� ������ � ���������
        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //��� �������������� ������ � ���������
        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent("Laba4_OS.File", false))
            {
                File tr;
                Point ap;
                Catalog targernode = null;

                ap = ((System.Windows.Forms.TreeView)sender).PointToClient(new Point(e.X,e.Y));

                try
                {
                    targernode = (Catalog)((System.Windows.Forms.TreeView)sender).GetNodeAt(ap);
                    tr = (File)e.Data.GetData("Laba4_OS.File");
                    tr.Remove();
                    targernode.Nodes.Add(tr);
                    targernode.Expand();
                }
                catch 
                {
                    //������
                }
            }
            if (e.Data.GetDataPresent("Laba4_OS.Catalog", false))
            {
                Catalog tr;
                Point ap;
                Catalog targernode = null;

                ap = ((System.Windows.Forms.TreeView)sender).PointToClient(new Point(e.X, e.Y));

                try
                {
                    targernode = (Catalog)((System.Windows.Forms.TreeView)sender).GetNodeAt(ap);
                    tr = (Catalog)e.Data.GetData("Laba4_OS.Catalog");
                    tr.Remove();
                    targernode.Nodes.Add(tr);
                    targernode.Expand();
                }
                catch
                {
                    //������
                }
            }
        }

        //��������� �� ������� �� ��������� ������-�� ������ � TreeNode
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Draw();
        }

        //������ �����������
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(treeView.SelectedNode is Catalog)
            {
                TreeNode selectNode = treeView.SelectedNode;

                supportCatalog = new Catalog(selectNode.Text + ".copy");

                //copy all the child nodes
                CopyChildNodes(selectNode, supportCatalog);
            }

            if(treeView.SelectedNode is File)
            {
                supportFile = (File)treeView.SelectedNode;
            }
        }

        //����������� �����������
        private void CopyChildNodes(TreeNode searchNode, Catalog newParentNode)
        {
            foreach (TreeNode tn1 in searchNode.Nodes)
            {
                if(tn1 is File file)
                {
                    File newFile = new File(file.Name, file._size);

                    AddSimpleFile(newFile);

                    newParentNode.Nodes.Add(newFile);
                }
                
                if(tn1 is Catalog catalog)
                {
                    Catalog newCatalog = new Catalog(catalog.Name + ".copy");

                    newParentNode.Nodes.Add(newCatalog);

                    CopyChildNodes(tn1, newCatalog);
                }
            }
        }

        //������ �������
        private void buttonPaste_Click(object sender, EventArgs e)
        {
            if (supportFile != null)
            {
                string Name = supportFile.Text + ".copy";
                int size = supportFile._size;
                File file = new File(Name, size);

                //���� �������� �������� ���� � ����
                if (treeView.SelectedNode is File)
                {
                    return;
                }

                treeView.SelectedNode.Nodes.Add(file);
                AddSimpleFile(file);
                supportFile = null;
            }
            else
            {
                treeView.SelectedNode.Nodes.Add(supportCatalog);
            }

            Draw();
        }
    }
}