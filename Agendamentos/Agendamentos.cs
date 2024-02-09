using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agendamentos
{
    public partial class Agendamentos : Form
    {
        public Agendamentos()
        {
            InitializeComponent();

            this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd";
            this.scheduleControl1.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            this.scheduleControl1.BackColor = System.Drawing.Color.Gray;
            this.scheduleControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(6, 3);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.ShowRoundedCorners = true;
            this.scheduleControl1.Size = new System.Drawing.Size(963, 445);
            this.scheduleControl1.TabIndex = 3;

            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colorPickerButton1.BeforeTouchSize = new System.Drawing.Size(84, 25);
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.Location = new System.Drawing.Point(217, 30);
            this.colorPickerButton1.Name = "buttonAdv6";
            this.colorPickerButton1.Size = new System.Drawing.Size(84, 25);
            this.colorPickerButton1.TabIndex = 10;
            this.colorPickerButton1.Text = "Load";
            this.colorPickerButton1.ThemeName = "Metro";
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.Click += new System.EventHandler(this.colorPickerButton1_Click);
        }

        private void colorPickerButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
