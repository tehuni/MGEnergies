﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MGEN
{
    public partial class MLPCC
    {
        /// <summary>
        /// model input class for MLPCC.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Carbon")]
            public float Carbon { get; set; }

            [ColumnName(@"Hydrogen")]
            public float Hydrogen { get; set; }

            [ColumnName(@"Nitrogen")]
            public float Nitrogen { get; set; }

            [ColumnName(@"Sulfur")]
            public float Sulfur { get; set; }

            [ColumnName(@"Oxygen")]
            public float Oxygen { get; set; }

            [ColumnName(@"Ash")]
            public float Ash { get; set; }

            [ColumnName(@"Air_MF")]
            public float Air_MF { get; set; }

            [ColumnName(@"Steam_MF")]
            public float Steam_MF { get; set; }

            [ColumnName(@"PYROL_T")]
            public float PYROL_T { get; set; }

            [ColumnName(@"GASIF_T")]
            public float GASIF_T { get; set; }

            [ColumnName(@"Water_WGS")]
            public float Water_WGS { get; set; }

            [ColumnName(@"CAOH2")]
            public float CAOH2 { get; set; }

            [ColumnName(@"CARBONAT_T")]
            public float CARBONAT_T { get; set; }

            [ColumnName(@"LNG_MF")]
            public float LNG_MF { get; set; }

            [ColumnName(@"H2_P")]
            public float H2_P { get; set; }

            [ColumnName(@"CO2_P")]
            public float CO2_P { get; set; }

            [ColumnName(@"POWER")]
            public float POWER { get; set; }

            [ColumnName(@"PCC_P")]
            public float PCC_P { get; set; }

            [ColumnName(@"EXERGY")]
            public float EXERGY { get; set; }

            [ColumnName(@"HHV")]
            public float HHV { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLPCC.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Carbon")]
            public float Carbon { get; set; }

            [ColumnName(@"Hydrogen")]
            public float Hydrogen { get; set; }

            [ColumnName(@"Nitrogen")]
            public float Nitrogen { get; set; }

            [ColumnName(@"Sulfur")]
            public float Sulfur { get; set; }

            [ColumnName(@"Oxygen")]
            public float Oxygen { get; set; }

            [ColumnName(@"Ash")]
            public float Ash { get; set; }

            [ColumnName(@"Air_MF")]
            public float Air_MF { get; set; }

            [ColumnName(@"Steam_MF")]
            public float Steam_MF { get; set; }

            [ColumnName(@"PYROL_T")]
            public float PYROL_T { get; set; }

            [ColumnName(@"GASIF_T")]
            public float GASIF_T { get; set; }

            [ColumnName(@"Water_WGS")]
            public float Water_WGS { get; set; }

            [ColumnName(@"CAOH2")]
            public float CAOH2 { get; set; }

            [ColumnName(@"CARBONAT_T")]
            public float CARBONAT_T { get; set; }

            [ColumnName(@"LNG_MF")]
            public float LNG_MF { get; set; }

            [ColumnName(@"H2_P")]
            public float H2_P { get; set; }

            [ColumnName(@"CO2_P")]
            public float CO2_P { get; set; }

            [ColumnName(@"POWER")]
            public float POWER { get; set; }

            [ColumnName(@"PCC_P")]
            public float PCC_P { get; set; }

            [ColumnName(@"EXERGY")]
            public float EXERGY { get; set; }

            [ColumnName(@"HHV")]
            public float HHV { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLPCC.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
