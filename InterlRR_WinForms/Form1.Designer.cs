namespace InterlRR_WinForms
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.picNetwork = new System.Windows.Forms.PictureBox();
            this.plotPareto = new ScottPlot.WinForms.FormsPlot();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblMapTitle = new System.Windows.Forms.Label();
            this.lblParetoTitle = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblLogsTitle = new System.Windows.Forms.Label();
            this.dgvNodes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(748, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar Optimización";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLogs
            // 
            this.txtLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogs.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLogs.ForeColor = System.Drawing.Color.LightGray;
            this.txtLogs.Location = new System.Drawing.Point(280, 540);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.Size = new System.Drawing.Size(648, 130);
            this.txtLogs.TabIndex = 3;
            this.txtLogs.Text = "";
            // 
            // picNetwork
            // 
            this.picNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.picNetwork.Location = new System.Drawing.Point(12, 100);
            this.picNetwork.Name = "picNetwork";
            this.picNetwork.Size = new System.Drawing.Size(450, 400);
            this.picNetwork.TabIndex = 1;
            this.picNetwork.TabStop = false;
            // 
            // plotPareto
            // 
            this.plotPareto.Location = new System.Drawing.Point(478, 100);
            this.plotPareto.Name = "plotPareto";
            this.plotPareto.Size = new System.Drawing.Size(450, 400);
            this.plotPareto.TabIndex = 2;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMainTitle.Location = new System.Drawing.Point(12, 15);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(700, 40);
            this.lblMainTitle.TabIndex = 4;
            this.lblMainTitle.Text = "IntelRR — Sistema Híbrido de Optimización Multiobjetivo";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapTitle
            // 
            this.lblMapTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMapTitle.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblMapTitle.Location = new System.Drawing.Point(12, 75);
            this.lblMapTitle.Name = "lblMapTitle";
            this.lblMapTitle.Size = new System.Drawing.Size(450, 20);
            this.lblMapTitle.TabIndex = 5;
            this.lblMapTitle.Text = "TOPOLOGÍA DE RED FÍSICA (CABLEADO STRUCT)";
            // 
            // lblParetoTitle
            // 
            this.lblParetoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblParetoTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblParetoTitle.Location = new System.Drawing.Point(478, 75);
            this.lblParetoTitle.Name = "lblParetoTitle";
            this.lblParetoTitle.Size = new System.Drawing.Size(450, 20);
            this.lblParetoTitle.TabIndex = 6;
            this.lblParetoTitle.Text = "FRENTE DE PARETO (CONVERGENCIA EFICIENTE)";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTableTitle.Location = new System.Drawing.Point(12, 515);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(250, 20);
            this.lblTableTitle.TabIndex = 7;
            this.lblTableTitle.Text = "MATRIZ DE COORDENADAS (INPUT)";
            // 
            // lblLogsTitle
            // 
            this.lblLogsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogsTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLogsTitle.Location = new System.Drawing.Point(280, 515);
            this.lblLogsTitle.Name = "lblLogsTitle";
            this.lblLogsTitle.Size = new System.Drawing.Size(648, 20);
            this.lblLogsTitle.TabIndex = 8;
            this.lblLogsTitle.Text = "CONSOLA DE RENDIMIENTO Y MÉTRICAS";
            // 
            // dgvNodes
            // 
            this.dgvNodes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvNodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNodes.Location = new System.Drawing.Point(12, 540);
            this.dgvNodes.Name = "dgvNodes";
            this.dgvNodes.RowHeadersVisible = false;
            this.dgvNodes.Size = new System.Drawing.Size(250, 130);
            this.dgvNodes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(944, 685);
            this.Controls.Add(this.dgvNodes);
            this.Controls.Add(this.lblLogsTitle);
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.lblParetoTitle);
            this.Controls.Add(this.lblMapTitle);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.txtLogs);
            this.Controls.Add(this.plotPareto);
            this.Controls.Add(this.picNetwork);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntelRR - Sistema de Optimización Multiobjetivo Híbrido";
            ((System.ComponentModel.ISupportInitialize)(this.picNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picNetwork;
        private ScottPlot.WinForms.FormsPlot plotPareto;
        private System.Windows.Forms.RichTextBox txtLogs;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblMapTitle;
        private System.Windows.Forms.Label lblParetoTitle;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Label lblLogsTitle;
        private System.Windows.Forms.DataGridView dgvNodes;
    }
}