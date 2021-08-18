
namespace WindowsForms_PictureViewer
{
    partial class Form_pictureViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pictureViewer));
            this.TableLayoutPanel_pictureViewer = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox_main = new System.Windows.Forms.PictureBox();
            this.CheckBox_stretch = new System.Windows.Forms.CheckBox();
            this.FlowLayoutPanel_controls = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_showPicture = new System.Windows.Forms.Button();
            this.Button_clearPicture = new System.Windows.Forms.Button();
            this.Button_setBackgroundColor = new System.Windows.Forms.Button();
            this.Button_close = new System.Windows.Forms.Button();
            this.OpenFileDialog_selectPicture = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialogue_background = new System.Windows.Forms.ColorDialog();
            this.TableLayoutPanel_pictureViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_main)).BeginInit();
            this.FlowLayoutPanel_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_pictureViewer
            // 
            this.TableLayoutPanel_pictureViewer.ColumnCount = 2;
            this.TableLayoutPanel_pictureViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TableLayoutPanel_pictureViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.TableLayoutPanel_pictureViewer.Controls.Add(this.PictureBox_main, 0, 0);
            this.TableLayoutPanel_pictureViewer.Controls.Add(this.CheckBox_stretch, 0, 1);
            this.TableLayoutPanel_pictureViewer.Controls.Add(this.FlowLayoutPanel_controls, 1, 1);
            this.TableLayoutPanel_pictureViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_pictureViewer.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_pictureViewer.Name = "TableLayoutPanel_pictureViewer";
            this.TableLayoutPanel_pictureViewer.RowCount = 2;
            this.TableLayoutPanel_pictureViewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.TableLayoutPanel_pictureViewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_pictureViewer.Size = new System.Drawing.Size(534, 311);
            this.TableLayoutPanel_pictureViewer.TabIndex = 0;
            // 
            // PictureBox_main
            // 
            this.PictureBox_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableLayoutPanel_pictureViewer.SetColumnSpan(this.PictureBox_main, 2);
            this.PictureBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_main.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_main.Name = "PictureBox_main";
            this.PictureBox_main.Size = new System.Drawing.Size(528, 273);
            this.PictureBox_main.TabIndex = 0;
            this.PictureBox_main.TabStop = false;
            // 
            // CheckBox_stretch
            // 
            this.CheckBox_stretch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_stretch.AutoSize = true;
            this.CheckBox_stretch.Location = new System.Drawing.Point(17, 282);
            this.CheckBox_stretch.Name = "CheckBox_stretch";
            this.CheckBox_stretch.Size = new System.Drawing.Size(60, 26);
            this.CheckBox_stretch.TabIndex = 1;
            this.CheckBox_stretch.Text = "Stretch";
            this.CheckBox_stretch.UseVisualStyleBackColor = true;
            this.CheckBox_stretch.CheckedChanged += new System.EventHandler(this.CheckBox_stretch_CheckedChanged);
            // 
            // FlowLayoutPanel_controls
            // 
            this.FlowLayoutPanel_controls.Controls.Add(this.Button_showPicture);
            this.FlowLayoutPanel_controls.Controls.Add(this.Button_clearPicture);
            this.FlowLayoutPanel_controls.Controls.Add(this.Button_setBackgroundColor);
            this.FlowLayoutPanel_controls.Controls.Add(this.Button_close);
            this.FlowLayoutPanel_controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_controls.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlowLayoutPanel_controls.Location = new System.Drawing.Point(83, 282);
            this.FlowLayoutPanel_controls.Name = "FlowLayoutPanel_controls";
            this.FlowLayoutPanel_controls.Size = new System.Drawing.Size(448, 26);
            this.FlowLayoutPanel_controls.TabIndex = 2;
            // 
            // Button_showPicture
            // 
            this.Button_showPicture.AutoSize = true;
            this.Button_showPicture.Location = new System.Drawing.Point(357, 3);
            this.Button_showPicture.Name = "Button_showPicture";
            this.Button_showPicture.Size = new System.Drawing.Size(88, 23);
            this.Button_showPicture.TabIndex = 0;
            this.Button_showPicture.Text = "Show a picture";
            this.Button_showPicture.UseVisualStyleBackColor = true;
            this.Button_showPicture.Click += new System.EventHandler(this.Button_showPicture_Click);
            // 
            // Button_clearPicture
            // 
            this.Button_clearPicture.AutoSize = true;
            this.Button_clearPicture.Location = new System.Drawing.Point(257, 3);
            this.Button_clearPicture.Name = "Button_clearPicture";
            this.Button_clearPicture.Size = new System.Drawing.Size(94, 23);
            this.Button_clearPicture.TabIndex = 1;
            this.Button_clearPicture.Text = "Clear the picture";
            this.Button_clearPicture.UseVisualStyleBackColor = true;
            this.Button_clearPicture.Click += new System.EventHandler(this.Button_clearPicture_Click);
            // 
            // Button_setBackgroundColor
            // 
            this.Button_setBackgroundColor.AutoSize = true;
            this.Button_setBackgroundColor.Location = new System.Drawing.Point(114, 3);
            this.Button_setBackgroundColor.Name = "Button_setBackgroundColor";
            this.Button_setBackgroundColor.Size = new System.Drawing.Size(137, 23);
            this.Button_setBackgroundColor.TabIndex = 2;
            this.Button_setBackgroundColor.Text = "Set the background color";
            this.Button_setBackgroundColor.UseVisualStyleBackColor = true;
            this.Button_setBackgroundColor.Click += new System.EventHandler(this.Button_setBackgroundColor_Click);
            // 
            // Button_close
            // 
            this.Button_close.AutoSize = true;
            this.Button_close.Location = new System.Drawing.Point(33, 3);
            this.Button_close.Name = "Button_close";
            this.Button_close.Size = new System.Drawing.Size(75, 23);
            this.Button_close.TabIndex = 3;
            this.Button_close.Text = "Close";
            this.Button_close.UseVisualStyleBackColor = true;
            this.Button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // OpenFileDialog_selectPicture
            // 
            this.OpenFileDialog_selectPicture.FileName = "selectedPicture";
            this.OpenFileDialog_selectPicture.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.OpenFileDialog_selectPicture.Title = "Select a picture file";
            // 
            // Form_pictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.ControlBox = false;
            this.Controls.Add(this.TableLayoutPanel_pictureViewer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_pictureViewer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Picture Viewer";
            this.Load += new System.EventHandler(this.Form_pictureViewer_Load);
            this.TableLayoutPanel_pictureViewer.ResumeLayout(false);
            this.TableLayoutPanel_pictureViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_main)).EndInit();
            this.FlowLayoutPanel_controls.ResumeLayout(false);
            this.FlowLayoutPanel_controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_pictureViewer;
        private System.Windows.Forms.PictureBox PictureBox_main;
        private System.Windows.Forms.CheckBox CheckBox_stretch;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_controls;
        private System.Windows.Forms.Button Button_showPicture;
        private System.Windows.Forms.Button Button_clearPicture;
        private System.Windows.Forms.Button Button_setBackgroundColor;
        private System.Windows.Forms.Button Button_close;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_selectPicture;
        private System.Windows.Forms.ColorDialog ColorDialogue_background;
    }
}

