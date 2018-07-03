namespace MiniPaint
{
    partial class FormPaint
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
      
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.drawShapes = new System.Windows.Forms.Panel();
            this.labelShapes = new System.Windows.Forms.Label();
            this.panelCanvasCol = new System.Windows.Forms.Panel();
            this.btn_CanvasColor = new System.Windows.Forms.Button();
            this.panelCanvasName = new System.Windows.Forms.Panel();
            this.labelCanvasCol = new System.Windows.Forms.Label();
            this.panelPenSizeCol = new System.Windows.Forms.Panel();
            this.panelPenName = new System.Windows.Forms.Panel();
            this.labelPenName = new System.Windows.Forms.Label();
            this.panelPenTool = new System.Windows.Forms.Panel();
            this.buttonDrawCol = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPenTool = new System.Windows.Forms.Button();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMiniPaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelShapes.SuspendLayout();
            this.drawShapes.SuspendLayout();
            this.panelCanvasCol.SuspendLayout();
            this.panelCanvasName.SuspendLayout();
            this.panelPenSizeCol.SuspendLayout();
            this.panelPenName.SuspendLayout();
            this.panelPenTool.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Controls.Add(this.panelShapes);
            this.panelMain.Controls.Add(this.panelCanvasCol);
            this.panelMain.Controls.Add(this.panelPenSizeCol);
            this.panelMain.Location = new System.Drawing.Point(0, 21);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(140, 433);
            this.panelMain.TabIndex = 0;
            // 
            // panelShapes
            // 
            this.panelShapes.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelShapes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           
           
            this.panelShapes.Controls.Add(this.btn_Circle);
            this.panelShapes.Controls.Add(this.btn_Rectangle);
            this.panelShapes.Controls.Add(this.btn_Square);
            this.panelShapes.Controls.Add(this.drawShapes);
            this.panelShapes.Location = new System.Drawing.Point(5, 188);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(130, 184);
            this.panelShapes.TabIndex = 3;
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(3, 100);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(122, 28);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(3, 66);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(122, 28);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Square.Location = new System.Drawing.Point(3, 32);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(122, 28);
            this.btn_Square.TabIndex = 5;
            this.btn_Square.Text = "Square";
            this.btn_Square.UseVisualStyleBackColor = false;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // drawShapes
            // 
            this.drawShapes.BackColor = System.Drawing.Color.DimGray;
            this.drawShapes.Controls.Add(this.labelShapes);
            this.drawShapes.Location = new System.Drawing.Point(-1, -1);
            this.drawShapes.Name = "drawShapes";
            this.drawShapes.Size = new System.Drawing.Size(130, 27);
            this.drawShapes.TabIndex = 1;
            // 
            // labelShapes
            // 
            this.labelShapes.AutoSize = true;
            this.labelShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShapes.ForeColor = System.Drawing.Color.White;
            this.labelShapes.Location = new System.Drawing.Point(15, 5);
            this.labelShapes.Name = "labelShapes";
            this.labelShapes.Size = new System.Drawing.Size(100, 16);
            this.labelShapes.TabIndex = 1;
            this.labelShapes.Text = "Draw Shapes";
            // 
            // panelCanvasCol
            // 
            this.panelCanvasCol.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelCanvasCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvasCol.Controls.Add(this.btn_CanvasColor);
            this.panelCanvasCol.Controls.Add(this.panelCanvasName);
            this.panelCanvasCol.Location = new System.Drawing.Point(5, 112);
            this.panelCanvasCol.Name = "panelCanvasCol";
            this.panelCanvasCol.Size = new System.Drawing.Size(130, 70);
            this.panelCanvasCol.TabIndex = 2;
            // 
            // btn_CanvasColor
            // 
            this.btn_CanvasColor.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CanvasColor.Location = new System.Drawing.Point(3, 34);
            this.btn_CanvasColor.Name = "btn_CanvasColor";
            this.btn_CanvasColor.Size = new System.Drawing.Size(122, 28);
            this.btn_CanvasColor.TabIndex = 4;
            this.btn_CanvasColor.UseVisualStyleBackColor = false;
            this.btn_CanvasColor.Click += new System.EventHandler(this.btn_CanvasColor_Click_1);
            // 
            // panelCanvasName
            // 
            this.panelCanvasName.BackColor = System.Drawing.Color.DimGray;
            this.panelCanvasName.Controls.Add(this.labelCanvasCol);
            this.panelCanvasName.Location = new System.Drawing.Point(-1, -1);
            this.panelCanvasName.Name = "panelCanvasName";
            this.panelCanvasName.Size = new System.Drawing.Size(130, 27);
            this.panelCanvasName.TabIndex = 0;
            // 
            // labelCanvasCol
            // 
            this.labelCanvasCol.AutoSize = true;
            this.labelCanvasCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCanvasCol.ForeColor = System.Drawing.Color.White;
            this.labelCanvasCol.Location = new System.Drawing.Point(15, 5);
            this.labelCanvasCol.Name = "labelCanvasCol";
            this.labelCanvasCol.Size = new System.Drawing.Size(101, 16);
            this.labelCanvasCol.TabIndex = 1;
            this.labelCanvasCol.Text = "Canvas Color";
            // 
            // panelPenSizeCol
            // 
            this.panelPenSizeCol.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelPenSizeCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPenSizeCol.Controls.Add(this.panelPenName);
            this.panelPenSizeCol.Controls.Add(this.panelPenTool);
            this.panelPenSizeCol.Controls.Add(this.btn_PenColor);
            this.panelPenSizeCol.Controls.Add(this.cmb_PenSize);
            this.panelPenSizeCol.Location = new System.Drawing.Point(5, 6);
            this.panelPenSizeCol.Name = "panelPenSizeCol";
            this.panelPenSizeCol.Size = new System.Drawing.Size(130, 100);
            this.panelPenSizeCol.TabIndex = 1;
            // 
            // panelPenName
            // 
            this.panelPenName.BackColor = System.Drawing.Color.DimGray;
            this.panelPenName.Controls.Add(this.labelPenName);
            this.panelPenName.Location = new System.Drawing.Point(0, -1);
            this.panelPenName.Name = "panelPenName";
            this.panelPenName.Size = new System.Drawing.Size(130, 27);
            this.panelPenName.TabIndex = 2;
            // 
            // labelPenName
            // 
            this.labelPenName.AutoSize = true;
            this.labelPenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenName.ForeColor = System.Drawing.Color.White;
            this.labelPenName.Location = new System.Drawing.Point(27, 5);
            this.labelPenName.Name = "labelPenName";
            this.labelPenName.Size = new System.Drawing.Size(71, 16);
            this.labelPenName.TabIndex = 1;
            this.labelPenName.Text = "Pen Tool";
            // 
            // panelPenTool
            // 
            this.panelPenTool.BackColor = System.Drawing.Color.DarkGray;
            this.panelPenTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPenTool.Controls.Add(this.buttonDrawCol);
            this.panelPenTool.Controls.Add(this.comboBox1);
            this.panelPenTool.Controls.Add(this.buttonPenTool);
            this.panelPenTool.Location = new System.Drawing.Point(-1, 126);
            this.panelPenTool.Name = "panelPenTool";
            this.panelPenTool.Size = new System.Drawing.Size(130, 100);
            this.panelPenTool.TabIndex = 3;
            // 
            // buttonDrawCol
            // 
            this.buttonDrawCol.BackColor = System.Drawing.Color.Black;
            this.buttonDrawCol.Location = new System.Drawing.Point(3, 65);
            this.buttonDrawCol.Name = "buttonDrawCol";
            this.buttonDrawCol.Size = new System.Drawing.Size(122, 28);
            this.buttonDrawCol.TabIndex = 2;
            this.buttonDrawCol.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(4, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "1";
            // 
            // buttonPenTool
            // 
            this.buttonPenTool.Image = global::MiniPaint.Properties.Resources.pencil;
            this.buttonPenTool.Location = new System.Drawing.Point(4, 4);
            this.buttonPenTool.Name = "buttonPenTool";
            this.buttonPenTool.Size = new System.Drawing.Size(22, 428);
            this.buttonPenTool.TabIndex = 0;
            this.buttonPenTool.Text = "Pen Tool";
            this.buttonPenTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPenTool.UseVisualStyleBackColor = true;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.Location = new System.Drawing.Point(3, 65);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(122, 28);
            this.btn_PenColor.TabIndex = 2;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_PenSize.Location = new System.Drawing.Point(4, 38);
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(122, 21);
            this.cmb_PenSize.TabIndex = 1;
            this.cmb_PenSize.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            
            
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMiniPaintToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMiniPaintToolStripMenuItem
            // 
            this.aboutMiniPaintToolStripMenuItem.Name = "aboutMiniPaintToolStripMenuItem";
            this.aboutMiniPaintToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutMiniPaintToolStripMenuItem.Text = "About Mini Paint";
            this.aboutMiniPaintToolStripMenuItem.Click += new System.EventHandler(this.aboutMiniPaintToolStripMenuItem_Click);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Draw.Location = new System.Drawing.Point(140, 23);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(604, 431);
            this.pnl_Draw.TabIndex = 2;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.pnl_Draw);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "FormPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Paint by Dimitar Rafailov";
            this.panelMain.ResumeLayout(false);
            this.panelShapes.ResumeLayout(false);
            this.panelShapes.PerformLayout();
            this.drawShapes.ResumeLayout(false);
            this.drawShapes.PerformLayout();
            this.panelCanvasCol.ResumeLayout(false);
            this.panelCanvasName.ResumeLayout(false);
            this.panelCanvasName.PerformLayout();
            this.panelPenSizeCol.ResumeLayout(false);
            this.panelPenName.ResumeLayout(false);
            this.panelPenName.PerformLayout();
            this.panelPenTool.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Panel panelPenSizeCol;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panelCanvasCol;
        private System.Windows.Forms.Panel panelCanvasName;
        private System.Windows.Forms.Label labelCanvasCol;
        private System.Windows.Forms.Panel panelPenTool;
        private System.Windows.Forms.Button buttonDrawCol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPenTool;
        private System.Windows.Forms.Button btn_CanvasColor;
        private System.Windows.Forms.Panel panelPenName;
        private System.Windows.Forms.Label labelPenName;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Panel drawShapes;
        private System.Windows.Forms.Label labelShapes;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMiniPaintToolStripMenuItem;
    }
}

