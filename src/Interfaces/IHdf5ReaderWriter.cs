using System;
using System.Collections.Generic;

namespace Tensorflow.Keras.HDF5.Interfaces
{
    public interface IHdf5ReaderWriter
    {
        (int success, long CreatedgroupId) WriteFromArray<T>(long groupId, string name, Array dset);
        (bool success, Array result) ReadToArray<T>(long groupId, string name, string alternativeName);
        (int success, long CreatedgroupId) WriteStrings(long groupId, string name, IEnumerable<string> collection, string datasetName = null);
        (bool success, IEnumerable<string>) ReadStrings(long groupId, string name, string alternativeName);
    }
}
