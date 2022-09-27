namespace JobManagerDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtHoraEntradaManha = new System.Windows.Forms.DateTimePicker();
            this.DtHoraSaidaManha = new System.Windows.Forms.DateTimePicker();
            this.DtHoraEntradaTarde = new System.Windows.Forms.DateTimePicker();
            this.DtHoraSaidaTarde = new System.Windows.Forms.DateTimePicker();
            this.GbHorarios = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ListViewCargasHorarias = new System.Windows.Forms.ListView();
            this.entradaManha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saidaManha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.entradaTarde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saidaTarde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnRemoverRegistro = new System.Windows.Forms.Button();
            this.LblTotalHoras = new System.Windows.Forms.Label();
            this.GbHorarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTRADA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SAÍDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MANHÃ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TARDE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SAÍDA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ENTRADA:";
            // 
            // DtHoraEntradaManha
            // 
            this.DtHoraEntradaManha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtHoraEntradaManha.CustomFormat = "hh:mm";
            this.DtHoraEntradaManha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHoraEntradaManha.Location = new System.Drawing.Point(74, 49);
            this.DtHoraEntradaManha.Name = "DtHoraEntradaManha";
            this.DtHoraEntradaManha.ShowUpDown = true;
            this.DtHoraEntradaManha.Size = new System.Drawing.Size(72, 20);
            this.DtHoraEntradaManha.TabIndex = 11;
            this.DtHoraEntradaManha.Value = new System.DateTime(2022, 9, 27, 12, 27, 21, 0);
            // 
            // DtHoraSaidaManha
            // 
            this.DtHoraSaidaManha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtHoraSaidaManha.CustomFormat = "HH:mm";
            this.DtHoraSaidaManha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHoraSaidaManha.Location = new System.Drawing.Point(74, 75);
            this.DtHoraSaidaManha.Name = "DtHoraSaidaManha";
            this.DtHoraSaidaManha.ShowUpDown = true;
            this.DtHoraSaidaManha.Size = new System.Drawing.Size(72, 20);
            this.DtHoraSaidaManha.TabIndex = 11;
            this.DtHoraSaidaManha.Value = new System.DateTime(2022, 9, 27, 12, 27, 32, 0);
            // 
            // DtHoraEntradaTarde
            // 
            this.DtHoraEntradaTarde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtHoraEntradaTarde.CustomFormat = "HH:mm";
            this.DtHoraEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHoraEntradaTarde.Location = new System.Drawing.Point(248, 49);
            this.DtHoraEntradaTarde.Name = "DtHoraEntradaTarde";
            this.DtHoraEntradaTarde.ShowUpDown = true;
            this.DtHoraEntradaTarde.Size = new System.Drawing.Size(72, 20);
            this.DtHoraEntradaTarde.TabIndex = 11;
            this.DtHoraEntradaTarde.Value = new System.DateTime(2022, 9, 27, 12, 27, 35, 0);
            // 
            // DtHoraSaidaTarde
            // 
            this.DtHoraSaidaTarde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtHoraSaidaTarde.CustomFormat = "HH:mm";
            this.DtHoraSaidaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtHoraSaidaTarde.Location = new System.Drawing.Point(248, 75);
            this.DtHoraSaidaTarde.Name = "DtHoraSaidaTarde";
            this.DtHoraSaidaTarde.ShowUpDown = true;
            this.DtHoraSaidaTarde.Size = new System.Drawing.Size(72, 20);
            this.DtHoraSaidaTarde.TabIndex = 11;
            this.DtHoraSaidaTarde.Value = new System.DateTime(2022, 9, 27, 12, 27, 39, 0);
            // 
            // GbHorarios
            // 
            this.GbHorarios.Controls.Add(this.DtHoraSaidaTarde);
            this.GbHorarios.Controls.Add(this.DtHoraEntradaTarde);
            this.GbHorarios.Controls.Add(this.DtHoraSaidaManha);
            this.GbHorarios.Controls.Add(this.DtHoraEntradaManha);
            this.GbHorarios.Controls.Add(this.BtnAdd);
            this.GbHorarios.Controls.Add(this.label3);
            this.GbHorarios.Controls.Add(this.label1);
            this.GbHorarios.Controls.Add(this.label4);
            this.GbHorarios.Controls.Add(this.label2);
            this.GbHorarios.Controls.Add(this.label6);
            this.GbHorarios.Controls.Add(this.label5);
            this.GbHorarios.Location = new System.Drawing.Point(12, 12);
            this.GbHorarios.Name = "GbHorarios";
            this.GbHorarios.Size = new System.Drawing.Size(337, 155);
            this.GbHorarios.TabIndex = 12;
            this.GbHorarios.TabStop = false;
            this.GbHorarios.Text = "HORARIOS";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(48, 117);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(246, 23);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "INCLUIR HORÁRIOS";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ListViewCargasHorarias
            // 
            this.ListViewCargasHorarias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.entradaManha,
            this.saidaManha,
            this.entradaTarde,
            this.saidaTarde});
            this.ListViewCargasHorarias.FullRowSelect = true;
            this.ListViewCargasHorarias.HideSelection = false;
            this.ListViewCargasHorarias.Location = new System.Drawing.Point(12, 173);
            this.ListViewCargasHorarias.Name = "ListViewCargasHorarias";
            this.ListViewCargasHorarias.Size = new System.Drawing.Size(337, 174);
            this.ListViewCargasHorarias.TabIndex = 13;
            this.ListViewCargasHorarias.UseCompatibleStateImageBehavior = false;
            this.ListViewCargasHorarias.View = System.Windows.Forms.View.Details;
            this.ListViewCargasHorarias.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListViewCargasHorarias_ItemSelectionChanged);
            // 
            // entradaManha
            // 
            this.entradaManha.Text = "ENT. MANHA";
            this.entradaManha.Width = 80;
            // 
            // saidaManha
            // 
            this.saidaManha.Text = "SAIDA MANHA";
            this.saidaManha.Width = 90;
            // 
            // entradaTarde
            // 
            this.entradaTarde.Text = "ENT. TARDE";
            this.entradaTarde.Width = 80;
            // 
            // saidaTarde
            // 
            this.saidaTarde.Text = "SAIDA TARDE";
            this.saidaTarde.Width = 89;
            // 
            // BtnRemoverRegistro
            // 
            this.BtnRemoverRegistro.Enabled = false;
            this.BtnRemoverRegistro.Location = new System.Drawing.Point(195, 353);
            this.BtnRemoverRegistro.Name = "BtnRemoverRegistro";
            this.BtnRemoverRegistro.Size = new System.Drawing.Size(154, 23);
            this.BtnRemoverRegistro.TabIndex = 13;
            this.BtnRemoverRegistro.Text = "REMOVER REGISTRO";
            this.BtnRemoverRegistro.UseVisualStyleBackColor = true;
            this.BtnRemoverRegistro.Click += new System.EventHandler(this.BtnRemoverRegistro_Click);
            // 
            // LblTotalHoras
            // 
            this.LblTotalHoras.AutoSize = true;
            this.LblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalHoras.Location = new System.Drawing.Point(12, 356);
            this.LblTotalHoras.Name = "LblTotalHoras";
            this.LblTotalHoras.Size = new System.Drawing.Size(85, 16);
            this.LblTotalHoras.TabIndex = 14;
            this.LblTotalHoras.Text = "Total Horas: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 422);
            this.Controls.Add(this.LblTotalHoras);
            this.Controls.Add(this.BtnRemoverRegistro);
            this.Controls.Add(this.ListViewCargasHorarias);
            this.Controls.Add(this.GbHorarios);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Manager Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GbHorarios.ResumeLayout(false);
            this.GbHorarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtHoraEntradaManha;
        private System.Windows.Forms.DateTimePicker DtHoraSaidaManha;
        private System.Windows.Forms.DateTimePicker DtHoraEntradaTarde;
        private System.Windows.Forms.DateTimePicker DtHoraSaidaTarde;
        private System.Windows.Forms.GroupBox GbHorarios;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListView ListViewCargasHorarias;
        private System.Windows.Forms.ColumnHeader entradaManha;
        private System.Windows.Forms.ColumnHeader saidaManha;
        private System.Windows.Forms.ColumnHeader entradaTarde;
        private System.Windows.Forms.ColumnHeader saidaTarde;
        private System.Windows.Forms.Button BtnRemoverRegistro;
        private System.Windows.Forms.Label LblTotalHoras;
    }
}

