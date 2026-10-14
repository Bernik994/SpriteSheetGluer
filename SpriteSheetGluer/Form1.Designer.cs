namespace SpriteSheetGluer
{
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            groupBox1 = new GroupBox();
            NumY = new NumericUpDown();
            NumX = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            NumKol = new NumericUpDown();
            NumPoz = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            FolderGen = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            sklej1 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumX).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumKol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumPoz).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NumY);
            groupBox1.Controls.Add(NumX);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 119);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Rozmiar pojedynczego sprite'a";
            // 
            // NumY
            // 
            NumY.Location = new Point(108, 81);
            NumY.Name = "NumY";
            NumY.Size = new Size(94, 27);
            NumY.TabIndex = 6;
            // 
            // NumX
            // 
            NumX.Location = new Point(108, 27);
            NumX.Name = "NumX";
            NumX.Size = new Size(94, 27);
            NumX.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 83);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 4;
            label2.Text = "Y px";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "X px";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NumKol);
            groupBox2.Controls.Add(NumPoz);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(279, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 119);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "2. Informacje do arkusza";
            // 
            // NumKol
            // 
            NumKol.Location = new Point(235, 73);
            NumKol.Name = "NumKol";
            NumKol.Size = new Size(94, 27);
            NumKol.TabIndex = 8;
            // 
            // NumPoz
            // 
            NumPoz.Location = new Point(235, 27);
            NumPoz.Name = "NumPoz";
            NumPoz.Size = new Size(94, 27);
            NumPoz.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 80);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 5;
            label4.Text = "Liczba kolumn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 29);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 4;
            label3.Text = "Liczba sprite'ów w poziomie";
            // 
            // FolderGen
            // 
            FolderGen.Location = new Point(16, 36);
            FolderGen.Name = "FolderGen";
            FolderGen.Size = new Size(128, 29);
            FolderGen.TabIndex = 5;
            FolderGen.Text = "Generuj foldery";
            FolderGen.UseVisualStyleBackColor = true;
            FolderGen.Click += FolderGen_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(FolderGen);
            groupBox3.Location = new Point(12, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(551, 193);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "3. Generowanie folderu i dalsze kroki";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 68);
            label8.Name = "label8";
            label8.Size = new Size(133, 40);
            label8.TabIndex = 10;
            label8.Text = "Foldery tworzą się \r\nna Pulpicie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 36);
            label5.Name = "label5";
            label5.Size = new Size(378, 140);
            label5.TabIndex = 6;
            label5.Text = resources.GetString("label5.Text");
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(sklej1);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(668, 89);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(554, 241);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "4. Generowanie arkusza sprite'ów";
            // 
            // sklej1
            // 
            sklej1.Location = new Point(438, 102);
            sklej1.Name = "sklej1";
            sklej1.Size = new Size(94, 29);
            sklej1.TabIndex = 1;
            sklej1.Text = "Sklej";
            sklej1.UseVisualStyleBackColor = true;
            sklej1.Click += sklej1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 34);
            label6.Name = "label6";
            label6.Size = new Size(410, 200);
            label6.TabIndex = 0;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 341);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "SpriteSheetGluer v.0.1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumX).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumKol).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumPoz).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Button FolderGen;
        private GroupBox groupBox3;
        private Label label5;
        private GroupBox groupBox4;
        private Label label6;
        private Button sklej1;
        private Label label8;
        private NumericUpDown NumY;
        private NumericUpDown NumX;
        private NumericUpDown NumKol;
        private NumericUpDown NumPoz;
    }
}
