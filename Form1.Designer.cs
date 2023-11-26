namespace Practical6_Sophie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEventAnimal = new System.Windows.Forms.Button();
            this.btnEventMammal = new System.Windows.Forms.Button();
            this.btnEventUngulate = new System.Windows.Forms.Button();
            this.btnEventBird = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEventAnimal
            // 
            this.btnEventAnimal.Location = new System.Drawing.Point(12, 25);
            this.btnEventAnimal.Name = "btnEventAnimal";
            this.btnEventAnimal.Size = new System.Drawing.Size(252, 33);
            this.btnEventAnimal.TabIndex = 0;
            this.btnEventAnimal.Text = "Івент тварин";
            this.btnEventAnimal.UseVisualStyleBackColor = true;
            this.btnEventAnimal.Click += new System.EventHandler(this.btnEventAnimal_Click);
            // 
            // btnEventMammal
            // 
            this.btnEventMammal.Location = new System.Drawing.Point(12, 64);
            this.btnEventMammal.Name = "btnEventMammal";
            this.btnEventMammal.Size = new System.Drawing.Size(252, 33);
            this.btnEventMammal.TabIndex = 0;
            this.btnEventMammal.Text = "Івент ссавців";
            this.btnEventMammal.UseVisualStyleBackColor = true;
            this.btnEventMammal.Click += new System.EventHandler(this.btnEventMammal_Click);
            // 
            // btnEventUngulate
            // 
            this.btnEventUngulate.Location = new System.Drawing.Point(12, 103);
            this.btnEventUngulate.Name = "btnEventUngulate";
            this.btnEventUngulate.Size = new System.Drawing.Size(252, 33);
            this.btnEventUngulate.TabIndex = 0;
            this.btnEventUngulate.Text = "Івент парнокопитних";
            this.btnEventUngulate.UseVisualStyleBackColor = true;
            this.btnEventUngulate.Click += new System.EventHandler(this.btnEventUngulate_Click);
            // 
            // btnEventBird
            // 
            this.btnEventBird.Location = new System.Drawing.Point(12, 142);
            this.btnEventBird.Name = "btnEventBird";
            this.btnEventBird.Size = new System.Drawing.Size(252, 33);
            this.btnEventBird.TabIndex = 0;
            this.btnEventBird.Text = "Івент птахів";
            this.btnEventBird.UseVisualStyleBackColor = true;
            this.btnEventBird.Click += new System.EventHandler(this.btnEventBird_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 226);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEventBird);
            this.Controls.Add(this.btnEventUngulate);
            this.Controls.Add(this.btnEventMammal);
            this.Controls.Add(this.btnEventAnimal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pract6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEventAnimal;
        private System.Windows.Forms.Button btnEventMammal;
        private System.Windows.Forms.Button btnEventUngulate;
        private System.Windows.Forms.Button btnEventBird;
        private System.Windows.Forms.Button btnExit;
    }
}

