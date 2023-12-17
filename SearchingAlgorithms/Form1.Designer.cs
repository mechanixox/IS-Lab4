using System.Windows.Forms;

namespace Barte_SearchAlgo { 
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnimationClock = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.artanPanel1 = new IDSystemGUI.ArtanPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.artanPanel2 = new IDSystemGUI.ArtanPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ComboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxStart = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artanPanel4 = new IDSystemGUI.ArtanPanel();
            this.ButtonAStar = new System.Windows.Forms.RadioButton();
            this.ButtonHC = new System.Windows.Forms.RadioButton();
            this.ButtonBeam = new System.Windows.Forms.RadioButton();
            this.ButtonBnB = new System.Windows.Forms.RadioButton();
            this.ButtonDFS = new System.Windows.Forms.RadioButton();
            this.ButtonBFS = new System.Windows.Forms.RadioButton();
            this.artanPanel3 = new IDSystemGUI.ArtanPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.ButtonUndoVertex = new System.Windows.Forms.Button();
            this.AddVertex = new System.Windows.Forms.CheckBox();
            this.ButtonFinalize = new System.Windows.Forms.Button();
            this.ButtonUndoEdge = new System.Windows.Forms.Button();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.AddEdge = new System.Windows.Forms.CheckBox();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.artanPanel5 = new IDSystemGUI.ArtanPanel();
            this.ButtonStepBack = new System.Windows.Forms.Button();
            this.ButtonStepForward = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.TrackbarSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.artanPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimationClock
            // 
            this.AnimationClock.Interval = 1000;
            this.AnimationClock.Tick += new System.EventHandler(this.AnimationClock_Tick);
            // 
            // PictureBoxGraph
            // 
            this.PictureBoxGraph.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PictureBoxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxGraph.Location = new System.Drawing.Point(3, 2);
            this.PictureBoxGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxGraph.Name = "PictureBoxGraph";
            this.PictureBoxGraph.Size = new System.Drawing.Size(1374, 827);
            this.PictureBoxGraph.TabIndex = 11;
            this.PictureBoxGraph.TabStop = false;
            this.PictureBoxGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxGraph_MouseClick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.artanPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1824, 89);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 20;
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(113)))), ((int)(((byte)(218)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(113)))), ((int)(((byte)(218)))));
            this.artanPanel1.Location = new System.Drawing.Point(7, 7);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1365, 74);
            this.artanPanel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 20.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 42);
            this.label3.TabIndex = 26;
            this.label3.Text = "SEARCHING VISUALIZATION";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 20;
            this.artanPanel2.Controls.Add(this.label2);
            this.artanPanel2.Controls.Add(this.ButtonRun);
            this.artanPanel2.Controls.Add(this.ComboBoxSearch);
            this.artanPanel2.Controls.Add(this.label1);
            this.artanPanel2.Controls.Add(this.ComboBoxStart);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel2.Location = new System.Drawing.Point(1384, 4);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(433, 78);
            this.artanPanel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Goal";
            // 
            // ButtonRun
            // 
            this.ButtonRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.ButtonRun.Enabled = false;
            this.ButtonRun.FlatAppearance.BorderSize = 0;
            this.ButtonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRun.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Bold);
            this.ButtonRun.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonRun.Location = new System.Drawing.Point(331, 0);
            this.ButtonRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(103, 78);
            this.ButtonRun.TabIndex = 0;
            this.ButtonRun.Text = "Run";
            this.ButtonRun.UseVisualStyleBackColor = false;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // ComboBoxSearch
            // 
            this.ComboBoxSearch.Enabled = false;
            this.ComboBoxSearch.FormattingEnabled = true;
            this.ComboBoxSearch.Location = new System.Drawing.Point(107, 41);
            this.ComboBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSearch.Name = "ComboBoxSearch";
            this.ComboBoxSearch.Size = new System.Drawing.Size(201, 24);
            this.ComboBoxSearch.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Start";
            // 
            // ComboBoxStart
            // 
            this.ComboBoxStart.Enabled = false;
            this.ComboBoxStart.FormattingEnabled = true;
            this.ComboBoxStart.Location = new System.Drawing.Point(107, 7);
            this.ComboBoxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxStart.Name = "ComboBoxStart";
            this.ComboBoxStart.Size = new System.Drawing.Size(201, 24);
            this.ComboBoxStart.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.artanPanel4);
            this.panel1.Controls.Add(this.artanPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1380, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 902);
            this.panel1.TabIndex = 33;
            // 
            // artanPanel4
            // 
            this.artanPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 20;
            this.artanPanel4.Controls.Add(this.ButtonAStar);
            this.artanPanel4.Controls.Add(this.ButtonHC);
            this.artanPanel4.Controls.Add(this.ButtonBeam);
            this.artanPanel4.Controls.Add(this.ButtonBnB);
            this.artanPanel4.Controls.Add(this.ButtonDFS);
            this.artanPanel4.Controls.Add(this.ButtonBFS);
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel4.Location = new System.Drawing.Point(7, 10);
            this.artanPanel4.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(427, 143);
            this.artanPanel4.TabIndex = 14;
            // 
            // ButtonAStar
            // 
            this.ButtonAStar.AutoSize = true;
            this.ButtonAStar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAStar.Enabled = false;
            this.ButtonAStar.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAStar.ForeColor = System.Drawing.Color.White;
            this.ButtonAStar.Location = new System.Drawing.Point(137, 95);
            this.ButtonAStar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAStar.Name = "ButtonAStar";
            this.ButtonAStar.Size = new System.Drawing.Size(60, 33);
            this.ButtonAStar.TabIndex = 7;
            this.ButtonAStar.TabStop = true;
            this.ButtonAStar.Text = "A*";
            this.ButtonAStar.UseVisualStyleBackColor = false;
            // 
            // ButtonHC
            // 
            this.ButtonHC.AutoSize = true;
            this.ButtonHC.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHC.Enabled = false;
            this.ButtonHC.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHC.ForeColor = System.Drawing.Color.White;
            this.ButtonHC.Location = new System.Drawing.Point(137, 53);
            this.ButtonHC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonHC.Name = "ButtonHC";
            this.ButtonHC.Size = new System.Drawing.Size(177, 33);
            this.ButtonHC.TabIndex = 5;
            this.ButtonHC.TabStop = true;
            this.ButtonHC.Text = "Hill-climbing";
            this.ButtonHC.UseVisualStyleBackColor = false;
            // 
            // ButtonBeam
            // 
            this.ButtonBeam.AutoSize = true;
            this.ButtonBeam.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBeam.Enabled = false;
            this.ButtonBeam.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBeam.ForeColor = System.Drawing.Color.White;
            this.ButtonBeam.Location = new System.Drawing.Point(27, 95);
            this.ButtonBeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBeam.Name = "ButtonBeam";
            this.ButtonBeam.Size = new System.Drawing.Size(99, 33);
            this.ButtonBeam.TabIndex = 4;
            this.ButtonBeam.TabStop = true;
            this.ButtonBeam.Text = "Beam";
            this.ButtonBeam.UseVisualStyleBackColor = false;
            // 
            // ButtonBnB
            // 
            this.ButtonBnB.AutoSize = true;
            this.ButtonBnB.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBnB.Enabled = false;
            this.ButtonBnB.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBnB.ForeColor = System.Drawing.Color.White;
            this.ButtonBnB.Location = new System.Drawing.Point(137, 12);
            this.ButtonBnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBnB.Name = "ButtonBnB";
            this.ButtonBnB.Size = new System.Drawing.Size(244, 33);
            this.ButtonBnB.TabIndex = 6;
            this.ButtonBnB.TabStop = true;
            this.ButtonBnB.Text = "Branch and Bound";
            this.ButtonBnB.UseVisualStyleBackColor = false;
            // 
            // ButtonDFS
            // 
            this.ButtonDFS.AutoSize = true;
            this.ButtonDFS.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDFS.Enabled = false;
            this.ButtonDFS.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDFS.ForeColor = System.Drawing.Color.White;
            this.ButtonDFS.Location = new System.Drawing.Point(27, 12);
            this.ButtonDFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDFS.Name = "ButtonDFS";
            this.ButtonDFS.Size = new System.Drawing.Size(80, 33);
            this.ButtonDFS.TabIndex = 3;
            this.ButtonDFS.TabStop = true;
            this.ButtonDFS.Text = "DFS";
            this.ButtonDFS.UseVisualStyleBackColor = false;
            // 
            // ButtonBFS
            // 
            this.ButtonBFS.AutoSize = true;
            this.ButtonBFS.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBFS.Enabled = false;
            this.ButtonBFS.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBFS.ForeColor = System.Drawing.Color.White;
            this.ButtonBFS.Location = new System.Drawing.Point(27, 53);
            this.ButtonBFS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBFS.Name = "ButtonBFS";
            this.ButtonBFS.Size = new System.Drawing.Size(79, 33);
            this.ButtonBFS.TabIndex = 2;
            this.ButtonBFS.TabStop = true;
            this.ButtonBFS.Text = "BFS";
            this.ButtonBFS.UseVisualStyleBackColor = false;
            this.ButtonBFS.CheckedChanged += new System.EventHandler(this.ButtonBFS_CheckedChanged);
            // 
            // artanPanel3
            // 
            this.artanPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 20;
            this.artanPanel3.Controls.Add(this.label4);
            this.artanPanel3.Controls.Add(this.LogBox);
            this.artanPanel3.Controls.Add(this.ButtonUndoVertex);
            this.artanPanel3.Controls.Add(this.AddVertex);
            this.artanPanel3.Controls.Add(this.ButtonFinalize);
            this.artanPanel3.Controls.Add(this.ButtonUndoEdge);
            this.artanPanel3.Controls.Add(this.ComboBoxFrom);
            this.artanPanel3.Controls.Add(this.AddEdge);
            this.artanPanel3.Controls.Add(this.ComboBoxTo);
            this.artanPanel3.Controls.Add(this.ButtonAdd);
            this.artanPanel3.Controls.Add(this.TextBoxWeight);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.artanPanel3.Location = new System.Drawing.Point(7, 162);
            this.artanPanel3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(429, 730);
            this.artanPanel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Weight:";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(179)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.ForeColor = System.Drawing.Color.White;
            this.LogBox.Location = new System.Drawing.Point(20, 332);
            this.LogBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(389, 382);
            this.LogBox.TabIndex = 25;
            this.LogBox.Text = "";
            // 
            // ButtonUndoVertex
            // 
            this.ButtonUndoVertex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ButtonUndoVertex.FlatAppearance.BorderSize = 0;
            this.ButtonUndoVertex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndoVertex.Font = new System.Drawing.Font("Inter", 11F);
            this.ButtonUndoVertex.Location = new System.Drawing.Point(228, 34);
            this.ButtonUndoVertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUndoVertex.Name = "ButtonUndoVertex";
            this.ButtonUndoVertex.Size = new System.Drawing.Size(165, 32);
            this.ButtonUndoVertex.TabIndex = 21;
            this.ButtonUndoVertex.Text = "Undo";
            this.ButtonUndoVertex.UseVisualStyleBackColor = false;
            this.ButtonUndoVertex.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // AddVertex
            // 
            this.AddVertex.AutoSize = true;
            this.AddVertex.BackColor = System.Drawing.Color.Transparent;
            this.AddVertex.Font = new System.Drawing.Font("Inter", 13F);
            this.AddVertex.ForeColor = System.Drawing.Color.White;
            this.AddVertex.Location = new System.Drawing.Point(37, 39);
            this.AddVertex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(91, 30);
            this.AddVertex.TabIndex = 11;
            this.AddVertex.Text = "Node";
            this.AddVertex.UseVisualStyleBackColor = false;
            this.AddVertex.CheckedChanged += new System.EventHandler(this.AddVertex_CheckedChanged);
            // 
            // ButtonFinalize
            // 
            this.ButtonFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.ButtonFinalize.FlatAppearance.BorderSize = 0;
            this.ButtonFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFinalize.Font = new System.Drawing.Font("Inter", 12F);
            this.ButtonFinalize.ForeColor = System.Drawing.Color.White;
            this.ButtonFinalize.Location = new System.Drawing.Point(272, 263);
            this.ButtonFinalize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFinalize.Name = "ButtonFinalize";
            this.ButtonFinalize.Size = new System.Drawing.Size(121, 42);
            this.ButtonFinalize.TabIndex = 18;
            this.ButtonFinalize.Text = "Ready";
            this.ButtonFinalize.UseVisualStyleBackColor = false;
            this.ButtonFinalize.Click += new System.EventHandler(this.ButtonFinalize_Click);
            // 
            // ButtonUndoEdge
            // 
            this.ButtonUndoEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ButtonUndoEdge.FlatAppearance.BorderSize = 0;
            this.ButtonUndoEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUndoEdge.Font = new System.Drawing.Font("Inter", 11F);
            this.ButtonUndoEdge.Location = new System.Drawing.Point(228, 87);
            this.ButtonUndoEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonUndoEdge.Name = "ButtonUndoEdge";
            this.ButtonUndoEdge.Size = new System.Drawing.Size(165, 32);
            this.ButtonUndoEdge.TabIndex = 22;
            this.ButtonUndoEdge.Text = "Undo";
            this.ButtonUndoEdge.UseVisualStyleBackColor = false;
            this.ButtonUndoEdge.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.Enabled = false;
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Location = new System.Drawing.Point(37, 154);
            this.ComboBoxFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(184, 24);
            this.ComboBoxFrom.TabIndex = 14;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.BackColor = System.Drawing.Color.Transparent;
            this.AddEdge.Font = new System.Drawing.Font("Inter", 13F);
            this.AddEdge.ForeColor = System.Drawing.Color.White;
            this.AddEdge.Location = new System.Drawing.Point(37, 89);
            this.AddEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(87, 30);
            this.AddEdge.TabIndex = 12;
            this.AddEdge.Text = "Edge";
            this.AddEdge.UseVisualStyleBackColor = false;
            this.AddEdge.CheckedChanged += new System.EventHandler(this.AddEdge_CheckedChanged);
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.Enabled = false;
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Location = new System.Drawing.Point(228, 154);
            this.ComboBoxTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxTo.TabIndex = 15;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Inter", 12F);
            this.ButtonAdd.Location = new System.Drawing.Point(37, 263);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(213, 42);
            this.ButtonAdd.TabIndex = 13;
            this.ButtonAdd.Text = "Connect nodes";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Enabled = false;
            this.TextBoxWeight.Location = new System.Drawing.Point(37, 214);
            this.TextBoxWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(355, 22);
            this.TextBoxWeight.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 902);
            this.panel2.TabIndex = 34;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PictureBoxGraph, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.artanPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.1286F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.871397F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1380, 902);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // artanPanel5
            // 
            this.artanPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel5.BackColor = System.Drawing.Color.White;
            this.artanPanel5.BorderRadius = 20;
            this.artanPanel5.Controls.Add(this.ButtonStepBack);
            this.artanPanel5.Controls.Add(this.ButtonStepForward);
            this.artanPanel5.Controls.Add(this.ButtonPause);
            this.artanPanel5.Controls.Add(this.TrackbarSpeed);
            this.artanPanel5.ForeColor = System.Drawing.Color.Black;
            this.artanPanel5.GradientAngle = 90F;
            this.artanPanel5.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(149)))), ((int)(((byte)(231)))));
            this.artanPanel5.Location = new System.Drawing.Point(3, 835);
            this.artanPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.artanPanel5.Name = "artanPanel5";
            this.artanPanel5.Size = new System.Drawing.Size(1374, 57);
            this.artanPanel5.TabIndex = 14;
            // 
            // ButtonStepBack
            // 
            this.ButtonStepBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(179)))));
            this.ButtonStepBack.Enabled = false;
            this.ButtonStepBack.FlatAppearance.BorderSize = 0;
            this.ButtonStepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStepBack.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStepBack.ForeColor = System.Drawing.Color.White;
            this.ButtonStepBack.Location = new System.Drawing.Point(31, 16);
            this.ButtonStepBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonStepBack.Name = "ButtonStepBack";
            this.ButtonStepBack.Size = new System.Drawing.Size(112, 30);
            this.ButtonStepBack.TabIndex = 21;
            this.ButtonStepBack.Text = "Prev";
            this.ButtonStepBack.UseVisualStyleBackColor = false;
            // 
            // ButtonStepForward
            // 
            this.ButtonStepForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(179)))));
            this.ButtonStepForward.Enabled = false;
            this.ButtonStepForward.FlatAppearance.BorderSize = 0;
            this.ButtonStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStepForward.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStepForward.ForeColor = System.Drawing.Color.White;
            this.ButtonStepForward.Location = new System.Drawing.Point(165, 16);
            this.ButtonStepForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonStepForward.Name = "ButtonStepForward";
            this.ButtonStepForward.Size = new System.Drawing.Size(112, 30);
            this.ButtonStepForward.TabIndex = 22;
            this.ButtonStepForward.Text = "Forward";
            this.ButtonStepForward.UseVisualStyleBackColor = false;
            this.ButtonStepForward.Click += new System.EventHandler(this.ButtonStepForward_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(179)))));
            this.ButtonPause.Enabled = false;
            this.ButtonPause.FlatAppearance.BorderSize = 0;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPause.ForeColor = System.Drawing.Color.White;
            this.ButtonPause.Location = new System.Drawing.Point(300, 16);
            this.ButtonPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(112, 30);
            this.ButtonPause.TabIndex = 19;
            this.ButtonPause.Text = "Play";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // TrackbarSpeed
            // 
            this.TrackbarSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(123)))), ((int)(((byte)(179)))));
            this.TrackbarSpeed.Enabled = false;
            this.TrackbarSpeed.Location = new System.Drawing.Point(1179, 4);
            this.TrackbarSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackbarSpeed.Minimum = 1;
            this.TrackbarSpeed.Name = "TrackbarSpeed";
            this.TrackbarSpeed.Size = new System.Drawing.Size(195, 56);
            this.TrackbarSpeed.TabIndex = 1;
            this.TrackbarSpeed.Value = 1;
            this.TrackbarSpeed.Scroll += new System.EventHandler(this.TrackbarSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1824, 991);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1439, 1018);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGraph)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.artanPanel5.ResumeLayout(false);
            this.artanPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonRun;
        private RadioButton ButtonBFS;
        private RadioButton ButtonDFS;
        private RadioButton ButtonBeam;
        private RadioButton ButtonHC;
        private RadioButton ButtonBnB;
        private RadioButton ButtonAStar;
        private ComboBox ComboBoxStart;
        private ComboBox ComboBoxSearch;
        private System.Windows.Forms.Timer AnimationClock;
        private PictureBox PictureBoxGraph;
        private Label label2;
        private Label label1;
        private Button ButtonFinalize;
        private Button ButtonAdd;
        private TextBox TextBoxWeight;
        private Button ButtonUndoEdge;
        private ComboBox ComboBoxTo;
        private RichTextBox LogBox;
        private CheckBox AddVertex;
        private ComboBox ComboBoxFrom;
        private CheckBox AddEdge;
        private Button ButtonUndoVertex;
        private IDSystemGUI.ArtanPanel artanPanel1;
        private IDSystemGUI.ArtanPanel artanPanel2;
        private IDSystemGUI.ArtanPanel artanPanel3;
        private IDSystemGUI.ArtanPanel artanPanel4;
        private TrackBar TrackbarSpeed;
        private Button ButtonPause;
        private Button ButtonStepBack;
        private Button ButtonStepForward;
        private IDSystemGUI.ArtanPanel artanPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
    }
}