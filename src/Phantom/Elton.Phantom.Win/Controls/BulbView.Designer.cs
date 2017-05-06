namespace Elton.Phantom.Win.Controls
{
    partial class BulbView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.labelBulb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTitle.Location = new System.Drawing.Point(0, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 21);
            this.labelTitle.TabIndex = 71;
            this.labelTitle.Text = "灯泡(100%)";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.Image = global::Elton.Phantom.Win.Properties.Resources.more_10;
            this.btnMore.Location = new System.Drawing.Point(63, 4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(21, 21);
            this.btnMore.TabIndex = 72;
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // labelBulb
            // 
            this.labelBulb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBulb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBulb.Image = global::Elton.Phantom.Win.Properties.Resources.bulb_off_48;
            this.labelBulb.Location = new System.Drawing.Point(18, 2);
            this.labelBulb.Name = "labelBulb";
            this.labelBulb.Size = new System.Drawing.Size(48, 48);
            this.labelBulb.TabIndex = 70;
            // 
            // BulbView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBulb);
            this.MaximumSize = new System.Drawing.Size(90, 76);
            this.MinimumSize = new System.Drawing.Size(90, 76);
            this.Name = "BulbView";
            this.Size = new System.Drawing.Size(88, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBulb;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnMore;
    }
}
