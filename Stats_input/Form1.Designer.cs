namespace Stats_input
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
            detectedIVs = new TextBox();
            atkTextBox = new TextBox();
            defTextBox = new TextBox();
            hpTextBox = new TextBox();
            spAtkTextBox = new TextBox();
            spDefTextBox = new TextBox();
            speedTextBox = new TextBox();
            toSpypokes = new LinkLabel();
            toMarriland = new LinkLabel();
            atkDetectedTextBox = new TextBox();
            defDetectedTextBox = new TextBox();
            hpDetectedTextBox = new TextBox();
            spAtkDetectedTextBox = new TextBox();
            spDefDetectedTextBox = new TextBox();
            speedDetectedTextBox = new TextBox();
            explainingTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            statsPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)statsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // detectedIVs
            // 
            detectedIVs.Location = new Point(386, 50);
            detectedIVs.Name = "detectedIVs";
            detectedIVs.ReadOnly = true;
            detectedIVs.Size = new Size(100, 23);
            detectedIVs.TabIndex = 0;
            detectedIVs.Text = "Detected IVs :";
            // 
            // atkTextBox
            // 
            atkTextBox.Location = new Point(386, 107);
            atkTextBox.Name = "atkTextBox";
            atkTextBox.ReadOnly = true;
            atkTextBox.Size = new Size(100, 23);
            atkTextBox.TabIndex = 1;
            atkTextBox.Text = "Atk";
            // 
            // defTextBox
            // 
            defTextBox.Location = new Point(386, 136);
            defTextBox.Name = "defTextBox";
            defTextBox.ReadOnly = true;
            defTextBox.Size = new Size(100, 23);
            defTextBox.TabIndex = 2;
            defTextBox.Text = "Def";
            // 
            // hpTextBox
            // 
            hpTextBox.Location = new Point(386, 78);
            hpTextBox.Name = "hpTextBox";
            hpTextBox.ReadOnly = true;
            hpTextBox.Size = new Size(100, 23);
            hpTextBox.TabIndex = 3;
            hpTextBox.Text = "HP";
            // 
            // spAtkTextBox
            // 
            spAtkTextBox.Location = new Point(386, 165);
            spAtkTextBox.Name = "spAtkTextBox";
            spAtkTextBox.ReadOnly = true;
            spAtkTextBox.Size = new Size(100, 23);
            spAtkTextBox.TabIndex = 4;
            spAtkTextBox.Text = "SpAtk";
            // 
            // spDefTextBox
            // 
            spDefTextBox.Location = new Point(386, 194);
            spDefTextBox.Name = "spDefTextBox";
            spDefTextBox.ReadOnly = true;
            spDefTextBox.Size = new Size(100, 23);
            spDefTextBox.TabIndex = 5;
            spDefTextBox.Text = "SpDef";
            // 
            // speedTextBox
            // 
            speedTextBox.Location = new Point(386, 223);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.ReadOnly = true;
            speedTextBox.Size = new Size(100, 23);
            speedTextBox.TabIndex = 6;
            speedTextBox.Text = "Speed";
            // 
            // toSpypokes
            // 
            toSpypokes.AutoSize = true;
            toSpypokes.Location = new Point(663, 504);
            toSpypokes.Name = "toSpypokes";
            toSpypokes.Size = new Size(127, 15);
            toSpypokes.TabIndex = 7;
            toSpypokes.TabStop = true;
            toSpypokes.Text = "Spypokes IV Calculator";
            toSpypokes.LinkClicked += toSpypokes_LinkClicked;
            // 
            // toMarriland
            // 
            toMarriland.AutoSize = true;
            toMarriland.Location = new Point(663, 528);
            toMarriland.Name = "toMarriland";
            toMarriland.Size = new Size(128, 15);
            toMarriland.TabIndex = 8;
            toMarriland.TabStop = true;
            toMarriland.Text = "Marriland IV Calculator";
            toMarriland.LinkClicked += toMarriland_LinkClicked;
            // 
            // atkDetectedTextBox
            // 
            atkDetectedTextBox.Location = new Point(492, 107);
            atkDetectedTextBox.Name = "atkDetectedTextBox";
            atkDetectedTextBox.Size = new Size(61, 23);
            atkDetectedTextBox.TabIndex = 9;
            atkDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // defDetectedTextBox
            // 
            defDetectedTextBox.Location = new Point(492, 136);
            defDetectedTextBox.Name = "defDetectedTextBox";
            defDetectedTextBox.Size = new Size(61, 23);
            defDetectedTextBox.TabIndex = 10;
            defDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // hpDetectedTextBox
            // 
            hpDetectedTextBox.Location = new Point(492, 78);
            hpDetectedTextBox.Name = "hpDetectedTextBox";
            hpDetectedTextBox.Size = new Size(61, 23);
            hpDetectedTextBox.TabIndex = 11;
            hpDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // spAtkDetectedTextBox
            // 
            spAtkDetectedTextBox.Location = new Point(492, 165);
            spAtkDetectedTextBox.Name = "spAtkDetectedTextBox";
            spAtkDetectedTextBox.Size = new Size(61, 23);
            spAtkDetectedTextBox.TabIndex = 12;
            spAtkDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // spDefDetectedTextBox
            // 
            spDefDetectedTextBox.Location = new Point(492, 194);
            spDefDetectedTextBox.Name = "spDefDetectedTextBox";
            spDefDetectedTextBox.Size = new Size(61, 23);
            spDefDetectedTextBox.TabIndex = 13;
            spDefDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // speedDetectedTextBox
            // 
            speedDetectedTextBox.Location = new Point(492, 223);
            speedDetectedTextBox.Name = "speedDetectedTextBox";
            speedDetectedTextBox.Size = new Size(61, 23);
            speedDetectedTextBox.TabIndex = 14;
            speedDetectedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // explainingTextBox
            // 
            explainingTextBox.Location = new Point(386, 276);
            explainingTextBox.Name = "explainingTextBox";
            explainingTextBox.ReadOnly = true;
            explainingTextBox.Size = new Size(314, 23);
            explainingTextBox.TabIndex = 15;
            explainingTextBox.Text = "Press F7 when you want the values to automatically enter";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // statsPictureBox
            // 
            statsPictureBox.AccessibleDescription = "";
            statsPictureBox.BackColor = Color.FromArgb(255, 192, 192);
            statsPictureBox.BorderStyle = BorderStyle.Fixed3D;
            statsPictureBox.Location = new Point(12, 12);
            statsPictureBox.Name = "statsPictureBox";
            statsPictureBox.Size = new Size(140, 89);
            statsPictureBox.TabIndex = 17;
            statsPictureBox.TabStop = false;
            statsPictureBox.DragDrop += pictureBox1_DragDrop;
            statsPictureBox.DragEnter += statsPictureBox_DragEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 562);
            Controls.Add(statsPictureBox);
            Controls.Add(explainingTextBox);
            Controls.Add(speedDetectedTextBox);
            Controls.Add(spDefDetectedTextBox);
            Controls.Add(spAtkDetectedTextBox);
            Controls.Add(hpDetectedTextBox);
            Controls.Add(defDetectedTextBox);
            Controls.Add(atkDetectedTextBox);
            Controls.Add(toMarriland);
            Controls.Add(toSpypokes);
            Controls.Add(speedTextBox);
            Controls.Add(spDefTextBox);
            Controls.Add(spAtkTextBox);
            Controls.Add(hpTextBox);
            Controls.Add(defTextBox);
            Controls.Add(atkTextBox);
            Controls.Add(detectedIVs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)statsPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox detectedIVs;
        private TextBox atkTextBox;
        private TextBox defTextBox;
        private TextBox hpTextBox;
        private TextBox spAtkTextBox;
        private TextBox spDefTextBox;
        private TextBox speedTextBox;
        private LinkLabel toSpypokes;
        private LinkLabel toMarriland;
        private TextBox atkDetectedTextBox;
        private TextBox defDetectedTextBox;
        private TextBox hpDetectedTextBox;
        private TextBox spAtkDetectedTextBox;
        private TextBox spDefDetectedTextBox;
        private TextBox speedDetectedTextBox;
        private TextBox explainingTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox statsPictureBox;
    }
}