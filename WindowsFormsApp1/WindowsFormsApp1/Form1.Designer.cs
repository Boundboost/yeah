namespace WindowsFormsApp1
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_play_other = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(248, -1);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(307, 114);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "TITLE";
            // 
            // btn_play_other
            // 
            this.btn_play_other.BackColor = System.Drawing.SystemColors.Control;
            this.btn_play_other.FlatAppearance.BorderSize = 0;
            this.btn_play_other.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_play_other.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_play_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play_other.Image = global::WindowsFormsApp1.Properties.Resources.button_removebg_preview__1_;
            this.btn_play_other.Location = new System.Drawing.Point(301, 242);
            this.btn_play_other.Name = "btn_play_other";
            this.btn_play_other.Size = new System.Drawing.Size(173, 65);
            this.btn_play_other.TabIndex = 2;
            this.btn_play_other.Text = "change the code";
            this.btn_play_other.UseVisualStyleBackColor = false;
            this.btn_play_other.Click += new System.EventHandler(this.btn_play_other_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Control;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btn_play.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Image = global::WindowsFormsApp1.Properties.Resources.button_removebg_preview__1_;
            this.btn_play.Location = new System.Drawing.Point(301, 133);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(173, 65);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "typo spotter";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_play_other);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_play_other;
    }
}

