namespace Práctica_bits_y_bytes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProcesoLLenado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjustarFecha = new System.Windows.Forms.Button();
            this.txtFechaDecimal = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgSen1 = new System.Windows.Forms.Label();
            this.imgSen2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgFull = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgDirec = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(98, 31);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(167, 29);
            this.txtNum.TabIndex = 1;
            // 
            // btnProcess
            // 
            this.btnProcess.AutoSize = true;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(287, 31);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(79, 29);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(35, 351);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(159, 26);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Fecha de lectura:";
            // 
            // lblProcesoLLenado
            // 
            this.lblProcesoLLenado.AutoSize = true;
            this.lblProcesoLLenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesoLLenado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProcesoLLenado.Location = new System.Drawing.Point(53, 197);
            this.lblProcesoLLenado.Name = "lblProcesoLLenado";
            this.lblProcesoLLenado.Size = new System.Drawing.Size(0, 18);
            this.lblProcesoLLenado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-29, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(910, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha:";
            // 
            // btnAjustarFecha
            // 
            this.btnAjustarFecha.AutoSize = true;
            this.btnAjustarFecha.Location = new System.Drawing.Point(168, 504);
            this.btnAjustarFecha.Name = "btnAjustarFecha";
            this.btnAjustarFecha.Size = new System.Drawing.Size(128, 34);
            this.btnAjustarFecha.TabIndex = 17;
            this.btnAjustarFecha.Text = "Ajustar fecha";
            this.btnAjustarFecha.UseVisualStyleBackColor = true;
            this.btnAjustarFecha.Click += new System.EventHandler(this.btnAjustarFecha_Click);
            // 
            // txtFechaDecimal
            // 
            this.txtFechaDecimal.Location = new System.Drawing.Point(119, 560);
            this.txtFechaDecimal.Name = "txtFechaDecimal";
            this.txtFechaDecimal.ReadOnly = true;
            this.txtFechaDecimal.Size = new System.Drawing.Size(236, 29);
            this.txtFechaDecimal.TabIndex = 18;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(115, 450);
            this.datePicker.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(363, 29);
            this.datePicker.TabIndex = 19;
            this.datePicker.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgSen1);
            this.groupBox1.Controls.Add(this.imgSen2);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 215);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensores";
            // 
            // imgSen1
            // 
            this.imgSen1.Image = global::Práctica_bits_y_bytes.Properties.Resources.iconmonstr_circle_2_48;
            this.imgSen1.Location = new System.Drawing.Point(23, 91);
            this.imgSen1.Name = "imgSen1";
            this.imgSen1.Size = new System.Drawing.Size(74, 57);
            this.imgSen1.TabIndex = 8;
            this.imgSen1.Visible = false;
            // 
            // imgSen2
            // 
            this.imgSen2.Image = global::Práctica_bits_y_bytes.Properties.Resources.iconmonstr_forbidden_1_72;
            this.imgSen2.Location = new System.Drawing.Point(103, 66);
            this.imgSen2.Name = "imgSen2";
            this.imgSen2.Size = new System.Drawing.Size(103, 82);
            this.imgSen2.TabIndex = 7;
            this.imgSen2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgFull);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblProcesoLLenado);
            this.groupBox2.Location = new System.Drawing.Point(255, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 241);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nivel";
            // 
            // imgFull
            // 
            this.imgFull.BackColor = System.Drawing.SystemColors.Control;
            this.imgFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFull.Location = new System.Drawing.Point(56, 43);
            this.imgFull.Name = "imgFull";
            this.imgFull.Size = new System.Drawing.Size(90, 140);
            this.imgFull.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(56, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 140);
            this.label5.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgDirec);
            this.groupBox3.Location = new System.Drawing.Point(475, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 215);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dirrección";
            // 
            // imgDirec
            // 
            this.imgDirec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgDirec.Location = new System.Drawing.Point(27, 43);
            this.imgDirec.Name = "imgDirec";
            this.imgDirec.Size = new System.Drawing.Size(150, 150);
            this.imgDirec.TabIndex = 14;
            this.imgDirec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 668);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtFechaDecimal);
            this.Controls.Add(this.btnAjustarFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Bits and bytes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProcesoLLenado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjustarFecha;
        private System.Windows.Forms.TextBox txtFechaDecimal;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label imgSen1;
        private System.Windows.Forms.Label imgSen2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label imgFull;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imgDirec;
    }
}

