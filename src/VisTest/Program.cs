using PclSharp;
using PclSharp.IO;
using PclSharp.Vis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cloud = new PointCloudOfXYZRGBA())
            {
                using (var reader = new PCDReader())
                {
                    string fileName = DataPath(@"tutorials\table_scene_mug_stereo_textured.pcd");
                    reader.Read(fileName, cloud);
                    Console.WriteLine($"Read point cloud in {fileName} with {cloud.Points.Count} points");
                }
                               
                using (var visualizer = new Visualizer("Disys Viewer"))
                {
                    visualizer.AddPointCloud(cloud);
                    visualizer.SetPointCloudRenderingProperties(RenderingProperties.PointSize, 100);
                    visualizer.SetPointCloudRenderingProperties(RenderingProperties.Opacity, 0.95);

                    while (!visualizer.WasStopped)
                        visualizer.SpinOnce(100);
                }
            }
        }

        public static string DataPath(string path)
        { 
            var fullpath = Path.Combine("..", "..", "..", "..", "data", path);
            return fullpath;
        }
    }
}
