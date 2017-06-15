namespace FillBitmap
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
            this.pictureBoxFilled = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxInputLib = new System.Windows.Forms.PictureBox();
            this.pictureBoxFilledLib = new System.Windows.Forms.PictureBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFilled = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilledLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFilled
            // 
            this.pictureBoxFilled.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFilled.Location = new System.Drawing.Point(29, 165);
            this.pictureBoxFilled.Name = "pictureBoxFilled";
            this.pictureBoxFilled.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxFilled.TabIndex = 1;
            this.pictureBoxFilled.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxInput.Location = new System.Drawing.Point(29, 63);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxInput.TabIndex = 2;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxInputLib
            // 
            this.pictureBoxInputLib.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxInputLib.Location = new System.Drawing.Point(29, 114);
            this.pictureBoxInputLib.Name = "pictureBoxInputLib";
            this.pictureBoxInputLib.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxInputLib.TabIndex = 6;
            this.pictureBoxInputLib.TabStop = false;
            // 
            // pictureBoxFilledLib
            // 
            this.pictureBoxFilledLib.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFilledLib.Location = new System.Drawing.Point(29, 216);
            this.pictureBoxFilledLib.Name = "pictureBoxFilledLib";
            this.pictureBoxFilledLib.Size = new System.Drawing.Size(125, 45);
            this.pictureBoxFilledLib.TabIndex = 5;
            this.pictureBoxFilledLib.TabStop = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(29, 267);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(125, 26);
            this.textBoxInput.TabIndex = 7;
            // 
            // textBoxFilled
            // 
            this.textBoxFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilled.Location = new System.Drawing.Point(29, 299);
            this.textBoxFilled.Name = "textBoxFilled";
            this.textBoxFilled.Size = new System.Drawing.Size(125, 26);
            this.textBoxFilled.TabIndex = 8;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(29, 12);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(125, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 351);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBoxFilled);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.pictureBoxInputLib);
            this.Controls.Add(this.pictureBoxFilledLib);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.pictureBoxFilled);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CaptchaRecognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInputLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilledLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFilled;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxInputLib;
        private System.Windows.Forms.PictureBox pictureBoxFilledLib;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFilled;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

