using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Scintilab
{
    /** @brief Datastruktur for systemparametere */
    [Serializable()]
    public class SystemParameters
    {
        public string GenieDirectory;
        public int ErrorMultiplier;
        public string ReportTemplate;
        public string ReportSection;
        public string ReportScaleY;
        public string ReportScaleX;
        public string LimsExport;
        public string LimsImport;
        public bool UseActiveDirectory;
    }

    /** @brief Datastruktur for begere */
    [Serializable()]
    [XmlRoot(ElementName = "Beaker")]
    public class Beaker
    {
        public string Name;
        public string Manufacturer;
        public bool InUse;
    }

    /** @brief Datastruktur for QA-begere */
    [Serializable()]
    [XmlRoot(ElementName = "QABeaker")]
    public class QABeaker
    {
        public string Name;
        public string BeakerName;
        public DateTime RefDate;
        public double SampleQuantity;
        public double Uncertainty;
        public string Unit;
        public string SampleType;
        public bool InUse;
    }

    /** @brief Datastruktur for beger/calibrering/QA kombinasjon */
    [Serializable()]
    [XmlRoot(ElementName = "BeakerInfo")]
    public class BeakerInfo
    {
        public string BeakerName;
        public string CalibrationFile;
        public string QAName;
    }

    /** @brief Datastruktur for detektor */
    [Serializable()]
    [XmlRoot(ElementName = "Detector")]
    public class Detector
    {        
        /** Navn på detektor */
        public string Name;
        /** Om detektor er i bruk */
        public bool InUse;        
        public int SearchRegionFrom;
        public int SearchRegionTo;
        public double Tolerance;
        public double SignificanceThreshold;
        public int PeakAreaRegionFrom;
        public int PeakAreaRegionTo;
        public double Continuum;
        public string ContinuumFunction;
        public bool CriticalLevel;
        public bool FitSinglets;
        public bool DisplayROIs;
        public bool UseFixedTailParameter;
        public bool RejectZeroAreaPeaks;
        public bool UseFixedFWHM;
        public double MaxFWHMSBetweenPeaks;
        public double MaxFWHMSForLeftLimit;
        public double MaxFWHMSForRightLimit;
        public string BackgroundSubtract;
        public string EfficiencyCalibrationType;
        public string NIDLibrary;
        public double NIDConfidenceThreshold;
        public double MDAConfidenceFactor;
        public bool InhibitATDCorrection;
        public bool UseStoredLibrary;
        public bool PerformMDATest;
        public string PresetCount;
        public int PresetCountValue;
        public int PresetCountChanFrom;
        public int PresetCountChanTo;
        public string PresetTime;
        public int PresetTimeValue;
        public string PresetTimeUnit;
        public double RandomError;
        public double SystematicError;
        /** Liste med gyldige beger for detektor */
        public List<BeakerInfo> BeakerInfoList = new List<BeakerInfo>();
        /** Teller for spektere kjørt med denne detektoren */
        public int SpectrumCounter;
        /** Max antall kanaler for denne detektoren */
        public int MaxChannels;

        public string QARefPresetArea;
        public int QARefPresetAreaValue;
        public int QARefPresetAreaChanFrom;
        public int QARefPresetAreaChanTo;
        public string QARefPresetTime;
        public int QARefPresetTimeValue;
        public string QARefPresetTimeUnit;

        public string QABkgPresetArea;
        public int QABkgPresetAreaValue;
        public int QABkgPresetAreaChanFrom;
        public int QABkgPresetAreaChanTo;
        public string QABkgPresetTime;
        public int QABkgPresetTimeValue;
        public string QABkgPresetTimeUnit;
    }

    /** @brief Datastruktur for jobb parametere */
    [Serializable()]
    [XmlRoot(ElementName = "JobParams")]
    public class JobParams
    {
        public string Operation;
        public string OrderName;
        public string CollectorName;
        public string Description;
        public string SpecRef;
        public string Comment;
        public string SampleID;
        public string SampleType;
        public double SampleQuantity;
        public double SampleQuantityError;
        public string SampleQuantityUnit;
        public string Geometry;
        public string CalibrationFile;
        public string BuildupType;
        public DateTime SpectrumDate;
        public DateTime BuildupStartDate;
        public DateTime BuildupEndDate;
        public double RandomError;
        public double SystematicError;
        public string PresetCount;
        public int PresetCountValue;
        public int PresetCountChanFrom;
        public int PresetCountChanTo;
        public string PresetTime;
        public int PresetTimeValue;
        public string PresetTimeUnit;
        public string DetectorName;
        public int SearchRegionFrom;
        public int SearchRegionTo;
        public double Tolerance;
        public double SignificanceThreshold;
        public int PeakAreaRegionFrom;
        public int PeakAreaRegionTo;
        public double Continuum;
        public string ContinuumFunction;
        public bool CriticalLevel;
        public bool FitSinglets;
        public bool DisplayROIs;
        public bool UseFixedTailParameter;
        public bool RejectZeroAreaPeaks;
        public bool UseFixedFWHM;
        public double MaxFWHMSBetweenPeaks;
        public double MaxFWHMSForLeftLimit;
        public double MaxFWHMSForRightLimit;
        public string BackgroundSubtractFile;
        public string EfficiencyCalibrationType;
        public string NIDLibraryFile;
        public double NIDConfidenceThreshold;
        public double MDAConfidenceFactor;
        public bool InhibitATDCorrection;
        public bool UseStoredLibrary;
        public bool PerformMDATest;       
        public int Sigma;
        public string ReportTemplateFile;
        public string ReportSection;
        public bool RunError;
    }

    /** @brief Klasse for parametere valgt av bruker gjennom grensesnitt */
    public class SelectionInfo
    {
        public void Init()
        {
            AnalType = "Sample";
            IsWizard = false;
            SelectedDetector = null;
            SelectedBeakerInfo = null;
            //SelectedBeaker = null;
            //SelectedQABeaker = null;
            DoStart = false;
            SelectedLIMSFile = "";
            AllDetectors = null;
            AllBeakers = null;
            AllQABeakers = null;
            SysPar = null;
        }

        public string AnalType;
        public bool IsWizard;
        public Detector SelectedDetector;
        public BeakerInfo SelectedBeakerInfo;
        //public QABeaker SelectedQABeaker;
        public bool DoStart;
        public string SelectedLIMSFile;
        public List<Detector> AllDetectors;
        public List<Beaker> AllBeakers;
        public List<QABeaker> AllQABeakers;
        public SystemParameters SysPar;

    }
}