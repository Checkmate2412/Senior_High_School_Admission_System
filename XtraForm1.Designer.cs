namespace Research
{
    partial class XtraForm1
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
            this.GSpanel = new DevExpress.XtraEditors.PanelControl();
            this.PBControl = new DevExpress.XtraLayout.LayoutControl();
            this.StrandInfo = new DevExpress.XtraEditors.LabelControl();
            this.Gradetxt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Strandtxt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PBlayout = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PBlayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GSpanel)).BeginInit();
            this.GSpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBControl)).BeginInit();
            this.PBControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gradetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strandtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBlayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBlayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // GSpanel
            // 
            this.GSpanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.GSpanel.Appearance.Options.UseBackColor = true;
            this.GSpanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GSpanel.Controls.Add(this.PBControl);
            this.GSpanel.Location = new System.Drawing.Point(94, 87);
            this.GSpanel.Name = "GSpanel";
            this.GSpanel.Size = new System.Drawing.Size(1160, 412);
            this.GSpanel.TabIndex = 45;
            // 
            // PBControl
            // 
            this.PBControl.Controls.Add(this.StrandInfo);
            this.PBControl.Controls.Add(this.Gradetxt);
            this.PBControl.Controls.Add(this.Strandtxt);
            this.PBControl.Location = new System.Drawing.Point(3, 3);
            this.PBControl.Name = "PBControl";
            this.PBControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(206, 120, 450, 400);
            this.PBControl.Root = this.PBlayout;
            this.PBControl.Size = new System.Drawing.Size(1160, 412);
            this.PBControl.TabIndex = 0;
            this.PBControl.Text = "layoutControl2";
            // 
            // StrandInfo
            // 
            this.StrandInfo.Appearance.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrandInfo.Appearance.ForeColor = System.Drawing.Color.White;
            this.StrandInfo.Appearance.Options.UseFont = true;
            this.StrandInfo.Appearance.Options.UseForeColor = true;
            this.StrandInfo.Appearance.Options.UseTextOptions = true;
            this.StrandInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.StrandInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.StrandInfo.Location = new System.Drawing.Point(12, 88);
            this.StrandInfo.Name = "StrandInfo";
            this.StrandInfo.Size = new System.Drawing.Size(1136, 312);
            this.StrandInfo.StyleController = this.PBControl;
            this.StrandInfo.TabIndex = 45;
            this.StrandInfo.Text = "                      ";
            // 
            // Gradetxt
            // 
            this.Gradetxt.Location = new System.Drawing.Point(12, 41);
            this.Gradetxt.Name = "Gradetxt";
            this.Gradetxt.Properties.Appearance.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.Gradetxt.Properties.Appearance.Options.UseFont = true;
            this.Gradetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Gradetxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Gradetxt.Properties.Items.AddRange(new object[] {
            "Grade 11",
            "Grade 12"});
            this.Gradetxt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Gradetxt.Size = new System.Drawing.Size(181, 32);
            this.Gradetxt.StyleController = this.PBControl;
            this.Gradetxt.TabIndex = 0;
            // 
            // Strandtxt
            // 
            this.Strandtxt.Location = new System.Drawing.Point(197, 41);
            this.Strandtxt.Name = "Strandtxt";
            this.Strandtxt.Properties.Appearance.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.Strandtxt.Properties.Appearance.Options.UseFont = true;
            this.Strandtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.Strandtxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Strandtxt.Properties.DropDownRows = 8;
            this.Strandtxt.Properties.Items.AddRange(new object[] {
            "General Academic Strand (GAS)",
            "Accountancy, Business and Management (ABM)",
            "Science, Technology, Engineering, and Mathematics (STEM)",
            "Home Economics (HE)",
            "Humanities and Social Sciences (HUMSS)",
            "Information and Communications Technology (ICT)",
            "Pre-Baccalaureate Maritime Specialization",
            "TVL Maritime Specialization"});
            this.Strandtxt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.Strandtxt.Size = new System.Drawing.Size(951, 32);
            this.Strandtxt.StyleController = this.PBControl;
            this.Strandtxt.TabIndex = 5;
            this.Strandtxt.EditValueChanged += new System.EventHandler(this.textEdit10_EditValueChanged);
            // 
            // PBlayout
            // 
            this.PBlayout.BackgroundImage = global::Research.Properties.Resources.Untitled_1;
            this.PBlayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.PBlayout.BackgroundImageVisible = true;
            this.PBlayout.CustomizationFormText = "Root";
            this.PBlayout.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.PBlayout.GroupBordersVisible = false;
            this.PBlayout.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PBlayoutControl,
            this.layoutControlItem10,
            this.layoutControlItem1});
            this.PBlayout.Location = new System.Drawing.Point(0, 0);
            this.PBlayout.Name = "Root";
            this.PBlayout.Size = new System.Drawing.Size(1160, 412);
            this.PBlayout.TextVisible = false;
            this.PBlayout.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime;
            // 
            // PBlayoutControl
            // 
            this.PBlayoutControl.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.PBlayoutControl.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkOrange;
            this.PBlayoutControl.AppearanceItemCaption.Options.UseFont = true;
            this.PBlayoutControl.AppearanceItemCaption.Options.UseForeColor = true;
            this.PBlayoutControl.Control = this.Gradetxt;
            this.PBlayoutControl.CustomizationFormText = "Address line 1:";
            this.PBlayoutControl.Location = new System.Drawing.Point(0, 0);
            this.PBlayoutControl.MinSize = new System.Drawing.Size(50, 25);
            this.PBlayoutControl.Name = "PBlayoutControl";
            this.PBlayoutControl.Size = new System.Drawing.Size(185, 76);
            this.PBlayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.PBlayoutControl.Text = "Grade:";
            this.PBlayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.PBlayoutControl.TextSize = new System.Drawing.Size(62, 26);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.layoutControlItem10.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkOrange;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem10.Control = this.Strandtxt;
            this.layoutControlItem10.CustomizationFormText = "Address line 1:";
            this.layoutControlItem10.Location = new System.Drawing.Point(185, 0);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(66, 65);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(955, 76);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.Text = "Strand:";
            this.layoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(62, 26);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.layoutControlItem1.Control = this.StrandInfo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(50, 30);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.layoutControlItem1.Size = new System.Drawing.Size(1140, 316);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 586);
            this.Controls.Add(this.GSpanel);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GSpanel)).EndInit();
            this.GSpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBControl)).EndInit();
            this.PBControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gradetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strandtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBlayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBlayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl GSpanel;
        private DevExpress.XtraLayout.LayoutControl PBControl;
        private DevExpress.XtraLayout.LayoutControlGroup PBlayout;
        private DevExpress.XtraLayout.LayoutControlItem PBlayoutControl;
        private DevExpress.XtraEditors.ComboBoxEdit Gradetxt;
        private DevExpress.XtraEditors.ComboBoxEdit Strandtxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LabelControl StrandInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;

    }
}