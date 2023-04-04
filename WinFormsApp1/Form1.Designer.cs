namespace WinFormsApp1
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
            this.txt_tenetId = new System.Windows.Forms.TextBox();
            this.txt_requestId = new System.Windows.Forms.TextBox();
            this.txt_stored = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reuslt = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tenetId
            // 
            this.txt_tenetId.Location = new System.Drawing.Point(130, 58);
            this.txt_tenetId.Name = "txt_tenetId";
            this.txt_tenetId.Size = new System.Drawing.Size(1062, 23);
            this.txt_tenetId.TabIndex = 0;
            // 
            // txt_requestId
            // 
            this.txt_requestId.Location = new System.Drawing.Point(130, 101);
            this.txt_requestId.Name = "txt_requestId";
            this.txt_requestId.Size = new System.Drawing.Size(1062, 23);
            this.txt_requestId.TabIndex = 1;
            // 
            // txt_stored
            // 
            this.txt_stored.Location = new System.Drawing.Point(130, 149);
            this.txt_stored.Name = "txt_stored";
            this.txt_stored.Size = new System.Drawing.Size(1062, 23);
            this.txt_stored.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "TenetId";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "RequestId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stored name";
            // 
            // btn_reuslt
            // 
            this.btn_reuslt.Location = new System.Drawing.Point(23, 201);
            this.btn_reuslt.Name = "btn_reuslt";
            this.btn_reuslt.Size = new System.Drawing.Size(187, 33);
            this.btn_reuslt.TabIndex = 6;
            this.btn_reuslt.Text = "Result";
            this.btn_reuslt.UseVisualStyleBackColor = true;
            this.btn_reuslt.Click += new System.EventHandler(this.btn_reuslt_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(23, 256);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(1244, 23);
            this.txt_result.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(23, 316);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(187, 30);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 438);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_reuslt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stored);
            this.Controls.Add(this.txt_requestId);
            this.Controls.Add(this.txt_tenetId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_tenetId;
        private TextBox txt_requestId;
        private TextBox txt_stored;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_reuslt;
        private TextBox txt_result;
        private Button btn_clear;
    }
}