namespace text_to_img
{
    partial class MainForm
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
            this.txt_TextToImg = new System.Windows.Forms.RichTextBox();
            this.btn_GO = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.brn_ChooseColor = new System.Windows.Forms.Button();
            this.pctr_Result = new System.Windows.Forms.PictureBox();
            this.txt_OnesColor = new System.Windows.Forms.TextBox();
            this.btn_Decode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TextToImg
            // 
            this.txt_TextToImg.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_TextToImg.Location = new System.Drawing.Point(12, 12);
            this.txt_TextToImg.Name = "txt_TextToImg";
            this.txt_TextToImg.Size = new System.Drawing.Size(597, 115);
            this.txt_TextToImg.TabIndex = 0;
            this.txt_TextToImg.Text = "";
            this.txt_TextToImg.TextChanged += new System.EventHandler(this.txt_TextToImg_TextChanged);
            // 
            // btn_GO
            // 
            this.btn_GO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GO.Location = new System.Drawing.Point(686, 400);
            this.btn_GO.Name = "btn_GO";
            this.btn_GO.Size = new System.Drawing.Size(102, 38);
            this.btn_GO.TabIndex = 1;
            this.btn_GO.Text = "Save File";
            this.btn_GO.UseVisualStyleBackColor = false;
            this.btn_GO.Click += new System.EventHandler(this.btn_GO_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // brn_ChooseColor
            // 
            this.brn_ChooseColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.brn_ChooseColor.Location = new System.Drawing.Point(686, 347);
            this.brn_ChooseColor.Name = "brn_ChooseColor";
            this.brn_ChooseColor.Size = new System.Drawing.Size(102, 38);
            this.brn_ChooseColor.TabIndex = 2;
            this.brn_ChooseColor.Text = "ChooseColor";
            this.brn_ChooseColor.UseVisualStyleBackColor = false;
            this.brn_ChooseColor.Click += new System.EventHandler(this.brn_ChooseColor_Click);
            // 
            // pctr_Result
            // 
            this.pctr_Result.Location = new System.Drawing.Point(12, 133);
            this.pctr_Result.Name = "pctr_Result";
            this.pctr_Result.Size = new System.Drawing.Size(597, 305);
            this.pctr_Result.TabIndex = 3;
            this.pctr_Result.TabStop = false;
            // 
            // txt_OnesColor
            // 
            this.txt_OnesColor.Enabled = false;
            this.txt_OnesColor.Location = new System.Drawing.Point(654, 356);
            this.txt_OnesColor.Name = "txt_OnesColor";
            this.txt_OnesColor.Size = new System.Drawing.Size(26, 23);
            this.txt_OnesColor.TabIndex = 4;
            // 
            // btn_Decode
            // 
            this.btn_Decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Decode.Location = new System.Drawing.Point(686, 291);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(102, 38);
            this.btn_Decode.TabIndex = 5;
            this.btn_Decode.Text = "Choose Img";
            this.btn_Decode.UseVisualStyleBackColor = false;
            this.btn_Decode.Click += new System.EventHandler(this.btn_Decode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Decode);
            this.Controls.Add(this.txt_OnesColor);
            this.Controls.Add(this.pctr_Result);
            this.Controls.Add(this.brn_ChooseColor);
            this.Controls.Add(this.btn_GO);
            this.Controls.Add(this.txt_TextToImg);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txt_TextToImg;
        private Button btn_GO;
        private ColorDialog colorDialog1;
        private Button brn_ChooseColor;
        private PictureBox pctr_Result;
        private TextBox txt_OnesColor;
        private Button btn_Decode;
    }
}