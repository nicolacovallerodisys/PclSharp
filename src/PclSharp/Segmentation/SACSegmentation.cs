﻿// Code generated by a template
using PclSharp.SampleConsensus;
using PclSharp.Common;

namespace PclSharp.Segmentation
{
	public abstract class SACSegmentation<PointT> : UnmanagedObject
	{
		public abstract SACModel ModelType { get; set; }
		public abstract int MaxIterations { get; set; }
		public abstract SACMethod MethodType { get; set; }
		public abstract double DistanceThreshold { get; set; }

		public abstract void SetInputCloud(PointCloud<PointT> cloud);
		public abstract void Segment(PointIndices inliers, ModelCoefficients coefficients);
	}
}
