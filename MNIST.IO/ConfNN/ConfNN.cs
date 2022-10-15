using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNIST.IO
{
    public class ConfNN
    {
        int dim = 28;
        double[,] filter1 = new double[3, 3];
        double[,] filter2 = new double[3, 3];
        double[,] filter3 = new double[3, 3];
        double[,] filter4 = new double[3, 3];
        double[,] filter5 = new double[3, 3];
        double[,] filter6 = new double[3, 3];
        double[] image;
        public void Init_Filters()
        {
            image = new double[dim * dim];
            filter1[0, 0] = 3.0d; filter1[1, 0] = -1.0d; filter1[2, 0] = -0.0d;
            filter1[0, 1] = -1.0d; filter1[1, 1] = 3.0d; filter1[2, 1] = -1.0d;
            filter1[0, 2] = -0.0d; filter1[1, 2] = -1.0d; filter1[2, 2] = 3.0d;
            //**********************************
            filter2[0, 0] = -0.0f; filter2[1, 0] = -1.0f; filter2[2, 0] = 3.0f;
            filter2[0, 1] = -1.0f; filter2[1, 1] = 3.0f; filter2[2, 1] = -1.0f;
            filter2[0, 2] = 3.0f; filter2[1, 2] = -1.0f; filter2[2, 2] = -0.0f;           
            //**********************************
            filter3[0, 0] = 3.0f; filter3[1, 0] = 3.0f; filter3[2, 0] = 3.0f;
            filter3[0, 1] = -1.0f; filter3[1, 1] = -1.0f; filter3[2, 1] = -1.0f;
            filter3[0, 2] = -0.0f; filter3[1, 2] = -0.0f; filter3[2, 2] = -0.0f;
            //**********************************
            filter4[0, 0] = 3.0f; filter4[1, 0] = -1.0f; filter4[2, 0] = 0.0f;
            filter4[0, 1] = 3.0f; filter4[1, 1] = -1.0f; filter4[2, 1] = 0.0f;
            filter4[0, 2] = 3.0f; filter4[1, 2] = -1.0f; filter4[2, 2] = 0.0f;
            //**********************************
            filter5[0, 0] = 0.0f; filter5[1, 0] = -4.0f; filter5[2, 0] = 0.0f;
            filter5[0, 1] = -2.0f; filter5[1, 1] = 8.0f; filter5[2, 1] = -2.0f;
            filter5[0, 2] = 0.0f; filter5[1, 2] = -4.0f; filter5[2, 2] = 0.0f;

            //filter1[0, 0] = 1; filter1[1, 0] = 0; filter1[2, 0] = 0;
            //filter1[0, 1] = 0; filter1[1, 1] = 1; filter1[2, 1] = 0;
            //filter1[0, 2] = 0; filter1[1, 2] = 0; filter1[2, 2] = 1;
            //**********************************
            //filter2[0, 0] = 1; filter2[1, 0] = 0; filter2[2, 0] = 1;
            //filter2[0, 1] = 0; filter2[1, 1] = 1; filter2[2, 1] = 0;
            //filter2[0, 2] = 1; filter2[1, 2] = 0; filter2[2, 2] = 1;
            ////**********************************
            //filter3[0, 0] = 0; filter3[1, 0] = 0; filter3[2, 0] = 1;
            //filter3[0, 1] = 0; filter3[1, 1] = 1; filter3[2, 1] = 0;
            //filter3[0, 2] = 1; filter3[1, 2] = 0; filter3[2, 2] = 0;
            ////**********************************
            //filter4[0, 0] = 0; filter4[1, 0] = 0; filter4[2, 0] = 0;
            //filter4[0, 1] = 1; filter4[1, 1] = 1; filter4[2, 1] = 1;
            //filter4[0, 2] = 0; filter4[1, 2] = 0; filter4[2, 2] = 0;
            ////**********************************
            //filter5[0, 0] = 0; filter5[1, 0] = 1; filter5[2, 0] = 0;
            //filter5[0, 1] = 0; filter5[1, 1] = 1; filter5[2, 1] = 0;
            //filter5[0, 2] = 0; filter5[1, 2] = 1; filter5[2, 2] = 0;


        }
        public double[] DataProcess(double[] data)
        {
            double max = 0; double[] d = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (max < data[i])
                    max = data[i];
            }
            for (int i = 0; i < data.Length; i++)
            {
                d[i] = data[i] / (double)(max);
            }
            return d;
        }
        public void Init_Image()
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    //image[i, j] = 0;
                    //if (i == j) image[i, j] = 1;
                    //if ((11 - i) == j) image[i, j] = 1;

                    //if (i == (image.GetLength(0) / 2)) image[i, j] = 255;
                    //if (j == (image.GetLength(1) / 2)) image[i, j] = 255;
                }
            }
        }
        public double[,] Filter1
        {
            get { return filter1; }
        }
        public double[,] Filter2
        {
            get { return filter2; }
        }
        public double[,] Filter3
        {
            get { return filter3; }
        }
        public double[,] Filter4
        {
            get { return filter4; }
        }
        public double[,] Filter5
        {
            get { return filter5; }
        }
        public double[] Image
        {
            get { return image; }
            set { image = value; }
        }
        public enum Filter
        {
            filter1,
            filter2,
            filter3,
            filter4,
            filter5,
        }
        public double[] AddPadding(double[] image, int Pad)
        {
            float[,] image2 = new float[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    image2[i, j] = (float)image[i * dim + j];
                }
            }
            float[,] aux = new float[image2.GetLength(0) + 2 * Pad, image2.GetLength(1) + 2 * Pad];
            for (int i = 0; i < aux.GetLength(0); i++)
            {
                for (int j = 0; j < aux.GetLength(1); j++)
                {
                    aux[j, i] = -1.0f;
                }
            }
            for (int i = 0; i < image2.GetLength(0); i++)
            {
                for (int j = 0; j < image2.GetLength(1); j++)
                {
                    aux[i + Pad, j + Pad] = image2[i, j];
                }
            }
            double[] auxx = new double[(image2.GetLength(0) + 2 * Pad) * (image2.GetLength(1) + 2 * Pad)];

            for (int i = 0; i < dim + 2; i++)
            {
                for (int j = 0; j < dim + 2; j++)
                {
                    auxx[i * (dim + 2) + j] = (double)aux[i, j];
                }
            }
            return auxx;
        }
        public double[] FilterProcc(double[] image, Filter f)
        {
            double[] aux = new double[image.Length];
            double[] auxx;
            int index = 0;
            auxx = AddPadding(image, 1);

            double[,] filter = filter1;

            if (f == Filter.filter1)
                filter = filter1;
            else if (f == Filter.filter2)
                filter = filter2;
            else if (f == Filter.filter3)
                filter = filter3;
            else if (f == Filter.filter4)
                filter = filter4;
            else if (f == Filter.filter5)
                filter = filter5;

            int filter_width = (filter.GetLength(0) - 1) / 2;
            double aa = 0.0d;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    index = i * dim + j;
                    aa = 0.0f;
                    for (int ii = -filter_width; ii <= filter_width; ii++)
                    {
                        for (int jj = -filter_width; jj <= filter_width; jj++)
                        {
                            aa += auxx[(i + 1 + ii) * (dim + 2) + (j + 1 + jj)] * filter[ii + filter_width, jj + filter_width];
                        }
                    }
                    aa = aa / filter.Length;
                    if (aa <= 0.0d)
                        aa = 0.0d;
                    if (aa > 1.0d)
                        aa = 1.0d;
                    aux[index] = aa;
                }
            }
            return aux;
        }
        public double[] Pooling(double[] image)
        {
            int wh1 = (int)Math.Sqrt(image.Length);
            double[] aux = new double[image.Length / 4];
            int wh2 = (int)Math.Sqrt(aux.Length);
            double max = 0; int ii = 0; int jj = 0;
            for (int i = 0; i < wh1; i += 2)
            {
                for (int j = 0; j < wh1; j += 2)
                {
                    if (max < image[i * wh1 + j])
                        max = image[i * wh1 + j];
                    if (max < image[(i + 1) * wh1 + j])
                        max = image[(i + 1) * wh1 + j];
                    if (max < image[(i + 1) * wh1 + (j + 1)])
                        max = image[(i + 1) * wh1 + (j + 1)];
                    if (max < image[(i) * wh1 + (j + 1)])
                        max = image[(i) * wh1 + (j + 1)];
                    aux[ii * wh2 + jj] = max;
                    jj++; max = 0;
                }
                ii++; jj = 0; max = 0;
            }
            return aux;
        }

    }
}
