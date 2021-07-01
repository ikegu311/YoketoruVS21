
namespace YoketoruVS21
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
            this.startbutton = new System.Windows.Forms.Button();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.copyrightlabel = new System.Windows.Forms.Label();
            this.Highlabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Gameoverlabel = new System.Windows.Forms.Label();
            this.Clearlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startbutton.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startbutton.Location = new System.Drawing.Point(311, 270);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(179, 59);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "スタート";
            this.startbutton.UseVisualStyleBackColor = false;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titlelabel.ForeColor = System.Drawing.Color.Blue;
            this.Titlelabel.Location = new System.Drawing.Point(227, 139);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(347, 53);
            this.Titlelabel.TabIndex = 1;
            this.Titlelabel.Text = "よけとる2021";
            this.Titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // copyrightlabel
            // 
            this.copyrightlabel.AutoSize = true;
            this.copyrightlabel.Location = new System.Drawing.Point(337, 426);
            this.copyrightlabel.Name = "copyrightlabel";
            this.copyrightlabel.Size = new System.Drawing.Size(126, 15);
            this.copyrightlabel.TabIndex = 2;
            this.copyrightlabel.Text = "copyright @ 2021 井口";
            // 
            // Highlabel
            // 
            this.Highlabel.AutoSize = true;
            this.Highlabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Highlabel.Location = new System.Drawing.Point(330, 222);
            this.Highlabel.Name = "Highlabel";
            this.Highlabel.Size = new System.Drawing.Size(141, 28);
            this.Highlabel.TabIndex = 3;
            this.Highlabel.Text = "HighScore 100";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timelabel.Location = new System.Drawing.Point(12, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(127, 37);
            this.Timelabel.TabIndex = 4;
            this.Timelabel.Text = "Time 100";
            // 
            // Gameoverlabel
            // 
            this.Gameoverlabel.AutoSize = true;
            this.Gameoverlabel.BackColor = System.Drawing.Color.White;
            this.Gameoverlabel.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gameoverlabel.ForeColor = System.Drawing.Color.Blue;
            this.Gameoverlabel.Location = new System.Drawing.Point(301, 196);
            this.Gameoverlabel.Name = "Gameoverlabel";
            this.Gameoverlabel.Size = new System.Drawing.Size(202, 54);
            this.Gameoverlabel.TabIndex = 5;
            this.Gameoverlabel.Text = "Gameover";
            // 
            // Clearlabel
            // 
            this.Clearlabel.AutoSize = true;
            this.Clearlabel.BackColor = System.Drawing.Color.White;
            this.Clearlabel.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clearlabel.ForeColor = System.Drawing.Color.Red;
            this.Clearlabel.Location = new System.Drawing.Point(337, 196);
            this.Clearlabel.Name = "Clearlabel";
            this.Clearlabel.Size = new System.Drawing.Size(113, 54);
            this.Clearlabel.TabIndex = 6;
            this.Clearlabel.Text = "Clear";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(543, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "タイトルへ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Clearlabel);
            this.Controls.Add(this.Gameoverlabel);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.Highlabel);
            this.Controls.Add(this.copyrightlabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label copyrightlabel;
        private System.Windows.Forms.Label Highlabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Gameoverlabel;
        private System.Windows.Forms.Label Clearlabel;
        private System.Windows.Forms.Button button1;
    }
}

