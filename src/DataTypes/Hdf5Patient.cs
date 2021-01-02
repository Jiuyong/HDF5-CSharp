﻿using System;

namespace Tensorflow.Keras.HDF5.DataTypes
{
    [Hdf5GroupName("Patient")]
    public class Hdf5Patient
    {
        public string Name = "";
        public string Id = "";
        public int RecId = -1;
        public string Gender = "";
        public DateTime BirthDate = DateTime.Now;
        public double Height = double.NaN;
        public double Weight = double.NaN;
        public DateTime EditData = DateTime.Now;
    }
}
