namespace Alarm
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.time_label = new System.Windows.Forms.Label();
            this.repeat_lablel = new System.Windows.Forms.Label();
            this.alaram_switch_toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.White;
            this.time_label.Location = new System.Drawing.Point(11, 4);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(105, 30);
            this.time_label.TabIndex = 0;
            this.time_label.Text = "00:00 AM";
            // 
            // repeat_lablel
            // 
            this.repeat_lablel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.repeat_lablel.AutoSize = true;
            this.repeat_lablel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeat_lablel.ForeColor = System.Drawing.Color.White;
            this.repeat_lablel.Location = new System.Drawing.Point(14, 39);
            this.repeat_lablel.Name = "repeat_lablel";
            this.repeat_lablel.Size = new System.Drawing.Size(60, 17);
            this.repeat_lablel.TabIndex = 1;
            this.repeat_lablel.Text = "Everyday";
            // 
            // alaram_switch_toggle
            // 
            this.alaram_switch_toggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alaram_switch_toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alaram_switch_toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alaram_switch_toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.alaram_switch_toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.alaram_switch_toggle.Location = new System.Drawing.Point(363, 10);
            this.alaram_switch_toggle.Name = "alaram_switch_toggle";
            this.alaram_switch_toggle.Size = new System.Drawing.Size(35, 20);
            this.alaram_switch_toggle.TabIndex = 2;
            this.alaram_switch_toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.alaram_switch_toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.alaram_switch_toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.alaram_switch_toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.alaram_switch_toggle.Click += new System.EventHandler(this.alaram_switch_toggle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repeat_lablel);
            this.Controls.Add(this.alaram_switch_toggle);
            this.Controls.Add(this.time_label);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(413, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label time_label;
        public System.Windows.Forms.Label repeat_lablel;
        public Guna.UI2.WinForms.Guna2ToggleSwitch alaram_switch_toggle;
        public System.Windows.Forms.Label label1;
    }
}
