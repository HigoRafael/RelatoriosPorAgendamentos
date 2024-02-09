namespace Agendamentos
{
    partial class Agendamentos
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
            components = new System.ComponentModel.Container();
            scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            SuspendLayout();
            // 
            // scheduleControl1
            // 
            scheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd";
            scheduleControl1.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            scheduleControl1.BackColor = Color.FromArgb(192, 201, 219);
            scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            scheduleControl1.DataSource = null;
            scheduleControl1.ISO8601CalenderFormat = false;
            scheduleControl1.Location = new Point(235, 262);
            scheduleControl1.Name = "scheduleControl1";
            scheduleControl1.Size = new Size(671, 381);
            scheduleControl1.TabIndex = 0;
            // 
            // colorPickerButton1
            // 
            colorPickerButton1.Location = new Point(57, 34);
            colorPickerButton1.Name = "colorPickerButton1";
            colorPickerButton1.Size = new Size(75, 23);
            colorPickerButton1.TabIndex = 1;
            colorPickerButton1.Text = "colorPickerButton1";
            colorPickerButton1.Click += colorPickerButton1_Click;
            // 
            // Agendamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 645);
            Controls.Add(colorPickerButton1);
            Controls.Add(scheduleControl1);
            Name = "Agendamentos";
            Text = "Agendamentos";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
    }
}