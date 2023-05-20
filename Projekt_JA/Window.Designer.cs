namespace Projekt_JA
{
    partial class Window
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConvertedPictureBox = new System.Windows.Forms.PictureBox();
            this.ASMLibrary = new System.Windows.Forms.RadioButton();
            this.CSharpLibrary = new System.Windows.Forms.RadioButton();
            this.TestOption = new System.Windows.Forms.CheckBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Import_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.ImportPictureBox = new System.Windows.Forms.PictureBox();
            this.ThreadTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertedPictureBox
            // 
            this.ConvertedPictureBox.Location = new System.Drawing.Point(436, 50);
            this.ConvertedPictureBox.Name = "ConvertedPictureBox";
            this.ConvertedPictureBox.Size = new System.Drawing.Size(300, 200);
            this.ConvertedPictureBox.TabIndex = 8;
            this.ConvertedPictureBox.TabStop = false;
            // 
            // ASMLibrary
            // 
            this.ASMLibrary.AutoSize = true;
            this.ASMLibrary.Location = new System.Drawing.Point(436, 280);
            this.ASMLibrary.Name = "ASMLibrary";
            this.ASMLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ASMLibrary.Size = new System.Drawing.Size(48, 17);
            this.ASMLibrary.TabIndex = 9;
            this.ASMLibrary.TabStop = true;
            this.ASMLibrary.Text = "ASM";
            this.ASMLibrary.UseVisualStyleBackColor = true;
            // 
            // CSharpLibrary
            // 
            this.CSharpLibrary.AutoSize = true;
            this.CSharpLibrary.Location = new System.Drawing.Point(436, 304);
            this.CSharpLibrary.Name = "CSharpLibrary";
            this.CSharpLibrary.Size = new System.Drawing.Size(39, 17);
            this.CSharpLibrary.TabIndex = 10;
            this.CSharpLibrary.TabStop = true;
            this.CSharpLibrary.Text = "C#";
            this.CSharpLibrary.UseVisualStyleBackColor = true;
            // 
            // TestOption
            // 
            this.TestOption.AutoSize = true;
            this.TestOption.Location = new System.Drawing.Point(436, 328);
            this.TestOption.Name = "TestOption";
            this.TestOption.Size = new System.Drawing.Size(47, 17);
            this.TestOption.TabIndex = 11;
            this.TestOption.Text = "Test";
            this.TestOption.UseVisualStyleBackColor = true;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(603, 280);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 12;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Import_Button
            // 
            this.Import_Button.Location = new System.Drawing.Point(603, 310);
            this.Import_Button.Name = "Import_Button";
            this.Import_Button.Size = new System.Drawing.Size(75, 23);
            this.Import_Button.TabIndex = 13;
            this.Import_Button.Text = "Import";
            this.Import_Button.UseVisualStyleBackColor = true;
            this.Import_Button.Click += new System.EventHandler(this.Import_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(603, 340);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 14;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // ImportPictureBox
            // 
            this.ImportPictureBox.Location = new System.Drawing.Point(46, 50);
            this.ImportPictureBox.Name = "ImportPictureBox";
            this.ImportPictureBox.Size = new System.Drawing.Size(332, 200);
            this.ImportPictureBox.TabIndex = 15;
            this.ImportPictureBox.TabStop = false;
            // 
            // ThreadTrackBar
            // 
            this.ThreadTrackBar.Location = new System.Drawing.Point(436, 377);
            this.ThreadTrackBar.Maximum = 64;
            this.ThreadTrackBar.Minimum = 1;
            this.ThreadTrackBar.Name = "ThreadTrackBar";
            this.ThreadTrackBar.Size = new System.Drawing.Size(172, 45);
            this.ThreadTrackBar.TabIndex = 16;
            this.ThreadTrackBar.Value = 1;
            this.ThreadTrackBar.Scroll += new System.EventHandler(this.ThreadTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 286);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(46, 312);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(46, 340);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(105, 286);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown4.TabIndex = 21;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(105, 312);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown5.TabIndex = 22;
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(105, 340);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown6.TabIndex = 23;
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Time:";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThreadTrackBar);
            this.Controls.Add(this.ImportPictureBox);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Import_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.TestOption);
            this.Controls.Add(this.CSharpLibrary);
            this.Controls.Add(this.ASMLibrary);
            this.Controls.Add(this.ConvertedPictureBox);
            this.Name = "Window";
            this.Text = "ColorPop";
            this.Load += new System.EventHandler(this.Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ConvertedPictureBox;
        private System.Windows.Forms.RadioButton ASMLibrary;
        private System.Windows.Forms.RadioButton CSharpLibrary;
        private System.Windows.Forms.CheckBox TestOption;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Import_Button;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.PictureBox ImportPictureBox;
        private System.Windows.Forms.TrackBar ThreadTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

