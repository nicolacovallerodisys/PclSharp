using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PclSharp;
using PclSharp.Struct;

namespace TestPclSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PclSharp.PointCloudOfXYZ pcl = new PointCloudOfXYZ();
            pcl.Add(new PclSharp.Struct.PointXYZ() { X = 1, Y = 1, Z = 1 });


            //PclSharp.Filters.StatisticalOutlierRemovalOfXYZ fitler = new
        }
    }
}
