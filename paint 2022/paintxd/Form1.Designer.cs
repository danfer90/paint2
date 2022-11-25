namespace Paint1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.figurePolygon = new System.Windows.Forms.Button();
            this.figureTriangle = new System.Windows.Forms.Button();
            this.figureCircle = new System.Windows.Forms.Button();
            this.figureSquare = new System.Windows.Forms.Button();
            this.pointPolygon = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.colorBt = new System.Windows.Forms.Button();
            this.trackBrush = new System.Windows.Forms.TrackBar();
            this.cleanBt = new System.Windows.Forms.Button();
            this.brushTool = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VectorTools = new System.Windows.Forms.ToolStripMenuItem();
            this.RastrTools = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.rastr = new System.Windows.Forms.Panel();
            this.vector = new System.Windows.Forms.Panel();
            this.canvas_vector = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Drag = new System.Windows.Forms.Button();
            this.change_figure = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.triangleVectorBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.clBtn_vec = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.rastr.SuspendLayout();
            this.vector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_vector)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Moccasin;
            this.panel.Controls.Add(this.figurePolygon);
            this.panel.Controls.Add(this.fill);
            this.panel.Controls.Add(this.figureCircle);
            this.panel.Controls.Add(this.figureTriangle);
            this.panel.Controls.Add(this.numericUpDown1);
            this.panel.Controls.Add(this.brushTool);
            this.panel.Controls.Add(this.pointPolygon);
            this.panel.Controls.Add(this.figureSquare);
            this.panel.Controls.Add(this.cleanBt);
            this.panel.Controls.Add(this.colorBt);
            this.panel.Controls.Add(this.trackBrush);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(653, 52);
            this.panel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(200, 14);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // figurePolygon
            // 
            this.figurePolygon.BackColor = System.Drawing.Color.White;
            this.figurePolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figurePolygon.BackgroundImage")));
            this.figurePolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figurePolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figurePolygon.FlatAppearance.BorderSize = 0;
            this.figurePolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figurePolygon.Location = new System.Drawing.Point(166, 15);
            this.figurePolygon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.figurePolygon.Name = "figurePolygon";
            this.figurePolygon.Size = new System.Drawing.Size(14, 20);
            this.figurePolygon.TabIndex = 8;
            this.figurePolygon.UseVisualStyleBackColor = false;
            this.figurePolygon.Click += new System.EventHandler(this.figurePolygon_Click);
            // 
            // figureTriangle
            // 
            this.figureTriangle.BackColor = System.Drawing.Color.White;
            this.figureTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureTriangle.BackgroundImage")));
            this.figureTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureTriangle.FlatAppearance.BorderSize = 0;
            this.figureTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureTriangle.Location = new System.Drawing.Point(130, 14);
            this.figureTriangle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.figureTriangle.Name = "figureTriangle";
            this.figureTriangle.Size = new System.Drawing.Size(14, 20);
            this.figureTriangle.TabIndex = 7;
            this.figureTriangle.UseVisualStyleBackColor = false;
            this.figureTriangle.Click += new System.EventHandler(this.figureTriangle_Click);
            // 
            // figureCircle
            // 
            this.figureCircle.BackColor = System.Drawing.Color.White;
            this.figureCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureCircle.BackgroundImage")));
            this.figureCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureCircle.FlatAppearance.BorderSize = 0;
            this.figureCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureCircle.Location = new System.Drawing.Point(148, 14);
            this.figureCircle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.figureCircle.Name = "figureCircle";
            this.figureCircle.Size = new System.Drawing.Size(14, 20);
            this.figureCircle.TabIndex = 6;
            this.figureCircle.UseVisualStyleBackColor = false;
            this.figureCircle.Click += new System.EventHandler(this.figureCircle_Click);
            // 
            // figureSquare
            // 
            this.figureSquare.BackColor = System.Drawing.Color.White;
            this.figureSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureSquare.BackgroundImage")));
            this.figureSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureSquare.FlatAppearance.BorderSize = 0;
            this.figureSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureSquare.Location = new System.Drawing.Point(94, 14);
            this.figureSquare.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.figureSquare.Name = "figureSquare";
            this.figureSquare.Size = new System.Drawing.Size(14, 20);
            this.figureSquare.TabIndex = 3;
            this.figureSquare.UseVisualStyleBackColor = false;
            this.figureSquare.Click += new System.EventHandler(this.figureSquare_Click);
            // 
            // pointPolygon
            // 
            this.pointPolygon.BackColor = System.Drawing.Color.White;
            this.pointPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pointPolygon.BackgroundImage")));
            this.pointPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pointPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointPolygon.FlatAppearance.BorderSize = 0;
            this.pointPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointPolygon.Location = new System.Drawing.Point(112, 14);
            this.pointPolygon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pointPolygon.Name = "pointPolygon";
            this.pointPolygon.Size = new System.Drawing.Size(14, 20);
            this.pointPolygon.TabIndex = 5;
            this.pointPolygon.UseVisualStyleBackColor = false;
            this.pointPolygon.Click += new System.EventHandler(this.pointPolygon_Click);
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.Color.White;
            this.fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill.BackgroundImage")));
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill.FlatAppearance.BorderSize = 0;
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.Location = new System.Drawing.Point(65, 14);
            this.fill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(14, 20);
            this.fill.TabIndex = 5;
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // colorBt
            // 
            this.colorBt.BackColor = System.Drawing.Color.Black;
            this.colorBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBt.FlatAppearance.BorderSize = 0;
            this.colorBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBt.Location = new System.Drawing.Point(47, 14);
            this.colorBt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(14, 20);
            this.colorBt.TabIndex = 1;
            this.colorBt.UseVisualStyleBackColor = false;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // trackBrush
            // 
            this.trackBrush.AutoSize = false;
            this.trackBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrush.Location = new System.Drawing.Point(250, 14);
            this.trackBrush.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(137, 26);
            this.trackBrush.TabIndex = 2;
            this.trackBrush.ValueChanged += new System.EventHandler(this.trackBrush_ValueChanged);
            // 
            // cleanBt
            // 
            this.cleanBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBt.BackgroundImage")));
            this.cleanBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBt.FlatAppearance.BorderSize = 0;
            this.cleanBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBt.Location = new System.Drawing.Point(11, 14);
            this.cleanBt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(14, 20);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.cleanBt_Click);
            // 
            // brushTool
            // 
            this.brushTool.BackColor = System.Drawing.Color.White;
            this.brushTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushTool.BackgroundImage")));
            this.brushTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brushTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushTool.FlatAppearance.BorderSize = 0;
            this.brushTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushTool.Location = new System.Drawing.Point(29, 14);
            this.brushTool.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(14, 20);
            this.brushTool.TabIndex = 4;
            this.brushTool.UseVisualStyleBackColor = false;
            this.brushTool.Click += new System.EventHandler(this.brushTool_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.ErrorImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 58);
            this.canvas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(653, 780);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.DoubleClick += new System.EventHandler(this.canvas_DoubleClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1142, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VectorTools,
            this.RastrTools,
            this.Save,
            this.SaveAs,
            this.load});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.менюToolStripMenuItem.Text = "Menú";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // VectorTools
            // 
            this.VectorTools.Name = "VectorTools";
            this.VectorTools.Size = new System.Drawing.Size(180, 22);
            this.VectorTools.Text = "Gráficos vectoriales";
            this.VectorTools.Click += new System.EventHandler(this.VectorTools_Click_1);
            // 
            // RastrTools
            // 
            this.RastrTools.Name = "RastrTools";
            this.RastrTools.Size = new System.Drawing.Size(180, 22);
            this.RastrTools.Text = "Gráficos de trama";
            this.RastrTools.Click += new System.EventHandler(this.RastrTools_Click_1);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Guardar";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Guardar como";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(180, 22);
            this.load.Text = "Descargar";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // rastr
            // 
            this.rastr.Controls.Add(this.panel);
            this.rastr.Controls.Add(this.canvas);
            this.rastr.Location = new System.Drawing.Point(10, 31);
            this.rastr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rastr.Name = "rastr";
            this.rastr.Size = new System.Drawing.Size(653, 831);
            this.rastr.TabIndex = 2;
            // 
            // vector
            // 
            this.vector.Controls.Add(this.canvas_vector);
            this.vector.Controls.Add(this.panel3);
            this.vector.Location = new System.Drawing.Point(669, 32);
            this.vector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.vector.Name = "vector";
            this.vector.Size = new System.Drawing.Size(644, 831);
            this.vector.TabIndex = 3;
            // 
            // canvas_vector
            // 
            this.canvas_vector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas_vector.ErrorImage = null;
            this.canvas_vector.Location = new System.Drawing.Point(0, 84);
            this.canvas_vector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.canvas_vector.Name = "canvas_vector";
            this.canvas_vector.Size = new System.Drawing.Size(644, 747);
            this.canvas_vector.TabIndex = 4;
            this.canvas_vector.TabStop = false;
            this.canvas_vector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseDown);
            this.canvas_vector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseMove);
            this.canvas_vector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Drag);
            this.panel3.Controls.Add(this.change_figure);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 84);
            this.panel3.TabIndex = 3;
            // 
            // Drag
            // 
            this.Drag.BackColor = System.Drawing.Color.White;
            this.Drag.FlatAppearance.BorderSize = 0;
            this.Drag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drag.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drag.Location = new System.Drawing.Point(323, 17);
            this.Drag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Drag.Name = "Drag";
            this.Drag.Size = new System.Drawing.Size(83, 44);
            this.Drag.TabIndex = 9;
            this.Drag.Text = "Drag";
            this.Drag.UseVisualStyleBackColor = false;
            this.Drag.Click += new System.EventHandler(this.Drag_Click);
            // 
            // change_figure
            // 
            this.change_figure.BackColor = System.Drawing.Color.White;
            this.change_figure.FlatAppearance.BorderSize = 0;
            this.change_figure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_figure.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_figure.Location = new System.Drawing.Point(243, 17);
            this.change_figure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.change_figure.Name = "change_figure";
            this.change_figure.Size = new System.Drawing.Size(83, 44);
            this.change_figure.TabIndex = 8;
            this.change_figure.Text = "Change";
            this.change_figure.UseVisualStyleBackColor = false;
            this.change_figure.Click += new System.EventHandler(this.change_figure_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.triangleVectorBtn);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.square);
            this.panel4.Location = new System.Drawing.Point(173, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 62);
            this.panel4.TabIndex = 7;
            // 
            // triangleVectorBtn
            // 
            this.triangleVectorBtn.BackColor = System.Drawing.Color.White;
            this.triangleVectorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangleVectorBtn.BackgroundImage")));
            this.triangleVectorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangleVectorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleVectorBtn.FlatAppearance.BorderSize = 0;
            this.triangleVectorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleVectorBtn.Location = new System.Drawing.Point(22, 3);
            this.triangleVectorBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.triangleVectorBtn.Name = "triangleVectorBtn";
            this.triangleVectorBtn.Size = new System.Drawing.Size(13, 20);
            this.triangleVectorBtn.TabIndex = 7;
            this.triangleVectorBtn.UseVisualStyleBackColor = false;
            this.triangleVectorBtn.Click += new System.EventHandler(this.triangleVectorBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(41, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(14, 20);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.Color.White;
            this.square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("square.BackgroundImage")));
            this.square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Location = new System.Drawing.Point(2, 3);
            this.square.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(14, 20);
            this.square.TabIndex = 3;
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.clBtn_vec);
            this.panel5.Controls.Add(this.line);
            this.panel5.Location = new System.Drawing.Point(10, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 63);
            this.panel5.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(21, 3);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(14, 20);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(40, 3);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(105, 43);
            this.trackBar1.TabIndex = 2;
            // 
            // clBtn_vec
            // 
            this.clBtn_vec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clBtn_vec.BackgroundImage")));
            this.clBtn_vec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clBtn_vec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clBtn_vec.FlatAppearance.BorderSize = 0;
            this.clBtn_vec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clBtn_vec.Location = new System.Drawing.Point(2, 30);
            this.clBtn_vec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clBtn_vec.Name = "clBtn_vec";
            this.clBtn_vec.Size = new System.Drawing.Size(14, 20);
            this.clBtn_vec.TabIndex = 1;
            this.clBtn_vec.UseVisualStyleBackColor = true;
            this.clBtn_vec.Click += new System.EventHandler(this.clBtn_vec_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(2, 3);
            this.line.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(14, 20);
            this.line.TabIndex = 4;
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1142, 749);
            this.Controls.Add(this.vector);
            this.Controls.Add(this.rastr);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "paint2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rastr.ResumeLayout(false);
            this.vector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas_vector)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button cleanBt;
        private System.Windows.Forms.Button colorBt;
        private System.Windows.Forms.Button figureSquare;
        private System.Windows.Forms.Button brushTool;
        private System.Windows.Forms.Button pointPolygon;
        private System.Windows.Forms.Button figureCircle;
        public System.Windows.Forms.TrackBar trackBrush;
        private System.Windows.Forms.Button figurePolygon;
        private System.Windows.Forms.Button figureTriangle;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VectorTools;
        private System.Windows.Forms.Panel rastr;
        private System.Windows.Forms.Panel vector;
        private System.Windows.Forms.Panel panel3;
       
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button triangleVectorBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button clBtn_vec;
        private System.Windows.Forms.Button line;
        public System.Windows.Forms.PictureBox canvas_vector;
        private System.Windows.Forms.ToolStripMenuItem RastrTools;
        private System.Windows.Forms.Button change_figure;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Drag;
    }
}

