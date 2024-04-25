namespace AS2324._3G.MarongiuMarco.battagliaNavale
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
            cmbMossa = new ComboBox();
            btnAttacca = new Button();
            lblScore1 = new Label();
            lblScore2 = new Label();
            lblMossaNemica = new Label();
            lblRound = new Label();
            btnW1 = new Button();
            btnW2 = new Button();
            btnW4 = new Button();
            btnW3 = new Button();
            btnZ1 = new Button();
            btnZ2 = new Button();
            btnZ3 = new Button();
            btnZ4 = new Button();
            btnY1 = new Button();
            btnY2 = new Button();
            btnY3 = new Button();
            btnY4 = new Button();
            btnX4 = new Button();
            btnX3 = new Button();
            btnX2 = new Button();
            btnX1 = new Button();
            A1 = new Button();
            B1 = new Button();
            D1 = new Button();
            C1 = new Button();
            D2 = new Button();
            C2 = new Button();
            B2 = new Button();
            A2 = new Button();
            A3 = new Button();
            B3 = new Button();
            C3 = new Button();
            D3 = new Button();
            D4 = new Button();
            C4 = new Button();
            B4 = new Button();
            A4 = new Button();
            label1 = new Label();
            timerNemico = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // cmbMossa
            // 
            cmbMossa.BackColor = Color.PaleGreen;
            cmbMossa.FormattingEnabled = true;
            cmbMossa.ItemHeight = 17;
            cmbMossa.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "B1", "B2", "B3", "B4", "C1", "C2", "C3", "C4", "D1", "D2", "D3", "D4" });
            cmbMossa.Location = new Point(155, 31);
            cmbMossa.Name = "cmbMossa";
            cmbMossa.Size = new Size(78, 25);
            cmbMossa.TabIndex = 0;
            // 
            // btnAttacca
            // 
            btnAttacca.Location = new Point(266, 26);
            btnAttacca.Name = "btnAttacca";
            btnAttacca.Size = new Size(78, 36);
            btnAttacca.TabIndex = 1;
            btnAttacca.Text = "ATTACCA";
            btnAttacca.UseVisualStyleBackColor = true;
            // 
            // lblScore1
            // 
            lblScore1.BackColor = Color.Transparent;
            lblScore1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore1.ForeColor = SystemColors.ButtonHighlight;
            lblScore1.Location = new Point(305, 111);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(60, 29);
            lblScore1.TabIndex = 2;
            lblScore1.Text = "00";
            // 
            // lblScore2
            // 
            lblScore2.BackColor = Color.Transparent;
            lblScore2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore2.ForeColor = SystemColors.ButtonHighlight;
            lblScore2.Location = new Point(764, 111);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(54, 29);
            lblScore2.TabIndex = 3;
            lblScore2.Text = "00";
            // 
            // lblMossaNemica
            // 
            lblMossaNemica.BackColor = Color.Transparent;
            lblMossaNemica.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMossaNemica.ForeColor = SystemColors.ButtonHighlight;
            lblMossaNemica.Location = new Point(750, 34);
            lblMossaNemica.Name = "lblMossaNemica";
            lblMossaNemica.Size = new Size(68, 29);
            lblMossaNemica.TabIndex = 4;
            lblMossaNemica.Text = "A1";
            // 
            // lblRound
            // 
            lblRound.BackColor = Color.Transparent;
            lblRound.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRound.ForeColor = SystemColors.ButtonHighlight;
            lblRound.Location = new Point(386, 142);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(141, 43);
            lblRound.TabIndex = 5;
            lblRound.Text = "Round: 10";
            // 
            // btnW1
            // 
            btnW1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnW1.Location = new Point(84, 236);
            btnW1.Name = "btnW1";
            btnW1.Size = new Size(67, 60);
            btnW1.TabIndex = 6;
            btnW1.Text = "W1";
            btnW1.UseVisualStyleBackColor = true;
            // 
            // btnW2
            // 
            btnW2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnW2.Location = new Point(166, 236);
            btnW2.Name = "btnW2";
            btnW2.Size = new Size(67, 60);
            btnW2.TabIndex = 7;
            btnW2.Text = "W2";
            btnW2.UseVisualStyleBackColor = true;
            // 
            // btnW4
            // 
            btnW4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnW4.Location = new Point(324, 236);
            btnW4.Name = "btnW4";
            btnW4.Size = new Size(67, 60);
            btnW4.TabIndex = 8;
            btnW4.Text = "W4";
            btnW4.UseVisualStyleBackColor = true;
            // 
            // btnW3
            // 
            btnW3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnW3.Location = new Point(239, 236);
            btnW3.Name = "btnW3";
            btnW3.Size = new Size(67, 60);
            btnW3.TabIndex = 9;
            btnW3.Text = "W3";
            btnW3.UseVisualStyleBackColor = true;
            // 
            // btnZ1
            // 
            btnZ1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZ1.Location = new Point(93, 467);
            btnZ1.Name = "btnZ1";
            btnZ1.Size = new Size(67, 60);
            btnZ1.TabIndex = 10;
            btnZ1.Text = "Z1";
            btnZ1.UseVisualStyleBackColor = true;
            // 
            // btnZ2
            // 
            btnZ2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZ2.Location = new Point(166, 467);
            btnZ2.Name = "btnZ2";
            btnZ2.Size = new Size(67, 60);
            btnZ2.TabIndex = 11;
            btnZ2.Text = "Z2";
            btnZ2.UseVisualStyleBackColor = true;
            // 
            // btnZ3
            // 
            btnZ3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZ3.Location = new Point(239, 467);
            btnZ3.Name = "btnZ3";
            btnZ3.Size = new Size(67, 60);
            btnZ3.TabIndex = 12;
            btnZ3.Text = "Z3";
            btnZ3.UseVisualStyleBackColor = true;
            // 
            // btnZ4
            // 
            btnZ4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnZ4.Location = new Point(324, 467);
            btnZ4.Name = "btnZ4";
            btnZ4.Size = new Size(67, 60);
            btnZ4.TabIndex = 13;
            btnZ4.Text = "Z4";
            btnZ4.UseVisualStyleBackColor = true;
            // 
            // btnY1
            // 
            btnY1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnY1.Location = new Point(93, 390);
            btnY1.Name = "btnY1";
            btnY1.Size = new Size(67, 60);
            btnY1.TabIndex = 14;
            btnY1.Text = "Y1";
            btnY1.UseVisualStyleBackColor = true;
            // 
            // btnY2
            // 
            btnY2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnY2.Location = new Point(166, 390);
            btnY2.Name = "btnY2";
            btnY2.Size = new Size(67, 60);
            btnY2.TabIndex = 15;
            btnY2.Text = "Y2";
            btnY2.UseVisualStyleBackColor = true;
            // 
            // btnY3
            // 
            btnY3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnY3.Location = new Point(239, 390);
            btnY3.Name = "btnY3";
            btnY3.Size = new Size(67, 60);
            btnY3.TabIndex = 16;
            btnY3.Text = "Y3";
            btnY3.UseVisualStyleBackColor = true;
            // 
            // btnY4
            // 
            btnY4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnY4.Location = new Point(324, 390);
            btnY4.Name = "btnY4";
            btnY4.Size = new Size(67, 60);
            btnY4.TabIndex = 17;
            btnY4.Text = "Y4";
            btnY4.UseVisualStyleBackColor = true;
            // 
            // btnX4
            // 
            btnX4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnX4.Location = new Point(324, 313);
            btnX4.Name = "btnX4";
            btnX4.Size = new Size(67, 60);
            btnX4.TabIndex = 18;
            btnX4.Text = "X4";
            btnX4.UseVisualStyleBackColor = true;
            // 
            // btnX3
            // 
            btnX3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnX3.Location = new Point(239, 313);
            btnX3.Name = "btnX3";
            btnX3.Size = new Size(67, 60);
            btnX3.TabIndex = 19;
            btnX3.Text = "X3";
            btnX3.UseVisualStyleBackColor = true;
            // 
            // btnX2
            // 
            btnX2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnX2.Location = new Point(166, 313);
            btnX2.Name = "btnX2";
            btnX2.Size = new Size(67, 60);
            btnX2.TabIndex = 20;
            btnX2.Text = "X2";
            btnX2.UseVisualStyleBackColor = true;
            // 
            // btnX1
            // 
            btnX1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnX1.Location = new Point(84, 313);
            btnX1.Name = "btnX1";
            btnX1.Size = new Size(67, 60);
            btnX1.TabIndex = 21;
            btnX1.Text = "X1";
            btnX1.UseVisualStyleBackColor = true;
            // 
            // A1
            // 
            A1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            A1.Location = new Point(509, 236);
            A1.Name = "A1";
            A1.Size = new Size(67, 60);
            A1.TabIndex = 22;
            A1.Text = "A1";
            A1.UseVisualStyleBackColor = true;
            // 
            // B1
            // 
            B1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B1.Location = new Point(508, 313);
            B1.Name = "B1";
            B1.Size = new Size(67, 60);
            B1.TabIndex = 23;
            B1.Text = "B1";
            B1.UseVisualStyleBackColor = true;
            // 
            // D1
            // 
            D1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            D1.Location = new Point(509, 467);
            D1.Name = "D1";
            D1.Size = new Size(67, 60);
            D1.TabIndex = 24;
            D1.Text = "D1";
            D1.UseVisualStyleBackColor = true;
            // 
            // C1
            // 
            C1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            C1.Location = new Point(509, 390);
            C1.Name = "C1";
            C1.Size = new Size(67, 60);
            C1.TabIndex = 25;
            C1.Text = "C1";
            C1.UseVisualStyleBackColor = true;
            // 
            // D2
            // 
            D2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            D2.Location = new Point(592, 467);
            D2.Name = "D2";
            D2.Size = new Size(67, 60);
            D2.TabIndex = 26;
            D2.Text = "D2";
            D2.UseVisualStyleBackColor = true;
            // 
            // C2
            // 
            C2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            C2.Location = new Point(592, 390);
            C2.Name = "C2";
            C2.Size = new Size(67, 60);
            C2.TabIndex = 27;
            C2.Text = "C2";
            C2.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            B2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B2.Location = new Point(581, 313);
            B2.Name = "B2";
            B2.Size = new Size(67, 60);
            B2.TabIndex = 28;
            B2.Text = "B2";
            B2.UseVisualStyleBackColor = true;
            // 
            // A2
            // 
            A2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            A2.Location = new Point(581, 236);
            A2.Name = "A2";
            A2.Size = new Size(67, 60);
            A2.TabIndex = 29;
            A2.Text = "A2";
            A2.UseVisualStyleBackColor = true;
            // 
            // A3
            // 
            A3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            A3.Location = new Point(665, 236);
            A3.Name = "A3";
            A3.Size = new Size(67, 60);
            A3.TabIndex = 30;
            A3.Text = "A3";
            A3.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            B3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B3.Location = new Point(665, 313);
            B3.Name = "B3";
            B3.Size = new Size(67, 60);
            B3.TabIndex = 31;
            B3.Text = "B3";
            B3.UseVisualStyleBackColor = true;
            // 
            // C3
            // 
            C3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            C3.Location = new Point(665, 390);
            C3.Name = "C3";
            C3.Size = new Size(67, 60);
            C3.TabIndex = 32;
            C3.Text = "C3";
            C3.UseVisualStyleBackColor = true;
            // 
            // D3
            // 
            D3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            D3.Location = new Point(665, 467);
            D3.Name = "D3";
            D3.Size = new Size(67, 60);
            D3.TabIndex = 33;
            D3.Text = "D3";
            D3.UseVisualStyleBackColor = true;
            // 
            // D4
            // 
            D4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            D4.Location = new Point(750, 467);
            D4.Name = "D4";
            D4.Size = new Size(67, 60);
            D4.TabIndex = 34;
            D4.Text = "D4";
            D4.UseVisualStyleBackColor = true;
            // 
            // C4
            // 
            C4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            C4.Location = new Point(751, 390);
            C4.Name = "C4";
            C4.Size = new Size(67, 60);
            C4.TabIndex = 35;
            C4.Text = "C4";
            C4.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            B4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B4.Location = new Point(750, 313);
            B4.Name = "B4";
            B4.Size = new Size(67, 60);
            B4.TabIndex = 36;
            B4.Text = "B4";
            B4.UseVisualStyleBackColor = true;
            // 
            // A4
            // 
            A4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            A4.Location = new Point(750, 236);
            A4.Name = "A4";
            A4.Size = new Size(67, 60);
            A4.TabIndex = 37;
            A4.Text = "A4";
            A4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(85, 563);
            label1.Name = "label1";
            label1.Size = new Size(463, 22);
            label1.TabIndex = 38;
            label1.Text = "Premi 3 caselle tue per far partire il gioco";
            // 
            // timerNemico
            // 
            timerNemico.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(905, 590);
            Controls.Add(label1);
            Controls.Add(A4);
            Controls.Add(B4);
            Controls.Add(C4);
            Controls.Add(D4);
            Controls.Add(D3);
            Controls.Add(C3);
            Controls.Add(B3);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(B2);
            Controls.Add(C2);
            Controls.Add(D2);
            Controls.Add(C1);
            Controls.Add(D1);
            Controls.Add(B1);
            Controls.Add(A1);
            Controls.Add(btnX1);
            Controls.Add(btnX2);
            Controls.Add(btnX3);
            Controls.Add(btnX4);
            Controls.Add(btnY4);
            Controls.Add(btnY3);
            Controls.Add(btnY2);
            Controls.Add(btnY1);
            Controls.Add(btnZ4);
            Controls.Add(btnZ3);
            Controls.Add(btnZ2);
            Controls.Add(btnZ1);
            Controls.Add(btnW3);
            Controls.Add(btnW4);
            Controls.Add(btnW2);
            Controls.Add(btnW1);
            Controls.Add(lblRound);
            Controls.Add(lblMossaNemica);
            Controls.Add(lblScore2);
            Controls.Add(lblScore1);
            Controls.Add(btnAttacca);
            Controls.Add(cmbMossa);
            Name = "Form1";
            Text = "AS2324.3G.MarongiuMarco.battagliaNavale";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMossa;
        private Button btnAttacca;
        private Label lblScore1;
        private Label lblScore2;
        private Label lblMossaNemica;
        private Label lblRound;
        private Button btnW1;
        private Button btnW2;
        private Button btnW4;
        private Button btnW3;
        private Button btnZ1;
        private Button btnZ2;
        private Button btnZ3;
        private Button btnZ4;
        private Button btnY1;
        private Button btnY2;
        private Button btnY3;
        private Button btnY4;
        private Button btnX4;
        private Button btnX3;
        private Button btnX2;
        private Button btnX1;
        private Button A1;
        private Button B1;
        private Button D1;
        private Button C1;
        private Button D2;
        private Button C2;
        private Button B2;
        private Button A2;
        private Button A3;
        private Button B3;
        private Button C3;
        private Button D3;
        private Button D4;
        private Button C4;
        private Button B4;
        private Button A4;
        private Label label1;
        private System.Windows.Forms.Timer timerNemico;
    }
}