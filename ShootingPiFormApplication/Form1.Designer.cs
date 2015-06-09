namespace ShootingPiFormApplication
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
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.btnCalculatePi = new System.Windows.Forms.Button();
            this.textBoxLengthOfSquare = new System.Windows.Forms.TextBox();
            this.textBoxNoOfReps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPiOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BackColor = System.Drawing.Color.White;
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(59, 58);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxResult.TabIndex = 0;
            this.pictureBoxResult.TabStop = false;
            // 
            // btnCalculatePi
            // 
            this.btnCalculatePi.Location = new System.Drawing.Point(418, 191);
            this.btnCalculatePi.Name = "btnCalculatePi";
            this.btnCalculatePi.Size = new System.Drawing.Size(138, 23);
            this.btnCalculatePi.TabIndex = 1;
            this.btnCalculatePi.Text = "Estimate Pi";
            this.btnCalculatePi.UseVisualStyleBackColor = true;
            this.btnCalculatePi.Click += new System.EventHandler(this.btnCalculatePi_Click);
            // 
            // textBoxLengthOfSquare
            // 
            this.textBoxLengthOfSquare.Location = new System.Drawing.Point(418, 113);
            this.textBoxLengthOfSquare.Name = "textBoxLengthOfSquare";
            this.textBoxLengthOfSquare.Size = new System.Drawing.Size(138, 20);
            this.textBoxLengthOfSquare.TabIndex = 2;
            // 
            // textBoxNoOfReps
            // 
            this.textBoxNoOfReps.Location = new System.Drawing.Point(418, 165);
            this.textBoxNoOfReps.Name = "textBoxNoOfReps";
            this.textBoxNoOfReps.Size = new System.Drawing.Size(138, 20);
            this.textBoxNoOfReps.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length of square";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Visualisation";
            // 
            // labelPiOutput
            // 
            this.labelPiOutput.AutoSize = true;
            this.labelPiOutput.Location = new System.Drawing.Point(415, 294);
            this.labelPiOutput.Name = "labelPiOutput";
            this.labelPiOutput.Size = new System.Drawing.Size(103, 13);
            this.labelPiOutput.TabIndex = 7;
            this.labelPiOutput.Text = "................................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estimate of Pi";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculatePi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(627, 389);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPiOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNoOfReps);
            this.Controls.Add(this.textBoxLengthOfSquare);
            this.Controls.Add(this.btnCalculatePi);
            this.Controls.Add(this.pictureBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pi Estimator (Monte Carlo Method)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button btnCalculatePi;
        private System.Windows.Forms.TextBox textBoxLengthOfSquare;
        private System.Windows.Forms.TextBox textBoxNoOfReps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPiOutput;
        private System.Windows.Forms.Label label4;
    }
}

