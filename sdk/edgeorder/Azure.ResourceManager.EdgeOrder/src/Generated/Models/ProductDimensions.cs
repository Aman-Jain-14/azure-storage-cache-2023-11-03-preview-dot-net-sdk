// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Dimensions of a configuration. </summary>
    public partial class ProductDimensions
    {
        /// <summary> Initializes a new instance of <see cref="ProductDimensions"/>. </summary>
        internal ProductDimensions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProductDimensions"/>. </summary>
        /// <param name="length"> Length of the device. </param>
        /// <param name="height"> Height of the device. </param>
        /// <param name="width"> Width of the device. </param>
        /// <param name="lengthHeightUnit"> Unit for the dimensions of length, height and width. </param>
        /// <param name="weight"> Weight of the device. </param>
        /// <param name="depth"> Depth of the device. </param>
        /// <param name="weightUnit"> Unit for the dimensions of weight. </param>
        internal ProductDimensions(double? length, double? height, double? width, ProductLengthHeightWidthUnit? lengthHeightUnit, double? weight, double? depth, ProductWeightMeasurementUnit? weightUnit)
        {
            Length = length;
            Height = height;
            Width = width;
            LengthHeightUnit = lengthHeightUnit;
            Weight = weight;
            Depth = depth;
            WeightUnit = weightUnit;
        }

        /// <summary> Length of the device. </summary>
        public double? Length { get; }
        /// <summary> Height of the device. </summary>
        public double? Height { get; }
        /// <summary> Width of the device. </summary>
        public double? Width { get; }
        /// <summary> Unit for the dimensions of length, height and width. </summary>
        public ProductLengthHeightWidthUnit? LengthHeightUnit { get; }
        /// <summary> Weight of the device. </summary>
        public double? Weight { get; }
        /// <summary> Depth of the device. </summary>
        public double? Depth { get; }
        /// <summary> Unit for the dimensions of weight. </summary>
        public ProductWeightMeasurementUnit? WeightUnit { get; }
    }
}
