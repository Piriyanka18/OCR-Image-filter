namespace OCR_1
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
            this.pbimg = new System.Windows.Forms.PictureBox();
            this.rtxresult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnload = new System.Windows.Forms.Button();
            this.Btnp = new System.Windows.Forms.Button();
            this.Btnrl = new System.Windows.Forms.Button();
            this.Btnrr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbimg
            // 
            this.pbimg.Location = new System.Drawing.Point(49, 31);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(292, 256);
            this.pbimg.TabIndex = 0;
            this.pbimg.TabStop = false;
            // 
            // rtxresult
            // 
            this.rtxresult.Location = new System.Drawing.Point(475, 57);
            this.rtxresult.Name = "rtxresult";
            this.rtxresult.Size = new System.Drawing.Size(225, 265);
            this.rtxresult.TabIndex = 1;
            this.rtxresult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "OCR Result";
            // 
            // Btnload
            // 
            this.Btnload.Location = new System.Drawing.Point(29, 306);
            this.Btnload.Name = "Btnload";
            this.Btnload.Size = new System.Drawing.Size(120, 45);
            this.Btnload.TabIndex = 3;
            this.Btnload.Text = "Load Image";
            this.Btnload.UseVisualStyleBackColor = true;
            this.Btnload.Click += new System.EventHandler(this.Btnload_Click);
            // 
            // Btnp
            // 
            this.Btnp.Location = new System.Drawing.Point(178, 312);
            this.Btnp.Name = "Btnp";
            this.Btnp.Size = new System.Drawing.Size(118, 39);
            this.Btnp.TabIndex = 4;
            this.Btnp.Text = "Process";
            this.Btnp.UseVisualStyleBackColor = true;
            this.Btnp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btnrl
            // 
            this.Btnrl.Location = new System.Drawing.Point(29, 376);
            this.Btnrl.Name = "Btnrl";
            this.Btnrl.Size = new System.Drawing.Size(108, 38);
            this.Btnrl.TabIndex = 5;
            this.Btnrl.Text = "Rotart";
            this.Btnrl.UseVisualStyleBackColor = true;
            this.Btnrl.Click += new System.EventHandler(this.Btnrl_Click);
            // 
            // Btnrr
            // 
            this.Btnrr.Location = new System.Drawing.Point(192, 376);
            this.Btnrr.Name = "Btnrr";
            this.Btnrr.Size = new System.Drawing.Size(91, 38);
            this.Btnrr.TabIndex = 6;
            this.Btnrr.Text = "Rotart";
            this.Btnrr.UseVisualStyleBackColor = true;
            this.Btnrr.Click += new System.EventHandler(this.Btnrr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnrr);
            this.Controls.Add(this.Btnrl);
            this.Controls.Add(this.Btnp);
            this.Controls.Add(this.Btnload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxresult);
            this.Controls.Add(this.pbimg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbimg;
        private System.Windows.Forms.RichTextBox rtxresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnload;
        private System.Windows.Forms.Button Btnp;
        private System.Windows.Forms.Button Btnrl;
        private System.Windows.Forms.Button Btnrr;
    }
}

