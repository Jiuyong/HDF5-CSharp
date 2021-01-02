using System;

namespace Tensorflow.Keras.HDF5.DataTypes
{
    public class FileClosedArgs : EventArgs
    {
        public string ClosedFile { get; }
        public bool CancelRequested { get; set; }

        public FileClosedArgs(string fileName)
        {
            ClosedFile = fileName;
        }
    }
}
