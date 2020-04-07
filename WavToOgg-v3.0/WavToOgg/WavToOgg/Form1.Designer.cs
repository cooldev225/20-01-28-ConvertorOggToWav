namespace WavToOggTest
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wavlab = new System.Windows.Forms.Label();
            this.ogglab = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.channelTxt = new System.Windows.Forms.TextBox();
            this.rateCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "WAV File: ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ogg File: ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // wavlab
            // 
            this.wavlab.AutoSize = true;
            this.wavlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wavlab.Location = new System.Drawing.Point(125, 71);
            this.wavlab.Name = "wavlab";
            this.wavlab.Size = new System.Drawing.Size(25, 24);
            this.wavlab.TabIndex = 3;
            this.wavlab.Text = "...";
            // 
            // ogglab
            // 
            this.ogglab.AutoSize = true;
            this.ogglab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogglab.Location = new System.Drawing.Point(125, 139);
            this.ogglab.Name = "ogglab";
            this.ogglab.Size = new System.Drawing.Size(25, 24);
            this.ogglab.TabIndex = 4;
            this.ogglab.Text = "...";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(76, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "WAV To OGG";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "SampleRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Channel";
            // 
            // channelTxt
            // 
            this.channelTxt.Location = new System.Drawing.Point(599, 23);
            this.channelTxt.Name = "channelTxt";
            this.channelTxt.Size = new System.Drawing.Size(86, 20);
            this.channelTxt.TabIndex = 10;
            this.channelTxt.ModifiedChanged += new System.EventHandler(this.channelTxt_ModifiedChanged);
            this.channelTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.channelTxt_KeyUp);
            // 
            // rateCb
            // 
            this.rateCb.FormattingEnabled = true;
            this.rateCb.Location = new System.Drawing.Point(387, 24);
            this.rateCb.Name = "rateCb";
            this.rateCb.Size = new System.Drawing.Size(121, 21);
            this.rateCb.TabIndex = 12;
            this.rateCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 181);
            this.Controls.Add(this.rateCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.channelTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wavlab);
            this.Controls.Add(this.ogglab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label wavlab;
        private System.Windows.Forms.Label ogglab;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox channelTxt;
        private System.Windows.Forms.ComboBox rateCb;
    }
}

