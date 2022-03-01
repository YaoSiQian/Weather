namespace Weather
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.comboBoxProvince = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxCity = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.buttonCustom = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.buttonWCN = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVerson = new System.Windows.Forms.ToolStripStatusLabel();
            this.weatherDayMore8 = new Weather.WeatherDayMore();
            this.weatherDayMore7 = new Weather.WeatherDayMore();
            this.weatherDayMore6 = new Weather.WeatherDayMore();
            this.weatherDayMore5 = new Weather.WeatherDayMore();
            this.weatherDayMore4 = new Weather.WeatherDayMore();
            this.weatherDayMore3 = new Weather.WeatherDayMore();
            this.weatherDayMore2 = new Weather.WeatherDayMore();
            this.weatherDayMore1 = new Weather.WeatherDayMore();
            this.weatherDay7 = new Weather.WeatherDay();
            this.weatherDay6 = new Weather.WeatherDay();
            this.weatherDay5 = new Weather.WeatherDay();
            this.weatherDay4 = new Weather.WeatherDay();
            this.weatherDay3 = new Weather.WeatherDay();
            this.weatherDay2 = new Weather.WeatherDay();
            this.weatherDay1 = new Weather.WeatherDay();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxProvince,
            this.comboBoxCity,
            this.comboBoxDistrict,
            this.buttonSearch,
            this.buttonCustom,
            this.buttonAbout,
            this.buttonWCN});
            this.toolStrip.Name = "toolStrip";
            // 
            // comboBoxProvince
            // 
            resources.ApplyResources(this.comboBoxProvince, "comboBoxProvince");
            this.comboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvince.Margin = new System.Windows.Forms.Padding(5, 3, 1, 0);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProvince_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            resources.ApplyResources(this.comboBoxCity, "comboBoxCity");
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxDistrict
            // 
            resources.ApplyResources(this.comboBoxDistrict, "comboBoxDistrict");
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Margin = new System.Windows.Forms.Padding(1, 3, 1, 0);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            // 
            // buttonSearch
            // 
            resources.ApplyResources(this.buttonSearch, "buttonSearch");
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCustom
            // 
            resources.ApplyResources(this.buttonCustom, "buttonCustom");
            this.buttonCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonCustom.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.buttonCustom.Name = "buttonCustom";
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.buttonAbout.Name = "buttonAbout";
            // 
            // buttonWCN
            // 
            resources.ApplyResources(this.buttonWCN, "buttonWCN");
            this.buttonWCN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonWCN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonWCN.Name = "buttonWCN";
            this.buttonWCN.Click += new System.EventHandler(this.buttonWCN_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblVerson});
            this.statusStrip.Name = "statusStrip";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Spring = true;
            // 
            // lblVerson
            // 
            resources.ApplyResources(this.lblVerson, "lblVerson");
            this.lblVerson.Name = "lblVerson";
            // 
            // weatherDayMore8
            // 
            resources.ApplyResources(this.weatherDayMore8, "weatherDayMore8");
            this.weatherDayMore8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore8.Day = null;
            this.weatherDayMore8.Info = null;
            this.weatherDayMore8.Name = "weatherDayMore8";
            this.weatherDayMore8.Temperature = null;
            this.weatherDayMore8.Wind1 = null;
            this.weatherDayMore8.Wind2 = null;
            // 
            // weatherDayMore7
            // 
            resources.ApplyResources(this.weatherDayMore7, "weatherDayMore7");
            this.weatherDayMore7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore7.Day = null;
            this.weatherDayMore7.Info = null;
            this.weatherDayMore7.Name = "weatherDayMore7";
            this.weatherDayMore7.Temperature = null;
            this.weatherDayMore7.Wind1 = null;
            this.weatherDayMore7.Wind2 = null;
            // 
            // weatherDayMore6
            // 
            resources.ApplyResources(this.weatherDayMore6, "weatherDayMore6");
            this.weatherDayMore6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore6.Day = null;
            this.weatherDayMore6.Info = null;
            this.weatherDayMore6.Name = "weatherDayMore6";
            this.weatherDayMore6.Temperature = null;
            this.weatherDayMore6.Wind1 = null;
            this.weatherDayMore6.Wind2 = null;
            // 
            // weatherDayMore5
            // 
            resources.ApplyResources(this.weatherDayMore5, "weatherDayMore5");
            this.weatherDayMore5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore5.Day = null;
            this.weatherDayMore5.Info = null;
            this.weatherDayMore5.Name = "weatherDayMore5";
            this.weatherDayMore5.Temperature = null;
            this.weatherDayMore5.Wind1 = null;
            this.weatherDayMore5.Wind2 = null;
            // 
            // weatherDayMore4
            // 
            resources.ApplyResources(this.weatherDayMore4, "weatherDayMore4");
            this.weatherDayMore4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore4.Day = null;
            this.weatherDayMore4.Info = null;
            this.weatherDayMore4.Name = "weatherDayMore4";
            this.weatherDayMore4.Temperature = null;
            this.weatherDayMore4.Wind1 = null;
            this.weatherDayMore4.Wind2 = null;
            // 
            // weatherDayMore3
            // 
            resources.ApplyResources(this.weatherDayMore3, "weatherDayMore3");
            this.weatherDayMore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore3.Day = null;
            this.weatherDayMore3.Info = null;
            this.weatherDayMore3.Name = "weatherDayMore3";
            this.weatherDayMore3.Temperature = null;
            this.weatherDayMore3.Wind1 = null;
            this.weatherDayMore3.Wind2 = null;
            // 
            // weatherDayMore2
            // 
            resources.ApplyResources(this.weatherDayMore2, "weatherDayMore2");
            this.weatherDayMore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore2.Day = null;
            this.weatherDayMore2.Info = null;
            this.weatherDayMore2.Name = "weatherDayMore2";
            this.weatherDayMore2.Temperature = null;
            this.weatherDayMore2.Wind1 = null;
            this.weatherDayMore2.Wind2 = null;
            // 
            // weatherDayMore1
            // 
            resources.ApplyResources(this.weatherDayMore1, "weatherDayMore1");
            this.weatherDayMore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDayMore1.Day = null;
            this.weatherDayMore1.Info = null;
            this.weatherDayMore1.Name = "weatherDayMore1";
            this.weatherDayMore1.Temperature = null;
            this.weatherDayMore1.Wind1 = null;
            this.weatherDayMore1.Wind2 = null;
            // 
            // weatherDay7
            // 
            resources.ApplyResources(this.weatherDay7, "weatherDay7");
            this.weatherDay7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay7.Day = null;
            this.weatherDay7.Info = null;
            this.weatherDay7.Name = "weatherDay7";
            this.weatherDay7.Temperature = null;
            this.weatherDay7.Wind = null;
            // 
            // weatherDay6
            // 
            resources.ApplyResources(this.weatherDay6, "weatherDay6");
            this.weatherDay6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay6.Day = null;
            this.weatherDay6.Info = null;
            this.weatherDay6.Name = "weatherDay6";
            this.weatherDay6.Temperature = null;
            this.weatherDay6.Wind = null;
            // 
            // weatherDay5
            // 
            resources.ApplyResources(this.weatherDay5, "weatherDay5");
            this.weatherDay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay5.Day = null;
            this.weatherDay5.Info = null;
            this.weatherDay5.Name = "weatherDay5";
            this.weatherDay5.Temperature = null;
            this.weatherDay5.Wind = null;
            // 
            // weatherDay4
            // 
            resources.ApplyResources(this.weatherDay4, "weatherDay4");
            this.weatherDay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay4.Day = null;
            this.weatherDay4.Info = null;
            this.weatherDay4.Name = "weatherDay4";
            this.weatherDay4.Temperature = null;
            this.weatherDay4.Wind = null;
            // 
            // weatherDay3
            // 
            resources.ApplyResources(this.weatherDay3, "weatherDay3");
            this.weatherDay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay3.Day = null;
            this.weatherDay3.Info = null;
            this.weatherDay3.Name = "weatherDay3";
            this.weatherDay3.Temperature = null;
            this.weatherDay3.Wind = null;
            // 
            // weatherDay2
            // 
            resources.ApplyResources(this.weatherDay2, "weatherDay2");
            this.weatherDay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay2.Day = null;
            this.weatherDay2.Info = null;
            this.weatherDay2.Name = "weatherDay2";
            this.weatherDay2.Temperature = null;
            this.weatherDay2.Wind = null;
            // 
            // weatherDay1
            // 
            resources.ApplyResources(this.weatherDay1, "weatherDay1");
            this.weatherDay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weatherDay1.Day = null;
            this.weatherDay1.Info = null;
            this.weatherDay1.Name = "weatherDay1";
            this.weatherDay1.Temperature = "";
            this.weatherDay1.Wind = null;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.weatherDayMore8);
            this.Controls.Add(this.weatherDayMore7);
            this.Controls.Add(this.weatherDayMore6);
            this.Controls.Add(this.weatherDayMore5);
            this.Controls.Add(this.weatherDayMore4);
            this.Controls.Add(this.weatherDayMore3);
            this.Controls.Add(this.weatherDayMore2);
            this.Controls.Add(this.weatherDayMore1);
            this.Controls.Add(this.weatherDay7);
            this.Controls.Add(this.weatherDay6);
            this.Controls.Add(this.weatherDay5);
            this.Controls.Add(this.weatherDay4);
            this.Controls.Add(this.weatherDay3);
            this.Controls.Add(this.weatherDay2);
            this.Controls.Add(this.weatherDay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeatherDay weatherDay1;
        private WeatherDay weatherDay2;
        private WeatherDay weatherDay3;
        private WeatherDay weatherDay4;
        private WeatherDay weatherDay5;
        private WeatherDay weatherDay6;
        private WeatherDay weatherDay7;
        private WeatherDayMore weatherDayMore1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton buttonCustom;
        private WeatherDayMore weatherDayMore2;
        private WeatherDayMore weatherDayMore3;
        private WeatherDayMore weatherDayMore4;
        private WeatherDayMore weatherDayMore5;
        private WeatherDayMore weatherDayMore6;
        private WeatherDayMore weatherDayMore7;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblVerson;
        private System.Windows.Forms.ToolStripComboBox comboBoxProvince;
        private System.Windows.Forms.ToolStripComboBox comboBoxCity;
        private System.Windows.Forms.ToolStripComboBox comboBoxDistrict;
        private System.Windows.Forms.ToolStripButton buttonSearch;
        private WeatherDayMore weatherDayMore8;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private System.Windows.Forms.ToolStripButton buttonWCN;
    }
}

