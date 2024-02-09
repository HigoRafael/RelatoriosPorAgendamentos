namespace Agendamentos
{
    partial class FAgendamentos
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
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            sfDataGridAgendas = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            sfDataGridRelatorios = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sfDataGridAgendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sfDataGridRelatorios).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(sfDataGridAgendas);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(956, 655);
            gradientPanel1.TabIndex = 0;
            // 
            // sfDataGridAgendas
            // 
            sfDataGridAgendas.AccessibleName = "Table";
            sfDataGridAgendas.AllowFiltering = true;
            sfDataGridAgendas.AllowResizingColumns = true;
            sfDataGridAgendas.AllowSelectionOnMouseDown = true;
            sfDataGridAgendas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sfDataGridAgendas.BackColor = SystemColors.Control;
            sfDataGridAgendas.Location = new Point(384, 145);
            sfDataGridAgendas.Name = "sfDataGridAgendas";
            sfDataGridAgendas.Size = new Size(223, 254);
            sfDataGridAgendas.Style.BorderColor = Color.FromArgb(100, 100, 100);
            sfDataGridAgendas.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            sfDataGridAgendas.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGridAgendas.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGridAgendas.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            sfDataGridAgendas.TabIndex = 0;
            sfDataGridAgendas.Text = "sfDataGrid1";
            // 
            // sfDataGridRelatorios
            // 
            sfDataGridRelatorios.AccessibleName = "Table";
            sfDataGridRelatorios.AllowDraggingColumns = true;
            sfDataGridRelatorios.AllowDrop = true;
            sfDataGridRelatorios.AllowFiltering = true;
            sfDataGridRelatorios.AllowResizingColumns = true;
            sfDataGridRelatorios.AllowSelectionOnMouseDown = true;
            sfDataGridRelatorios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sfDataGridRelatorios.BackColor = SystemColors.ControlLight;
            sfDataGridRelatorios.Location = new Point(976, 79);
            sfDataGridRelatorios.Name = "sfDataGridRelatorios";
            sfDataGridRelatorios.Size = new Size(223, 254);
            sfDataGridRelatorios.Style.BorderColor = Color.FromArgb(100, 100, 100);
            sfDataGridRelatorios.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            sfDataGridRelatorios.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGridRelatorios.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            sfDataGridRelatorios.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            sfDataGridRelatorios.TabIndex = 2;
            sfDataGridRelatorios.Text = "sfDataGrid2";
            // 
            // FAgendamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 655);
            Controls.Add(sfDataGridRelatorios);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FAgendamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamentos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sfDataGridAgendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)sfDataGridRelatorios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridAgendas;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridRelatorios;
    }
}
