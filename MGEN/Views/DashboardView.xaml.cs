using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MGEN.Views
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void sldASH_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblASH.Content = $"{sldASH.Value:F2} %";
        }

        private void sldOxygen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblOxygen.Content = $"{sldOxygen.Value:F2} %";
        }

        private void sldCarbon_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblCarbon.Content = $"{sldCarbon.Value:F2} %";
        }

        private void sldHydrogen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblHydrogen.Content = $"{sldHydrogen.Value:F2} %";
        }

        private void sldSulfur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblSulfur.Content = $"{sldSulfur.Value:F2} %";
        }

        private void sldNitrogen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblNitrogen.Content = $"{sldNitrogen.Value:F2} %";
        }

        private void sldAirMF_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblAirMF.Content = $"{sldAirMF.Value:F0} Kg/h";
        }

        private void sldSteamMF_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblSteamMF.Content = $"{sldSteamMF.Value:F0} Kg/h";
        }

        private void sldPyrolT_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblPyroT.Content = $"{sldPyroT.Value:F0} C";
        }

        private void sldGasifT_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblGasifT.Content = $"{sldGasifT.Value:F0} C";
        }

        private void sldWaterMF_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblWaterMF.Content = $"{sldWaterMF.Value:F0} Kg/h";
        }

        private void sldCaMF_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblCaMF.Content = $"{sldCaMF.Value:F0} Kg/h";
        }

        private void sldCarboT_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblCarboT.Content = $"{sldCarboT.Value:F0} C";
        }

        private void sldLNGMF_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                lblLNGMF.Content = $"{sldLNGMF.Value:F0} Kg/h";
        }

        //private void btnPredict_Click(object sender, RoutedEventArgs e)
        //{

        //}


       
        private void btnPredict_Click(object sender, RoutedEventArgs e)
        {
            var predictedEngineH = PredictEngineH(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            var predictedEngineC = PredictEngineC(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            var predictedEnginePCC = PredictEnginePCC(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            var predictedEngineWork = PredictEngineWork(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            var predictedEngineExergy = PredictEngineExergy(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            var predictedEngineHHV = PredictEngineHHV(sldASH.Value, sldOxygen.Value,
                sldCarbon.Value, sldHydrogen.Value, sldAirMF.Value, sldNitrogen.Value,
                sldSteamMF.Value, sldPyroT.Value, sldGasifT.Value, sldWaterMF.Value,
                sldCaMF.Value, sldCarboT.Value, sldLNGMF.Value, sldSulfur.Value);

            lblH2Predicted.Content = $"Hydrogen Produced : {predictedEngineH:F1} Kg/h";
            lblCO2Predicted.Content = $"Liquid-CO2 Produced : {predictedEngineC:F1} Kg/h";
            lblPccPredicted.Content = $"PCC Produced : {predictedEnginePCC:F1} Kg/h";
            lblWorkPredicted.Content = $"Work Produced : {predictedEngineWork:F1} kW";
            lblExergyPredicted.Content = $"Exergy of Exhaust Gases : {predictedEngineExergy:F1} kW";
            lblHHVPredicted.Content = $"HHV of Exhaust Gases : {predictedEngineHHV:F1} kJ/cum";
        }

        private float PredictEngineH(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLHydrogen.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
            };

            //Load model and predict output
            var result = MLHydrogen.Predict(sampleData);
            return result.Score;
        }

        private float PredictEngineC(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLCO2.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
                LNG_MF= (float)LNG,

            };

            //Load model and predict output
            var result = MLCO2.Predict(sampleData);
            return result.Score;


        }
        
        private float PredictEnginePCC(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLPCC.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
                LNG_MF= (float)LNG,

            };

            //Load model and predict output
            var result = MLPCC.Predict(sampleData);
            return result.Score;
        }

        private float PredictEngineWork(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLPower.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
                LNG_MF = (float)LNG,

            };

            //Load model and predict output
            var result = MLPower.Predict(sampleData);
            return result.Score;
        }

        private float PredictEngineExergy(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLExergy.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
                LNG_MF = (float)LNG,

            };

            //Load model and predict output
            var result = MLExergy.Predict(sampleData);
            return result.Score;
        }

        private float PredictEngineHHV(double Ash, double Oxygen, double Carbon, double Hydrogen, double Air_MF,
            double Nitrogen, double Steam_MF, double PYROL_T, double GASIF_T, double Water_WGS, double CAOH2, double CARBONAT_T, double LNG, double Sulfur)
        {

            var sampleData = new MLHHV.ModelInput()
            {
                Carbon = (float)Carbon,
                Hydrogen = (float)Hydrogen,
                Nitrogen = (float)Nitrogen,
                Sulfur = (float)Sulfur,
                Oxygen = (float)Oxygen,
                Ash = (float)Ash,
                Air_MF = (float)Air_MF,
                Steam_MF = (float)Steam_MF,
                PYROL_T = (float)PYROL_T,
                GASIF_T = (float)GASIF_T,
                Water_WGS = (float)Water_WGS,
                CAOH2 = (float)CAOH2,
                CARBONAT_T = (float)CARBONAT_T,
                LNG_MF = (float)LNG,

            };

            //Load model and predict output
            var result = MLHHV.Predict(sampleData);
            return result.Score;
        }


    }
}
