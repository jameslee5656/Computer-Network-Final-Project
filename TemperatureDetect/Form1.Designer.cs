namespace TemperatureDetect
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.RecText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_sensor = new System.Windows.Forms.DataGridView();
            this.RecText2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sensor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Receive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // RecText
            // 
            this.RecText.Location = new System.Drawing.Point(16, 98);
            this.RecText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecText.Multiline = true;
            this.RecText.Name = "RecText";
            this.RecText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecText.Size = new System.Drawing.Size(356, 138);
            this.RecText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SQL";
            // 
            // dataGridView_sensor
            // 
            this.dataGridView_sensor.AllowUserToAddRows = false;
            this.dataGridView_sensor.AllowUserToDeleteRows = false;
            this.dataGridView_sensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sensor.Location = new System.Drawing.Point(16, 286);
            this.dataGridView_sensor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_sensor.Name = "dataGridView_sensor";
            this.dataGridView_sensor.ReadOnly = true;
            this.dataGridView_sensor.RowTemplate.Height = 24;
            this.dataGridView_sensor.Size = new System.Drawing.Size(765, 188);
            this.dataGridView_sensor.TabIndex = 7;
            // 
            // RecText2
            // 
            this.RecText2.Location = new System.Drawing.Point(431, 98);
            this.RecText2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecText2.Multiline = true;
            this.RecText2.Name = "RecText2";
            this.RecText2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecText2.Size = new System.Drawing.Size(349, 138);
            this.RecText2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(427, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "humidity";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "temperuture";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 250);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecText2);
            this.Controls.Add(this.dataGridView_sensor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecText);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Detect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RecText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_sensor;
        private System.Windows.Forms.TextBox RecText2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

