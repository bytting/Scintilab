namespace Scintilab
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.lblToolsDetector = new System.Windows.Forms.ToolStripLabel();
            this.lblToolsInterface = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdmGeoNew = new System.Windows.Forms.ToolStripButton();
            this.btnAdmQANew = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblStatusUsername = new System.Windows.Forms.ToolStripLabel();
            this.btnToolsLogout = new System.Windows.Forms.ToolStripButton();
            this.tabs = new TabControlWizard.TabControlWizard();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenuArchive = new System.Windows.Forms.Button();
            this.btnMenuJobs = new System.Windows.Forms.Button();
            this.btnMenuBkgSample = new System.Windows.Forms.Button();
            this.btnMenuRegSample = new System.Windows.Forms.Button();
            this.btnMenuBarcodeWizardBkg = new System.Windows.Forms.Button();
            this.btnMenuBarcodeWizard = new System.Windows.Forms.Button();
            this.btnMenuBarcodeWizardRef = new System.Windows.Forms.Button();
            this.btnMenuRefSample = new System.Windows.Forms.Button();
            this.tabDetectors = new System.Windows.Forms.TabPage();
            this.lvDetectors = new System.Windows.Forms.ListView();
            this.ilDetector = new System.Windows.Forms.ImageList(this.components);
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.panel28 = new System.Windows.Forms.Panel();
            this.gridJobs = new System.Windows.Forms.DataGridView();
            this.Detector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnJobShow = new System.Windows.Forms.Button();
            this.btnJobsShowOutput = new System.Windows.Forms.Button();
            this.btnJobOpenSpectrum = new System.Windows.Forms.Button();
            this.tabSample = new System.Windows.Forms.TabPage();
            this.tabsSamples = new System.Windows.Forms.TabControl();
            this.tabSamplesParams = new System.Windows.Forms.TabPage();
            this.splitSamples = new System.Windows.Forms.SplitContainer();
            this.layoutSamples = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSampGeom = new System.Windows.Forms.Label();
            this.lblSampType = new System.Windows.Forms.Label();
            this.lblSampID = new System.Windows.Forms.Label();
            this.lblSampDesc = new System.Windows.Forms.Label();
            this.lblSampOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboxSampGeom = new System.Windows.Forms.ComboBox();
            this.tbSampType = new System.Windows.Forms.TextBox();
            this.tbSampID = new System.Windows.Forms.TextBox();
            this.tbSampDesc = new System.Windows.Forms.TextBox();
            this.tbSampOrder = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSampComment = new System.Windows.Forms.Label();
            this.lblSampCollector = new System.Windows.Forms.Label();
            this.lblSampRef = new System.Windows.Forms.Label();
            this.lblSampQuantUnc = new System.Windows.Forms.Label();
            this.lblSampQuantUnit = new System.Windows.Forms.Label();
            this.lblSampQuant = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbSampComment = new System.Windows.Forms.TextBox();
            this.tbSampCollector = new System.Windows.Forms.TextBox();
            this.tbSampRef = new System.Windows.Forms.TextBox();
            this.tbSampQuantUnc = new System.Windows.Forms.TextBox();
            this.cboxSampQuantUnit = new System.Windows.Forms.ComboBox();
            this.tbSampQuant = new System.Windows.Forms.TextBox();
            this.tabsBuildup = new System.Windows.Forms.TabControl();
            this.tabBuildupNone = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dtSampBuildNoneTime = new System.Windows.Forms.DateTimePicker();
            this.dtSampBuildNoneDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.tabBuildupIrrad = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dtSampBuildIrradTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtSampBuildIrradDateTo = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtSampBuildIrradTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtSampBuildIrradDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.tabBuildupDeposit = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dtSampBuildDepTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtSampBuildDepDateTo = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dtSampBuildDepTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dtSampBuildDepDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.tabSamplesAdvancedParams = new System.Windows.Forms.TabPage();
            this.layoutSamplesAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbSampAdvSystErr = new System.Windows.Forms.TextBox();
            this.tbSampAdvRandErr = new System.Windows.Forms.TextBox();
            this.cboxSampAdvCal = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbSampAdvPreAreaChanTo = new System.Windows.Forms.TextBox();
            this.tbSampAdvPreAreaChanFrom = new System.Windows.Forms.TextBox();
            this.tbSampAdvPreAreaValue = new System.Windows.Forms.TextBox();
            this.cboxSampAdvPreArea = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cboxSampAdvPreTimeUnit = new System.Windows.Forms.ComboBox();
            this.tbSampAdvPreTimeValue = new System.Windows.Forms.TextBox();
            this.cboxSampAdvPreTime = new System.Windows.Forms.ComboBox();
            this.tabSamplesAnalParams = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label68 = new System.Windows.Forms.Label();
            this.tbSampAnalTolerance = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.tbSampAnalSigThresh = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tbSampAnalContinuum = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.cboxSampAnalContinuumFunc = new System.Windows.Forms.ComboBox();
            this.cbSampAnalCritLev = new System.Windows.Forms.CheckBox();
            this.cbSampAnalFitSinglets = new System.Windows.Forms.CheckBox();
            this.cbSampAnalDispRois = new System.Windows.Forms.CheckBox();
            this.cbSampAnalUseFixed = new System.Windows.Forms.CheckBox();
            this.cbSampAnalRejectZero = new System.Windows.Forms.CheckBox();
            this.cbSampAnalFixedFWHM = new System.Windows.Forms.CheckBox();
            this.label73 = new System.Windows.Forms.Label();
            this.cboxSampAnalEffCal = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.tbSampAnalMaxFWHMBetween = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.tbSampAnalMaxFWHMRight = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.tbSampAnalMaxFWHMLeft = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tbSampAnalBkgSub = new System.Windows.Forms.TextBox();
            this.btnSampAnalBkgSub = new System.Windows.Forms.Button();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.tbSampAnalNIDLib = new System.Windows.Forms.TextBox();
            this.btnSampAnalNIDLib = new System.Windows.Forms.Button();
            this.label82 = new System.Windows.Forms.Label();
            this.tbSampAnalNIDConfThresh = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.tbSampAnalMDAConfFac = new System.Windows.Forms.TextBox();
            this.cbSampAnalInhibitATD = new System.Windows.Forms.CheckBox();
            this.cbSampAnalUseStoredLib = new System.Windows.Forms.CheckBox();
            this.cbSampAnalPerformMDA = new System.Windows.Forms.CheckBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnSampStart = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.lblSampIsReanal = new System.Windows.Forms.Label();
            this.btnSampReadBarcode = new System.Windows.Forms.Button();
            this.lblSampAnalType = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.tabsAdmin = new System.Windows.Forms.TabControl();
            this.tabAdminGeneral = new System.Windows.Forms.TabPage();
            this.tabsAdminGeneral = new System.Windows.Forms.TabControl();
            this.tabAdminGeneral1 = new System.Windows.Forms.TabPage();
            this.layoutAdminGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.cboxAdmSection = new System.Windows.Forms.ComboBox();
            this.tbAdmSigma = new System.Windows.Forms.TextBox();
            this.tbAdmGenieFolder = new System.Windows.Forms.TextBox();
            this.tbAdmTemplate = new System.Windows.Forms.TextBox();
            this.tbAdmLIMSImport = new System.Windows.Forms.TextBox();
            this.tbAdmLIMSExport = new System.Windows.Forms.TextBox();
            this.btnAdmGenieFolder = new System.Windows.Forms.Button();
            this.btnAdmTemplate = new System.Windows.Forms.Button();
            this.btnAdmLIMSImport = new System.Windows.Forms.Button();
            this.btnAdmLIMSExport = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxAdmPlotScaleY = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxAdmPlotScaleX = new System.Windows.Forms.ComboBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnAdmSave = new System.Windows.Forms.Button();
            this.tabAdminDet = new System.Windows.Forms.TabPage();
            this.splitAdmDet = new System.Windows.Forms.SplitContainer();
            this.lbAdmDetList = new System.Windows.Forms.ListBox();
            this.tabsAdmDetPages = new System.Windows.Forms.TabControl();
            this.tabAdmDetPage1 = new System.Windows.Forms.TabPage();
            this.layoutAdmDet = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tbAdmDetSearchRegionFrom = new System.Windows.Forms.TextBox();
            this.tbAdmDetSearchRegionTo = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tbAdmDetTolerance = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tbAdmDetSignThresh = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbAdmDetPeakAreaRegionFrom = new System.Windows.Forms.TextBox();
            this.tbAdmDetPeakAreaRegionTo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tbAdmDetContinuum = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.cboxAdmDetContinuumFunc = new System.Windows.Forms.ComboBox();
            this.cbAdmDetCriticalLevel = new System.Windows.Forms.CheckBox();
            this.cbAdmDetFitSinglets = new System.Windows.Forms.CheckBox();
            this.cbAdmDetDisplayROIs = new System.Windows.Forms.CheckBox();
            this.cbAdmDetUseFixedTailParam = new System.Windows.Forms.CheckBox();
            this.cbAdmDetRejectZeroAreaPeaks = new System.Windows.Forms.CheckBox();
            this.cbAdmDetUseFixedFWHM = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cboxAdmDetEffCalType = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbAdmDetMaxFHWMBetPeaks = new System.Windows.Forms.TextBox();
            this.cbAdmDetInUse = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbAdmDetMaxFHWMRightLim = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbAdmDetMaxFHWMLeftLim = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbAdmDetBkgSub = new System.Windows.Forms.TextBox();
            this.btnAdmDetBkgSub = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.tbAdmDetNIDLib = new System.Windows.Forms.TextBox();
            this.btnAdmDetNIDLib = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.tbAdmDetNIDConfThresh = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbAdmDetMDAConfFac = new System.Windows.Forms.TextBox();
            this.cbAdmDetInhibitATDCorr = new System.Windows.Forms.CheckBox();
            this.cbAdmDetUseStoredLib = new System.Windows.Forms.CheckBox();
            this.cbAdmDetPerfMDATest = new System.Windows.Forms.CheckBox();
            this.tabAdmDetPage2 = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.gridAdmDetGeomCalQA = new System.Windows.Forms.DataGridView();
            this.Geom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QABeaker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnAdmDetGeomCalDelete = new System.Windows.Forms.Button();
            this.btnAdmDetGeomCalEdit = new System.Windows.Forms.Button();
            this.btnAdmDetGeomCalAdd = new System.Windows.Forms.Button();
            this.layoutAdmDetPage2 = new System.Windows.Forms.TableLayoutPanel();
            this.label53 = new System.Windows.Forms.Label();
            this.cboxAdmDetPresetArea = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.cboxAdmDetPresetTime = new System.Windows.Forms.ComboBox();
            this.tbAdmDetPresetAreaValue = new System.Windows.Forms.TextBox();
            this.tbAdmDetPresetTimeValue = new System.Windows.Forms.TextBox();
            this.cboxAdmDetPresetTimeUnit = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.tbAdmDetPresetAreaChanFrom = new System.Windows.Forms.TextBox();
            this.tbAdmDetPresetAreaChanTo = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.tbAdmDetRandErr = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tbAdmDetSysErr = new System.Windows.Forms.TextBox();
            this.tabAdmDetPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxAdmDetBkgPresetArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxAdmDetBkgPresetTime = new System.Windows.Forms.ComboBox();
            this.tbAdmDetBkgPresetAreaValue = new System.Windows.Forms.TextBox();
            this.tbAdmDetBkgPresetTimeValue = new System.Windows.Forms.TextBox();
            this.cboxAdmDetBkgPresetTimeUnit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAdmDetBkgPresetAreaChanFrom = new System.Windows.Forms.TextBox();
            this.tbAdmDetBkgPresetAreaChanTo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxAdmDetQAPresetArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxAdmDetQAPresetTime = new System.Windows.Forms.ComboBox();
            this.tbAdmDetQAPresetAreaValue = new System.Windows.Forms.TextBox();
            this.tbAdmDetQAPresetTimeValue = new System.Windows.Forms.TextBox();
            this.cboxAdmDetQAPresetTimeUnit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdmDetQAPresetAreaChanFrom = new System.Windows.Forms.TextBox();
            this.tbAdmDetQAPresetAreaChanTo = new System.Windows.Forms.TextBox();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnAdmDetSave = new System.Windows.Forms.Button();
            this.tabAdminGeom = new System.Windows.Forms.TabPage();
            this.splitAdmGeom = new System.Windows.Forms.SplitContainer();
            this.lbAdmGeomList = new System.Windows.Forms.ListBox();
            this.layoutAdmGeom = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.tbAdmGeomManufacturer = new System.Windows.Forms.TextBox();
            this.cbAdmGeomInUse = new System.Windows.Forms.CheckBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnAdmGeomSave = new System.Windows.Forms.Button();
            this.tabAdminQA = new System.Windows.Forms.TabPage();
            this.splitAdmQA = new System.Windows.Forms.SplitContainer();
            this.lbAdmQAList = new System.Windows.Forms.ListBox();
            this.layoutAdmQA = new System.Windows.Forms.TableLayoutPanel();
            this.cbAdmQAInUse = new System.Windows.Forms.CheckBox();
            this.cboxAdmQABeaker = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.dtAdmQARefDate = new System.Windows.Forms.DateTimePicker();
            this.dtAdmQARefTime = new System.Windows.Forms.DateTimePicker();
            this.label62 = new System.Windows.Forms.Label();
            this.tbAdmQASampType = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.tbAdmQASampQuant = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.cboxAdmQASampUnit = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.tbAdmQASampUnc = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnAdmQASave = new System.Windows.Forms.Button();
            this.tabArchive = new System.Windows.Forms.TabPage();
            this.splitArchive = new System.Windows.Forms.SplitContainer();
            this.tvArchive = new System.Windows.Forms.TreeView();
            this.gridArchive = new System.Windows.Forms.DataGridView();
            this.SpecRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel29 = new System.Windows.Forms.Panel();
            this.btnArchiveShowSpectrum = new System.Windows.Forms.Button();
            this.btnArchiveCreateBkg = new System.Windows.Forms.Button();
            this.btnArchiveReanal = new System.Windows.Forms.Button();
            this.btnOpenQAPlot = new System.Windows.Forms.Button();
            this.btnArchiveShowReport = new System.Windows.Forms.Button();
            this.btnArchiveShowParams = new System.Windows.Forms.Button();
            this.btnArchivePrint = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.status.SuspendLayout();
            this.menu.SuspendLayout();
            this.tools.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabDetectors.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            this.panel27.SuspendLayout();
            this.tabSample.SuspendLayout();
            this.tabsSamples.SuspendLayout();
            this.tabSamplesParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSamples)).BeginInit();
            this.splitSamples.Panel1.SuspendLayout();
            this.splitSamples.Panel2.SuspendLayout();
            this.splitSamples.SuspendLayout();
            this.layoutSamples.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabsBuildup.SuspendLayout();
            this.tabBuildupNone.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tabBuildupIrrad.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tabBuildupDeposit.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tabSamplesAdvancedParams.SuspendLayout();
            this.layoutSamplesAdvanced.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabSamplesAnalParams.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel24.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabsAdmin.SuspendLayout();
            this.tabAdminGeneral.SuspendLayout();
            this.tabsAdminGeneral.SuspendLayout();
            this.tabAdminGeneral1.SuspendLayout();
            this.layoutAdminGeneral.SuspendLayout();
            this.panel25.SuspendLayout();
            this.tabAdminDet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmDet)).BeginInit();
            this.splitAdmDet.Panel1.SuspendLayout();
            this.splitAdmDet.Panel2.SuspendLayout();
            this.splitAdmDet.SuspendLayout();
            this.tabsAdmDetPages.SuspendLayout();
            this.tabAdmDetPage1.SuspendLayout();
            this.layoutAdmDet.SuspendLayout();
            this.tabAdmDetPage2.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmDetGeomCalQA)).BeginInit();
            this.panel20.SuspendLayout();
            this.layoutAdmDetPage2.SuspendLayout();
            this.tabAdmDetPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tabAdminGeom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmGeom)).BeginInit();
            this.splitAdmGeom.Panel1.SuspendLayout();
            this.splitAdmGeom.Panel2.SuspendLayout();
            this.splitAdmGeom.SuspendLayout();
            this.layoutAdmGeom.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tabAdminQA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmQA)).BeginInit();
            this.splitAdmQA.Panel1.SuspendLayout();
            this.splitAdmQA.Panel2.SuspendLayout();
            this.splitAdmQA.SuspendLayout();
            this.layoutAdmQA.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tabArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitArchive)).BeginInit();
            this.splitArchive.Panel1.SuspendLayout();
            this.splitArchive.Panel2.SuspendLayout();
            this.splitArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArchive)).BeginInit();
            this.panel29.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 588);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.status.Size = new System.Drawing.Size(1131, 25);
            this.status.TabIndex = 0;
            this.status.Text = "status";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 20);
            this.lblStatus.Text = "<Status>";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1131, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdmin,
            this.MenuItemLogout,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(36, 24);
            this.MenuItemFile.Text = "&Fil";
            // 
            // MenuItemAdmin
            // 
            this.MenuItemAdmin.Name = "MenuItemAdmin";
            this.MenuItemAdmin.Size = new System.Drawing.Size(177, 24);
            this.MenuItemAdmin.Text = "Administrasjon";
            this.MenuItemAdmin.Click += new System.EventHandler(this.MenuItemAdmin_Click);
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(177, 24);
            this.MenuItemLogout.Text = "Logg &Ut";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(177, 24);
            this.MenuItemExit.Text = "&Avslutt";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.lblToolsDetector,
            this.lblToolsInterface,
            this.toolStripSeparator2,
            this.btnAdmGeoNew,
            this.btnAdmQANew,
            this.toolStripLabel1,
            this.lblStatusUsername,
            this.btnToolsLogout});
            this.tools.Location = new System.Drawing.Point(0, 28);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1131, 27);
            this.tools.TabIndex = 2;
            this.tools.Text = "tools";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Enabled = false;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 24);
            this.btnBack.Text = "Tilbake";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblToolsDetector
            // 
            this.lblToolsDetector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblToolsDetector.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToolsDetector.Name = "lblToolsDetector";
            this.lblToolsDetector.Size = new System.Drawing.Size(93, 24);
            this.lblToolsDetector.Text = "<Detektor>";
            // 
            // lblToolsInterface
            // 
            this.lblToolsInterface.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblToolsInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToolsInterface.Name = "lblToolsInterface";
            this.lblToolsInterface.Size = new System.Drawing.Size(112, 24);
            this.lblToolsInterface.Text = "<Grensesnitt>";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdmGeoNew
            // 
            this.btnAdmGeoNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmGeoNew.Image")));
            this.btnAdmGeoNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmGeoNew.Name = "btnAdmGeoNew";
            this.btnAdmGeoNew.Size = new System.Drawing.Size(112, 24);
            this.btnAdmGeoNew.Text = "Ny geometri";
            this.btnAdmGeoNew.Click += new System.EventHandler(this.btnAdmGeoNew_Click);
            // 
            // btnAdmQANew
            // 
            this.btnAdmQANew.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmQANew.Image")));
            this.btnAdmQANew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmQANew.Name = "btnAdmQANew";
            this.btnAdmQANew.Size = new System.Drawing.Size(107, 24);
            this.btnAdmQANew.Text = "Ny QA boks";
            this.btnAdmQANew.ToolTipText = "Opprett ny QA boks";
            this.btnAdmQANew.Click += new System.EventHandler(this.btnAdmQANew_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 24);
            this.toolStripLabel1.Text = "Brukernavn :";
            // 
            // lblStatusUsername
            // 
            this.lblStatusUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusUsername.Name = "lblStatusUsername";
            this.lblStatusUsername.Size = new System.Drawing.Size(102, 24);
            this.lblStatusUsername.Text = "<Username>";
            this.lblStatusUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnToolsLogout
            // 
            this.btnToolsLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolsLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToolsLogout.ForeColor = System.Drawing.Color.Blue;
            this.btnToolsLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnToolsLogout.Image")));
            this.btnToolsLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolsLogout.Name = "btnToolsLogout";
            this.btnToolsLogout.Size = new System.Drawing.Size(69, 24);
            this.btnToolsLogout.Text = "Logg Ut";
            this.btnToolsLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMenu);
            this.tabs.Controls.Add(this.tabDetectors);
            this.tabs.Controls.Add(this.tabJobs);
            this.tabs.Controls.Add(this.tabSample);
            this.tabs.Controls.Add(this.tabAdmin);
            this.tabs.Controls.Add(this.tabArchive);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 55);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1131, 533);
            this.tabs.TabIndex = 3;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabMenu.Controls.Add(this.tableLayoutPanel4);
            this.tabMenu.Location = new System.Drawing.Point(4, 26);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Size = new System.Drawing.Size(1123, 503);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Meny";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnMenuArchive, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuJobs, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuBkgSample, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuRegSample, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuBarcodeWizardBkg, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuBarcodeWizard, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuBarcodeWizardRef, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnMenuRefSample, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1117, 499);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnMenuArchive
            // 
            this.btnMenuArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuArchive.FlatAppearance.BorderSize = 0;
            this.btnMenuArchive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuArchive.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuArchive.Image")));
            this.btnMenuArchive.Location = new System.Drawing.Point(375, 324);
            this.btnMenuArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuArchive.Name = "btnMenuArchive";
            this.btnMenuArchive.Size = new System.Drawing.Size(366, 158);
            this.btnMenuArchive.TabIndex = 2;
            this.btnMenuArchive.Text = "Arkiv";
            this.btnMenuArchive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuArchive.UseVisualStyleBackColor = true;
            this.btnMenuArchive.Click += new System.EventHandler(this.btnMenuArchive_Click);
            // 
            // btnMenuJobs
            // 
            this.btnMenuJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuJobs.FlatAppearance.BorderSize = 0;
            this.btnMenuJobs.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuJobs.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuJobs.Image")));
            this.btnMenuJobs.Location = new System.Drawing.Point(3, 324);
            this.btnMenuJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuJobs.Name = "btnMenuJobs";
            this.btnMenuJobs.Size = new System.Drawing.Size(366, 158);
            this.btnMenuJobs.TabIndex = 1;
            this.btnMenuJobs.Text = "Jobber";
            this.btnMenuJobs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuJobs.UseVisualStyleBackColor = true;
            this.btnMenuJobs.Click += new System.EventHandler(this.btnMenuJobs_Click);
            // 
            // btnMenuBkgSample
            // 
            this.btnMenuBkgSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuBkgSample.FlatAppearance.BorderSize = 0;
            this.btnMenuBkgSample.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBkgSample.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBkgSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBkgSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBkgSample.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBkgSample.Image")));
            this.btnMenuBkgSample.Location = new System.Drawing.Point(748, 4);
            this.btnMenuBkgSample.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuBkgSample.Name = "btnMenuBkgSample";
            this.btnMenuBkgSample.Size = new System.Drawing.Size(365, 153);
            this.btnMenuBkgSample.TabIndex = 6;
            this.btnMenuBkgSample.Text = "Bakgrunn";
            this.btnMenuBkgSample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuBkgSample.UseVisualStyleBackColor = true;
            this.btnMenuBkgSample.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // btnMenuRegSample
            // 
            this.btnMenuRegSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuRegSample.FlatAppearance.BorderSize = 0;
            this.btnMenuRegSample.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuRegSample.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuRegSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegSample.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuRegSample.Image")));
            this.btnMenuRegSample.Location = new System.Drawing.Point(3, 2);
            this.btnMenuRegSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuRegSample.Name = "btnMenuRegSample";
            this.btnMenuRegSample.Size = new System.Drawing.Size(366, 157);
            this.btnMenuRegSample.TabIndex = 1;
            this.btnMenuRegSample.Text = "Prøve";
            this.btnMenuRegSample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuRegSample.UseVisualStyleBackColor = true;
            this.btnMenuRegSample.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // btnMenuBarcodeWizardBkg
            // 
            this.btnMenuBarcodeWizardBkg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuBarcodeWizardBkg.FlatAppearance.BorderSize = 0;
            this.btnMenuBarcodeWizardBkg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizardBkg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizardBkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBarcodeWizardBkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBarcodeWizardBkg.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBarcodeWizardBkg.Image")));
            this.btnMenuBarcodeWizardBkg.Location = new System.Drawing.Point(747, 163);
            this.btnMenuBarcodeWizardBkg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuBarcodeWizardBkg.Name = "btnMenuBarcodeWizardBkg";
            this.btnMenuBarcodeWizardBkg.Size = new System.Drawing.Size(367, 157);
            this.btnMenuBarcodeWizardBkg.TabIndex = 4;
            this.btnMenuBarcodeWizardBkg.Text = "Strekkode Bakgrunn";
            this.btnMenuBarcodeWizardBkg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuBarcodeWizardBkg.UseVisualStyleBackColor = true;
            this.btnMenuBarcodeWizardBkg.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // btnMenuBarcodeWizard
            // 
            this.btnMenuBarcodeWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuBarcodeWizard.FlatAppearance.BorderSize = 0;
            this.btnMenuBarcodeWizard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBarcodeWizard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBarcodeWizard.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBarcodeWizard.Image")));
            this.btnMenuBarcodeWizard.Location = new System.Drawing.Point(3, 163);
            this.btnMenuBarcodeWizard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuBarcodeWizard.Name = "btnMenuBarcodeWizard";
            this.btnMenuBarcodeWizard.Size = new System.Drawing.Size(366, 157);
            this.btnMenuBarcodeWizard.TabIndex = 3;
            this.btnMenuBarcodeWizard.Text = "Strekkode Prøve";
            this.btnMenuBarcodeWizard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuBarcodeWizard.UseVisualStyleBackColor = true;
            this.btnMenuBarcodeWizard.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // btnMenuBarcodeWizardRef
            // 
            this.btnMenuBarcodeWizardRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuBarcodeWizardRef.FlatAppearance.BorderSize = 0;
            this.btnMenuBarcodeWizardRef.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizardRef.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuBarcodeWizardRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBarcodeWizardRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBarcodeWizardRef.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuBarcodeWizardRef.Image")));
            this.btnMenuBarcodeWizardRef.Location = new System.Drawing.Point(375, 163);
            this.btnMenuBarcodeWizardRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuBarcodeWizardRef.Name = "btnMenuBarcodeWizardRef";
            this.btnMenuBarcodeWizardRef.Size = new System.Drawing.Size(366, 157);
            this.btnMenuBarcodeWizardRef.TabIndex = 5;
            this.btnMenuBarcodeWizardRef.Text = "Strekkode Ref. Måling";
            this.btnMenuBarcodeWizardRef.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuBarcodeWizardRef.UseVisualStyleBackColor = true;
            this.btnMenuBarcodeWizardRef.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // btnMenuRefSample
            // 
            this.btnMenuRefSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuRefSample.FlatAppearance.BorderSize = 0;
            this.btnMenuRefSample.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuRefSample.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenuRefSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRefSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRefSample.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuRefSample.Image")));
            this.btnMenuRefSample.Location = new System.Drawing.Point(376, 4);
            this.btnMenuRefSample.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuRefSample.Name = "btnMenuRefSample";
            this.btnMenuRefSample.Size = new System.Drawing.Size(364, 153);
            this.btnMenuRefSample.TabIndex = 9;
            this.btnMenuRefSample.Text = "Referanse";
            this.btnMenuRefSample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuRefSample.UseVisualStyleBackColor = true;
            this.btnMenuRefSample.Click += new System.EventHandler(this.btnMenuSample_Click);
            // 
            // tabDetectors
            // 
            this.tabDetectors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabDetectors.Controls.Add(this.lvDetectors);
            this.tabDetectors.Location = new System.Drawing.Point(4, 26);
            this.tabDetectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDetectors.Name = "tabDetectors";
            this.tabDetectors.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDetectors.Size = new System.Drawing.Size(1123, 503);
            this.tabDetectors.TabIndex = 1;
            this.tabDetectors.Text = "Detektorer";
            // 
            // lvDetectors
            // 
            this.lvDetectors.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvDetectors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvDetectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDetectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetectors.LargeImageList = this.ilDetector;
            this.lvDetectors.Location = new System.Drawing.Point(3, 2);
            this.lvDetectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDetectors.Name = "lvDetectors";
            this.lvDetectors.Size = new System.Drawing.Size(1117, 499);
            this.lvDetectors.TabIndex = 0;
            this.lvDetectors.UseCompatibleStateImageBehavior = false;
            this.lvDetectors.SelectedIndexChanged += new System.EventHandler(this.lvDetectors_SelectedIndexChanged);
            // 
            // ilDetector
            // 
            this.ilDetector.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDetector.ImageStream")));
            this.ilDetector.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDetector.Images.SetKeyName(0, "detector64.png");
            // 
            // tabJobs
            // 
            this.tabJobs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabJobs.Controls.Add(this.panel28);
            this.tabJobs.Controls.Add(this.panel27);
            this.tabJobs.Location = new System.Drawing.Point(4, 26);
            this.tabJobs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabJobs.Size = new System.Drawing.Size(1123, 503);
            this.tabJobs.TabIndex = 2;
            this.tabJobs.Text = "Jobber";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.gridJobs);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(3, 2);
            this.panel28.Margin = new System.Windows.Forms.Padding(4);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(947, 499);
            this.panel28.TabIndex = 1;
            // 
            // gridJobs
            // 
            this.gridJobs.AllowUserToAddRows = false;
            this.gridJobs.AllowUserToDeleteRows = false;
            this.gridJobs.AllowUserToResizeRows = false;
            this.gridJobs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detector,
            this.JobStatus});
            this.gridJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJobs.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridJobs.Location = new System.Drawing.Point(0, 0);
            this.gridJobs.Margin = new System.Windows.Forms.Padding(4);
            this.gridJobs.MultiSelect = false;
            this.gridJobs.Name = "gridJobs";
            this.gridJobs.ReadOnly = true;
            this.gridJobs.RowHeadersVisible = false;
            this.gridJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridJobs.Size = new System.Drawing.Size(947, 499);
            this.gridJobs.TabIndex = 0;
            // 
            // Detector
            // 
            this.Detector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detector.HeaderText = "Detektor";
            this.Detector.Name = "Detector";
            this.Detector.ReadOnly = true;
            // 
            // JobStatus
            // 
            this.JobStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JobStatus.HeaderText = "Status";
            this.JobStatus.Name = "JobStatus";
            this.JobStatus.ReadOnly = true;
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel27.Controls.Add(this.btnJobShow);
            this.panel27.Controls.Add(this.btnJobsShowOutput);
            this.panel27.Controls.Add(this.btnJobOpenSpectrum);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel27.Location = new System.Drawing.Point(950, 2);
            this.panel27.Margin = new System.Windows.Forms.Padding(4);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(170, 499);
            this.panel27.TabIndex = 0;
            // 
            // btnJobShow
            // 
            this.btnJobShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobShow.Location = new System.Drawing.Point(0, 62);
            this.btnJobShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobShow.Name = "btnJobShow";
            this.btnJobShow.Size = new System.Drawing.Size(168, 31);
            this.btnJobShow.TabIndex = 6;
            this.btnJobShow.Text = "Behandle Rapport";
            this.btnJobShow.UseVisualStyleBackColor = true;
            this.btnJobShow.Click += new System.EventHandler(this.btnJobShow_Click);
            // 
            // btnJobsShowOutput
            // 
            this.btnJobsShowOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobsShowOutput.Location = new System.Drawing.Point(0, 31);
            this.btnJobsShowOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobsShowOutput.Name = "btnJobsShowOutput";
            this.btnJobsShowOutput.Size = new System.Drawing.Size(168, 31);
            this.btnJobsShowOutput.TabIndex = 5;
            this.btnJobsShowOutput.Text = "Vis Logg";
            this.btnJobsShowOutput.UseVisualStyleBackColor = true;
            this.btnJobsShowOutput.Click += new System.EventHandler(this.btnJobsShowOutput_Click);
            // 
            // btnJobOpenSpectrum
            // 
            this.btnJobOpenSpectrum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobOpenSpectrum.Location = new System.Drawing.Point(0, 0);
            this.btnJobOpenSpectrum.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobOpenSpectrum.Name = "btnJobOpenSpectrum";
            this.btnJobOpenSpectrum.Size = new System.Drawing.Size(168, 31);
            this.btnJobOpenSpectrum.TabIndex = 1;
            this.btnJobOpenSpectrum.Text = "Vis Spektrum";
            this.btnJobOpenSpectrum.UseVisualStyleBackColor = true;
            this.btnJobOpenSpectrum.Click += new System.EventHandler(this.btnJobOpenSpectrum_Click);
            // 
            // tabSample
            // 
            this.tabSample.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSample.Controls.Add(this.tabsSamples);
            this.tabSample.Controls.Add(this.panel26);
            this.tabSample.Controls.Add(this.panel24);
            this.tabSample.Location = new System.Drawing.Point(4, 26);
            this.tabSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSample.Name = "tabSample";
            this.tabSample.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSample.Size = new System.Drawing.Size(1123, 503);
            this.tabSample.TabIndex = 3;
            this.tabSample.Text = "Prøveinfo";
            // 
            // tabsSamples
            // 
            this.tabsSamples.Controls.Add(this.tabSamplesParams);
            this.tabsSamples.Controls.Add(this.tabSamplesAdvancedParams);
            this.tabsSamples.Controls.Add(this.tabSamplesAnalParams);
            this.tabsSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsSamples.Location = new System.Drawing.Point(3, 34);
            this.tabsSamples.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsSamples.Name = "tabsSamples";
            this.tabsSamples.SelectedIndex = 0;
            this.tabsSamples.Size = new System.Drawing.Size(1117, 439);
            this.tabsSamples.TabIndex = 0;
            // 
            // tabSamplesParams
            // 
            this.tabSamplesParams.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSamplesParams.Controls.Add(this.splitSamples);
            this.tabSamplesParams.Location = new System.Drawing.Point(4, 25);
            this.tabSamplesParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSamplesParams.Name = "tabSamplesParams";
            this.tabSamplesParams.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSamplesParams.Size = new System.Drawing.Size(1109, 410);
            this.tabSamplesParams.TabIndex = 0;
            this.tabSamplesParams.Text = "Parametere";
            // 
            // splitSamples
            // 
            this.splitSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSamples.Location = new System.Drawing.Point(3, 2);
            this.splitSamples.Margin = new System.Windows.Forms.Padding(0);
            this.splitSamples.Name = "splitSamples";
            this.splitSamples.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSamples.Panel1
            // 
            this.splitSamples.Panel1.Controls.Add(this.layoutSamples);
            // 
            // splitSamples.Panel2
            // 
            this.splitSamples.Panel2.Controls.Add(this.tabsBuildup);
            this.splitSamples.Size = new System.Drawing.Size(1103, 406);
            this.splitSamples.SplitterDistance = 263;
            this.splitSamples.TabIndex = 0;
            // 
            // layoutSamples
            // 
            this.layoutSamples.ColumnCount = 4;
            this.layoutSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutSamples.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutSamples.Controls.Add(this.panel1, 0, 0);
            this.layoutSamples.Controls.Add(this.panel2, 1, 0);
            this.layoutSamples.Controls.Add(this.panel3, 2, 0);
            this.layoutSamples.Controls.Add(this.panel4, 3, 0);
            this.layoutSamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSamples.Location = new System.Drawing.Point(0, 0);
            this.layoutSamples.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutSamples.Name = "layoutSamples";
            this.layoutSamples.RowCount = 1;
            this.layoutSamples.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSamples.Size = new System.Drawing.Size(1103, 263);
            this.layoutSamples.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSampGeom);
            this.panel1.Controls.Add(this.lblSampType);
            this.panel1.Controls.Add(this.lblSampID);
            this.panel1.Controls.Add(this.lblSampDesc);
            this.panel1.Controls.Add(this.lblSampOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 259);
            this.panel1.TabIndex = 0;
            // 
            // lblSampGeom
            // 
            this.lblSampGeom.AutoSize = true;
            this.lblSampGeom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampGeom.Location = new System.Drawing.Point(0, 100);
            this.lblSampGeom.Name = "lblSampGeom";
            this.lblSampGeom.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampGeom.Size = new System.Drawing.Size(104, 25);
            this.lblSampGeom.TabIndex = 5;
            this.lblSampGeom.Text = "Prøve geometri";
            // 
            // lblSampType
            // 
            this.lblSampType.AutoSize = true;
            this.lblSampType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampType.Location = new System.Drawing.Point(0, 75);
            this.lblSampType.Name = "lblSampType";
            this.lblSampType.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampType.Size = new System.Drawing.Size(72, 25);
            this.lblSampType.TabIndex = 3;
            this.lblSampType.Text = "Prøvetype";
            // 
            // lblSampID
            // 
            this.lblSampID.AutoSize = true;
            this.lblSampID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampID.Location = new System.Drawing.Point(0, 50);
            this.lblSampID.Name = "lblSampID";
            this.lblSampID.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampID.Size = new System.Drawing.Size(62, 25);
            this.lblSampID.TabIndex = 2;
            this.lblSampID.Text = "Prøve ID";
            // 
            // lblSampDesc
            // 
            this.lblSampDesc.AutoSize = true;
            this.lblSampDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampDesc.Location = new System.Drawing.Point(0, 25);
            this.lblSampDesc.Name = "lblSampDesc";
            this.lblSampDesc.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampDesc.Size = new System.Drawing.Size(80, 25);
            this.lblSampDesc.TabIndex = 1;
            this.lblSampDesc.Text = "Beskrivelse";
            // 
            // lblSampOrder
            // 
            this.lblSampOrder.AutoSize = true;
            this.lblSampOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampOrder.Location = new System.Drawing.Point(0, 0);
            this.lblSampOrder.Name = "lblSampOrder";
            this.lblSampOrder.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampOrder.Size = new System.Drawing.Size(45, 25);
            this.lblSampOrder.TabIndex = 0;
            this.lblSampOrder.Text = "Ordre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboxSampGeom);
            this.panel2.Controls.Add(this.tbSampType);
            this.panel2.Controls.Add(this.tbSampID);
            this.panel2.Controls.Add(this.tbSampDesc);
            this.panel2.Controls.Add(this.tbSampOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(168, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 259);
            this.panel2.TabIndex = 1;
            // 
            // cboxSampGeom
            // 
            this.cboxSampGeom.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampGeom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampGeom.FormattingEnabled = true;
            this.cboxSampGeom.Location = new System.Drawing.Point(0, 88);
            this.cboxSampGeom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampGeom.Name = "cboxSampGeom";
            this.cboxSampGeom.Size = new System.Drawing.Size(380, 24);
            this.cboxSampGeom.TabIndex = 5;
            this.cboxSampGeom.SelectedIndexChanged += new System.EventHandler(this.cboxSampGeom_SelectedIndexChanged);
            // 
            // tbSampType
            // 
            this.tbSampType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampType.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampType.Location = new System.Drawing.Point(0, 66);
            this.tbSampType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampType.MaxLength = 16;
            this.tbSampType.Name = "tbSampType";
            this.tbSampType.Size = new System.Drawing.Size(380, 22);
            this.tbSampType.TabIndex = 3;
            // 
            // tbSampID
            // 
            this.tbSampID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampID.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampID.Location = new System.Drawing.Point(0, 44);
            this.tbSampID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampID.MaxLength = 16;
            this.tbSampID.Name = "tbSampID";
            this.tbSampID.Size = new System.Drawing.Size(380, 22);
            this.tbSampID.TabIndex = 2;
            // 
            // tbSampDesc
            // 
            this.tbSampDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampDesc.Location = new System.Drawing.Point(0, 22);
            this.tbSampDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampDesc.MaxLength = 64;
            this.tbSampDesc.Name = "tbSampDesc";
            this.tbSampDesc.Size = new System.Drawing.Size(380, 22);
            this.tbSampDesc.TabIndex = 1;
            // 
            // tbSampOrder
            // 
            this.tbSampOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampOrder.Location = new System.Drawing.Point(0, 0);
            this.tbSampOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampOrder.MaxLength = 64;
            this.tbSampOrder.Name = "tbSampOrder";
            this.tbSampOrder.Size = new System.Drawing.Size(380, 22);
            this.tbSampOrder.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSampComment);
            this.panel3.Controls.Add(this.lblSampCollector);
            this.panel3.Controls.Add(this.lblSampRef);
            this.panel3.Controls.Add(this.lblSampQuantUnc);
            this.panel3.Controls.Add(this.lblSampQuantUnit);
            this.panel3.Controls.Add(this.lblSampQuant);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(554, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 259);
            this.panel3.TabIndex = 2;
            // 
            // lblSampComment
            // 
            this.lblSampComment.AutoSize = true;
            this.lblSampComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampComment.Location = new System.Drawing.Point(0, 125);
            this.lblSampComment.Name = "lblSampComment";
            this.lblSampComment.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblSampComment.Size = new System.Drawing.Size(80, 23);
            this.lblSampComment.TabIndex = 6;
            this.lblSampComment.Text = "Kommentar";
            // 
            // lblSampCollector
            // 
            this.lblSampCollector.AutoSize = true;
            this.lblSampCollector.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampCollector.Location = new System.Drawing.Point(0, 100);
            this.lblSampCollector.Name = "lblSampCollector";
            this.lblSampCollector.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampCollector.Size = new System.Drawing.Size(69, 25);
            this.lblSampCollector.TabIndex = 5;
            this.lblSampCollector.Text = "Startet av";
            // 
            // lblSampRef
            // 
            this.lblSampRef.AutoSize = true;
            this.lblSampRef.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampRef.Location = new System.Drawing.Point(0, 75);
            this.lblSampRef.Name = "lblSampRef";
            this.lblSampRef.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampRef.Size = new System.Drawing.Size(82, 25);
            this.lblSampRef.TabIndex = 4;
            this.lblSampRef.Text = "Spekter ref.";
            // 
            // lblSampQuantUnc
            // 
            this.lblSampQuantUnc.AutoSize = true;
            this.lblSampQuantUnc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampQuantUnc.Location = new System.Drawing.Point(0, 50);
            this.lblSampQuantUnc.Name = "lblSampQuantUnc";
            this.lblSampQuantUnc.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampQuantUnc.Size = new System.Drawing.Size(113, 25);
            this.lblSampQuantUnc.TabIndex = 3;
            this.lblSampQuantUnc.Text = "Usikkerhet (Abs)";
            // 
            // lblSampQuantUnit
            // 
            this.lblSampQuantUnit.AutoSize = true;
            this.lblSampQuantUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampQuantUnit.Location = new System.Drawing.Point(0, 25);
            this.lblSampQuantUnit.Name = "lblSampQuantUnit";
            this.lblSampQuantUnit.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampQuantUnit.Size = new System.Drawing.Size(45, 25);
            this.lblSampQuantUnit.TabIndex = 2;
            this.lblSampQuantUnit.Text = "Enhet";
            // 
            // lblSampQuant
            // 
            this.lblSampQuant.AutoSize = true;
            this.lblSampQuant.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSampQuant.Location = new System.Drawing.Point(0, 0);
            this.lblSampQuant.Name = "lblSampQuant";
            this.lblSampQuant.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.lblSampQuant.Size = new System.Drawing.Size(96, 25);
            this.lblSampQuant.TabIndex = 0;
            this.lblSampQuant.Text = "Prøvemengde";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbSampComment);
            this.panel4.Controls.Add(this.tbSampCollector);
            this.panel4.Controls.Add(this.tbSampRef);
            this.panel4.Controls.Add(this.tbSampQuantUnc);
            this.panel4.Controls.Add(this.cboxSampQuantUnit);
            this.panel4.Controls.Add(this.tbSampQuant);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(719, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(381, 259);
            this.panel4.TabIndex = 3;
            // 
            // tbSampComment
            // 
            this.tbSampComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampComment.Location = new System.Drawing.Point(0, 112);
            this.tbSampComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampComment.MaxLength = 256;
            this.tbSampComment.Multiline = true;
            this.tbSampComment.Name = "tbSampComment";
            this.tbSampComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSampComment.Size = new System.Drawing.Size(381, 147);
            this.tbSampComment.TabIndex = 8;
            // 
            // tbSampCollector
            // 
            this.tbSampCollector.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampCollector.Enabled = false;
            this.tbSampCollector.Location = new System.Drawing.Point(0, 90);
            this.tbSampCollector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampCollector.MaxLength = 24;
            this.tbSampCollector.Name = "tbSampCollector";
            this.tbSampCollector.Size = new System.Drawing.Size(381, 22);
            this.tbSampCollector.TabIndex = 7;
            // 
            // tbSampRef
            // 
            this.tbSampRef.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampRef.Enabled = false;
            this.tbSampRef.Location = new System.Drawing.Point(0, 68);
            this.tbSampRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampRef.MaxLength = 64;
            this.tbSampRef.Name = "tbSampRef";
            this.tbSampRef.Size = new System.Drawing.Size(381, 22);
            this.tbSampRef.TabIndex = 6;
            // 
            // tbSampQuantUnc
            // 
            this.tbSampQuantUnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampQuantUnc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampQuantUnc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSampQuantUnc.Location = new System.Drawing.Point(0, 46);
            this.tbSampQuantUnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampQuantUnc.MaxLength = 16;
            this.tbSampQuantUnc.Name = "tbSampQuantUnc";
            this.tbSampQuantUnc.Size = new System.Drawing.Size(381, 22);
            this.tbSampQuantUnc.TabIndex = 5;
            this.tbSampQuantUnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // cboxSampQuantUnit
            // 
            this.cboxSampQuantUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampQuantUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampQuantUnit.FormattingEnabled = true;
            this.cboxSampQuantUnit.Items.AddRange(new object[] {
            "g",
            "Kg"});
            this.cboxSampQuantUnit.Location = new System.Drawing.Point(0, 22);
            this.cboxSampQuantUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampQuantUnit.Name = "cboxSampQuantUnit";
            this.cboxSampQuantUnit.Size = new System.Drawing.Size(381, 24);
            this.cboxSampQuantUnit.TabIndex = 4;
            // 
            // tbSampQuant
            // 
            this.tbSampQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampQuant.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampQuant.Location = new System.Drawing.Point(0, 0);
            this.tbSampQuant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampQuant.MaxLength = 16;
            this.tbSampQuant.Name = "tbSampQuant";
            this.tbSampQuant.Size = new System.Drawing.Size(381, 22);
            this.tbSampQuant.TabIndex = 0;
            this.tbSampQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // tabsBuildup
            // 
            this.tabsBuildup.Controls.Add(this.tabBuildupNone);
            this.tabsBuildup.Controls.Add(this.tabBuildupIrrad);
            this.tabsBuildup.Controls.Add(this.tabBuildupDeposit);
            this.tabsBuildup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsBuildup.Location = new System.Drawing.Point(0, 0);
            this.tabsBuildup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsBuildup.Name = "tabsBuildup";
            this.tabsBuildup.SelectedIndex = 0;
            this.tabsBuildup.Size = new System.Drawing.Size(1103, 139);
            this.tabsBuildup.TabIndex = 0;
            // 
            // tabBuildupNone
            // 
            this.tabBuildupNone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabBuildupNone.Controls.Add(this.panel11);
            this.tabBuildupNone.Location = new System.Drawing.Point(4, 25);
            this.tabBuildupNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupNone.Name = "tabBuildupNone";
            this.tabBuildupNone.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupNone.Size = new System.Drawing.Size(1095, 110);
            this.tabBuildupNone.TabIndex = 0;
            this.tabBuildupNone.Text = "None";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel16);
            this.panel11.Controls.Add(this.label21);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(3, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(292, 106);
            this.panel11.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.dtSampBuildNoneTime);
            this.panel16.Controls.Add(this.dtSampBuildNoneDate);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 21);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(292, 27);
            this.panel16.TabIndex = 3;
            // 
            // dtSampBuildNoneTime
            // 
            this.dtSampBuildNoneTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSampBuildNoneTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSampBuildNoneTime.Location = new System.Drawing.Point(153, 0);
            this.dtSampBuildNoneTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildNoneTime.Name = "dtSampBuildNoneTime";
            this.dtSampBuildNoneTime.ShowUpDown = true;
            this.dtSampBuildNoneTime.Size = new System.Drawing.Size(139, 22);
            this.dtSampBuildNoneTime.TabIndex = 1;
            // 
            // dtSampBuildNoneDate
            // 
            this.dtSampBuildNoneDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtSampBuildNoneDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSampBuildNoneDate.Location = new System.Drawing.Point(0, 0);
            this.dtSampBuildNoneDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildNoneDate.Name = "dtSampBuildNoneDate";
            this.dtSampBuildNoneDate.Size = new System.Drawing.Size(153, 22);
            this.dtSampBuildNoneDate.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label21.Size = new System.Drawing.Size(102, 21);
            this.label21.TabIndex = 2;
            this.label21.Text = "Referansedato";
            // 
            // tabBuildupIrrad
            // 
            this.tabBuildupIrrad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabBuildupIrrad.Controls.Add(this.panel12);
            this.tabBuildupIrrad.Location = new System.Drawing.Point(4, 25);
            this.tabBuildupIrrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupIrrad.Name = "tabBuildupIrrad";
            this.tabBuildupIrrad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupIrrad.Size = new System.Drawing.Size(1095, 110);
            this.tabBuildupIrrad.TabIndex = 1;
            this.tabBuildupIrrad.Text = "Irrad";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel14);
            this.panel12.Controls.Add(this.label23);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.label22);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(3, 2);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(292, 106);
            this.panel12.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dtSampBuildIrradTimeTo);
            this.panel14.Controls.Add(this.dtSampBuildIrradDateTo);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 69);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(292, 27);
            this.panel14.TabIndex = 4;
            // 
            // dtSampBuildIrradTimeTo
            // 
            this.dtSampBuildIrradTimeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSampBuildIrradTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSampBuildIrradTimeTo.Location = new System.Drawing.Point(153, 0);
            this.dtSampBuildIrradTimeTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildIrradTimeTo.Name = "dtSampBuildIrradTimeTo";
            this.dtSampBuildIrradTimeTo.ShowUpDown = true;
            this.dtSampBuildIrradTimeTo.Size = new System.Drawing.Size(139, 22);
            this.dtSampBuildIrradTimeTo.TabIndex = 1;
            // 
            // dtSampBuildIrradDateTo
            // 
            this.dtSampBuildIrradDateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtSampBuildIrradDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSampBuildIrradDateTo.Location = new System.Drawing.Point(0, 0);
            this.dtSampBuildIrradDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildIrradDateTo.Name = "dtSampBuildIrradDateTo";
            this.dtSampBuildIrradDateTo.Size = new System.Drawing.Size(153, 22);
            this.dtSampBuildIrradDateTo.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Location = new System.Drawing.Point(0, 48);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label23.Size = new System.Drawing.Size(121, 21);
            this.label23.TabIndex = 5;
            this.label23.Text = "Referansedato Til";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dtSampBuildIrradTimeFrom);
            this.panel13.Controls.Add(this.dtSampBuildIrradDateFrom);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 21);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(292, 27);
            this.panel13.TabIndex = 3;
            // 
            // dtSampBuildIrradTimeFrom
            // 
            this.dtSampBuildIrradTimeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSampBuildIrradTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSampBuildIrradTimeFrom.Location = new System.Drawing.Point(153, 0);
            this.dtSampBuildIrradTimeFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildIrradTimeFrom.Name = "dtSampBuildIrradTimeFrom";
            this.dtSampBuildIrradTimeFrom.ShowUpDown = true;
            this.dtSampBuildIrradTimeFrom.Size = new System.Drawing.Size(139, 22);
            this.dtSampBuildIrradTimeFrom.TabIndex = 1;
            // 
            // dtSampBuildIrradDateFrom
            // 
            this.dtSampBuildIrradDateFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtSampBuildIrradDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSampBuildIrradDateFrom.Location = new System.Drawing.Point(0, 0);
            this.dtSampBuildIrradDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildIrradDateFrom.Name = "dtSampBuildIrradDateFrom";
            this.dtSampBuildIrradDateFrom.Size = new System.Drawing.Size(153, 22);
            this.dtSampBuildIrradDateFrom.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Top;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label22.Size = new System.Drawing.Size(127, 21);
            this.label22.TabIndex = 2;
            this.label22.Text = "Referansedato Fra";
            // 
            // tabBuildupDeposit
            // 
            this.tabBuildupDeposit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabBuildupDeposit.Controls.Add(this.panel15);
            this.tabBuildupDeposit.Location = new System.Drawing.Point(4, 25);
            this.tabBuildupDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupDeposit.Name = "tabBuildupDeposit";
            this.tabBuildupDeposit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBuildupDeposit.Size = new System.Drawing.Size(1095, 110);
            this.tabBuildupDeposit.TabIndex = 2;
            this.tabBuildupDeposit.Text = "Deposit";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.label24);
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.label25);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(3, 2);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(292, 106);
            this.panel15.TabIndex = 2;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dtSampBuildDepTimeTo);
            this.panel17.Controls.Add(this.dtSampBuildDepDateTo);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 69);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(292, 27);
            this.panel17.TabIndex = 4;
            // 
            // dtSampBuildDepTimeTo
            // 
            this.dtSampBuildDepTimeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSampBuildDepTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSampBuildDepTimeTo.Location = new System.Drawing.Point(153, 0);
            this.dtSampBuildDepTimeTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildDepTimeTo.Name = "dtSampBuildDepTimeTo";
            this.dtSampBuildDepTimeTo.ShowUpDown = true;
            this.dtSampBuildDepTimeTo.Size = new System.Drawing.Size(139, 22);
            this.dtSampBuildDepTimeTo.TabIndex = 1;
            // 
            // dtSampBuildDepDateTo
            // 
            this.dtSampBuildDepDateTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtSampBuildDepDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSampBuildDepDateTo.Location = new System.Drawing.Point(0, 0);
            this.dtSampBuildDepDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildDepDateTo.Name = "dtSampBuildDepDateTo";
            this.dtSampBuildDepDateTo.Size = new System.Drawing.Size(153, 22);
            this.dtSampBuildDepDateTo.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Top;
            this.label24.Location = new System.Drawing.Point(0, 48);
            this.label24.Name = "label24";
            this.label24.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label24.Size = new System.Drawing.Size(121, 21);
            this.label24.TabIndex = 5;
            this.label24.Text = "Referansedato Til";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dtSampBuildDepTimeFrom);
            this.panel18.Controls.Add(this.dtSampBuildDepDateFrom);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 21);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(292, 27);
            this.panel18.TabIndex = 3;
            // 
            // dtSampBuildDepTimeFrom
            // 
            this.dtSampBuildDepTimeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSampBuildDepTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtSampBuildDepTimeFrom.Location = new System.Drawing.Point(153, 0);
            this.dtSampBuildDepTimeFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildDepTimeFrom.Name = "dtSampBuildDepTimeFrom";
            this.dtSampBuildDepTimeFrom.ShowUpDown = true;
            this.dtSampBuildDepTimeFrom.Size = new System.Drawing.Size(139, 22);
            this.dtSampBuildDepTimeFrom.TabIndex = 1;
            // 
            // dtSampBuildDepDateFrom
            // 
            this.dtSampBuildDepDateFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtSampBuildDepDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSampBuildDepDateFrom.Location = new System.Drawing.Point(0, 0);
            this.dtSampBuildDepDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSampBuildDepDateFrom.Name = "dtSampBuildDepDateFrom";
            this.dtSampBuildDepDateFrom.Size = new System.Drawing.Size(153, 22);
            this.dtSampBuildDepDateFrom.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label25.Size = new System.Drawing.Size(127, 21);
            this.label25.TabIndex = 2;
            this.label25.Text = "Referansedato Fra";
            // 
            // tabSamplesAdvancedParams
            // 
            this.tabSamplesAdvancedParams.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSamplesAdvancedParams.Controls.Add(this.layoutSamplesAdvanced);
            this.tabSamplesAdvancedParams.Location = new System.Drawing.Point(4, 25);
            this.tabSamplesAdvancedParams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSamplesAdvancedParams.Name = "tabSamplesAdvancedParams";
            this.tabSamplesAdvancedParams.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSamplesAdvancedParams.Size = new System.Drawing.Size(1109, 410);
            this.tabSamplesAdvancedParams.TabIndex = 1;
            this.tabSamplesAdvancedParams.Text = "Preset Parametere";
            // 
            // layoutSamplesAdvanced
            // 
            this.layoutSamplesAdvanced.ColumnCount = 6;
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.layoutSamplesAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.layoutSamplesAdvanced.Controls.Add(this.panel5, 0, 0);
            this.layoutSamplesAdvanced.Controls.Add(this.panel6, 1, 0);
            this.layoutSamplesAdvanced.Controls.Add(this.panel7, 2, 0);
            this.layoutSamplesAdvanced.Controls.Add(this.panel8, 3, 0);
            this.layoutSamplesAdvanced.Controls.Add(this.panel9, 4, 0);
            this.layoutSamplesAdvanced.Controls.Add(this.panel10, 5, 0);
            this.layoutSamplesAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSamplesAdvanced.Location = new System.Drawing.Point(3, 2);
            this.layoutSamplesAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutSamplesAdvanced.Name = "layoutSamplesAdvanced";
            this.layoutSamplesAdvanced.RowCount = 1;
            this.layoutSamplesAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSamplesAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.layoutSamplesAdvanced.Size = new System.Drawing.Size(1103, 406);
            this.layoutSamplesAdvanced.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(116, 402);
            this.panel5.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(0, 50);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "System. Err (%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 25);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label12.Size = new System.Drawing.Size(110, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Random Err (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cal fil";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSampAdvSystErr);
            this.panel6.Controls.Add(this.tbSampAdvRandErr);
            this.panel6.Controls.Add(this.cboxSampAdvCal);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(125, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 402);
            this.panel6.TabIndex = 1;
            // 
            // tbSampAdvSystErr
            // 
            this.tbSampAdvSystErr.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvSystErr.Location = new System.Drawing.Point(0, 46);
            this.tbSampAdvSystErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvSystErr.MaxLength = 16;
            this.tbSampAdvSystErr.Name = "tbSampAdvSystErr";
            this.tbSampAdvSystErr.Size = new System.Drawing.Size(239, 22);
            this.tbSampAdvSystErr.TabIndex = 2;
            this.tbSampAdvSystErr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // tbSampAdvRandErr
            // 
            this.tbSampAdvRandErr.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvRandErr.Location = new System.Drawing.Point(0, 24);
            this.tbSampAdvRandErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvRandErr.MaxLength = 16;
            this.tbSampAdvRandErr.Name = "tbSampAdvRandErr";
            this.tbSampAdvRandErr.Size = new System.Drawing.Size(239, 22);
            this.tbSampAdvRandErr.TabIndex = 1;
            this.tbSampAdvRandErr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // cboxSampAdvCal
            // 
            this.cboxSampAdvCal.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampAdvCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAdvCal.FormattingEnabled = true;
            this.cboxSampAdvCal.Location = new System.Drawing.Point(0, 0);
            this.cboxSampAdvCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAdvCal.Name = "cboxSampAdvCal";
            this.cboxSampAdvCal.Size = new System.Drawing.Size(239, 24);
            this.cboxSampAdvCal.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(370, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(116, 402);
            this.panel7.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(0, 75);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label17.Size = new System.Drawing.Size(66, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Chan. To";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(0, 50);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label16.Size = new System.Drawing.Size(81, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Chan. From";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 25);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label15.Size = new System.Drawing.Size(44, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label14.Size = new System.Drawing.Size(83, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Preset Area";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbSampAdvPreAreaChanTo);
            this.panel8.Controls.Add(this.tbSampAdvPreAreaChanFrom);
            this.panel8.Controls.Add(this.tbSampAdvPreAreaValue);
            this.panel8.Controls.Add(this.cboxSampAdvPreArea);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(492, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(239, 402);
            this.panel8.TabIndex = 3;
            // 
            // tbSampAdvPreAreaChanTo
            // 
            this.tbSampAdvPreAreaChanTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvPreAreaChanTo.Location = new System.Drawing.Point(0, 68);
            this.tbSampAdvPreAreaChanTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvPreAreaChanTo.MaxLength = 16;
            this.tbSampAdvPreAreaChanTo.Name = "tbSampAdvPreAreaChanTo";
            this.tbSampAdvPreAreaChanTo.Size = new System.Drawing.Size(239, 22);
            this.tbSampAdvPreAreaChanTo.TabIndex = 3;
            this.tbSampAdvPreAreaChanTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbSampAdvPreAreaChanFrom
            // 
            this.tbSampAdvPreAreaChanFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvPreAreaChanFrom.Location = new System.Drawing.Point(0, 46);
            this.tbSampAdvPreAreaChanFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvPreAreaChanFrom.MaxLength = 16;
            this.tbSampAdvPreAreaChanFrom.Name = "tbSampAdvPreAreaChanFrom";
            this.tbSampAdvPreAreaChanFrom.Size = new System.Drawing.Size(239, 22);
            this.tbSampAdvPreAreaChanFrom.TabIndex = 2;
            this.tbSampAdvPreAreaChanFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbSampAdvPreAreaValue
            // 
            this.tbSampAdvPreAreaValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvPreAreaValue.Location = new System.Drawing.Point(0, 24);
            this.tbSampAdvPreAreaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvPreAreaValue.MaxLength = 16;
            this.tbSampAdvPreAreaValue.Name = "tbSampAdvPreAreaValue";
            this.tbSampAdvPreAreaValue.Size = new System.Drawing.Size(239, 22);
            this.tbSampAdvPreAreaValue.TabIndex = 1;
            this.tbSampAdvPreAreaValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // cboxSampAdvPreArea
            // 
            this.cboxSampAdvPreArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampAdvPreArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAdvPreArea.FormattingEnabled = true;
            this.cboxSampAdvPreArea.Items.AddRange(new object[] {
            "",
            "INTPRESET",
            "AREAPRESET",
            "CNTSPRESET"});
            this.cboxSampAdvPreArea.Location = new System.Drawing.Point(0, 0);
            this.cboxSampAdvPreArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAdvPreArea.Name = "cboxSampAdvPreArea";
            this.cboxSampAdvPreArea.Size = new System.Drawing.Size(239, 24);
            this.cboxSampAdvPreArea.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label20);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(737, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(116, 402);
            this.panel9.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Location = new System.Drawing.Point(0, 50);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label20.Size = new System.Drawing.Size(33, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Unit";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(0, 25);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label19.Size = new System.Drawing.Size(44, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "Value";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 6, 0, 2);
            this.label18.Size = new System.Drawing.Size(84, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Preset Time";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cboxSampAdvPreTimeUnit);
            this.panel10.Controls.Add(this.tbSampAdvPreTimeValue);
            this.panel10.Controls.Add(this.cboxSampAdvPreTime);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(859, 2);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(241, 402);
            this.panel10.TabIndex = 5;
            // 
            // cboxSampAdvPreTimeUnit
            // 
            this.cboxSampAdvPreTimeUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampAdvPreTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAdvPreTimeUnit.FormattingEnabled = true;
            this.cboxSampAdvPreTimeUnit.Items.AddRange(new object[] {
            "Sekunder",
            "Minutter",
            "Timer"});
            this.cboxSampAdvPreTimeUnit.Location = new System.Drawing.Point(0, 46);
            this.cboxSampAdvPreTimeUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAdvPreTimeUnit.Name = "cboxSampAdvPreTimeUnit";
            this.cboxSampAdvPreTimeUnit.Size = new System.Drawing.Size(241, 24);
            this.cboxSampAdvPreTimeUnit.TabIndex = 2;
            // 
            // tbSampAdvPreTimeValue
            // 
            this.tbSampAdvPreTimeValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSampAdvPreTimeValue.Location = new System.Drawing.Point(0, 24);
            this.tbSampAdvPreTimeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAdvPreTimeValue.MaxLength = 16;
            this.tbSampAdvPreTimeValue.Name = "tbSampAdvPreTimeValue";
            this.tbSampAdvPreTimeValue.Size = new System.Drawing.Size(241, 22);
            this.tbSampAdvPreTimeValue.TabIndex = 1;
            this.tbSampAdvPreTimeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // cboxSampAdvPreTime
            // 
            this.cboxSampAdvPreTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboxSampAdvPreTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAdvPreTime.FormattingEnabled = true;
            this.cboxSampAdvPreTime.Items.AddRange(new object[] {
            "",
            "REALPRESET",
            "LIVEPRESET"});
            this.cboxSampAdvPreTime.Location = new System.Drawing.Point(0, 0);
            this.cboxSampAdvPreTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAdvPreTime.Name = "cboxSampAdvPreTime";
            this.cboxSampAdvPreTime.Size = new System.Drawing.Size(241, 24);
            this.cboxSampAdvPreTime.TabIndex = 0;
            // 
            // tabSamplesAnalParams
            // 
            this.tabSamplesAnalParams.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSamplesAnalParams.Controls.Add(this.tableLayoutPanel3);
            this.tabSamplesAnalParams.Location = new System.Drawing.Point(4, 25);
            this.tabSamplesAnalParams.Margin = new System.Windows.Forms.Padding(4);
            this.tabSamplesAnalParams.Name = "tabSamplesAnalParams";
            this.tabSamplesAnalParams.Padding = new System.Windows.Forms.Padding(4);
            this.tabSamplesAnalParams.Size = new System.Drawing.Size(1109, 410);
            this.tabSamplesAnalParams.TabIndex = 2;
            this.tabSamplesAnalParams.Text = "Analyse Parametere";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label68, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalTolerance, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label69, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalSigThresh, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label71, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalContinuum, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label72, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboxSampAnalContinuumFunc, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalCritLev, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalFitSinglets, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalDispRois, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalUseFixed, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalRejectZero, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalFixedFWHM, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label73, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.cboxSampAnalEffCal, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.label74, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalMaxFWHMBetween, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label77, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalMaxFWHMRight, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.label78, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalMaxFWHMLeft, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.label79, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalBkgSub, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.btnSampAnalBkgSub, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.label80, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label81, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalNIDLib, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.btnSampAnalNIDLib, 4, 7);
            this.tableLayoutPanel3.Controls.Add(this.label82, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalNIDConfThresh, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.label83, 3, 8);
            this.tableLayoutPanel3.Controls.Add(this.tbSampAnalMDAConfFac, 4, 8);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalInhibitATD, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalUseStoredLib, 2, 9);
            this.tableLayoutPanel3.Controls.Add(this.cbSampAnalPerformMDA, 3, 9);
            this.tableLayoutPanel3.Controls.Add(this.label66, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label67, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1101, 402);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(223, 11);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(72, 17);
            this.label68.TabIndex = 6;
            this.label68.Text = "Tolerance";
            // 
            // tbSampAnalTolerance
            // 
            this.tbSampAnalTolerance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalTolerance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalTolerance.Location = new System.Drawing.Point(443, 2);
            this.tbSampAnalTolerance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalTolerance.MaxLength = 16;
            this.tbSampAnalTolerance.Name = "tbSampAnalTolerance";
            this.tbSampAnalTolerance.Size = new System.Drawing.Size(214, 22);
            this.tbSampAnalTolerance.TabIndex = 7;
            this.tbSampAnalTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(663, 11);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(137, 17);
            this.label69.TabIndex = 8;
            this.label69.Text = "Significance Thresh.";
            // 
            // tbSampAnalSigThresh
            // 
            this.tbSampAnalSigThresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalSigThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalSigThresh.Location = new System.Drawing.Point(883, 2);
            this.tbSampAnalSigThresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalSigThresh.MaxLength = 16;
            this.tbSampAnalSigThresh.Name = "tbSampAnalSigThresh";
            this.tbSampAnalSigThresh.Size = new System.Drawing.Size(215, 22);
            this.tbSampAnalSigThresh.TabIndex = 9;
            this.tbSampAnalSigThresh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label71
            // 
            this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(223, 39);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(75, 17);
            this.label71.TabIndex = 14;
            this.label71.Text = "Continuum";
            // 
            // tbSampAnalContinuum
            // 
            this.tbSampAnalContinuum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalContinuum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalContinuum.Location = new System.Drawing.Point(443, 30);
            this.tbSampAnalContinuum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalContinuum.MaxLength = 16;
            this.tbSampAnalContinuum.Name = "tbSampAnalContinuum";
            this.tbSampAnalContinuum.Size = new System.Drawing.Size(214, 22);
            this.tbSampAnalContinuum.TabIndex = 15;
            this.tbSampAnalContinuum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label72
            // 
            this.label72.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(663, 39);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(114, 17);
            this.label72.TabIndex = 16;
            this.label72.Text = "Continuum Func.";
            // 
            // cboxSampAnalContinuumFunc
            // 
            this.cboxSampAnalContinuumFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSampAnalContinuumFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAnalContinuumFunc.FormattingEnabled = true;
            this.cboxSampAnalContinuumFunc.Items.AddRange(new object[] {
            "STEP",
            "LINEAR"});
            this.cboxSampAnalContinuumFunc.Location = new System.Drawing.Point(883, 30);
            this.cboxSampAnalContinuumFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAnalContinuumFunc.Name = "cboxSampAnalContinuumFunc";
            this.cboxSampAnalContinuumFunc.Size = new System.Drawing.Size(215, 24);
            this.cboxSampAnalContinuumFunc.TabIndex = 17;
            // 
            // cbSampAnalCritLev
            // 
            this.cbSampAnalCritLev.AutoSize = true;
            this.cbSampAnalCritLev.Location = new System.Drawing.Point(223, 58);
            this.cbSampAnalCritLev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalCritLev.Name = "cbSampAnalCritLev";
            this.cbSampAnalCritLev.Size = new System.Drawing.Size(142, 21);
            this.cbSampAnalCritLev.TabIndex = 18;
            this.cbSampAnalCritLev.Text = "95% Critical Level";
            this.cbSampAnalCritLev.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalFitSinglets
            // 
            this.cbSampAnalFitSinglets.AutoSize = true;
            this.cbSampAnalFitSinglets.Location = new System.Drawing.Point(443, 58);
            this.cbSampAnalFitSinglets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalFitSinglets.Name = "cbSampAnalFitSinglets";
            this.cbSampAnalFitSinglets.Size = new System.Drawing.Size(99, 21);
            this.cbSampAnalFitSinglets.TabIndex = 19;
            this.cbSampAnalFitSinglets.Text = "Fit Singlets";
            this.cbSampAnalFitSinglets.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalDispRois
            // 
            this.cbSampAnalDispRois.AutoSize = true;
            this.cbSampAnalDispRois.Location = new System.Drawing.Point(663, 58);
            this.cbSampAnalDispRois.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalDispRois.Name = "cbSampAnalDispRois";
            this.cbSampAnalDispRois.Size = new System.Drawing.Size(111, 21);
            this.cbSampAnalDispRois.TabIndex = 20;
            this.cbSampAnalDispRois.Text = "Display ROIs";
            this.cbSampAnalDispRois.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalUseFixed
            // 
            this.cbSampAnalUseFixed.AutoSize = true;
            this.cbSampAnalUseFixed.Location = new System.Drawing.Point(883, 58);
            this.cbSampAnalUseFixed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalUseFixed.Name = "cbSampAnalUseFixed";
            this.cbSampAnalUseFixed.Size = new System.Drawing.Size(189, 21);
            this.cbSampAnalUseFixed.TabIndex = 21;
            this.cbSampAnalUseFixed.Text = "Use Fixed Tail Parameter";
            this.cbSampAnalUseFixed.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalRejectZero
            // 
            this.cbSampAnalRejectZero.AutoSize = true;
            this.cbSampAnalRejectZero.Location = new System.Drawing.Point(223, 86);
            this.cbSampAnalRejectZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalRejectZero.Name = "cbSampAnalRejectZero";
            this.cbSampAnalRejectZero.Size = new System.Drawing.Size(181, 21);
            this.cbSampAnalRejectZero.TabIndex = 22;
            this.cbSampAnalRejectZero.Text = "Reject Zero Area Peaks";
            this.cbSampAnalRejectZero.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalFixedFWHM
            // 
            this.cbSampAnalFixedFWHM.AutoSize = true;
            this.cbSampAnalFixedFWHM.Location = new System.Drawing.Point(443, 86);
            this.cbSampAnalFixedFWHM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalFixedFWHM.Name = "cbSampAnalFixedFWHM";
            this.cbSampAnalFixedFWHM.Size = new System.Drawing.Size(145, 21);
            this.cbSampAnalFixedFWHM.TabIndex = 23;
            this.cbSampAnalFixedFWHM.Text = "Use Fixed FWHMs";
            this.cbSampAnalFixedFWHM.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            this.label73.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(663, 95);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(93, 17);
            this.label73.TabIndex = 24;
            this.label73.Text = "Eff. Cal. Type";
            // 
            // cboxSampAnalEffCal
            // 
            this.cboxSampAnalEffCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSampAnalEffCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSampAnalEffCal.FormattingEnabled = true;
            this.cboxSampAnalEffCal.Items.AddRange(new object[] {
            "INTERP",
            "EMP",
            "DUAL",
            "LINEAR"});
            this.cboxSampAnalEffCal.Location = new System.Drawing.Point(883, 86);
            this.cboxSampAnalEffCal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxSampAnalEffCal.Name = "cboxSampAnalEffCal";
            this.cboxSampAnalEffCal.Size = new System.Drawing.Size(215, 24);
            this.cboxSampAnalEffCal.TabIndex = 25;
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(223, 123);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(185, 17);
            this.label74.TabIndex = 26;
            this.label74.Text = "Max FHWMs between peaks";
            // 
            // tbSampAnalMaxFWHMBetween
            // 
            this.tbSampAnalMaxFWHMBetween.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalMaxFWHMBetween.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalMaxFWHMBetween.Location = new System.Drawing.Point(443, 114);
            this.tbSampAnalMaxFWHMBetween.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalMaxFWHMBetween.MaxLength = 16;
            this.tbSampAnalMaxFWHMBetween.Name = "tbSampAnalMaxFWHMBetween";
            this.tbSampAnalMaxFWHMBetween.Size = new System.Drawing.Size(214, 22);
            this.tbSampAnalMaxFWHMBetween.TabIndex = 27;
            // 
            // label77
            // 
            this.label77.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(663, 151);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(167, 17);
            this.label77.TabIndex = 30;
            this.label77.Text = "Max FHWMs for right limit";
            // 
            // tbSampAnalMaxFWHMRight
            // 
            this.tbSampAnalMaxFWHMRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalMaxFWHMRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalMaxFWHMRight.Location = new System.Drawing.Point(883, 142);
            this.tbSampAnalMaxFWHMRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalMaxFWHMRight.MaxLength = 16;
            this.tbSampAnalMaxFWHMRight.Name = "tbSampAnalMaxFWHMRight";
            this.tbSampAnalMaxFWHMRight.Size = new System.Drawing.Size(215, 22);
            this.tbSampAnalMaxFWHMRight.TabIndex = 31;
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(223, 151);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(158, 17);
            this.label78.TabIndex = 28;
            this.label78.Text = "Max FHWMs for left limit";
            // 
            // tbSampAnalMaxFWHMLeft
            // 
            this.tbSampAnalMaxFWHMLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalMaxFWHMLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalMaxFWHMLeft.Location = new System.Drawing.Point(443, 142);
            this.tbSampAnalMaxFWHMLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalMaxFWHMLeft.MaxLength = 16;
            this.tbSampAnalMaxFWHMLeft.Name = "tbSampAnalMaxFWHMLeft";
            this.tbSampAnalMaxFWHMLeft.Size = new System.Drawing.Size(214, 22);
            this.tbSampAnalMaxFWHMLeft.TabIndex = 29;
            // 
            // label79
            // 
            this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(223, 179);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(141, 17);
            this.label79.TabIndex = 32;
            this.label79.Text = "Background Subtract";
            // 
            // tbSampAnalBkgSub
            // 
            this.tbSampAnalBkgSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.SetColumnSpan(this.tbSampAnalBkgSub, 2);
            this.tbSampAnalBkgSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalBkgSub.Enabled = false;
            this.tbSampAnalBkgSub.Location = new System.Drawing.Point(443, 170);
            this.tbSampAnalBkgSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalBkgSub.MaxLength = 1024;
            this.tbSampAnalBkgSub.Name = "tbSampAnalBkgSub";
            this.tbSampAnalBkgSub.Size = new System.Drawing.Size(434, 22);
            this.tbSampAnalBkgSub.TabIndex = 33;
            // 
            // btnSampAnalBkgSub
            // 
            this.btnSampAnalBkgSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSampAnalBkgSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampAnalBkgSub.Location = new System.Drawing.Point(883, 170);
            this.btnSampAnalBkgSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSampAnalBkgSub.Name = "btnSampAnalBkgSub";
            this.btnSampAnalBkgSub.Size = new System.Drawing.Size(215, 24);
            this.btnSampAnalBkgSub.TabIndex = 34;
            this.btnSampAnalBkgSub.Text = "...";
            this.btnSampAnalBkgSub.UseVisualStyleBackColor = true;
            this.btnSampAnalBkgSub.Click += new System.EventHandler(this.btnSampAnalBkgSub_Click);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(3, 196);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(108, 17);
            this.label80.TabIndex = 35;
            this.label80.Text = "Nuclide Ident.";
            // 
            // label81
            // 
            this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(223, 207);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(79, 17);
            this.label81.TabIndex = 36;
            this.label81.Text = "NID Library";
            // 
            // tbSampAnalNIDLib
            // 
            this.tbSampAnalNIDLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel3.SetColumnSpan(this.tbSampAnalNIDLib, 2);
            this.tbSampAnalNIDLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalNIDLib.Enabled = false;
            this.tbSampAnalNIDLib.Location = new System.Drawing.Point(443, 198);
            this.tbSampAnalNIDLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalNIDLib.MaxLength = 1024;
            this.tbSampAnalNIDLib.Name = "tbSampAnalNIDLib";
            this.tbSampAnalNIDLib.Size = new System.Drawing.Size(434, 22);
            this.tbSampAnalNIDLib.TabIndex = 37;
            // 
            // btnSampAnalNIDLib
            // 
            this.btnSampAnalNIDLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSampAnalNIDLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampAnalNIDLib.Location = new System.Drawing.Point(883, 198);
            this.btnSampAnalNIDLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSampAnalNIDLib.Name = "btnSampAnalNIDLib";
            this.btnSampAnalNIDLib.Size = new System.Drawing.Size(215, 24);
            this.btnSampAnalNIDLib.TabIndex = 38;
            this.btnSampAnalNIDLib.Text = "...";
            this.btnSampAnalNIDLib.UseVisualStyleBackColor = true;
            this.btnSampAnalNIDLib.Click += new System.EventHandler(this.btnSampAnalNIDLib_Click);
            // 
            // label82
            // 
            this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(223, 235);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(121, 17);
            this.label82.TabIndex = 39;
            this.label82.Text = "NID Conf. Thresh.";
            // 
            // tbSampAnalNIDConfThresh
            // 
            this.tbSampAnalNIDConfThresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalNIDConfThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalNIDConfThresh.Location = new System.Drawing.Point(443, 226);
            this.tbSampAnalNIDConfThresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalNIDConfThresh.MaxLength = 16;
            this.tbSampAnalNIDConfThresh.Name = "tbSampAnalNIDConfThresh";
            this.tbSampAnalNIDConfThresh.Size = new System.Drawing.Size(214, 22);
            this.tbSampAnalNIDConfThresh.TabIndex = 40;
            // 
            // label83
            // 
            this.label83.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(663, 235);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(141, 17);
            this.label83.TabIndex = 41;
            this.label83.Text = "MDA Conf. factor (%)";
            // 
            // tbSampAnalMDAConfFac
            // 
            this.tbSampAnalMDAConfFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tbSampAnalMDAConfFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSampAnalMDAConfFac.Location = new System.Drawing.Point(883, 226);
            this.tbSampAnalMDAConfFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSampAnalMDAConfFac.MaxLength = 16;
            this.tbSampAnalMDAConfFac.Name = "tbSampAnalMDAConfFac";
            this.tbSampAnalMDAConfFac.Size = new System.Drawing.Size(215, 22);
            this.tbSampAnalMDAConfFac.TabIndex = 42;
            // 
            // cbSampAnalInhibitATD
            // 
            this.cbSampAnalInhibitATD.AutoSize = true;
            this.cbSampAnalInhibitATD.Location = new System.Drawing.Point(223, 254);
            this.cbSampAnalInhibitATD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalInhibitATD.Name = "cbSampAnalInhibitATD";
            this.cbSampAnalInhibitATD.Size = new System.Drawing.Size(134, 21);
            this.cbSampAnalInhibitATD.TabIndex = 43;
            this.cbSampAnalInhibitATD.Text = "Inhibit ATD Corr.";
            this.cbSampAnalInhibitATD.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalUseStoredLib
            // 
            this.cbSampAnalUseStoredLib.AutoSize = true;
            this.cbSampAnalUseStoredLib.Location = new System.Drawing.Point(443, 254);
            this.cbSampAnalUseStoredLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalUseStoredLib.Name = "cbSampAnalUseStoredLib";
            this.cbSampAnalUseStoredLib.Size = new System.Drawing.Size(149, 21);
            this.cbSampAnalUseStoredLib.TabIndex = 44;
            this.cbSampAnalUseStoredLib.Text = "Use Stored Library";
            this.cbSampAnalUseStoredLib.UseVisualStyleBackColor = true;
            // 
            // cbSampAnalPerformMDA
            // 
            this.cbSampAnalPerformMDA.AutoSize = true;
            this.cbSampAnalPerformMDA.Location = new System.Drawing.Point(663, 254);
            this.cbSampAnalPerformMDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSampAnalPerformMDA.Name = "cbSampAnalPerformMDA";
            this.cbSampAnalPerformMDA.Size = new System.Drawing.Size(146, 21);
            this.cbSampAnalPerformMDA.TabIndex = 45;
            this.cbSampAnalPerformMDA.Text = "Perform MDA Test";
            this.cbSampAnalPerformMDA.UseVisualStyleBackColor = true;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(4, 0);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(98, 17);
            this.label66.TabIndex = 46;
            this.label66.Text = "Peak Locate";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(4, 28);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(83, 17);
            this.label67.TabIndex = 47;
            this.label67.Text = "Peak Area";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btnSampStart);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel26.Location = new System.Drawing.Point(3, 473);
            this.panel26.Margin = new System.Windows.Forms.Padding(4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(1117, 28);
            this.panel26.TabIndex = 2;
            // 
            // btnSampStart
            // 
            this.btnSampStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSampStart.Location = new System.Drawing.Point(944, 0);
            this.btnSampStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSampStart.Name = "btnSampStart";
            this.btnSampStart.Size = new System.Drawing.Size(173, 28);
            this.btnSampStart.TabIndex = 0;
            this.btnSampStart.Text = "Start";
            this.btnSampStart.UseVisualStyleBackColor = true;
            this.btnSampStart.Click += new System.EventHandler(this.btnSampStart_Click);
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.lblSampIsReanal);
            this.panel24.Controls.Add(this.btnSampReadBarcode);
            this.panel24.Controls.Add(this.lblSampAnalType);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(3, 2);
            this.panel24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1117, 32);
            this.panel24.TabIndex = 1;
            // 
            // lblSampIsReanal
            // 
            this.lblSampIsReanal.AutoSize = true;
            this.lblSampIsReanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSampIsReanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampIsReanal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSampIsReanal.Location = new System.Drawing.Point(169, 0);
            this.lblSampIsReanal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSampIsReanal.Name = "lblSampIsReanal";
            this.lblSampIsReanal.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblSampIsReanal.Size = new System.Drawing.Size(122, 27);
            this.lblSampIsReanal.TabIndex = 1;
            this.lblSampIsReanal.Text = "<IsReanal>";
            // 
            // btnSampReadBarcode
            // 
            this.btnSampReadBarcode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSampReadBarcode.Location = new System.Drawing.Point(972, 0);
            this.btnSampReadBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSampReadBarcode.Name = "btnSampReadBarcode";
            this.btnSampReadBarcode.Size = new System.Drawing.Size(145, 32);
            this.btnSampReadBarcode.TabIndex = 0;
            this.btnSampReadBarcode.Text = "Les fra strekkode";
            this.btnSampReadBarcode.UseVisualStyleBackColor = true;
            this.btnSampReadBarcode.Click += new System.EventHandler(this.btnSampReadBarcode_Click);
            // 
            // lblSampAnalType
            // 
            this.lblSampAnalType.AutoSize = true;
            this.lblSampAnalType.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSampAnalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampAnalType.Location = new System.Drawing.Point(0, 0);
            this.lblSampAnalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSampAnalType.Name = "lblSampAnalType";
            this.lblSampAnalType.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblSampAnalType.Size = new System.Drawing.Size(169, 27);
            this.lblSampAnalType.TabIndex = 2;
            this.lblSampAnalType.Text = "<AnalysisType>";
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdmin.Controls.Add(this.tabsAdmin);
            this.tabAdmin.Location = new System.Drawing.Point(4, 26);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmin.Size = new System.Drawing.Size(1123, 503);
            this.tabAdmin.TabIndex = 4;
            this.tabAdmin.Text = "Administrasjon";
            // 
            // tabsAdmin
            // 
            this.tabsAdmin.Controls.Add(this.tabAdminGeneral);
            this.tabsAdmin.Controls.Add(this.tabAdminDet);
            this.tabsAdmin.Controls.Add(this.tabAdminGeom);
            this.tabsAdmin.Controls.Add(this.tabAdminQA);
            this.tabsAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsAdmin.Location = new System.Drawing.Point(3, 2);
            this.tabsAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsAdmin.Name = "tabsAdmin";
            this.tabsAdmin.SelectedIndex = 0;
            this.tabsAdmin.Size = new System.Drawing.Size(1117, 499);
            this.tabsAdmin.TabIndex = 0;
            // 
            // tabAdminGeneral
            // 
            this.tabAdminGeneral.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdminGeneral.Controls.Add(this.tabsAdminGeneral);
            this.tabAdminGeneral.Controls.Add(this.panel25);
            this.tabAdminGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabAdminGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminGeneral.Name = "tabAdminGeneral";
            this.tabAdminGeneral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminGeneral.Size = new System.Drawing.Size(1109, 470);
            this.tabAdminGeneral.TabIndex = 0;
            this.tabAdminGeneral.Text = "Generelt";
            // 
            // tabsAdminGeneral
            // 
            this.tabsAdminGeneral.Controls.Add(this.tabAdminGeneral1);
            this.tabsAdminGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsAdminGeneral.Location = new System.Drawing.Point(3, 2);
            this.tabsAdminGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tabsAdminGeneral.Name = "tabsAdminGeneral";
            this.tabsAdminGeneral.SelectedIndex = 0;
            this.tabsAdminGeneral.Size = new System.Drawing.Size(1103, 438);
            this.tabsAdminGeneral.TabIndex = 2;
            // 
            // tabAdminGeneral1
            // 
            this.tabAdminGeneral1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdminGeneral1.Controls.Add(this.layoutAdminGeneral);
            this.tabAdminGeneral1.Location = new System.Drawing.Point(4, 25);
            this.tabAdminGeneral1.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdminGeneral1.Name = "tabAdminGeneral1";
            this.tabAdminGeneral1.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdminGeneral1.Size = new System.Drawing.Size(1095, 409);
            this.tabAdminGeneral1.TabIndex = 0;
            this.tabAdminGeneral1.Text = "Generelle innstillinger";
            // 
            // layoutAdminGeneral
            // 
            this.layoutAdminGeneral.ColumnCount = 4;
            this.layoutAdminGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutAdminGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdminGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutAdminGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutAdminGeneral.Controls.Add(this.label26, 0, 0);
            this.layoutAdminGeneral.Controls.Add(this.label27, 1, 1);
            this.layoutAdminGeneral.Controls.Add(this.label28, 1, 2);
            this.layoutAdminGeneral.Controls.Add(this.label29, 0, 3);
            this.layoutAdminGeneral.Controls.Add(this.label30, 1, 4);
            this.layoutAdminGeneral.Controls.Add(this.label31, 1, 5);
            this.layoutAdminGeneral.Controls.Add(this.label32, 0, 8);
            this.layoutAdminGeneral.Controls.Add(this.label33, 1, 9);
            this.layoutAdminGeneral.Controls.Add(this.label34, 1, 10);
            this.layoutAdminGeneral.Controls.Add(this.cboxAdmSection, 2, 5);
            this.layoutAdminGeneral.Controls.Add(this.tbAdmSigma, 2, 2);
            this.layoutAdminGeneral.Controls.Add(this.tbAdmGenieFolder, 2, 1);
            this.layoutAdminGeneral.Controls.Add(this.tbAdmTemplate, 2, 4);
            this.layoutAdminGeneral.Controls.Add(this.tbAdmLIMSImport, 2, 9);
            this.layoutAdminGeneral.Controls.Add(this.tbAdmLIMSExport, 2, 10);
            this.layoutAdminGeneral.Controls.Add(this.btnAdmGenieFolder, 3, 1);
            this.layoutAdminGeneral.Controls.Add(this.btnAdmTemplate, 3, 4);
            this.layoutAdminGeneral.Controls.Add(this.btnAdmLIMSImport, 3, 9);
            this.layoutAdminGeneral.Controls.Add(this.btnAdmLIMSExport, 3, 10);
            this.layoutAdminGeneral.Controls.Add(this.label10, 1, 6);
            this.layoutAdminGeneral.Controls.Add(this.cboxAdmPlotScaleY, 2, 6);
            this.layoutAdminGeneral.Controls.Add(this.label11, 1, 7);
            this.layoutAdminGeneral.Controls.Add(this.cboxAdmPlotScaleX, 2, 7);
            this.layoutAdminGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAdminGeneral.Location = new System.Drawing.Point(4, 4);
            this.layoutAdminGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutAdminGeneral.Name = "layoutAdminGeneral";
            this.layoutAdminGeneral.RowCount = 12;
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdminGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutAdminGeneral.Size = new System.Drawing.Size(1087, 401);
            this.layoutAdminGeneral.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "Innstillinger";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(166, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "Genie katalog";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(166, 56);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 17);
            this.label28.TabIndex = 2;
            this.label28.Text = "Sigma";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 84);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 17);
            this.label29.TabIndex = 3;
            this.label29.Text = "Rapportering";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(166, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(102, 17);
            this.label30.TabIndex = 4;
            this.label30.Text = "Template navn";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(166, 140);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 17);
            this.label31.TabIndex = 5;
            this.label31.Text = "Section navn";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 224);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 17);
            this.label32.TabIndex = 6;
            this.label32.Text = "Import/Eksport";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(166, 252);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 17);
            this.label33.TabIndex = 7;
            this.label33.Text = "LIMS Import";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(166, 280);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 17);
            this.label34.TabIndex = 8;
            this.label34.Text = "LIMS Eksport";
            // 
            // cboxAdmSection
            // 
            this.cboxAdmSection.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboxAdmSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmSection.FormattingEnabled = true;
            this.cboxAdmSection.Items.AddRange(new object[] {
            "ALL",
            "HEADER"});
            this.cboxAdmSection.Location = new System.Drawing.Point(383, 142);
            this.cboxAdmSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmSection.Name = "cboxAdmSection";
            this.cboxAdmSection.Size = new System.Drawing.Size(168, 24);
            this.cboxAdmSection.TabIndex = 9;
            // 
            // tbAdmSigma
            // 
            this.tbAdmSigma.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbAdmSigma.Location = new System.Drawing.Point(383, 58);
            this.tbAdmSigma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmSigma.MaxLength = 16;
            this.tbAdmSigma.Name = "tbAdmSigma";
            this.tbAdmSigma.Size = new System.Drawing.Size(168, 22);
            this.tbAdmSigma.TabIndex = 10;
            this.tbAdmSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmGenieFolder
            // 
            this.tbAdmGenieFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmGenieFolder.Enabled = false;
            this.tbAdmGenieFolder.Location = new System.Drawing.Point(383, 30);
            this.tbAdmGenieFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmGenieFolder.MaxLength = 1024;
            this.tbAdmGenieFolder.Name = "tbAdmGenieFolder";
            this.tbAdmGenieFolder.Size = new System.Drawing.Size(591, 22);
            this.tbAdmGenieFolder.TabIndex = 11;
            // 
            // tbAdmTemplate
            // 
            this.tbAdmTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmTemplate.Enabled = false;
            this.tbAdmTemplate.Location = new System.Drawing.Point(383, 114);
            this.tbAdmTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmTemplate.MaxLength = 1024;
            this.tbAdmTemplate.Name = "tbAdmTemplate";
            this.tbAdmTemplate.Size = new System.Drawing.Size(591, 22);
            this.tbAdmTemplate.TabIndex = 12;
            // 
            // tbAdmLIMSImport
            // 
            this.tbAdmLIMSImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmLIMSImport.Enabled = false;
            this.tbAdmLIMSImport.Location = new System.Drawing.Point(383, 254);
            this.tbAdmLIMSImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmLIMSImport.MaxLength = 1024;
            this.tbAdmLIMSImport.Name = "tbAdmLIMSImport";
            this.tbAdmLIMSImport.Size = new System.Drawing.Size(591, 22);
            this.tbAdmLIMSImport.TabIndex = 13;
            // 
            // tbAdmLIMSExport
            // 
            this.tbAdmLIMSExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmLIMSExport.Enabled = false;
            this.tbAdmLIMSExport.Location = new System.Drawing.Point(383, 282);
            this.tbAdmLIMSExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmLIMSExport.MaxLength = 1024;
            this.tbAdmLIMSExport.Name = "tbAdmLIMSExport";
            this.tbAdmLIMSExport.Size = new System.Drawing.Size(591, 22);
            this.tbAdmLIMSExport.TabIndex = 14;
            // 
            // btnAdmGenieFolder
            // 
            this.btnAdmGenieFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmGenieFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmGenieFolder.Location = new System.Drawing.Point(980, 30);
            this.btnAdmGenieFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmGenieFolder.Name = "btnAdmGenieFolder";
            this.btnAdmGenieFolder.Size = new System.Drawing.Size(104, 24);
            this.btnAdmGenieFolder.TabIndex = 15;
            this.btnAdmGenieFolder.Text = "...";
            this.btnAdmGenieFolder.UseVisualStyleBackColor = true;
            this.btnAdmGenieFolder.Click += new System.EventHandler(this.btnAdmGenieFolder_Click);
            // 
            // btnAdmTemplate
            // 
            this.btnAdmTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmTemplate.Location = new System.Drawing.Point(980, 114);
            this.btnAdmTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmTemplate.Name = "btnAdmTemplate";
            this.btnAdmTemplate.Size = new System.Drawing.Size(104, 24);
            this.btnAdmTemplate.TabIndex = 16;
            this.btnAdmTemplate.Text = "...";
            this.btnAdmTemplate.UseVisualStyleBackColor = true;
            this.btnAdmTemplate.Click += new System.EventHandler(this.btnAdmTemplate_Click);
            // 
            // btnAdmLIMSImport
            // 
            this.btnAdmLIMSImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmLIMSImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmLIMSImport.Location = new System.Drawing.Point(980, 254);
            this.btnAdmLIMSImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmLIMSImport.Name = "btnAdmLIMSImport";
            this.btnAdmLIMSImport.Size = new System.Drawing.Size(104, 24);
            this.btnAdmLIMSImport.TabIndex = 17;
            this.btnAdmLIMSImport.Text = "...";
            this.btnAdmLIMSImport.UseVisualStyleBackColor = true;
            this.btnAdmLIMSImport.Click += new System.EventHandler(this.btnAdmLIMSImport_Click);
            // 
            // btnAdmLIMSExport
            // 
            this.btnAdmLIMSExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmLIMSExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmLIMSExport.Location = new System.Drawing.Point(980, 282);
            this.btnAdmLIMSExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmLIMSExport.Name = "btnAdmLIMSExport";
            this.btnAdmLIMSExport.Size = new System.Drawing.Size(104, 24);
            this.btnAdmLIMSExport.TabIndex = 18;
            this.btnAdmLIMSExport.Text = "...";
            this.btnAdmLIMSExport.UseVisualStyleBackColor = true;
            this.btnAdmLIMSExport.Click += new System.EventHandler(this.btnAdmLIMSExport_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y-Skala";
            // 
            // cboxAdmPlotScaleY
            // 
            this.cboxAdmPlotScaleY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmPlotScaleY.FormattingEnabled = true;
            this.cboxAdmPlotScaleY.Items.AddRange(new object[] {
            "LOG",
            "LINEAR"});
            this.cboxAdmPlotScaleY.Location = new System.Drawing.Point(384, 172);
            this.cboxAdmPlotScaleY.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAdmPlotScaleY.Name = "cboxAdmPlotScaleY";
            this.cboxAdmPlotScaleY.Size = new System.Drawing.Size(167, 24);
            this.cboxAdmPlotScaleY.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "X-Skala";
            // 
            // cboxAdmPlotScaleX
            // 
            this.cboxAdmPlotScaleX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmPlotScaleX.FormattingEnabled = true;
            this.cboxAdmPlotScaleX.Items.AddRange(new object[] {
            "ENERGY",
            "CHANNEL"});
            this.cboxAdmPlotScaleX.Location = new System.Drawing.Point(384, 200);
            this.cboxAdmPlotScaleX.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAdmPlotScaleX.Name = "cboxAdmPlotScaleX";
            this.cboxAdmPlotScaleX.Size = new System.Drawing.Size(167, 24);
            this.cboxAdmPlotScaleX.TabIndex = 22;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btnAdmSave);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel25.Location = new System.Drawing.Point(3, 440);
            this.panel25.Margin = new System.Windows.Forms.Padding(4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1103, 28);
            this.panel25.TabIndex = 1;
            // 
            // btnAdmSave
            // 
            this.btnAdmSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdmSave.Location = new System.Drawing.Point(994, 0);
            this.btnAdmSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmSave.Name = "btnAdmSave";
            this.btnAdmSave.Size = new System.Drawing.Size(109, 28);
            this.btnAdmSave.TabIndex = 0;
            this.btnAdmSave.Text = "Lagre";
            this.btnAdmSave.UseVisualStyleBackColor = true;
            this.btnAdmSave.Click += new System.EventHandler(this.btnAdmSave_Click);
            // 
            // tabAdminDet
            // 
            this.tabAdminDet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdminDet.Controls.Add(this.splitAdmDet);
            this.tabAdminDet.Location = new System.Drawing.Point(4, 25);
            this.tabAdminDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminDet.Name = "tabAdminDet";
            this.tabAdminDet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminDet.Size = new System.Drawing.Size(1109, 470);
            this.tabAdminDet.TabIndex = 1;
            this.tabAdminDet.Text = "Detektorer";
            // 
            // splitAdmDet
            // 
            this.splitAdmDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAdmDet.Location = new System.Drawing.Point(3, 2);
            this.splitAdmDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitAdmDet.Name = "splitAdmDet";
            // 
            // splitAdmDet.Panel1
            // 
            this.splitAdmDet.Panel1.Controls.Add(this.lbAdmDetList);
            this.splitAdmDet.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitAdmDet.Panel2
            // 
            this.splitAdmDet.Panel2.Controls.Add(this.tabsAdmDetPages);
            this.splitAdmDet.Panel2.Controls.Add(this.panel21);
            this.splitAdmDet.Panel2.Enabled = false;
            this.splitAdmDet.Size = new System.Drawing.Size(1103, 466);
            this.splitAdmDet.SplitterDistance = 106;
            this.splitAdmDet.TabIndex = 0;
            // 
            // lbAdmDetList
            // 
            this.lbAdmDetList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAdmDetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdmDetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmDetList.FormattingEnabled = true;
            this.lbAdmDetList.ItemHeight = 16;
            this.lbAdmDetList.Location = new System.Drawing.Point(5, 5);
            this.lbAdmDetList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdmDetList.Name = "lbAdmDetList";
            this.lbAdmDetList.Size = new System.Drawing.Size(96, 456);
            this.lbAdmDetList.TabIndex = 0;
            this.lbAdmDetList.SelectedIndexChanged += new System.EventHandler(this.lbAdmDetList_SelectedIndexChanged);
            // 
            // tabsAdmDetPages
            // 
            this.tabsAdmDetPages.Controls.Add(this.tabAdmDetPage1);
            this.tabsAdmDetPages.Controls.Add(this.tabAdmDetPage2);
            this.tabsAdmDetPages.Controls.Add(this.tabAdmDetPage3);
            this.tabsAdmDetPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsAdmDetPages.Location = new System.Drawing.Point(0, 0);
            this.tabsAdmDetPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabsAdmDetPages.Name = "tabsAdmDetPages";
            this.tabsAdmDetPages.SelectedIndex = 0;
            this.tabsAdmDetPages.Size = new System.Drawing.Size(993, 438);
            this.tabsAdmDetPages.TabIndex = 1;
            // 
            // tabAdmDetPage1
            // 
            this.tabAdmDetPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdmDetPage1.Controls.Add(this.layoutAdmDet);
            this.tabAdmDetPage1.Location = new System.Drawing.Point(4, 25);
            this.tabAdmDetPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmDetPage1.Name = "tabAdmDetPage1";
            this.tabAdmDetPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmDetPage1.Size = new System.Drawing.Size(985, 409);
            this.tabAdmDetPage1.TabIndex = 0;
            this.tabAdmDetPage1.Text = "Side 1";
            // 
            // layoutAdmDet
            // 
            this.layoutAdmDet.ColumnCount = 5;
            this.layoutAdmDet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDet.Controls.Add(this.label35, 0, 0);
            this.layoutAdmDet.Controls.Add(this.label37, 1, 1);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetSearchRegionFrom, 2, 1);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetSearchRegionTo, 3, 1);
            this.layoutAdmDet.Controls.Add(this.label38, 1, 2);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetTolerance, 2, 2);
            this.layoutAdmDet.Controls.Add(this.label39, 3, 2);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetSignThresh, 4, 2);
            this.layoutAdmDet.Controls.Add(this.label41, 1, 3);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetPeakAreaRegionFrom, 2, 3);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetPeakAreaRegionTo, 3, 3);
            this.layoutAdmDet.Controls.Add(this.label42, 1, 4);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetContinuum, 2, 4);
            this.layoutAdmDet.Controls.Add(this.label43, 3, 4);
            this.layoutAdmDet.Controls.Add(this.cboxAdmDetContinuumFunc, 4, 4);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetCriticalLevel, 1, 5);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetFitSinglets, 2, 5);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetDisplayROIs, 3, 5);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetUseFixedTailParam, 4, 5);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetRejectZeroAreaPeaks, 1, 6);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetUseFixedFWHM, 2, 6);
            this.layoutAdmDet.Controls.Add(this.label44, 3, 6);
            this.layoutAdmDet.Controls.Add(this.cboxAdmDetEffCalType, 4, 6);
            this.layoutAdmDet.Controls.Add(this.label45, 1, 7);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetMaxFHWMBetPeaks, 2, 7);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetInUse, 1, 0);
            this.layoutAdmDet.Controls.Add(this.label36, 0, 1);
            this.layoutAdmDet.Controls.Add(this.label40, 0, 3);
            this.layoutAdmDet.Controls.Add(this.label47, 3, 8);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetMaxFHWMRightLim, 4, 8);
            this.layoutAdmDet.Controls.Add(this.label46, 1, 8);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetMaxFHWMLeftLim, 2, 8);
            this.layoutAdmDet.Controls.Add(this.label48, 1, 9);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetBkgSub, 2, 9);
            this.layoutAdmDet.Controls.Add(this.btnAdmDetBkgSub, 4, 9);
            this.layoutAdmDet.Controls.Add(this.label49, 0, 10);
            this.layoutAdmDet.Controls.Add(this.label50, 1, 10);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetNIDLib, 2, 10);
            this.layoutAdmDet.Controls.Add(this.btnAdmDetNIDLib, 4, 10);
            this.layoutAdmDet.Controls.Add(this.label51, 1, 11);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetNIDConfThresh, 2, 11);
            this.layoutAdmDet.Controls.Add(this.label52, 3, 11);
            this.layoutAdmDet.Controls.Add(this.tbAdmDetMDAConfFac, 4, 11);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetInhibitATDCorr, 1, 12);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetUseStoredLib, 2, 12);
            this.layoutAdmDet.Controls.Add(this.cbAdmDetPerfMDATest, 3, 12);
            this.layoutAdmDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAdmDet.Location = new System.Drawing.Point(3, 2);
            this.layoutAdmDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutAdmDet.Name = "layoutAdmDet";
            this.layoutAdmDet.RowCount = 14;
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutAdmDet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutAdmDet.Size = new System.Drawing.Size(979, 405);
            this.layoutAdmDet.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 17);
            this.label35.TabIndex = 0;
            this.label35.Text = "Innstillinger";
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(198, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(102, 17);
            this.label37.TabIndex = 3;
            this.label37.Text = "Search Region";
            // 
            // tbAdmDetSearchRegionFrom
            // 
            this.tbAdmDetSearchRegionFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetSearchRegionFrom.Location = new System.Drawing.Point(393, 30);
            this.tbAdmDetSearchRegionFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetSearchRegionFrom.MaxLength = 16;
            this.tbAdmDetSearchRegionFrom.Name = "tbAdmDetSearchRegionFrom";
            this.tbAdmDetSearchRegionFrom.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetSearchRegionFrom.TabIndex = 4;
            this.tbAdmDetSearchRegionFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetSearchRegionTo
            // 
            this.tbAdmDetSearchRegionTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetSearchRegionTo.Location = new System.Drawing.Point(588, 30);
            this.tbAdmDetSearchRegionTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetSearchRegionTo.MaxLength = 16;
            this.tbAdmDetSearchRegionTo.Name = "tbAdmDetSearchRegionTo";
            this.tbAdmDetSearchRegionTo.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetSearchRegionTo.TabIndex = 5;
            this.tbAdmDetSearchRegionTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(198, 67);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(72, 17);
            this.label38.TabIndex = 6;
            this.label38.Text = "Tolerance";
            // 
            // tbAdmDetTolerance
            // 
            this.tbAdmDetTolerance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetTolerance.Location = new System.Drawing.Point(393, 58);
            this.tbAdmDetTolerance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetTolerance.MaxLength = 16;
            this.tbAdmDetTolerance.Name = "tbAdmDetTolerance";
            this.tbAdmDetTolerance.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetTolerance.TabIndex = 7;
            this.tbAdmDetTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(588, 67);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(137, 17);
            this.label39.TabIndex = 8;
            this.label39.Text = "Significance Thresh.";
            // 
            // tbAdmDetSignThresh
            // 
            this.tbAdmDetSignThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetSignThresh.Location = new System.Drawing.Point(783, 58);
            this.tbAdmDetSignThresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetSignThresh.MaxLength = 16;
            this.tbAdmDetSignThresh.Name = "tbAdmDetSignThresh";
            this.tbAdmDetSignThresh.Size = new System.Drawing.Size(193, 22);
            this.tbAdmDetSignThresh.TabIndex = 9;
            this.tbAdmDetSignThresh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(198, 95);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(123, 17);
            this.label41.TabIndex = 11;
            this.label41.Text = "Peak Area Region";
            // 
            // tbAdmDetPeakAreaRegionFrom
            // 
            this.tbAdmDetPeakAreaRegionFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPeakAreaRegionFrom.Location = new System.Drawing.Point(393, 86);
            this.tbAdmDetPeakAreaRegionFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPeakAreaRegionFrom.MaxLength = 16;
            this.tbAdmDetPeakAreaRegionFrom.Name = "tbAdmDetPeakAreaRegionFrom";
            this.tbAdmDetPeakAreaRegionFrom.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPeakAreaRegionFrom.TabIndex = 12;
            this.tbAdmDetPeakAreaRegionFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetPeakAreaRegionTo
            // 
            this.tbAdmDetPeakAreaRegionTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPeakAreaRegionTo.Location = new System.Drawing.Point(588, 86);
            this.tbAdmDetPeakAreaRegionTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPeakAreaRegionTo.MaxLength = 16;
            this.tbAdmDetPeakAreaRegionTo.Name = "tbAdmDetPeakAreaRegionTo";
            this.tbAdmDetPeakAreaRegionTo.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPeakAreaRegionTo.TabIndex = 13;
            this.tbAdmDetPeakAreaRegionTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(198, 123);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(75, 17);
            this.label42.TabIndex = 14;
            this.label42.Text = "Continuum";
            // 
            // tbAdmDetContinuum
            // 
            this.tbAdmDetContinuum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetContinuum.Location = new System.Drawing.Point(393, 114);
            this.tbAdmDetContinuum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetContinuum.MaxLength = 16;
            this.tbAdmDetContinuum.Name = "tbAdmDetContinuum";
            this.tbAdmDetContinuum.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetContinuum.TabIndex = 15;
            this.tbAdmDetContinuum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(588, 123);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(114, 17);
            this.label43.TabIndex = 16;
            this.label43.Text = "Continuum Func.";
            // 
            // cboxAdmDetContinuumFunc
            // 
            this.cboxAdmDetContinuumFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetContinuumFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetContinuumFunc.FormattingEnabled = true;
            this.cboxAdmDetContinuumFunc.Items.AddRange(new object[] {
            "STEP",
            "LINEAR"});
            this.cboxAdmDetContinuumFunc.Location = new System.Drawing.Point(783, 114);
            this.cboxAdmDetContinuumFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetContinuumFunc.Name = "cboxAdmDetContinuumFunc";
            this.cboxAdmDetContinuumFunc.Size = new System.Drawing.Size(193, 24);
            this.cboxAdmDetContinuumFunc.TabIndex = 17;
            // 
            // cbAdmDetCriticalLevel
            // 
            this.cbAdmDetCriticalLevel.AutoSize = true;
            this.cbAdmDetCriticalLevel.Location = new System.Drawing.Point(198, 142);
            this.cbAdmDetCriticalLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetCriticalLevel.Name = "cbAdmDetCriticalLevel";
            this.cbAdmDetCriticalLevel.Size = new System.Drawing.Size(142, 21);
            this.cbAdmDetCriticalLevel.TabIndex = 18;
            this.cbAdmDetCriticalLevel.Text = "95% Critical Level";
            this.cbAdmDetCriticalLevel.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetFitSinglets
            // 
            this.cbAdmDetFitSinglets.AutoSize = true;
            this.cbAdmDetFitSinglets.Location = new System.Drawing.Point(393, 142);
            this.cbAdmDetFitSinglets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetFitSinglets.Name = "cbAdmDetFitSinglets";
            this.cbAdmDetFitSinglets.Size = new System.Drawing.Size(99, 21);
            this.cbAdmDetFitSinglets.TabIndex = 19;
            this.cbAdmDetFitSinglets.Text = "Fit Singlets";
            this.cbAdmDetFitSinglets.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetDisplayROIs
            // 
            this.cbAdmDetDisplayROIs.AutoSize = true;
            this.cbAdmDetDisplayROIs.Location = new System.Drawing.Point(588, 142);
            this.cbAdmDetDisplayROIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetDisplayROIs.Name = "cbAdmDetDisplayROIs";
            this.cbAdmDetDisplayROIs.Size = new System.Drawing.Size(111, 21);
            this.cbAdmDetDisplayROIs.TabIndex = 20;
            this.cbAdmDetDisplayROIs.Text = "Display ROIs";
            this.cbAdmDetDisplayROIs.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetUseFixedTailParam
            // 
            this.cbAdmDetUseFixedTailParam.AutoSize = true;
            this.cbAdmDetUseFixedTailParam.Location = new System.Drawing.Point(783, 142);
            this.cbAdmDetUseFixedTailParam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetUseFixedTailParam.Name = "cbAdmDetUseFixedTailParam";
            this.cbAdmDetUseFixedTailParam.Size = new System.Drawing.Size(189, 21);
            this.cbAdmDetUseFixedTailParam.TabIndex = 21;
            this.cbAdmDetUseFixedTailParam.Text = "Use Fixed Tail Parameter";
            this.cbAdmDetUseFixedTailParam.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetRejectZeroAreaPeaks
            // 
            this.cbAdmDetRejectZeroAreaPeaks.AutoSize = true;
            this.cbAdmDetRejectZeroAreaPeaks.Location = new System.Drawing.Point(198, 170);
            this.cbAdmDetRejectZeroAreaPeaks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetRejectZeroAreaPeaks.Name = "cbAdmDetRejectZeroAreaPeaks";
            this.cbAdmDetRejectZeroAreaPeaks.Size = new System.Drawing.Size(181, 21);
            this.cbAdmDetRejectZeroAreaPeaks.TabIndex = 22;
            this.cbAdmDetRejectZeroAreaPeaks.Text = "Reject Zero Area Peaks";
            this.cbAdmDetRejectZeroAreaPeaks.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetUseFixedFWHM
            // 
            this.cbAdmDetUseFixedFWHM.AutoSize = true;
            this.cbAdmDetUseFixedFWHM.Location = new System.Drawing.Point(393, 170);
            this.cbAdmDetUseFixedFWHM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetUseFixedFWHM.Name = "cbAdmDetUseFixedFWHM";
            this.cbAdmDetUseFixedFWHM.Size = new System.Drawing.Size(145, 21);
            this.cbAdmDetUseFixedFWHM.TabIndex = 23;
            this.cbAdmDetUseFixedFWHM.Text = "Use Fixed FHWMs";
            this.cbAdmDetUseFixedFWHM.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(588, 179);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(93, 17);
            this.label44.TabIndex = 24;
            this.label44.Text = "Eff. Cal. Type";
            // 
            // cboxAdmDetEffCalType
            // 
            this.cboxAdmDetEffCalType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetEffCalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetEffCalType.FormattingEnabled = true;
            this.cboxAdmDetEffCalType.Items.AddRange(new object[] {
            "INTERP",
            "EMP",
            "DUAL",
            "LINEAR"});
            this.cboxAdmDetEffCalType.Location = new System.Drawing.Point(783, 170);
            this.cboxAdmDetEffCalType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetEffCalType.Name = "cboxAdmDetEffCalType";
            this.cboxAdmDetEffCalType.Size = new System.Drawing.Size(193, 24);
            this.cboxAdmDetEffCalType.TabIndex = 25;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(198, 207);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(185, 17);
            this.label45.TabIndex = 26;
            this.label45.Text = "Max FHWMs between peaks";
            // 
            // tbAdmDetMaxFHWMBetPeaks
            // 
            this.tbAdmDetMaxFHWMBetPeaks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetMaxFHWMBetPeaks.Location = new System.Drawing.Point(393, 198);
            this.tbAdmDetMaxFHWMBetPeaks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetMaxFHWMBetPeaks.MaxLength = 16;
            this.tbAdmDetMaxFHWMBetPeaks.Name = "tbAdmDetMaxFHWMBetPeaks";
            this.tbAdmDetMaxFHWMBetPeaks.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetMaxFHWMBetPeaks.TabIndex = 27;
            this.tbAdmDetMaxFHWMBetPeaks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // cbAdmDetInUse
            // 
            this.cbAdmDetInUse.AutoSize = true;
            this.cbAdmDetInUse.Location = new System.Drawing.Point(198, 2);
            this.cbAdmDetInUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetInUse.Name = "cbAdmDetInUse";
            this.cbAdmDetInUse.Size = new System.Drawing.Size(65, 21);
            this.cbAdmDetInUse.TabIndex = 1;
            this.cbAdmDetInUse.Text = "I bruk";
            this.cbAdmDetInUse.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(3, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(98, 17);
            this.label36.TabIndex = 2;
            this.label36.Text = "Peak Locate";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(3, 84);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 17);
            this.label40.TabIndex = 10;
            this.label40.Text = "Peak Area";
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(588, 235);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(167, 17);
            this.label47.TabIndex = 30;
            this.label47.Text = "Max FHWMs for right limit";
            // 
            // tbAdmDetMaxFHWMRightLim
            // 
            this.tbAdmDetMaxFHWMRightLim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetMaxFHWMRightLim.Location = new System.Drawing.Point(783, 226);
            this.tbAdmDetMaxFHWMRightLim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetMaxFHWMRightLim.MaxLength = 16;
            this.tbAdmDetMaxFHWMRightLim.Name = "tbAdmDetMaxFHWMRightLim";
            this.tbAdmDetMaxFHWMRightLim.Size = new System.Drawing.Size(193, 22);
            this.tbAdmDetMaxFHWMRightLim.TabIndex = 31;
            this.tbAdmDetMaxFHWMRightLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(198, 235);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(158, 17);
            this.label46.TabIndex = 28;
            this.label46.Text = "Max FHWMs for left limit";
            // 
            // tbAdmDetMaxFHWMLeftLim
            // 
            this.tbAdmDetMaxFHWMLeftLim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetMaxFHWMLeftLim.Location = new System.Drawing.Point(393, 226);
            this.tbAdmDetMaxFHWMLeftLim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetMaxFHWMLeftLim.MaxLength = 16;
            this.tbAdmDetMaxFHWMLeftLim.Name = "tbAdmDetMaxFHWMLeftLim";
            this.tbAdmDetMaxFHWMLeftLim.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetMaxFHWMLeftLim.TabIndex = 29;
            this.tbAdmDetMaxFHWMLeftLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(198, 263);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(141, 17);
            this.label48.TabIndex = 32;
            this.label48.Text = "Background Subtract";
            // 
            // tbAdmDetBkgSub
            // 
            this.layoutAdmDet.SetColumnSpan(this.tbAdmDetBkgSub, 2);
            this.tbAdmDetBkgSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetBkgSub.Enabled = false;
            this.tbAdmDetBkgSub.Location = new System.Drawing.Point(393, 254);
            this.tbAdmDetBkgSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetBkgSub.MaxLength = 1024;
            this.tbAdmDetBkgSub.Name = "tbAdmDetBkgSub";
            this.tbAdmDetBkgSub.Size = new System.Drawing.Size(384, 22);
            this.tbAdmDetBkgSub.TabIndex = 33;
            // 
            // btnAdmDetBkgSub
            // 
            this.btnAdmDetBkgSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmDetBkgSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmDetBkgSub.Location = new System.Drawing.Point(783, 254);
            this.btnAdmDetBkgSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetBkgSub.Name = "btnAdmDetBkgSub";
            this.btnAdmDetBkgSub.Size = new System.Drawing.Size(193, 24);
            this.btnAdmDetBkgSub.TabIndex = 34;
            this.btnAdmDetBkgSub.Text = "...";
            this.btnAdmDetBkgSub.UseVisualStyleBackColor = true;
            this.btnAdmDetBkgSub.Click += new System.EventHandler(this.btnAdmDetBkgSub_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(3, 280);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(108, 17);
            this.label49.TabIndex = 35;
            this.label49.Text = "Nuclide Ident.";
            // 
            // label50
            // 
            this.label50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(198, 291);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(79, 17);
            this.label50.TabIndex = 36;
            this.label50.Text = "NID Library";
            // 
            // tbAdmDetNIDLib
            // 
            this.layoutAdmDet.SetColumnSpan(this.tbAdmDetNIDLib, 2);
            this.tbAdmDetNIDLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetNIDLib.Enabled = false;
            this.tbAdmDetNIDLib.Location = new System.Drawing.Point(393, 282);
            this.tbAdmDetNIDLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetNIDLib.MaxLength = 1024;
            this.tbAdmDetNIDLib.Name = "tbAdmDetNIDLib";
            this.tbAdmDetNIDLib.Size = new System.Drawing.Size(384, 22);
            this.tbAdmDetNIDLib.TabIndex = 37;
            // 
            // btnAdmDetNIDLib
            // 
            this.btnAdmDetNIDLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmDetNIDLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmDetNIDLib.Location = new System.Drawing.Point(783, 282);
            this.btnAdmDetNIDLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetNIDLib.Name = "btnAdmDetNIDLib";
            this.btnAdmDetNIDLib.Size = new System.Drawing.Size(193, 24);
            this.btnAdmDetNIDLib.TabIndex = 38;
            this.btnAdmDetNIDLib.Text = "...";
            this.btnAdmDetNIDLib.UseVisualStyleBackColor = true;
            this.btnAdmDetNIDLib.Click += new System.EventHandler(this.btnAdmDetNIDLib_Click);
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(198, 319);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(121, 17);
            this.label51.TabIndex = 39;
            this.label51.Text = "NID Conf. Thresh.";
            // 
            // tbAdmDetNIDConfThresh
            // 
            this.tbAdmDetNIDConfThresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetNIDConfThresh.Location = new System.Drawing.Point(393, 310);
            this.tbAdmDetNIDConfThresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetNIDConfThresh.MaxLength = 16;
            this.tbAdmDetNIDConfThresh.Name = "tbAdmDetNIDConfThresh";
            this.tbAdmDetNIDConfThresh.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetNIDConfThresh.TabIndex = 40;
            this.tbAdmDetNIDConfThresh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label52
            // 
            this.label52.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(588, 319);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(141, 17);
            this.label52.TabIndex = 41;
            this.label52.Text = "MDA Conf. factor (%)";
            // 
            // tbAdmDetMDAConfFac
            // 
            this.tbAdmDetMDAConfFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetMDAConfFac.Location = new System.Drawing.Point(783, 310);
            this.tbAdmDetMDAConfFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetMDAConfFac.MaxLength = 16;
            this.tbAdmDetMDAConfFac.Name = "tbAdmDetMDAConfFac";
            this.tbAdmDetMDAConfFac.Size = new System.Drawing.Size(193, 22);
            this.tbAdmDetMDAConfFac.TabIndex = 42;
            this.tbAdmDetMDAConfFac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // cbAdmDetInhibitATDCorr
            // 
            this.cbAdmDetInhibitATDCorr.AutoSize = true;
            this.cbAdmDetInhibitATDCorr.Location = new System.Drawing.Point(198, 338);
            this.cbAdmDetInhibitATDCorr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetInhibitATDCorr.Name = "cbAdmDetInhibitATDCorr";
            this.cbAdmDetInhibitATDCorr.Size = new System.Drawing.Size(134, 21);
            this.cbAdmDetInhibitATDCorr.TabIndex = 43;
            this.cbAdmDetInhibitATDCorr.Text = "Inhibit ATD Corr.";
            this.cbAdmDetInhibitATDCorr.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetUseStoredLib
            // 
            this.cbAdmDetUseStoredLib.AutoSize = true;
            this.cbAdmDetUseStoredLib.Location = new System.Drawing.Point(393, 338);
            this.cbAdmDetUseStoredLib.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetUseStoredLib.Name = "cbAdmDetUseStoredLib";
            this.cbAdmDetUseStoredLib.Size = new System.Drawing.Size(149, 21);
            this.cbAdmDetUseStoredLib.TabIndex = 44;
            this.cbAdmDetUseStoredLib.Text = "Use Stored Library";
            this.cbAdmDetUseStoredLib.UseVisualStyleBackColor = true;
            // 
            // cbAdmDetPerfMDATest
            // 
            this.cbAdmDetPerfMDATest.AutoSize = true;
            this.cbAdmDetPerfMDATest.Location = new System.Drawing.Point(588, 338);
            this.cbAdmDetPerfMDATest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmDetPerfMDATest.Name = "cbAdmDetPerfMDATest";
            this.cbAdmDetPerfMDATest.Size = new System.Drawing.Size(146, 21);
            this.cbAdmDetPerfMDATest.TabIndex = 45;
            this.cbAdmDetPerfMDATest.Text = "Perform MDA Test";
            this.cbAdmDetPerfMDATest.UseVisualStyleBackColor = true;
            // 
            // tabAdmDetPage2
            // 
            this.tabAdmDetPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdmDetPage2.Controls.Add(this.panel19);
            this.tabAdmDetPage2.Controls.Add(this.layoutAdmDetPage2);
            this.tabAdmDetPage2.Location = new System.Drawing.Point(4, 25);
            this.tabAdmDetPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmDetPage2.Name = "tabAdmDetPage2";
            this.tabAdmDetPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdmDetPage2.Size = new System.Drawing.Size(985, 409);
            this.tabAdmDetPage2.TabIndex = 1;
            this.tabAdmDetPage2.Text = "Side 2";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.gridAdmDetGeomCalQA);
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 220);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(979, 187);
            this.panel19.TabIndex = 1;
            // 
            // gridAdmDetGeomCalQA
            // 
            this.gridAdmDetGeomCalQA.AllowUserToAddRows = false;
            this.gridAdmDetGeomCalQA.AllowUserToDeleteRows = false;
            this.gridAdmDetGeomCalQA.AllowUserToResizeRows = false;
            this.gridAdmDetGeomCalQA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAdmDetGeomCalQA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridAdmDetGeomCalQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdmDetGeomCalQA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Geom,
            this.CalFile,
            this.QABeaker});
            this.gridAdmDetGeomCalQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAdmDetGeomCalQA.Location = new System.Drawing.Point(0, 0);
            this.gridAdmDetGeomCalQA.Margin = new System.Windows.Forms.Padding(4);
            this.gridAdmDetGeomCalQA.MultiSelect = false;
            this.gridAdmDetGeomCalQA.Name = "gridAdmDetGeomCalQA";
            this.gridAdmDetGeomCalQA.RowHeadersVisible = false;
            this.gridAdmDetGeomCalQA.RowHeadersWidth = 60;
            this.gridAdmDetGeomCalQA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAdmDetGeomCalQA.Size = new System.Drawing.Size(856, 187);
            this.gridAdmDetGeomCalQA.TabIndex = 1;
            // 
            // Geom
            // 
            this.Geom.FillWeight = 46.19689F;
            this.Geom.HeaderText = "Geom";
            this.Geom.Name = "Geom";
            this.Geom.ReadOnly = true;
            this.Geom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CalFile
            // 
            this.CalFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CalFile.FillWeight = 208.1178F;
            this.CalFile.HeaderText = "Cal Fil";
            this.CalFile.Name = "CalFile";
            this.CalFile.ReadOnly = true;
            this.CalFile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QABeaker
            // 
            this.QABeaker.FillWeight = 45.68528F;
            this.QABeaker.HeaderText = "QA Boks";
            this.QABeaker.Name = "QABeaker";
            this.QABeaker.ReadOnly = true;
            this.QABeaker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btnAdmDetGeomCalDelete);
            this.panel20.Controls.Add(this.btnAdmDetGeomCalEdit);
            this.panel20.Controls.Add(this.btnAdmDetGeomCalAdd);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel20.Location = new System.Drawing.Point(856, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(123, 187);
            this.panel20.TabIndex = 0;
            // 
            // btnAdmDetGeomCalDelete
            // 
            this.btnAdmDetGeomCalDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmDetGeomCalDelete.Location = new System.Drawing.Point(0, 56);
            this.btnAdmDetGeomCalDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetGeomCalDelete.Name = "btnAdmDetGeomCalDelete";
            this.btnAdmDetGeomCalDelete.Size = new System.Drawing.Size(123, 28);
            this.btnAdmDetGeomCalDelete.TabIndex = 2;
            this.btnAdmDetGeomCalDelete.Text = "Slett";
            this.btnAdmDetGeomCalDelete.UseVisualStyleBackColor = true;
            this.btnAdmDetGeomCalDelete.Click += new System.EventHandler(this.btnAdmDetGeomCalDelete_Click);
            // 
            // btnAdmDetGeomCalEdit
            // 
            this.btnAdmDetGeomCalEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmDetGeomCalEdit.Location = new System.Drawing.Point(0, 28);
            this.btnAdmDetGeomCalEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetGeomCalEdit.Name = "btnAdmDetGeomCalEdit";
            this.btnAdmDetGeomCalEdit.Size = new System.Drawing.Size(123, 28);
            this.btnAdmDetGeomCalEdit.TabIndex = 1;
            this.btnAdmDetGeomCalEdit.Text = "Rediger";
            this.btnAdmDetGeomCalEdit.UseVisualStyleBackColor = true;
            this.btnAdmDetGeomCalEdit.Click += new System.EventHandler(this.btnAdmDetGeomCalEdit_Click);
            // 
            // btnAdmDetGeomCalAdd
            // 
            this.btnAdmDetGeomCalAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmDetGeomCalAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdmDetGeomCalAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetGeomCalAdd.Name = "btnAdmDetGeomCalAdd";
            this.btnAdmDetGeomCalAdd.Size = new System.Drawing.Size(123, 28);
            this.btnAdmDetGeomCalAdd.TabIndex = 0;
            this.btnAdmDetGeomCalAdd.Text = "Legg Til";
            this.btnAdmDetGeomCalAdd.UseVisualStyleBackColor = true;
            this.btnAdmDetGeomCalAdd.Click += new System.EventHandler(this.btnAdmDetGeomCalAdd_Click);
            // 
            // layoutAdmDetPage2
            // 
            this.layoutAdmDetPage2.ColumnCount = 5;
            this.layoutAdmDetPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDetPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDetPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDetPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDetPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmDetPage2.Controls.Add(this.label53, 0, 0);
            this.layoutAdmDetPage2.Controls.Add(this.cboxAdmDetPresetArea, 2, 1);
            this.layoutAdmDetPage2.Controls.Add(this.label55, 1, 3);
            this.layoutAdmDetPage2.Controls.Add(this.cboxAdmDetPresetTime, 2, 3);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetPresetAreaValue, 3, 1);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetPresetTimeValue, 3, 3);
            this.layoutAdmDetPage2.Controls.Add(this.cboxAdmDetPresetTimeUnit, 4, 3);
            this.layoutAdmDetPage2.Controls.Add(this.label54, 1, 1);
            this.layoutAdmDetPage2.Controls.Add(this.label56, 1, 2);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetPresetAreaChanFrom, 2, 2);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetPresetAreaChanTo, 3, 2);
            this.layoutAdmDetPage2.Controls.Add(this.label57, 1, 4);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetRandErr, 2, 4);
            this.layoutAdmDetPage2.Controls.Add(this.label58, 3, 4);
            this.layoutAdmDetPage2.Controls.Add(this.tbAdmDetSysErr, 4, 4);
            this.layoutAdmDetPage2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutAdmDetPage2.Location = new System.Drawing.Point(3, 2);
            this.layoutAdmDetPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutAdmDetPage2.Name = "layoutAdmDetPage2";
            this.layoutAdmDetPage2.RowCount = 6;
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutAdmDetPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutAdmDetPage2.Size = new System.Drawing.Size(979, 218);
            this.layoutAdmDetPage2.TabIndex = 0;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(3, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(63, 17);
            this.label53.TabIndex = 0;
            this.label53.Text = "Presets";
            // 
            // cboxAdmDetPresetArea
            // 
            this.cboxAdmDetPresetArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetPresetArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetPresetArea.FormattingEnabled = true;
            this.cboxAdmDetPresetArea.Items.AddRange(new object[] {
            "",
            "INTPRESET",
            "AREAPRESET",
            "CNTSPRESET"});
            this.cboxAdmDetPresetArea.Location = new System.Drawing.Point(393, 30);
            this.cboxAdmDetPresetArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetPresetArea.Name = "cboxAdmDetPresetArea";
            this.cboxAdmDetPresetArea.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetPresetArea.TabIndex = 2;
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(198, 95);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(84, 17);
            this.label55.TabIndex = 3;
            this.label55.Text = "Preset Time";
            // 
            // cboxAdmDetPresetTime
            // 
            this.cboxAdmDetPresetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetPresetTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetPresetTime.FormattingEnabled = true;
            this.cboxAdmDetPresetTime.Items.AddRange(new object[] {
            "",
            "LIVEPRESET",
            "REALPRESET"});
            this.cboxAdmDetPresetTime.Location = new System.Drawing.Point(393, 86);
            this.cboxAdmDetPresetTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetPresetTime.Name = "cboxAdmDetPresetTime";
            this.cboxAdmDetPresetTime.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetPresetTime.TabIndex = 4;
            // 
            // tbAdmDetPresetAreaValue
            // 
            this.tbAdmDetPresetAreaValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPresetAreaValue.Location = new System.Drawing.Point(588, 30);
            this.tbAdmDetPresetAreaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPresetAreaValue.MaxLength = 16;
            this.tbAdmDetPresetAreaValue.Name = "tbAdmDetPresetAreaValue";
            this.tbAdmDetPresetAreaValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPresetAreaValue.TabIndex = 5;
            this.tbAdmDetPresetAreaValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetPresetTimeValue
            // 
            this.tbAdmDetPresetTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPresetTimeValue.Location = new System.Drawing.Point(588, 86);
            this.tbAdmDetPresetTimeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPresetTimeValue.MaxLength = 16;
            this.tbAdmDetPresetTimeValue.Name = "tbAdmDetPresetTimeValue";
            this.tbAdmDetPresetTimeValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPresetTimeValue.TabIndex = 6;
            this.tbAdmDetPresetTimeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // cboxAdmDetPresetTimeUnit
            // 
            this.cboxAdmDetPresetTimeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetPresetTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetPresetTimeUnit.FormattingEnabled = true;
            this.cboxAdmDetPresetTimeUnit.Items.AddRange(new object[] {
            "Sekunder",
            "Minutter",
            "Timer"});
            this.cboxAdmDetPresetTimeUnit.Location = new System.Drawing.Point(783, 86);
            this.cboxAdmDetPresetTimeUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetPresetTimeUnit.Name = "cboxAdmDetPresetTimeUnit";
            this.cboxAdmDetPresetTimeUnit.Size = new System.Drawing.Size(193, 24);
            this.cboxAdmDetPresetTimeUnit.TabIndex = 7;
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(198, 39);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 17);
            this.label54.TabIndex = 1;
            this.label54.Text = "Preset Area";
            // 
            // label56
            // 
            this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(198, 67);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(146, 17);
            this.label56.TabIndex = 8;
            this.label56.Text = "Preset Area Channels";
            // 
            // tbAdmDetPresetAreaChanFrom
            // 
            this.tbAdmDetPresetAreaChanFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPresetAreaChanFrom.Location = new System.Drawing.Point(393, 58);
            this.tbAdmDetPresetAreaChanFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPresetAreaChanFrom.MaxLength = 16;
            this.tbAdmDetPresetAreaChanFrom.Name = "tbAdmDetPresetAreaChanFrom";
            this.tbAdmDetPresetAreaChanFrom.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPresetAreaChanFrom.TabIndex = 9;
            this.tbAdmDetPresetAreaChanFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetPresetAreaChanTo
            // 
            this.tbAdmDetPresetAreaChanTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetPresetAreaChanTo.Location = new System.Drawing.Point(588, 58);
            this.tbAdmDetPresetAreaChanTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetPresetAreaChanTo.MaxLength = 16;
            this.tbAdmDetPresetAreaChanTo.Name = "tbAdmDetPresetAreaChanTo";
            this.tbAdmDetPresetAreaChanTo.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetPresetAreaChanTo.TabIndex = 10;
            this.tbAdmDetPresetAreaChanTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(198, 123);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(123, 17);
            this.label57.TabIndex = 11;
            this.label57.Text = "Random Error (%)";
            // 
            // tbAdmDetRandErr
            // 
            this.tbAdmDetRandErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetRandErr.Location = new System.Drawing.Point(393, 114);
            this.tbAdmDetRandErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetRandErr.MaxLength = 16;
            this.tbAdmDetRandErr.Name = "tbAdmDetRandErr";
            this.tbAdmDetRandErr.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetRandErr.TabIndex = 12;
            this.tbAdmDetRandErr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label58
            // 
            this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(588, 123);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(138, 17);
            this.label58.TabIndex = 13;
            this.label58.Text = "Systematic Error (%)";
            // 
            // tbAdmDetSysErr
            // 
            this.tbAdmDetSysErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetSysErr.Location = new System.Drawing.Point(783, 114);
            this.tbAdmDetSysErr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetSysErr.MaxLength = 16;
            this.tbAdmDetSysErr.Name = "tbAdmDetSysErr";
            this.tbAdmDetSysErr.Size = new System.Drawing.Size(193, 22);
            this.tbAdmDetSysErr.TabIndex = 14;
            this.tbAdmDetSysErr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // tabAdmDetPage3
            // 
            this.tabAdmDetPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdmDetPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabAdmDetPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabAdmDetPage3.Location = new System.Drawing.Point(4, 25);
            this.tabAdmDetPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdmDetPage3.Name = "tabAdmDetPage3";
            this.tabAdmDetPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdmDetPage3.Size = new System.Drawing.Size(985, 409);
            this.tabAdmDetPage3.TabIndex = 2;
            this.tabAdmDetPage3.Text = "Side 3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxAdmDetBkgPresetArea, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboxAdmDetBkgPresetTime, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbAdmDetBkgPresetAreaValue, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbAdmDetBkgPresetTimeValue, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboxAdmDetBkgPresetTimeUnit, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbAdmDetBkgPresetAreaChanFrom, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbAdmDetBkgPresetAreaChanTo, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 146);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(977, 142);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bakgrunn";
            // 
            // cboxAdmDetBkgPresetArea
            // 
            this.cboxAdmDetBkgPresetArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetBkgPresetArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetBkgPresetArea.FormattingEnabled = true;
            this.cboxAdmDetBkgPresetArea.Items.AddRange(new object[] {
            "",
            "INTPRESET",
            "AREAPRESET",
            "CNTSPRESET"});
            this.cboxAdmDetBkgPresetArea.Location = new System.Drawing.Point(393, 30);
            this.cboxAdmDetBkgPresetArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetBkgPresetArea.Name = "cboxAdmDetBkgPresetArea";
            this.cboxAdmDetBkgPresetArea.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetBkgPresetArea.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Preset Time";
            // 
            // cboxAdmDetBkgPresetTime
            // 
            this.cboxAdmDetBkgPresetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetBkgPresetTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetBkgPresetTime.FormattingEnabled = true;
            this.cboxAdmDetBkgPresetTime.Items.AddRange(new object[] {
            "",
            "LIVEPRESET",
            "REALPRESET"});
            this.cboxAdmDetBkgPresetTime.Location = new System.Drawing.Point(393, 86);
            this.cboxAdmDetBkgPresetTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetBkgPresetTime.Name = "cboxAdmDetBkgPresetTime";
            this.cboxAdmDetBkgPresetTime.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetBkgPresetTime.TabIndex = 4;
            // 
            // tbAdmDetBkgPresetAreaValue
            // 
            this.tbAdmDetBkgPresetAreaValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetBkgPresetAreaValue.Location = new System.Drawing.Point(588, 30);
            this.tbAdmDetBkgPresetAreaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetBkgPresetAreaValue.MaxLength = 16;
            this.tbAdmDetBkgPresetAreaValue.Name = "tbAdmDetBkgPresetAreaValue";
            this.tbAdmDetBkgPresetAreaValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetBkgPresetAreaValue.TabIndex = 5;
            this.tbAdmDetBkgPresetAreaValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetBkgPresetTimeValue
            // 
            this.tbAdmDetBkgPresetTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetBkgPresetTimeValue.Location = new System.Drawing.Point(588, 86);
            this.tbAdmDetBkgPresetTimeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetBkgPresetTimeValue.MaxLength = 16;
            this.tbAdmDetBkgPresetTimeValue.Name = "tbAdmDetBkgPresetTimeValue";
            this.tbAdmDetBkgPresetTimeValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetBkgPresetTimeValue.TabIndex = 6;
            this.tbAdmDetBkgPresetTimeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // cboxAdmDetBkgPresetTimeUnit
            // 
            this.cboxAdmDetBkgPresetTimeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetBkgPresetTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetBkgPresetTimeUnit.FormattingEnabled = true;
            this.cboxAdmDetBkgPresetTimeUnit.Items.AddRange(new object[] {
            "Sekunder",
            "Minutter",
            "Timer"});
            this.cboxAdmDetBkgPresetTimeUnit.Location = new System.Drawing.Point(783, 86);
            this.cboxAdmDetBkgPresetTimeUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetBkgPresetTimeUnit.Name = "cboxAdmDetBkgPresetTimeUnit";
            this.cboxAdmDetBkgPresetTimeUnit.Size = new System.Drawing.Size(191, 24);
            this.cboxAdmDetBkgPresetTimeUnit.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Preset Area";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Preset Area Channels";
            // 
            // tbAdmDetBkgPresetAreaChanFrom
            // 
            this.tbAdmDetBkgPresetAreaChanFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetBkgPresetAreaChanFrom.Location = new System.Drawing.Point(393, 58);
            this.tbAdmDetBkgPresetAreaChanFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetBkgPresetAreaChanFrom.MaxLength = 16;
            this.tbAdmDetBkgPresetAreaChanFrom.Name = "tbAdmDetBkgPresetAreaChanFrom";
            this.tbAdmDetBkgPresetAreaChanFrom.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetBkgPresetAreaChanFrom.TabIndex = 9;
            this.tbAdmDetBkgPresetAreaChanFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetBkgPresetAreaChanTo
            // 
            this.tbAdmDetBkgPresetAreaChanTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetBkgPresetAreaChanTo.Location = new System.Drawing.Point(588, 58);
            this.tbAdmDetBkgPresetAreaChanTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetBkgPresetAreaChanTo.MaxLength = 16;
            this.tbAdmDetBkgPresetAreaChanTo.Name = "tbAdmDetBkgPresetAreaChanTo";
            this.tbAdmDetBkgPresetAreaChanTo.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetBkgPresetAreaChanTo.TabIndex = 10;
            this.tbAdmDetBkgPresetAreaChanTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxAdmDetQAPresetArea, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboxAdmDetQAPresetTime, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbAdmDetQAPresetAreaValue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbAdmDetQAPresetTimeValue, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboxAdmDetQAPresetTimeUnit, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAdmDetQAPresetAreaChanFrom, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbAdmDetQAPresetAreaChanTo, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 142);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ref boks";
            // 
            // cboxAdmDetQAPresetArea
            // 
            this.cboxAdmDetQAPresetArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetQAPresetArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetQAPresetArea.FormattingEnabled = true;
            this.cboxAdmDetQAPresetArea.Items.AddRange(new object[] {
            "",
            "INTPRESET",
            "AREAPRESET",
            "CNTSPRESET"});
            this.cboxAdmDetQAPresetArea.Location = new System.Drawing.Point(393, 30);
            this.cboxAdmDetQAPresetArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetQAPresetArea.Name = "cboxAdmDetQAPresetArea";
            this.cboxAdmDetQAPresetArea.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetQAPresetArea.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preset Time";
            // 
            // cboxAdmDetQAPresetTime
            // 
            this.cboxAdmDetQAPresetTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetQAPresetTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetQAPresetTime.FormattingEnabled = true;
            this.cboxAdmDetQAPresetTime.Items.AddRange(new object[] {
            "",
            "LIVEPRESET",
            "REALPRESET"});
            this.cboxAdmDetQAPresetTime.Location = new System.Drawing.Point(393, 86);
            this.cboxAdmDetQAPresetTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetQAPresetTime.Name = "cboxAdmDetQAPresetTime";
            this.cboxAdmDetQAPresetTime.Size = new System.Drawing.Size(189, 24);
            this.cboxAdmDetQAPresetTime.TabIndex = 4;
            // 
            // tbAdmDetQAPresetAreaValue
            // 
            this.tbAdmDetQAPresetAreaValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetQAPresetAreaValue.Location = new System.Drawing.Point(588, 30);
            this.tbAdmDetQAPresetAreaValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetQAPresetAreaValue.MaxLength = 16;
            this.tbAdmDetQAPresetAreaValue.Name = "tbAdmDetQAPresetAreaValue";
            this.tbAdmDetQAPresetAreaValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetQAPresetAreaValue.TabIndex = 5;
            this.tbAdmDetQAPresetAreaValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetQAPresetTimeValue
            // 
            this.tbAdmDetQAPresetTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetQAPresetTimeValue.Location = new System.Drawing.Point(588, 86);
            this.tbAdmDetQAPresetTimeValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetQAPresetTimeValue.MaxLength = 16;
            this.tbAdmDetQAPresetTimeValue.Name = "tbAdmDetQAPresetTimeValue";
            this.tbAdmDetQAPresetTimeValue.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetQAPresetTimeValue.TabIndex = 6;
            this.tbAdmDetQAPresetTimeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // cboxAdmDetQAPresetTimeUnit
            // 
            this.cboxAdmDetQAPresetTimeUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmDetQAPresetTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmDetQAPresetTimeUnit.FormattingEnabled = true;
            this.cboxAdmDetQAPresetTimeUnit.Items.AddRange(new object[] {
            "Sekunder",
            "Minutter",
            "Timer"});
            this.cboxAdmDetQAPresetTimeUnit.Location = new System.Drawing.Point(783, 86);
            this.cboxAdmDetQAPresetTimeUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmDetQAPresetTimeUnit.Name = "cboxAdmDetQAPresetTimeUnit";
            this.cboxAdmDetQAPresetTimeUnit.Size = new System.Drawing.Size(191, 24);
            this.cboxAdmDetQAPresetTimeUnit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preset Area";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preset Area Channels";
            // 
            // tbAdmDetQAPresetAreaChanFrom
            // 
            this.tbAdmDetQAPresetAreaChanFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetQAPresetAreaChanFrom.Location = new System.Drawing.Point(393, 58);
            this.tbAdmDetQAPresetAreaChanFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetQAPresetAreaChanFrom.MaxLength = 16;
            this.tbAdmDetQAPresetAreaChanFrom.Name = "tbAdmDetQAPresetAreaChanFrom";
            this.tbAdmDetQAPresetAreaChanFrom.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetQAPresetAreaChanFrom.TabIndex = 9;
            this.tbAdmDetQAPresetAreaChanFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // tbAdmDetQAPresetAreaChanTo
            // 
            this.tbAdmDetQAPresetAreaChanTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmDetQAPresetAreaChanTo.Location = new System.Drawing.Point(588, 58);
            this.tbAdmDetQAPresetAreaChanTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmDetQAPresetAreaChanTo.MaxLength = 16;
            this.tbAdmDetQAPresetAreaChanTo.Name = "tbAdmDetQAPresetAreaChanTo";
            this.tbAdmDetQAPresetAreaChanTo.Size = new System.Drawing.Size(189, 22);
            this.tbAdmDetQAPresetAreaChanTo.TabIndex = 10;
            this.tbAdmDetQAPresetAreaChanTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Integer_KeyPress);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnAdmDetSave);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel21.Location = new System.Drawing.Point(0, 438);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(993, 28);
            this.panel21.TabIndex = 2;
            // 
            // btnAdmDetSave
            // 
            this.btnAdmDetSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdmDetSave.Location = new System.Drawing.Point(886, 0);
            this.btnAdmDetSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmDetSave.Name = "btnAdmDetSave";
            this.btnAdmDetSave.Size = new System.Drawing.Size(107, 28);
            this.btnAdmDetSave.TabIndex = 0;
            this.btnAdmDetSave.Text = "Lagre";
            this.btnAdmDetSave.UseVisualStyleBackColor = true;
            this.btnAdmDetSave.Click += new System.EventHandler(this.btnAdmDetSave_Click);
            // 
            // tabAdminGeom
            // 
            this.tabAdminGeom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdminGeom.Controls.Add(this.splitAdmGeom);
            this.tabAdminGeom.Location = new System.Drawing.Point(4, 25);
            this.tabAdminGeom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminGeom.Name = "tabAdminGeom";
            this.tabAdminGeom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminGeom.Size = new System.Drawing.Size(1109, 470);
            this.tabAdminGeom.TabIndex = 2;
            this.tabAdminGeom.Text = "Geometrier";
            // 
            // splitAdmGeom
            // 
            this.splitAdmGeom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAdmGeom.Location = new System.Drawing.Point(3, 2);
            this.splitAdmGeom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitAdmGeom.Name = "splitAdmGeom";
            // 
            // splitAdmGeom.Panel1
            // 
            this.splitAdmGeom.Panel1.Controls.Add(this.lbAdmGeomList);
            this.splitAdmGeom.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitAdmGeom.Panel2
            // 
            this.splitAdmGeom.Panel2.Controls.Add(this.layoutAdmGeom);
            this.splitAdmGeom.Panel2.Controls.Add(this.panel22);
            this.splitAdmGeom.Panel2.Enabled = false;
            this.splitAdmGeom.Size = new System.Drawing.Size(1103, 466);
            this.splitAdmGeom.SplitterDistance = 117;
            this.splitAdmGeom.TabIndex = 0;
            // 
            // lbAdmGeomList
            // 
            this.lbAdmGeomList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAdmGeomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdmGeomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmGeomList.FormattingEnabled = true;
            this.lbAdmGeomList.ItemHeight = 16;
            this.lbAdmGeomList.Location = new System.Drawing.Point(5, 5);
            this.lbAdmGeomList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdmGeomList.Name = "lbAdmGeomList";
            this.lbAdmGeomList.Size = new System.Drawing.Size(107, 456);
            this.lbAdmGeomList.TabIndex = 0;
            this.lbAdmGeomList.SelectedIndexChanged += new System.EventHandler(this.lbAdmGeomList_SelectedIndexChanged);
            // 
            // layoutAdmGeom
            // 
            this.layoutAdmGeom.ColumnCount = 4;
            this.layoutAdmGeom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmGeom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmGeom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmGeom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutAdmGeom.Controls.Add(this.label59, 0, 0);
            this.layoutAdmGeom.Controls.Add(this.tbAdmGeomManufacturer, 1, 0);
            this.layoutAdmGeom.Controls.Add(this.cbAdmGeomInUse, 1, 1);
            this.layoutAdmGeom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAdmGeom.Location = new System.Drawing.Point(0, 0);
            this.layoutAdmGeom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutAdmGeom.Name = "layoutAdmGeom";
            this.layoutAdmGeom.RowCount = 3;
            this.layoutAdmGeom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmGeom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmGeom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutAdmGeom.Size = new System.Drawing.Size(982, 438);
            this.layoutAdmGeom.TabIndex = 0;
            // 
            // label59
            // 
            this.label59.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(120, 11);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(73, 17);
            this.label59.TabIndex = 0;
            this.label59.Text = "Produsent";
            // 
            // tbAdmGeomManufacturer
            // 
            this.layoutAdmGeom.SetColumnSpan(this.tbAdmGeomManufacturer, 2);
            this.tbAdmGeomManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmGeomManufacturer.Location = new System.Drawing.Point(199, 2);
            this.tbAdmGeomManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmGeomManufacturer.MaxLength = 256;
            this.tbAdmGeomManufacturer.Name = "tbAdmGeomManufacturer";
            this.tbAdmGeomManufacturer.Size = new System.Drawing.Size(386, 22);
            this.tbAdmGeomManufacturer.TabIndex = 1;
            // 
            // cbAdmGeomInUse
            // 
            this.cbAdmGeomInUse.AutoSize = true;
            this.cbAdmGeomInUse.Enabled = false;
            this.cbAdmGeomInUse.Location = new System.Drawing.Point(199, 30);
            this.cbAdmGeomInUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmGeomInUse.Name = "cbAdmGeomInUse";
            this.cbAdmGeomInUse.Size = new System.Drawing.Size(66, 21);
            this.cbAdmGeomInUse.TabIndex = 2;
            this.cbAdmGeomInUse.Text = "I Bruk";
            this.cbAdmGeomInUse.UseVisualStyleBackColor = true;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnAdmGeomSave);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel22.Location = new System.Drawing.Point(0, 438);
            this.panel22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(982, 28);
            this.panel22.TabIndex = 1;
            // 
            // btnAdmGeomSave
            // 
            this.btnAdmGeomSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdmGeomSave.Location = new System.Drawing.Point(873, 0);
            this.btnAdmGeomSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmGeomSave.Name = "btnAdmGeomSave";
            this.btnAdmGeomSave.Size = new System.Drawing.Size(109, 28);
            this.btnAdmGeomSave.TabIndex = 0;
            this.btnAdmGeomSave.Text = "Lagre";
            this.btnAdmGeomSave.UseVisualStyleBackColor = true;
            this.btnAdmGeomSave.Click += new System.EventHandler(this.btnAdmGeomSave_Click);
            // 
            // tabAdminQA
            // 
            this.tabAdminQA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdminQA.Controls.Add(this.splitAdmQA);
            this.tabAdminQA.Location = new System.Drawing.Point(4, 25);
            this.tabAdminQA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminQA.Name = "tabAdminQA";
            this.tabAdminQA.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminQA.Size = new System.Drawing.Size(1109, 470);
            this.tabAdminQA.TabIndex = 3;
            this.tabAdminQA.Text = "QA bokser";
            // 
            // splitAdmQA
            // 
            this.splitAdmQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAdmQA.Location = new System.Drawing.Point(3, 2);
            this.splitAdmQA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitAdmQA.Name = "splitAdmQA";
            // 
            // splitAdmQA.Panel1
            // 
            this.splitAdmQA.Panel1.Controls.Add(this.lbAdmQAList);
            this.splitAdmQA.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitAdmQA.Panel2
            // 
            this.splitAdmQA.Panel2.Controls.Add(this.layoutAdmQA);
            this.splitAdmQA.Panel2.Controls.Add(this.panel23);
            this.splitAdmQA.Panel2.Enabled = false;
            this.splitAdmQA.Size = new System.Drawing.Size(1103, 466);
            this.splitAdmQA.SplitterDistance = 189;
            this.splitAdmQA.TabIndex = 0;
            // 
            // lbAdmQAList
            // 
            this.lbAdmQAList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAdmQAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdmQAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmQAList.FormattingEnabled = true;
            this.lbAdmQAList.ItemHeight = 16;
            this.lbAdmQAList.Location = new System.Drawing.Point(5, 5);
            this.lbAdmQAList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAdmQAList.Name = "lbAdmQAList";
            this.lbAdmQAList.Size = new System.Drawing.Size(179, 456);
            this.lbAdmQAList.TabIndex = 0;
            this.lbAdmQAList.SelectedIndexChanged += new System.EventHandler(this.lbAdmQAList_SelectedIndexChanged);
            // 
            // layoutAdmQA
            // 
            this.layoutAdmQA.ColumnCount = 4;
            this.layoutAdmQA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmQA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmQA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutAdmQA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutAdmQA.Controls.Add(this.cbAdmQAInUse, 1, 0);
            this.layoutAdmQA.Controls.Add(this.cboxAdmQABeaker, 1, 1);
            this.layoutAdmQA.Controls.Add(this.label60, 0, 1);
            this.layoutAdmQA.Controls.Add(this.label61, 0, 2);
            this.layoutAdmQA.Controls.Add(this.dtAdmQARefDate, 1, 2);
            this.layoutAdmQA.Controls.Add(this.dtAdmQARefTime, 2, 2);
            this.layoutAdmQA.Controls.Add(this.label62, 0, 3);
            this.layoutAdmQA.Controls.Add(this.tbAdmQASampType, 1, 3);
            this.layoutAdmQA.Controls.Add(this.label63, 0, 4);
            this.layoutAdmQA.Controls.Add(this.tbAdmQASampQuant, 1, 4);
            this.layoutAdmQA.Controls.Add(this.label64, 0, 5);
            this.layoutAdmQA.Controls.Add(this.cboxAdmQASampUnit, 1, 5);
            this.layoutAdmQA.Controls.Add(this.label65, 0, 6);
            this.layoutAdmQA.Controls.Add(this.tbAdmQASampUnc, 1, 6);
            this.layoutAdmQA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutAdmQA.Location = new System.Drawing.Point(0, 0);
            this.layoutAdmQA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutAdmQA.Name = "layoutAdmQA";
            this.layoutAdmQA.RowCount = 8;
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutAdmQA.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutAdmQA.Size = new System.Drawing.Size(910, 438);
            this.layoutAdmQA.TabIndex = 0;
            // 
            // cbAdmQAInUse
            // 
            this.cbAdmQAInUse.AutoSize = true;
            this.cbAdmQAInUse.Enabled = false;
            this.cbAdmQAInUse.Location = new System.Drawing.Point(185, 2);
            this.cbAdmQAInUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAdmQAInUse.Name = "cbAdmQAInUse";
            this.cbAdmQAInUse.Size = new System.Drawing.Size(66, 21);
            this.cbAdmQAInUse.TabIndex = 0;
            this.cbAdmQAInUse.Text = "I Bruk";
            this.cbAdmQAInUse.UseVisualStyleBackColor = true;
            // 
            // cboxAdmQABeaker
            // 
            this.layoutAdmQA.SetColumnSpan(this.cboxAdmQABeaker, 2);
            this.cboxAdmQABeaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmQABeaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmQABeaker.FormattingEnabled = true;
            this.cboxAdmQABeaker.Location = new System.Drawing.Point(185, 30);
            this.cboxAdmQABeaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmQABeaker.Name = "cboxAdmQABeaker";
            this.cboxAdmQABeaker.Size = new System.Drawing.Size(358, 24);
            this.cboxAdmQABeaker.TabIndex = 1;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(3, 28);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(66, 17);
            this.label60.TabIndex = 2;
            this.label60.Text = "Geometri";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(3, 56);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(68, 17);
            this.label61.TabIndex = 3;
            this.label61.Text = "Ref. Dato";
            // 
            // dtAdmQARefDate
            // 
            this.dtAdmQARefDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAdmQARefDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdmQARefDate.Location = new System.Drawing.Point(185, 58);
            this.dtAdmQARefDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAdmQARefDate.Name = "dtAdmQARefDate";
            this.dtAdmQARefDate.Size = new System.Drawing.Size(176, 22);
            this.dtAdmQARefDate.TabIndex = 4;
            // 
            // dtAdmQARefTime
            // 
            this.dtAdmQARefTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAdmQARefTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtAdmQARefTime.Location = new System.Drawing.Point(367, 58);
            this.dtAdmQARefTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtAdmQARefTime.Name = "dtAdmQARefTime";
            this.dtAdmQARefTime.ShowUpDown = true;
            this.dtAdmQARefTime.Size = new System.Drawing.Size(176, 22);
            this.dtAdmQARefTime.TabIndex = 5;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(3, 84);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(72, 17);
            this.label62.TabIndex = 6;
            this.label62.Text = "Prøvetype";
            // 
            // tbAdmQASampType
            // 
            this.layoutAdmQA.SetColumnSpan(this.tbAdmQASampType, 2);
            this.tbAdmQASampType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmQASampType.Location = new System.Drawing.Point(185, 86);
            this.tbAdmQASampType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmQASampType.MaxLength = 16;
            this.tbAdmQASampType.Name = "tbAdmQASampType";
            this.tbAdmQASampType.Size = new System.Drawing.Size(358, 22);
            this.tbAdmQASampType.TabIndex = 7;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(3, 112);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(96, 17);
            this.label63.TabIndex = 8;
            this.label63.Text = "Prøvemengde";
            // 
            // tbAdmQASampQuant
            // 
            this.layoutAdmQA.SetColumnSpan(this.tbAdmQASampQuant, 2);
            this.tbAdmQASampQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmQASampQuant.Location = new System.Drawing.Point(185, 114);
            this.tbAdmQASampQuant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmQASampQuant.MaxLength = 16;
            this.tbAdmQASampQuant.Name = "tbAdmQASampQuant";
            this.tbAdmQASampQuant.Size = new System.Drawing.Size(358, 22);
            this.tbAdmQASampQuant.TabIndex = 9;
            this.tbAdmQASampQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(3, 140);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(45, 17);
            this.label64.TabIndex = 10;
            this.label64.Text = "Enhet";
            // 
            // cboxAdmQASampUnit
            // 
            this.layoutAdmQA.SetColumnSpan(this.cboxAdmQASampUnit, 2);
            this.cboxAdmQASampUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxAdmQASampUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAdmQASampUnit.FormattingEnabled = true;
            this.cboxAdmQASampUnit.Items.AddRange(new object[] {
            "g",
            "Kg"});
            this.cboxAdmQASampUnit.Location = new System.Drawing.Point(185, 142);
            this.cboxAdmQASampUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxAdmQASampUnit.Name = "cboxAdmQASampUnit";
            this.cboxAdmQASampUnit.Size = new System.Drawing.Size(358, 24);
            this.cboxAdmQASampUnit.TabIndex = 11;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 168);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(113, 17);
            this.label65.TabIndex = 12;
            this.label65.Text = "Usikkerhet (Abs)";
            // 
            // tbAdmQASampUnc
            // 
            this.layoutAdmQA.SetColumnSpan(this.tbAdmQASampUnc, 2);
            this.tbAdmQASampUnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAdmQASampUnc.Location = new System.Drawing.Point(185, 170);
            this.tbAdmQASampUnc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdmQASampUnc.MaxLength = 16;
            this.tbAdmQASampUnc.Name = "tbAdmQASampUnc";
            this.tbAdmQASampUnc.Size = new System.Drawing.Size(358, 22);
            this.tbAdmQASampUnc.TabIndex = 13;
            this.tbAdmQASampUnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btnAdmQASave);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel23.Location = new System.Drawing.Point(0, 438);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(910, 28);
            this.panel23.TabIndex = 1;
            // 
            // btnAdmQASave
            // 
            this.btnAdmQASave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdmQASave.Location = new System.Drawing.Point(801, 0);
            this.btnAdmQASave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmQASave.Name = "btnAdmQASave";
            this.btnAdmQASave.Size = new System.Drawing.Size(109, 28);
            this.btnAdmQASave.TabIndex = 0;
            this.btnAdmQASave.Text = "Lagre";
            this.btnAdmQASave.UseVisualStyleBackColor = true;
            this.btnAdmQASave.Click += new System.EventHandler(this.btnAdmQASave_Click);
            // 
            // tabArchive
            // 
            this.tabArchive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabArchive.Controls.Add(this.splitArchive);
            this.tabArchive.Location = new System.Drawing.Point(4, 26);
            this.tabArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabArchive.Name = "tabArchive";
            this.tabArchive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabArchive.Size = new System.Drawing.Size(1123, 503);
            this.tabArchive.TabIndex = 5;
            this.tabArchive.Text = "Arkiv";
            // 
            // splitArchive
            // 
            this.splitArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitArchive.Location = new System.Drawing.Point(3, 2);
            this.splitArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitArchive.Name = "splitArchive";
            // 
            // splitArchive.Panel1
            // 
            this.splitArchive.Panel1.Controls.Add(this.tvArchive);
            // 
            // splitArchive.Panel2
            // 
            this.splitArchive.Panel2.Controls.Add(this.gridArchive);
            this.splitArchive.Panel2.Controls.Add(this.panel29);
            this.splitArchive.Size = new System.Drawing.Size(1117, 499);
            this.splitArchive.SplitterDistance = 175;
            this.splitArchive.TabIndex = 0;
            // 
            // tvArchive
            // 
            this.tvArchive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tvArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArchive.Location = new System.Drawing.Point(0, 0);
            this.tvArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvArchive.Name = "tvArchive";
            this.tvArchive.Size = new System.Drawing.Size(175, 499);
            this.tvArchive.TabIndex = 0;
            this.tvArchive.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArchive_AfterSelect);
            // 
            // gridArchive
            // 
            this.gridArchive.AllowUserToAddRows = false;
            this.gridArchive.AllowUserToDeleteRows = false;
            this.gridArchive.AllowUserToResizeRows = false;
            this.gridArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridArchive.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecRef,
            this.SampleID,
            this.Operation,
            this.Collector,
            this.Base});
            this.gridArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridArchive.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridArchive.Location = new System.Drawing.Point(0, 0);
            this.gridArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridArchive.MultiSelect = false;
            this.gridArchive.Name = "gridArchive";
            this.gridArchive.ReadOnly = true;
            this.gridArchive.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gridArchive.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridArchive.RowTemplate.Height = 24;
            this.gridArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridArchive.Size = new System.Drawing.Size(772, 499);
            this.gridArchive.TabIndex = 0;
            // 
            // SpecRef
            // 
            this.SpecRef.HeaderText = "Spekter";
            this.SpecRef.Name = "SpecRef";
            this.SpecRef.ReadOnly = true;
            // 
            // SampleID
            // 
            this.SampleID.HeaderText = "Prøve ID";
            this.SampleID.Name = "SampleID";
            this.SampleID.ReadOnly = true;
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Analyse Type";
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            // 
            // Collector
            // 
            this.Collector.HeaderText = "Bruker";
            this.Collector.Name = "Collector";
            this.Collector.ReadOnly = true;
            // 
            // Base
            // 
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            this.Base.ReadOnly = true;
            this.Base.Visible = false;
            // 
            // panel29
            // 
            this.panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel29.Controls.Add(this.btnArchiveShowSpectrum);
            this.panel29.Controls.Add(this.btnArchiveCreateBkg);
            this.panel29.Controls.Add(this.btnArchiveReanal);
            this.panel29.Controls.Add(this.btnOpenQAPlot);
            this.panel29.Controls.Add(this.btnArchiveShowReport);
            this.panel29.Controls.Add(this.btnArchiveShowParams);
            this.panel29.Controls.Add(this.btnArchivePrint);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel29.Location = new System.Drawing.Point(772, 0);
            this.panel29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(166, 499);
            this.panel29.TabIndex = 1;
            // 
            // btnArchiveShowSpectrum
            // 
            this.btnArchiveShowSpectrum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveShowSpectrum.Location = new System.Drawing.Point(0, 177);
            this.btnArchiveShowSpectrum.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveShowSpectrum.Name = "btnArchiveShowSpectrum";
            this.btnArchiveShowSpectrum.Size = new System.Drawing.Size(164, 28);
            this.btnArchiveShowSpectrum.TabIndex = 6;
            this.btnArchiveShowSpectrum.Text = "Vis spekter";
            this.btnArchiveShowSpectrum.UseVisualStyleBackColor = true;
            this.btnArchiveShowSpectrum.Click += new System.EventHandler(this.btnArchiveShowSpectrum_Click);
            // 
            // btnArchiveCreateBkg
            // 
            this.btnArchiveCreateBkg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveCreateBkg.Location = new System.Drawing.Point(0, 149);
            this.btnArchiveCreateBkg.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveCreateBkg.Name = "btnArchiveCreateBkg";
            this.btnArchiveCreateBkg.Size = new System.Drawing.Size(164, 28);
            this.btnArchiveCreateBkg.TabIndex = 5;
            this.btnArchiveCreateBkg.Text = "Opprett bkg";
            this.btnArchiveCreateBkg.UseVisualStyleBackColor = true;
            this.btnArchiveCreateBkg.Click += new System.EventHandler(this.btnArchiveCreateBkg_Click);
            // 
            // btnArchiveReanal
            // 
            this.btnArchiveReanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveReanal.Location = new System.Drawing.Point(0, 118);
            this.btnArchiveReanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchiveReanal.Name = "btnArchiveReanal";
            this.btnArchiveReanal.Size = new System.Drawing.Size(164, 31);
            this.btnArchiveReanal.TabIndex = 2;
            this.btnArchiveReanal.Text = "Reanalyser";
            this.btnArchiveReanal.UseVisualStyleBackColor = true;
            this.btnArchiveReanal.Click += new System.EventHandler(this.btnArchiveReanal_Click);
            // 
            // btnOpenQAPlot
            // 
            this.btnOpenQAPlot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenQAPlot.Location = new System.Drawing.Point(0, 87);
            this.btnOpenQAPlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenQAPlot.Name = "btnOpenQAPlot";
            this.btnOpenQAPlot.Size = new System.Drawing.Size(164, 31);
            this.btnOpenQAPlot.TabIndex = 1;
            this.btnOpenQAPlot.Text = "Vis QA-plott";
            this.btnOpenQAPlot.UseVisualStyleBackColor = true;
            this.btnOpenQAPlot.Click += new System.EventHandler(this.btnOpenQAPlot_Click);
            // 
            // btnArchiveShowReport
            // 
            this.btnArchiveShowReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveShowReport.Location = new System.Drawing.Point(0, 56);
            this.btnArchiveShowReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchiveShowReport.Name = "btnArchiveShowReport";
            this.btnArchiveShowReport.Size = new System.Drawing.Size(164, 31);
            this.btnArchiveShowReport.TabIndex = 0;
            this.btnArchiveShowReport.Text = "Vis rapport";
            this.btnArchiveShowReport.UseVisualStyleBackColor = true;
            this.btnArchiveShowReport.Click += new System.EventHandler(this.btnArchiveShowReport_Click);
            // 
            // btnArchiveShowParams
            // 
            this.btnArchiveShowParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchiveShowParams.Location = new System.Drawing.Point(0, 28);
            this.btnArchiveShowParams.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveShowParams.Name = "btnArchiveShowParams";
            this.btnArchiveShowParams.Size = new System.Drawing.Size(164, 28);
            this.btnArchiveShowParams.TabIndex = 3;
            this.btnArchiveShowParams.Text = "Vis parametere";
            this.btnArchiveShowParams.UseVisualStyleBackColor = true;
            this.btnArchiveShowParams.Click += new System.EventHandler(this.btnArchiveShowParams_Click);
            // 
            // btnArchivePrint
            // 
            this.btnArchivePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivePrint.Location = new System.Drawing.Point(0, 0);
            this.btnArchivePrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchivePrint.Name = "btnArchivePrint";
            this.btnArchivePrint.Size = new System.Drawing.Size(164, 28);
            this.btnArchivePrint.TabIndex = 4;
            this.btnArchivePrint.Text = "Print Analyse";
            this.btnArchivePrint.UseVisualStyleBackColor = true;
            this.btnArchivePrint.Click += new System.EventHandler(this.btnArchivePrint_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 613);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1006, 604);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scintilab - 1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabDetectors.ResumeLayout(false);
            this.tabJobs.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            this.panel27.ResumeLayout(false);
            this.tabSample.ResumeLayout(false);
            this.tabsSamples.ResumeLayout(false);
            this.tabSamplesParams.ResumeLayout(false);
            this.splitSamples.Panel1.ResumeLayout(false);
            this.splitSamples.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSamples)).EndInit();
            this.splitSamples.ResumeLayout(false);
            this.layoutSamples.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabsBuildup.ResumeLayout(false);
            this.tabBuildupNone.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.tabBuildupIrrad.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tabBuildupDeposit.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.tabSamplesAdvancedParams.ResumeLayout(false);
            this.layoutSamplesAdvanced.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabSamplesAnalParams.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabsAdmin.ResumeLayout(false);
            this.tabAdminGeneral.ResumeLayout(false);
            this.tabsAdminGeneral.ResumeLayout(false);
            this.tabAdminGeneral1.ResumeLayout(false);
            this.layoutAdminGeneral.ResumeLayout(false);
            this.layoutAdminGeneral.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.tabAdminDet.ResumeLayout(false);
            this.splitAdmDet.Panel1.ResumeLayout(false);
            this.splitAdmDet.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmDet)).EndInit();
            this.splitAdmDet.ResumeLayout(false);
            this.tabsAdmDetPages.ResumeLayout(false);
            this.tabAdmDetPage1.ResumeLayout(false);
            this.layoutAdmDet.ResumeLayout(false);
            this.layoutAdmDet.PerformLayout();
            this.tabAdmDetPage2.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAdmDetGeomCalQA)).EndInit();
            this.panel20.ResumeLayout(false);
            this.layoutAdmDetPage2.ResumeLayout(false);
            this.layoutAdmDetPage2.PerformLayout();
            this.tabAdmDetPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.tabAdminGeom.ResumeLayout(false);
            this.splitAdmGeom.Panel1.ResumeLayout(false);
            this.splitAdmGeom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmGeom)).EndInit();
            this.splitAdmGeom.ResumeLayout(false);
            this.layoutAdmGeom.ResumeLayout(false);
            this.layoutAdmGeom.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.tabAdminQA.ResumeLayout(false);
            this.splitAdmQA.Panel1.ResumeLayout(false);
            this.splitAdmQA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAdmQA)).EndInit();
            this.splitAdmQA.ResumeLayout(false);
            this.layoutAdmQA.ResumeLayout(false);
            this.layoutAdmQA.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.tabArchive.ResumeLayout(false);
            this.splitArchive.Panel1.ResumeLayout(false);
            this.splitArchive.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitArchive)).EndInit();
            this.splitArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArchive)).EndInit();
            this.panel29.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private TabControlWizard.TabControlWizard tabs;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tabDetectors;
        private System.Windows.Forms.TabPage tabJobs;
        private System.Windows.Forms.TabPage tabSample;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.Button btnMenuJobs;
        private System.Windows.Forms.Button btnMenuArchive;
        private System.Windows.Forms.ListView lvDetectors;
        private System.Windows.Forms.TabPage tabArchive;
        private System.Windows.Forms.ToolStripLabel lblToolsInterface;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList ilDetector;
        private System.Windows.Forms.ToolStripLabel lblToolsDetector;
        private System.Windows.Forms.TabControl tabsSamples;
        private System.Windows.Forms.TabPage tabSamplesParams;
        private System.Windows.Forms.TabPage tabSamplesAdvancedParams;
        private System.Windows.Forms.SplitContainer splitSamples;
        private System.Windows.Forms.TabControl tabsBuildup;
        private System.Windows.Forms.TabPage tabBuildupNone;
        private System.Windows.Forms.TabPage tabBuildupIrrad;
        private System.Windows.Forms.TabPage tabBuildupDeposit;
        private System.Windows.Forms.TableLayoutPanel layoutSamples;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSampDesc;
        private System.Windows.Forms.Label lblSampOrder;
        private System.Windows.Forms.TextBox tbSampDesc;
        private System.Windows.Forms.TextBox tbSampOrder;
        private System.Windows.Forms.Label lblSampQuant;
        private System.Windows.Forms.TextBox tbSampQuant;
        private System.Windows.Forms.Label lblSampGeom;
        private System.Windows.Forms.Label lblSampType;
        private System.Windows.Forms.Label lblSampID;
        private System.Windows.Forms.ComboBox cboxSampGeom;
        private System.Windows.Forms.TextBox tbSampType;
        private System.Windows.Forms.TextBox tbSampID;
        private System.Windows.Forms.Label lblSampCollector;
        private System.Windows.Forms.Label lblSampRef;
        private System.Windows.Forms.Label lblSampQuantUnc;
        private System.Windows.Forms.Label lblSampQuantUnit;
        private System.Windows.Forms.TextBox tbSampCollector;
        private System.Windows.Forms.TextBox tbSampRef;
        private System.Windows.Forms.TextBox tbSampQuantUnc;
        private System.Windows.Forms.ComboBox cboxSampQuantUnit;
        private System.Windows.Forms.TableLayoutPanel layoutSamplesAdvanced;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbSampAdvSystErr;
        private System.Windows.Forms.TextBox tbSampAdvRandErr;
        private System.Windows.Forms.ComboBox cboxSampAdvCal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbSampAdvPreAreaChanTo;
        private System.Windows.Forms.TextBox tbSampAdvPreAreaChanFrom;
        private System.Windows.Forms.TextBox tbSampAdvPreAreaValue;
        private System.Windows.Forms.ComboBox cboxSampAdvPreArea;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboxSampAdvPreTimeUnit;
        private System.Windows.Forms.TextBox tbSampAdvPreTimeValue;
        private System.Windows.Forms.ComboBox cboxSampAdvPreTime;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DateTimePicker dtSampBuildNoneTime;
        private System.Windows.Forms.DateTimePicker dtSampBuildNoneDate;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DateTimePicker dtSampBuildIrradTimeTo;
        private System.Windows.Forms.DateTimePicker dtSampBuildIrradDateTo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DateTimePicker dtSampBuildIrradTimeFrom;
        private System.Windows.Forms.DateTimePicker dtSampBuildIrradDateFrom;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.DateTimePicker dtSampBuildDepTimeTo;
        private System.Windows.Forms.DateTimePicker dtSampBuildDepDateTo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.DateTimePicker dtSampBuildDepTimeFrom;
        private System.Windows.Forms.DateTimePicker dtSampBuildDepDateFrom;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabControl tabsAdmin;
        private System.Windows.Forms.TabPage tabAdminGeneral;
        private System.Windows.Forms.TabPage tabAdminDet;
        private System.Windows.Forms.TabPage tabAdminGeom;
        private System.Windows.Forms.TabPage tabAdminQA;
        private System.Windows.Forms.SplitContainer splitAdmDet;
        private System.Windows.Forms.ListBox lbAdmDetList;
        private System.Windows.Forms.TabControl tabsAdmDetPages;
        private System.Windows.Forms.TabPage tabAdmDetPage1;
        private System.Windows.Forms.TableLayoutPanel layoutAdmDet;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbAdmDetInUse;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbAdmDetSearchRegionFrom;
        private System.Windows.Forms.TextBox tbAdmDetSearchRegionTo;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbAdmDetTolerance;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox tbAdmDetSignThresh;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbAdmDetPeakAreaRegionFrom;
        private System.Windows.Forms.TextBox tbAdmDetPeakAreaRegionTo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbAdmDetContinuum;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cboxAdmDetContinuumFunc;
        private System.Windows.Forms.TabPage tabAdmDetPage2;
        private System.Windows.Forms.CheckBox cbAdmDetCriticalLevel;
        private System.Windows.Forms.CheckBox cbAdmDetFitSinglets;
        private System.Windows.Forms.CheckBox cbAdmDetDisplayROIs;
        private System.Windows.Forms.CheckBox cbAdmDetUseFixedTailParam;
        private System.Windows.Forms.CheckBox cbAdmDetRejectZeroAreaPeaks;
        private System.Windows.Forms.CheckBox cbAdmDetUseFixedFWHM;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox cboxAdmDetEffCalType;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbAdmDetMaxFHWMBetPeaks;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbAdmDetMaxFHWMLeftLim;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tbAdmDetMaxFHWMRightLim;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tbAdmDetBkgSub;
        private System.Windows.Forms.Button btnAdmDetBkgSub;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tbAdmDetNIDLib;
        private System.Windows.Forms.Button btnAdmDetNIDLib;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tbAdmDetNIDConfThresh;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbAdmDetMDAConfFac;
        private System.Windows.Forms.CheckBox cbAdmDetInhibitATDCorr;
        private System.Windows.Forms.CheckBox cbAdmDetUseStoredLib;
        private System.Windows.Forms.CheckBox cbAdmDetPerfMDATest;
        private System.Windows.Forms.TableLayoutPanel layoutAdmDetPage2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cboxAdmDetPresetArea;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox cboxAdmDetPresetTime;
        private System.Windows.Forms.TextBox tbAdmDetPresetAreaValue;
        private System.Windows.Forms.TextBox tbAdmDetPresetTimeValue;
        private System.Windows.Forms.ComboBox cboxAdmDetPresetTimeUnit;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbAdmDetPresetAreaChanFrom;
        private System.Windows.Forms.TextBox tbAdmDetPresetAreaChanTo;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbAdmDetRandErr;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tbAdmDetSysErr;
        private System.Windows.Forms.Button btnAdmDetGeomCalDelete;
        private System.Windows.Forms.Button btnAdmDetGeomCalEdit;
        private System.Windows.Forms.Button btnAdmDetGeomCalAdd;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnAdmDetSave;
        private System.Windows.Forms.SplitContainer splitAdmGeom;
        private System.Windows.Forms.ListBox lbAdmGeomList;
        private System.Windows.Forms.TableLayoutPanel layoutAdmGeom;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tbAdmGeomManufacturer;
        private System.Windows.Forms.CheckBox cbAdmGeomInUse;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnAdmGeomSave;
        private System.Windows.Forms.SplitContainer splitAdmQA;
        private System.Windows.Forms.ListBox lbAdmQAList;
        private System.Windows.Forms.TableLayoutPanel layoutAdmQA;
        private System.Windows.Forms.CheckBox cbAdmQAInUse;
        private System.Windows.Forms.ComboBox cboxAdmQABeaker;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.DateTimePicker dtAdmQARefDate;
        private System.Windows.Forms.DateTimePicker dtAdmQARefTime;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox tbAdmQASampType;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox tbAdmQASampQuant;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cboxAdmQASampUnit;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox tbAdmQASampUnc;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnAdmQASave;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnSampReadBarcode;
        private System.Windows.Forms.Label lblSampComment;
        private System.Windows.Forms.TextBox tbSampComment;
        private System.Windows.Forms.Button btnMenuBarcodeWizard;
        private System.Windows.Forms.DataGridView gridAdmDetGeomCalQA;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Button btnAdmSave;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnSampStart;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView gridJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detector;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobStatus;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnJobOpenSpectrum;
        private System.Windows.Forms.Button btnJobsShowOutput;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SplitContainer splitArchive;
        private System.Windows.Forms.TreeView tvArchive;
        private System.Windows.Forms.DataGridView gridArchive;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Button btnArchiveReanal;
        private System.Windows.Forms.Button btnOpenQAPlot;
        private System.Windows.Forms.Button btnArchiveShowReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdmQANew;
        private System.Windows.Forms.TabControl tabsAdminGeneral;
        private System.Windows.Forms.TabPage tabAdminGeneral1;
        private System.Windows.Forms.TableLayoutPanel layoutAdminGeneral;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox cboxAdmSection;
        private System.Windows.Forms.TextBox tbAdmSigma;
        private System.Windows.Forms.TextBox tbAdmGenieFolder;
        private System.Windows.Forms.TextBox tbAdmTemplate;
        private System.Windows.Forms.TextBox tbAdmLIMSImport;
        private System.Windows.Forms.TextBox tbAdmLIMSExport;
        private System.Windows.Forms.Button btnAdmGenieFolder;
        private System.Windows.Forms.Button btnAdmTemplate;
        private System.Windows.Forms.Button btnAdmLIMSImport;
        private System.Windows.Forms.Button btnAdmLIMSExport;
        private System.Windows.Forms.Button btnMenuBarcodeWizardBkg;
        private System.Windows.Forms.Button btnMenuBarcodeWizardRef;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxAdmPlotScaleY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxAdmPlotScaleX;
        private System.Windows.Forms.Label lblSampIsReanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.Button btnJobShow;
        private System.Windows.Forms.TabPage tabSamplesAnalParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox tbSampAnalTolerance;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tbSampAnalSigThresh;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tbSampAnalContinuum;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox cboxSampAnalContinuumFunc;
        private System.Windows.Forms.CheckBox cbSampAnalCritLev;
        private System.Windows.Forms.CheckBox cbSampAnalFitSinglets;
        private System.Windows.Forms.CheckBox cbSampAnalDispRois;
        private System.Windows.Forms.CheckBox cbSampAnalUseFixed;
        private System.Windows.Forms.CheckBox cbSampAnalRejectZero;
        private System.Windows.Forms.CheckBox cbSampAnalFixedFWHM;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ComboBox cboxSampAnalEffCal;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox tbSampAnalMaxFWHMBetween;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox tbSampAnalMaxFWHMRight;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox tbSampAnalMaxFWHMLeft;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox tbSampAnalBkgSub;
        private System.Windows.Forms.Button btnSampAnalBkgSub;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox tbSampAnalNIDLib;
        private System.Windows.Forms.Button btnSampAnalNIDLib;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox tbSampAnalNIDConfThresh;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.TextBox tbSampAnalMDAConfFac;
        private System.Windows.Forms.CheckBox cbSampAnalInhibitATD;
        private System.Windows.Forms.CheckBox cbSampAnalUseStoredLib;
        private System.Windows.Forms.CheckBox cbSampAnalPerformMDA;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Button btnArchiveShowParams;
        private System.Windows.Forms.Button btnArchivePrint;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.TabPage tabAdmDetPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxAdmDetBkgPresetArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxAdmDetBkgPresetTime;
        private System.Windows.Forms.TextBox tbAdmDetBkgPresetAreaValue;
        private System.Windows.Forms.TextBox tbAdmDetBkgPresetTimeValue;
        private System.Windows.Forms.ComboBox cboxAdmDetBkgPresetTimeUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAdmDetBkgPresetAreaChanFrom;
        private System.Windows.Forms.TextBox tbAdmDetBkgPresetAreaChanTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxAdmDetQAPresetArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxAdmDetQAPresetTime;
        private System.Windows.Forms.TextBox tbAdmDetQAPresetAreaValue;
        private System.Windows.Forms.TextBox tbAdmDetQAPresetTimeValue;
        private System.Windows.Forms.ComboBox cboxAdmDetQAPresetTimeUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdmDetQAPresetAreaChanFrom;
        private System.Windows.Forms.TextBox tbAdmDetQAPresetAreaChanTo;
        private System.Windows.Forms.Button btnMenuBkgSample;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnMenuRegSample;
        private System.Windows.Forms.Button btnMenuRefSample;
        private System.Windows.Forms.Button btnArchiveCreateBkg;
        private System.Windows.Forms.Label lblSampAnalType;
        private System.Windows.Forms.ToolStripLabel lblStatusUsername;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnToolsLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn QABeaker;
        private System.Windows.Forms.ToolStripButton btnAdmGeoNew;
        private System.Windows.Forms.Button btnArchiveShowSpectrum;
    }
}

