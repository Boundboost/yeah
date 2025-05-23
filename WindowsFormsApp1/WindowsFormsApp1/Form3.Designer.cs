namespace WindowsFormsApp1
{
    partial class Form3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_quenum = new System.Windows.Forms.Label();
            this.lbl_que = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_out = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbl_quenum
            // 
            this.lbl_quenum.AutoSize = true;
            this.lbl_quenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quenum.Location = new System.Drawing.Point(570, 12);
            this.lbl_quenum.Name = "lbl_quenum";
            this.lbl_quenum.Size = new System.Drawing.Size(80, 18);
            this.lbl_quenum.TabIndex = 1;
            this.lbl_quenum.Text = "Question:1";
            // 
            // lbl_que
            // 
            this.lbl_que.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_que.Location = new System.Drawing.Point(490, 59);
            this.lbl_que.Name = "lbl_que";
            this.lbl_que.Size = new System.Drawing.Size(237, 82);
            this.lbl_que.TabIndex = 2;
            this.lbl_que.Text = "do the thing";
            this.lbl_que.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(573, 180);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_out.Location = new System.Drawing.Point(570, 123);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(0, 18);
            this.lbl_out.TabIndex = 4;
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(573, 233);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_que);
            this.Controls.Add(this.lbl_quenum);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_quenum;
        private System.Windows.Forms.Label lbl_que;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.Button btn_next;
    }
}