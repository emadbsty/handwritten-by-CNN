using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MNIST.IO
{
    public class MNISTCore
    {
        private ReadMNIST _TrainingDB;
        private ReadMNIST _TestDB;
        /**
         * The MNIST database 
         * (Modified National Institute of Standards and Technology database) 
         * is a large database of handwritten digits that is 
         * commonly used for training various image processing systems.
        **/
        public MNISTCore()
        {
            
        }

        public List<DigitImage> TrainingImages
        {
            get { return _TrainingDB.Images; }
        }
        public List<DigitImage> TestImages
        {
            get { return _TestDB.Images; }
        }

        public Boolean LoadDB(string filesPath, int trainSize, int testSize)
        {
            try
            {
                string testImagesPath = filesPath + "t10k-images.idx3-ubyte";
                string testLabelsPath = filesPath + "t10k-labels.idx1-ubyte";
                string trainingImagesPath = filesPath + "train-images.idx3-ubyte";
                string trainingLabelsPath = filesPath + "train-labels.idx1-ubyte";

                _TrainingDB = new ReadMNIST(trainingLabelsPath, trainingImagesPath, trainSize);
                _TestDB = new ReadMNIST(testLabelsPath, testImagesPath, testSize);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }
    }
}
