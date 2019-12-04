namespace SquareShape
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addHeightButton = new System.Windows.Forms.Button();
            this.adjustHeightButton = new System.Windows.Forms.Button();
            this.adjustWidthButton = new System.Windows.Forms.Button();
            this.addWidthButton = new System.Windows.Forms.Button();
            this.XLocationLabel = new System.Windows.Forms.Label();
            this.YLocationLabel = new System.Windows.Forms.Label();
            this.XLocationText = new System.Windows.Forms.TextBox();
            this.YLocationText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.groupBoxHeightText = new System.Windows.Forms.TextBox();
            this.groupBoxWidthText = new System.Windows.Forms.TextBox();
            this.groupBoxHeightLabel = new System.Windows.Forms.Label();
            this.groupBoxWidthLabel = new System.Windows.Forms.Label();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movementText = new System.Windows.Forms.TextBox();
            this.movementLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(300, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pobaw się kwadratem";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(200, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            // 
            // addHeightButton
            // 
            this.addHeightButton.Location = new System.Drawing.Point(53, 36);
            this.addHeightButton.Name = "addHeightButton";
            this.addHeightButton.Size = new System.Drawing.Size(35, 34);
            this.addHeightButton.TabIndex = 2;
            this.addHeightButton.Text = "Y+";
            this.addHeightButton.UseVisualStyleBackColor = true;
            this.addHeightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adjustHeightButton
            // 
            this.adjustHeightButton.Location = new System.Drawing.Point(53, 111);
            this.adjustHeightButton.Name = "adjustHeightButton";
            this.adjustHeightButton.Size = new System.Drawing.Size(35, 33);
            this.adjustHeightButton.TabIndex = 3;
            this.adjustHeightButton.Text = "Y-";
            this.adjustHeightButton.UseVisualStyleBackColor = true;
            this.adjustHeightButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // adjustWidthButton
            // 
            this.adjustWidthButton.Location = new System.Drawing.Point(17, 71);
            this.adjustWidthButton.Name = "adjustWidthButton";
            this.adjustWidthButton.Size = new System.Drawing.Size(36, 34);
            this.adjustWidthButton.TabIndex = 4;
            this.adjustWidthButton.Text = "X-";
            this.adjustWidthButton.UseVisualStyleBackColor = true;
            this.adjustWidthButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // addWidthButton
            // 
            this.addWidthButton.Location = new System.Drawing.Point(88, 71);
            this.addWidthButton.Name = "addWidthButton";
            this.addWidthButton.Size = new System.Drawing.Size(36, 34);
            this.addWidthButton.TabIndex = 5;
            this.addWidthButton.Text = "X+";
            this.addWidthButton.UseVisualStyleBackColor = true;
            this.addWidthButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // XLocationLabel
            // 
            this.XLocationLabel.AutoSize = true;
            this.XLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XLocationLabel.Location = new System.Drawing.Point(14, 165);
            this.XLocationLabel.Name = "XLocationLabel";
            this.XLocationLabel.Size = new System.Drawing.Size(104, 16);
            this.XLocationLabel.TabIndex = 6;
            this.XLocationLabel.Text = "panel XLocation";
            // 
            // YLocationLabel
            // 
            this.YLocationLabel.AutoSize = true;
            this.YLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YLocationLabel.Location = new System.Drawing.Point(14, 192);
            this.YLocationLabel.Name = "YLocationLabel";
            this.YLocationLabel.Size = new System.Drawing.Size(105, 16);
            this.YLocationLabel.TabIndex = 7;
            this.YLocationLabel.Text = "panel YLocation";
            // 
            // XLocationText
            // 
            this.XLocationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XLocationText.Location = new System.Drawing.Point(214, 159);
            this.XLocationText.Name = "XLocationText";
            this.XLocationText.ReadOnly = true;
            this.XLocationText.Size = new System.Drawing.Size(80, 22);
            this.XLocationText.TabIndex = 8;
            // 
            // YLocationText
            // 
            this.YLocationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YLocationText.Location = new System.Drawing.Point(214, 186);
            this.YLocationText.Name = "YLocationText";
            this.YLocationText.ReadOnly = true;
            this.YLocationText.Size = new System.Drawing.Size(80, 22);
            this.YLocationText.TabIndex = 9;
            // 
            // heightText
            // 
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightText.Location = new System.Drawing.Point(214, 251);
            this.heightText.Name = "heightText";
            this.heightText.ReadOnly = true;
            this.heightText.Size = new System.Drawing.Size(80, 22);
            this.heightText.TabIndex = 13;
            // 
            // widthText
            // 
            this.widthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthText.Location = new System.Drawing.Point(214, 224);
            this.widthText.Name = "widthText";
            this.widthText.ReadOnly = true;
            this.widthText.Size = new System.Drawing.Size(80, 22);
            this.widthText.TabIndex = 12;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightLabel.Location = new System.Drawing.Point(14, 257);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(84, 16);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "panel Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.widthLabel.Location = new System.Drawing.Point(14, 230);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(79, 16);
            this.widthLabel.TabIndex = 10;
            this.widthLabel.Text = "panel Width";
            // 
            // groupBoxHeightText
            // 
            this.groupBoxHeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxHeightText.Location = new System.Drawing.Point(214, 318);
            this.groupBoxHeightText.Name = "groupBoxHeightText";
            this.groupBoxHeightText.ReadOnly = true;
            this.groupBoxHeightText.Size = new System.Drawing.Size(80, 22);
            this.groupBoxHeightText.TabIndex = 17;
            // 
            // groupBoxWidthText
            // 
            this.groupBoxWidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWidthText.Location = new System.Drawing.Point(214, 291);
            this.groupBoxWidthText.Name = "groupBoxWidthText";
            this.groupBoxWidthText.ReadOnly = true;
            this.groupBoxWidthText.Size = new System.Drawing.Size(80, 22);
            this.groupBoxWidthText.TabIndex = 16;
            // 
            // groupBoxHeightLabel
            // 
            this.groupBoxHeightLabel.AutoSize = true;
            this.groupBoxHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxHeightLabel.Location = new System.Drawing.Point(14, 324);
            this.groupBoxHeightLabel.Name = "groupBoxHeightLabel";
            this.groupBoxHeightLabel.Size = new System.Drawing.Size(105, 16);
            this.groupBoxHeightLabel.TabIndex = 15;
            this.groupBoxHeightLabel.Text = "groupBoxHeight";
            // 
            // groupBoxWidthLabel
            // 
            this.groupBoxWidthLabel.AutoSize = true;
            this.groupBoxWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxWidthLabel.Location = new System.Drawing.Point(14, 297);
            this.groupBoxWidthLabel.Name = "groupBoxWidthLabel";
            this.groupBoxWidthLabel.Size = new System.Drawing.Size(100, 16);
            this.groupBoxWidthLabel.TabIndex = 14;
            this.groupBoxWidthLabel.Text = "groupBoxWidth";
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(241, 71);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(36, 34);
            this.moveRightButton.TabIndex = 21;
            this.moveRightButton.Text = "X+";
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(170, 71);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(36, 34);
            this.moveLeftButton.TabIndex = 20;
            this.moveLeftButton.Text = "X-";
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(206, 111);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(35, 33);
            this.moveDownButton.TabIndex = 19;
            this.moveDownButton.Text = "Y-";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(206, 36);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(35, 34);
            this.moveUpButton.TabIndex = 18;
            this.moveUpButton.Text = "Y+";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Panel Width/Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Panel Position";
            // 
            // movementText
            // 
            this.movementText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.movementText.Location = new System.Drawing.Point(214, 374);
            this.movementText.Name = "movementText";
            this.movementText.Size = new System.Drawing.Size(48, 22);
            this.movementText.TabIndex = 25;
            this.movementText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.movementText_KeyPress);
            // 
            // movementLabel
            // 
            this.movementLabel.AutoSize = true;
            this.movementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.movementLabel.Location = new System.Drawing.Point(14, 380);
            this.movementLabel.Name = "movementLabel";
            this.movementLabel.Size = new System.Drawing.Size(96, 16);
            this.movementLabel.TabIndex = 24;
            this.movementLabel.Text = "movement (px)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(268, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(26, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "px";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 421);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.movementText);
            this.Controls.Add(this.movementLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.groupBoxHeightText);
            this.Controls.Add(this.groupBoxWidthText);
            this.Controls.Add(this.groupBoxHeightLabel);
            this.Controls.Add(this.groupBoxWidthLabel);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.YLocationText);
            this.Controls.Add(this.XLocationText);
            this.Controls.Add(this.YLocationLabel);
            this.Controls.Add(this.XLocationLabel);
            this.Controls.Add(this.addWidthButton);
            this.Controls.Add(this.adjustWidthButton);
            this.Controls.Add(this.adjustHeightButton);
            this.Controls.Add(this.addHeightButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addHeightButton;
        private System.Windows.Forms.Button adjustHeightButton;
        private System.Windows.Forms.Button adjustWidthButton;
        private System.Windows.Forms.Button addWidthButton;
        private System.Windows.Forms.Label XLocationLabel;
        private System.Windows.Forms.Label YLocationLabel;
        private System.Windows.Forms.TextBox XLocationText;
        private System.Windows.Forms.TextBox YLocationText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox groupBoxHeightText;
        private System.Windows.Forms.TextBox groupBoxWidthText;
        private System.Windows.Forms.Label groupBoxHeightLabel;
        private System.Windows.Forms.Label groupBoxWidthLabel;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movementText;
        private System.Windows.Forms.Label movementLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

