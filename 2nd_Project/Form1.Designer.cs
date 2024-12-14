namespace _2nd_Project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_word = new System.Windows.Forms.Label();
            this.textBox1_guess = new System.Windows.Forms.TextBox();
            this.button1_Next = new System.Windows.Forms.Button();
            this.button2_begin = new System.Windows.Forms.Button();
            this.label2_result = new System.Windows.Forms.Label();
            this.label1_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.Color.Green;
            this.label_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_word.ForeColor = System.Drawing.Color.White;
            this.label_word.Location = new System.Drawing.Point(228, 24);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(608, 58);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1_guess
            // 
            this.textBox1_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1_guess.Location = new System.Drawing.Point(251, 111);
            this.textBox1_guess.Name = "textBox1_guess";
            this.textBox1_guess.Size = new System.Drawing.Size(568, 45);
            this.textBox1_guess.TabIndex = 1;
            this.textBox1_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1_guess.TextChanged += new System.EventHandler(this.textBox1_guess_TextChanged);
            // 
            // button1_Next
            // 
            this.button1_Next.BackColor = System.Drawing.Color.Lime;
            this.button1_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_Next.ForeColor = System.Drawing.Color.Black;
            this.button1_Next.Location = new System.Drawing.Point(251, 193);
            this.button1_Next.Name = "button1_Next";
            this.button1_Next.Size = new System.Drawing.Size(550, 86);
            this.button1_Next.TabIndex = 2;
            this.button1_Next.Text = "Next";
            this.button1_Next.UseVisualStyleBackColor = false;
            this.button1_Next.Click += new System.EventHandler(this.button1_Next_Click);
            // 
            // button2_begin
            // 
            this.button2_begin.BackColor = System.Drawing.Color.Lime;
            this.button2_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_begin.Location = new System.Drawing.Point(251, 311);
            this.button2_begin.Name = "button2_begin";
            this.button2_begin.Size = new System.Drawing.Size(550, 81);
            this.button2_begin.TabIndex = 3;
            this.button2_begin.Text = "Begin";
            this.button2_begin.UseVisualStyleBackColor = false;
            this.button2_begin.Click += new System.EventHandler(this.button2_begin_Click);
            // 
            // label2_result
            // 
            this.label2_result.BackColor = System.Drawing.Color.Orange;
            this.label2_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_result.ForeColor = System.Drawing.Color.Black;
            this.label2_result.Location = new System.Drawing.Point(228, 446);
            this.label2_result.Name = "label2_result";
            this.label2_result.Size = new System.Drawing.Size(608, 58);
            this.label2_result.TabIndex = 4;
            this.label2_result.Text = "Result";
            this.label2_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_score
            // 
            this.label1_score.AutoSize = true;
            this.label1_score.Location = new System.Drawing.Point(517, 547);
            this.label1_score.Name = "label1_score";
            this.label1_score.Size = new System.Drawing.Size(21, 16);
            this.label1_score.TabIndex = 5;
            this.label1_score.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 603);
            this.Controls.Add(this.label1_score);
            this.Controls.Add(this.label2_result);
            this.Controls.Add(this.button2_begin);
            this.Controls.Add(this.button1_Next);
            this.Controls.Add(this.textBox1_guess);
            this.Controls.Add(this.label_word);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox1_guess;
        private System.Windows.Forms.Button button1_Next;
        private System.Windows.Forms.Button button2_begin;
        private System.Windows.Forms.Label label2_result;
        private System.Windows.Forms.Label label1_score;
    }
}

