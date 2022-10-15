using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace MNIST.IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MNIST.IO.MNISTCore mnist = new MNISTCore(); 
        ConfNN cnn;
        ANNXML xml;
        double[] aux1; double[] aux2;
        double[] aux3; double[] aux4;
        double[] aux5; double[] aux6;
        double[] aux7; double[] aux8;
        double[] aux9;
        double[] aux10; double[] aux11;
        double[] aux12; double[] aux13;

        private void button1_Click(object sender, EventArgs e)
        {

            init();
        }
        public void init()
        {
            cnn.Init_Filters();
            if (mnist.LoadDB(@"..\..\MnistDB\", 6000, 6000))
            {
                //***********************************
                input = 7 * 7 * 4;
                h = 3;
                hn = new int[h];
                inputs = new double[input];
                hn[0] = 7 * 7 * 4;
                hn[1] = 7 * 7 * 2;
                hn[2] = 7 * 7;
                ann = new ANN(input, hn, ANN.ActivationFunction.Sigmoid, 10, ANN.ActivationFunction.Sigmoid);
            }
           
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            imageViewer1.inti(mnist.TestImages[(int)numericUpDown1.Value].RawImage, 28, 28, 5, 5);
            double[] img1 = mnist.TestImages[(int)numericUpDown1.Value].RawImage;
            
            cnn.Image = img1;
            aux1 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter1);
            
            cnn.Image = img1;
            aux2 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter2);
            
            cnn.Image = img1;
            aux3 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter3);
            
            cnn.Image = img1;
            aux4 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter4);

            aux6 = cnn.Pooling(cnn.Pooling(aux1)); imageViewer6.inti(aux6, 7, 7, 20, 20);
            aux7 = cnn.Pooling(cnn.Pooling(aux2)); imageViewer7.inti(aux7, 7, 7, 20, 20);
            aux8 = cnn.Pooling(cnn.Pooling(aux3)); imageViewer8.inti(aux8, 7, 7, 20, 20);
            aux9 = cnn.Pooling(cnn.Pooling(aux4)); imageViewer9.inti(aux9, 7, 7, 20, 20);  
            
            int v = (int)mnist.TestImages[(int)numericUpDown1.Value].Label;
            numericUpDown2.Value = v;
            for (int i = 0; i < target.Length; i++)
            {
                target[i] = 0.0;
                if (i == v)
                    target[i] = 1.0;                
            }
            for (int i = 0; i < aux6.Length; i++)
            {
                inputs[i] = aux6[i];
                inputs[i + aux6.Length] = aux7[i];
                inputs[i + 2 * aux6.Length] = aux8[i];
                inputs[i + 3 * aux6.Length] = aux9[i];
            }
            ann.Process(inputs);
            listBox1.Items.Clear();
            PV[] pv = new PV[ann.ON.Length];
            for (int i = 0; i < ann.ON.Length; i++)
            {
                pv[i].value = ann.ON[i].y;
                pv[i].pos = i;
            }
            //o = ann.SoftMax(o);
            for (int i = 0; i < ann.ON.Length; i++)
            {
                listBox1.Items.Add(pv[i].pos + "  :  " + pv[i].value);                
            }
            pv = ArrangPV(pv);
            listBox2.Items.Clear();
            listBox2.Items.Add(pv[0].pos + "  :  " + pv[0].value.ToString("#.######"));
            listBox2.Items.Add(pv[1].pos + "  :  " + pv[1].value.ToString("#.######"));
        }
        public struct PV
        {
            public int pos;
            public double value;
        }
        public PV[] ArrangPV(PV[] pv)
        {
            PV aux;
            for (int i = 0; i < pv.Length; i++)
            {
                for (int j = i; j < pv.Length; j++)
                {
                    if(pv[i].value <= pv[j].value)
                    {
                        aux = pv[i];
                        pv[i] = pv[j];
                        pv[j] = aux;
                    }
                }
            }
            return pv;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new ConfNN(); xml = new ANNXML();
        }

       


        ANN ann;
        int input = 7 * 7 * 4;
        int h = 2;
        int[] hn; double[] inputs;
        double[] target = new double[10];
       
        private void button4_Click(object sender, EventArgs e)
        {
            double[] img1 = imageViewer1.Image;

            cnn.Image = img1;
            aux1 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter1);

            cnn.Image = img1;
            aux2 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter2);

            cnn.Image = img1;
            aux3 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter3);

            cnn.Image = img1;
            aux4 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter4);

            aux6 = cnn.Pooling(cnn.Pooling(aux1)); imageViewer6.inti(aux6, 7, 7, 20, 20);
            aux7 = cnn.Pooling(cnn.Pooling(aux2)); imageViewer7.inti(aux7, 7, 7, 20, 20);
            aux8 = cnn.Pooling(cnn.Pooling(aux3)); imageViewer8.inti(aux8, 7, 7, 20, 20);
            aux9 = cnn.Pooling(cnn.Pooling(aux4)); imageViewer9.inti(aux9, 7, 7, 20, 20);
            for (int i = 0; i < aux6.Length; i++)
            {
                inputs[i] = aux6[i];
                inputs[i + aux6.Length] = aux7[i];
                inputs[i + 2 * aux6.Length] = aux8[i];
                inputs[i + 3 * aux6.Length] = aux9[i];
            }
            int v = (int)numericUpDown2.Value;
            for (int i = 0; i < target.Length; i++)
            {
                target[i] = 0.0;
                if (i == v)
                    target[i] = 1.0;
            }
            ann.learnrate = 0.1;
            for (int i = 0; i < 20; i++ )
            {
                ann.Process(inputs);
                ann.Update(target);
            }
            listBox1.Items.Clear();
            PV[] pv = new PV[ann.ON.Length];
            for (int i = 0; i < ann.ON.Length; i++)
            {
                pv[i].value = ann.ON[i].y;
                pv[i].pos = i;
            }
            //o = ann.SoftMax(o);
            for (int i = 0; i < ann.ON.Length; i++)
            {
                listBox1.Items.Add(pv[i].pos + "  :  " + pv[i].value);
            }
            pv = ArrangPV(pv);
            listBox2.Items.Clear();
            listBox2.Items.Add(pv[0].pos + "  :  " + pv[0].value.ToString("#.######"));
            listBox2.Items.Add(pv[1].pos + "  :  " + pv[1].value.ToString("#.######"));
        }
        
        private void button5_Click(object sender, EventArgs e)
        {

            double[] img1 = imageViewer1.Image;

            cnn.Image = img1;
            aux1 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter1);

            cnn.Image = img1;
            aux2 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter2);

            cnn.Image = img1;
            aux3 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter3);

            cnn.Image = img1;
            aux4 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter4);

            aux6 = cnn.Pooling(cnn.Pooling(aux1)); imageViewer6.inti(aux6, 7, 7, 20, 20);
            aux7 = cnn.Pooling(cnn.Pooling(aux2)); imageViewer7.inti(aux7, 7, 7, 20, 20);
            aux8 = cnn.Pooling(cnn.Pooling(aux3)); imageViewer8.inti(aux8, 7, 7, 20, 20);
            aux9 = cnn.Pooling(cnn.Pooling(aux4)); imageViewer9.inti(aux9, 7, 7, 20, 20);  
            for (int i = 0; i < aux6.Length; i++)
            {
                inputs[i] = aux6[i];
                inputs[i + aux6.Length] = aux7[i];
                inputs[i + 2 * aux6.Length] = aux8[i];
                inputs[i + 3 * aux6.Length] = aux9[i];
            }
            ann.Process(inputs);
            listBox1.Items.Clear();
            double[] oo = new double[ann.ON.Length];
            for (int i = 0; i < ann.ON.Length; i++)
            {
                oo[i] =  ann.ON[i].y;
            }
            PV[] pv = new PV[ann.ON.Length];
            for (int i = 0; i < ann.ON.Length; i++)
            {
                pv[i].value = ann.ON[i].y;
                pv[i].pos = i;
            }
            //o = ann.SoftMax(o);
            for (int i = 0; i < ann.ON.Length; i++)
            {
                listBox1.Items.Add(pv[i].pos + "  :  " + pv[i].value);
            }
            pv = ArrangPV(pv);
            listBox2.Items.Clear();
            listBox2.Items.Add(pv[0].pos + "  :  " + pv[0].value.ToString("#.######"));
            listBox2.Items.Add(pv[1].pos + "  :  " + pv[1].value.ToString("#.######"));
        }
        int iindex;
        int jindex;
        private void button6_Click(object sender, EventArgs e)
        {
            init();
            for (jindex = 0; jindex < 8; jindex++)
            {
                for (iindex = 0; iindex < 6000; iindex++)
                 {
                    double[] img1 = mnist.TestImages[iindex].RawImage;
                    int v = (int)mnist.TestImages[iindex].Label;
                    for (int ii = 0; ii < target.Length; ii++)
                    {
                        target[ii] = 0.0;
                        if (ii == v)
                            target[ii] = 1.0;
                    }
                    cnn.Image = img1;
                    aux1 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter1);

                    cnn.Image = img1;
                    aux2 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter2);

                    cnn.Image = img1;
                    aux3 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter3);

                    cnn.Image = img1;
                    aux4 = cnn.FilterProcc(cnn.Image, ConfNN.Filter.filter4);

                    aux6 = cnn.Pooling(cnn.Pooling(aux1)); //imageViewer6.inti(aux6, 7, 7, 20, 20);
                    aux7 = cnn.Pooling(cnn.Pooling(aux2)); //imageViewer7.inti(aux7, 7, 7, 20, 20);
                    aux8 = cnn.Pooling(cnn.Pooling(aux3)); //imageViewer8.inti(aux8, 7, 7, 20, 20);
                    aux9 = cnn.Pooling(cnn.Pooling(aux4)); //imageViewer9.inti(aux9, 7, 7, 20, 20);   

                    for (int ii = 0; ii < aux6.Length; ii++)
                    {
                        inputs[ii] = aux6[ii];
                        inputs[ii + aux6.Length] = aux7[ii];
                        inputs[ii + 2 * aux6.Length] = aux8[ii];
                        inputs[ii + 3 * aux6.Length] = aux9[ii];
                    }

                    ann.learnrate = 0.999999999;
                    for (int ii = 0; ii < 6; ii++)
                    {
                        ann.Process(inputs);
                        ann.Update(target);
                    }
                }
            }
            PV[] pv = new PV[ann.ON.Length];
            for (int i = 0; i < ann.ON.Length; i++)
            {
                pv[i].value = ann.ON[i].y;
                pv[i].pos = i;
            }
            //o = ann.SoftMax(o);
            for (int i = 0; i < ann.ON.Length; i++)
            {
                listBox1.Items.Add(pv[i].pos + "  :  " + pv[i].value);
            }
            pv = ArrangPV(pv);
            listBox2.Items.Clear();
            listBox2.Items.Add(pv[0].pos + "  :  " + pv[0].value.ToString("#.######"));
            listBox2.Items.Add(pv[1].pos + "  :  " + pv[1].value.ToString("#.######"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ss = xml.BuildANN(ann);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "ANN File|*.xml";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(ss);
                sw.Flush();
                sw.Close();
            }
        }
        int num = 0; int hnum = 0;
        private void button8_Click(object sender, EventArgs e)
        {
            init();
            
            treeView1.Nodes.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ANN File|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TreeNode root = new TreeNode("ANN");
                ANN.ActivationFunction haf = ANN.ActivationFunction.ReLU;
                ANN.ActivationFunction oaf = ANN.ActivationFunction.ReLU;
                int oo = 0;
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(ofd.FileName);
                foreach (XmlNode node in xdoc.DocumentElement.ChildNodes)
                {
                    if (node.Name == "input")
                    {
                        input = int.Parse(node.InnerText);
                        inputs = new double[input];
                    }
                    if (node.Name == "hidden")
                    {
                        h = int.Parse(node.InnerText);
                        hn = new int[h];
                        hnum = int.Parse(node.InnerText);
                    }
                    if (node.Name == "output")
                    {
                    }
                    if (node.Name == "HActivation")
                    {
                        if (node.InnerText == "ReLU")
                        {
                            haf = ANN.ActivationFunction.ReLU;
                        }
                        else
                        {
                            haf = ANN.ActivationFunction.Sigmoid;
                        }
                    }
                    if (node.Name == "OutActivation")
                    {
                        if (node.InnerText == "ReLU")
                        {
                            oaf = ANN.ActivationFunction.ReLU;
                        }
                        else
                        {
                            oaf = ANN.ActivationFunction.Sigmoid;
                        }
                    }
                    if (node.Name == "OLayer")
                    {
                        XmlNode n = node["NN"];
                        oo = int.Parse(n.InnerText);
                    }
                    for (int j = 0; j < hnum; j++)
                    {
                        if (node.Name == "HLayer" + j)
                        {
                            XmlNode n = node["NN"];
                            TreeNode aux1 = new TreeNode(node.Name + ":" + n.InnerText);
                            hn[j] = int.Parse(n.InnerText);
                        }
                    }
                }
                ann = new ANN(input, hn, haf, oo, oaf);

                //*********************************

                //xdoc.Load(@"d:\AddANN2.xml");
                foreach (XmlNode node in xdoc.DocumentElement.ChildNodes)
                {
                    if (node.Name == "input")
                    {
                        TreeNode aux = new TreeNode(node.Name + ":" + node.InnerText); root.Nodes.Add(aux);
                    }
                    if (node.Name == "hidden")
                    {
                        TreeNode aux = new TreeNode(node.Name + ":" + node.InnerText); root.Nodes.Add(aux);
                    }
                    if (node.Name == "output")
                    {
                        TreeNode aux = new TreeNode(node.Name + ":" + node.InnerText); root.Nodes.Add(aux);
                    }
                    if (node.Name == "HActivation")
                    {
                        TreeNode aux = new TreeNode(node.Name + ":" + node.InnerText); root.Nodes.Add(aux);
                    }
                    if (node.Name == "OutActivation")
                    {
                        TreeNode aux = new TreeNode(node.Name + ":" + node.InnerText); root.Nodes.Add(aux);
                    }
                    if (node.Name == "OLayer")
                    {
                        XmlNode n = node["NN"];
                        TreeNode aux1 = new TreeNode(node.Name + ":" + n.InnerText);
                        num = int.Parse(n.InnerText);
                        for (int i = 0; i < num; i++)
                        {
                            n = node["ON" + i];
                            TreeNode aux2 = new TreeNode(n.Name + ": bias = " + n.Attributes[0].InnerText);
                            ann.ON[i].bias = double.Parse(n.Attributes[0].InnerText);
                            int index = 0;
                            foreach (XmlNode sn in n)
                            {
                                TreeNode aux3 = new TreeNode(sn.Name + ":" + sn.InnerText);
                                ann.ON[i].w[index++] = double.Parse(sn.InnerText);
                                aux2.Nodes.Add(aux3);
                            }
                            aux1.Nodes.Add(aux2);
                        }
                        root.Nodes.Add(aux1);
                    }
                    for (int j = 0; j < hnum; j++)
                    {
                        if (node.Name == "HLayer" + j)
                        {
                            XmlNode n = node["NN"];
                            TreeNode aux1 = new TreeNode(node.Name + ":" + n.InnerText);
                            num = int.Parse(n.InnerText);
                            for (int i = 0; i < num; i++)
                            {
                                n = node["HN" + j + "" + i];
                                TreeNode aux2 = new TreeNode(n.Name + ": bias = " + n.Attributes[0].InnerText);
                                ann.HN[j][i].bias = double.Parse(n.Attributes[0].InnerText);
                                int index = 0;
                                foreach (XmlNode sn in n)
                                {
                                    TreeNode aux3 = new TreeNode(sn.Name + ":" + sn.InnerText); aux2.Nodes.Add(aux3);
                                    ann.HN[j][i].w[index++] = double.Parse(sn.InnerText);
                                }
                                aux1.Nodes.Add(aux2);
                            }
                            root.Nodes.Add(aux1);
                        }
                    }
                }
                //ann = new ANN(input, hn, haf, oo, oaf);
                treeView1.Nodes.Add(root); imageViewer1.Clear();
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //init();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Bitmap image = (Bitmap)Image.FromFile(ofd.FileName, true);
                    int width = image.Size.Width;
                    int high = image.Size.Height;
                    double[] aux1 = new double[width * high];
                    for (int i = 0; i < high; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Color c = image.GetPixel(i, j);
                            //if (c != Color.Black) c = Color.White;
                            aux1[j + i * high] = (double)((((c.R + c.G + c.B) / 3) / 127) - 1);
                            if (aux1[j + i * high] == 0) aux1[j + i * high] = 1.0d;
                        }
                    }
                    cnn.Image = aux1;
                    imageViewer1.inti(cnn.Image, 28, 28, 5, 5);
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("There was an error opening the bitmap." +
                        "Please check the path.");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            imageViewer1.Clear();
        }
    }
}
