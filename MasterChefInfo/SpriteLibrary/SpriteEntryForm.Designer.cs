namespace SpriteLibrary
{
    partial class SpriteEntryForm
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
            this.pbImageField = new System.Windows.Forms.PictureBox();
            this.cbStartingImage = new System.Windows.Forms.ComboBox();
            this.lblStartingImage = new System.Windows.Forms.Label();
            this.lblChosenArea = new System.Windows.Forms.Label();
            this.tbNumFrames = new System.Windows.Forms.TextBox();
            this.lblFrames = new System.Windows.Forms.Label();
            this.tbSpriteName = new System.Windows.Forms.TextBox();
            this.lblSpriteName = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnNewSprite = new System.Windows.Forms.Button();
            this.tbAmimationSpeed = new System.Windows.Forms.TextBox();
            this.lblAnimationSpeed = new System.Windows.Forms.Label();
            this.lblDefaultSize = new System.Windows.Forms.Label();
            this.tbDefaultSize = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.lblCountSprites = new System.Windows.Forms.Label();
            this.TCTabPages = new System.Windows.Forms.TabControl();
            this.tpFromImage = new System.Windows.Forms.TabPage();
            this.tpMirrorRotate = new System.Windows.Forms.TabPage();
            this.cbMirrorH = new System.Windows.Forms.CheckBox();
            this.cbMirrorV = new System.Windows.Forms.CheckBox();
            this.lblRotationDegrees = new System.Windows.Forms.Label();
            this.tbRotation = new System.Windows.Forms.TextBox();
            this.lblWhichAnim = new System.Windows.Forms.Label();
            this.cbAnimation = new System.Windows.Forms.ComboBox();
            this.lblAnimationNumber = new System.Windows.Forms.Label();
            this.lblAnimationFwdBack = new System.Windows.Forms.Label();
            this.btnAnimBack = new System.Windows.Forms.Button();
            this.btnAnimFwd = new System.Windows.Forms.Button();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.rbMirror = new System.Windows.Forms.RadioButton();
            this.rbRotation = new System.Windows.Forms.RadioButton();
            this.rbFromImage = new System.Windows.Forms.RadioButton();
            this.btnNewAnimation = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPreviewAnimFwd = new System.Windows.Forms.Button();
            this.btnPreviewAnimBack = new System.Windows.Forms.Button();
            this.pnlAnimationFWBK = new System.Windows.Forms.Panel();
            this.btnDeleteAnim = new System.Windows.Forms.Button();
            this.btnDelSprite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageField)).BeginInit();
            this.TCTabPages.SuspendLayout();
            this.tpFromImage.SuspendLayout();
            this.tpMirrorRotate.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.pnlAnimationFWBK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImageField
            // 
            this.pbImageField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImageField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImageField.Location = new System.Drawing.Point(4, 8);
            this.pbImageField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImageField.Name = "pbImageField";
            this.pbImageField.Size = new System.Drawing.Size(160, 249);
            this.pbImageField.TabIndex = 0;
            this.pbImageField.TabStop = false;
            this.pbImageField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImageField_MouseDown);
            this.pbImageField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImageField_MouseMove);
            this.pbImageField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImageField_MouseUp);
            // 
            // cbStartingImage
            // 
            this.cbStartingImage.FormattingEnabled = true;
            this.cbStartingImage.Location = new System.Drawing.Point(96, 5);
            this.cbStartingImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStartingImage.Name = "cbStartingImage";
            this.cbStartingImage.Size = new System.Drawing.Size(99, 21);
            this.cbStartingImage.TabIndex = 5;
            this.cbStartingImage.SelectedIndexChanged += new System.EventHandler(this.cbStartingImage_SelectedIndexChanged);
            // 
            // lblStartingImage
            // 
            this.lblStartingImage.AutoSize = true;
            this.lblStartingImage.Location = new System.Drawing.Point(17, 7);
            this.lblStartingImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartingImage.Name = "lblStartingImage";
            this.lblStartingImage.Size = new System.Drawing.Size(75, 13);
            this.lblStartingImage.TabIndex = 2;
            this.lblStartingImage.Text = "Starting Image";
            // 
            // lblChosenArea
            // 
            this.lblChosenArea.AutoSize = true;
            this.lblChosenArea.Location = new System.Drawing.Point(94, 27);
            this.lblChosenArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChosenArea.Name = "lblChosenArea";
            this.lblChosenArea.Size = new System.Drawing.Size(65, 13);
            this.lblChosenArea.TabIndex = 3;
            this.lblChosenArea.Text = "ChosenArea";
            // 
            // tbNumFrames
            // 
            this.tbNumFrames.Location = new System.Drawing.Point(96, 43);
            this.tbNumFrames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumFrames.Name = "tbNumFrames";
            this.tbNumFrames.Size = new System.Drawing.Size(36, 20);
            this.tbNumFrames.TabIndex = 6;
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Location = new System.Drawing.Point(52, 43);
            this.lblFrames.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(41, 13);
            this.lblFrames.TabIndex = 5;
            this.lblFrames.Text = "Frames";
            // 
            // tbSpriteName
            // 
            this.tbSpriteName.Location = new System.Drawing.Point(267, 8);
            this.tbSpriteName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSpriteName.Name = "tbSpriteName";
            this.tbSpriteName.Size = new System.Drawing.Size(76, 20);
            this.tbSpriteName.TabIndex = 1;
            // 
            // lblSpriteName
            // 
            this.lblSpriteName.AutoSize = true;
            this.lblSpriteName.Location = new System.Drawing.Point(194, 11);
            this.lblSpriteName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpriteName.Name = "lblSpriteName";
            this.lblSpriteName.Size = new System.Drawing.Size(65, 13);
            this.lblSpriteName.TabIndex = 7;
            this.lblSpriteName.Text = "Sprite Name";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(396, 254);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(56, 19);
            this.btnDone.TabIndex = 23;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(335, 254);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(189, 254);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(56, 19);
            this.btnApply.TabIndex = 20;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnNewSprite
            // 
            this.btnNewSprite.Location = new System.Drawing.Point(189, 228);
            this.btnNewSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewSprite.Name = "btnNewSprite";
            this.btnNewSprite.Size = new System.Drawing.Size(69, 19);
            this.btnNewSprite.TabIndex = 18;
            this.btnNewSprite.Text = "New Sprite";
            this.btnNewSprite.UseVisualStyleBackColor = true;
            this.btnNewSprite.Click += new System.EventHandler(this.btnNewSprite_Click);
            // 
            // tbAmimationSpeed
            // 
            this.tbAmimationSpeed.Location = new System.Drawing.Point(267, 176);
            this.tbAmimationSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAmimationSpeed.Name = "tbAmimationSpeed";
            this.tbAmimationSpeed.Size = new System.Drawing.Size(76, 20);
            this.tbAmimationSpeed.TabIndex = 11;
            // 
            // lblAnimationSpeed
            // 
            this.lblAnimationSpeed.AutoSize = true;
            this.lblAnimationSpeed.Location = new System.Drawing.Point(176, 179);
            this.lblAnimationSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimationSpeed.Name = "lblAnimationSpeed";
            this.lblAnimationSpeed.Size = new System.Drawing.Size(87, 13);
            this.lblAnimationSpeed.TabIndex = 13;
            this.lblAnimationSpeed.Text = "Animation Speed";
            // 
            // lblDefaultSize
            // 
            this.lblDefaultSize.AutoSize = true;
            this.lblDefaultSize.Location = new System.Drawing.Point(201, 202);
            this.lblDefaultSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefaultSize.Name = "lblDefaultSize";
            this.lblDefaultSize.Size = new System.Drawing.Size(64, 13);
            this.lblDefaultSize.TabIndex = 14;
            this.lblDefaultSize.Text = "Default Size";
            // 
            // tbDefaultSize
            // 
            this.tbDefaultSize.Location = new System.Drawing.Point(267, 200);
            this.tbDefaultSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDefaultSize.Name = "tbDefaultSize";
            this.tbDefaultSize.Size = new System.Drawing.Size(76, 20);
            this.tbDefaultSize.TabIndex = 12;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(9, 262);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 19);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFwd.Location = new System.Drawing.Point(133, 262);
            this.btnFwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(24, 19);
            this.btnFwd.TabIndex = 25;
            this.btnFwd.Text = ">";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // lblCountSprites
            // 
            this.lblCountSprites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountSprites.AutoSize = true;
            this.lblCountSprites.Location = new System.Drawing.Point(56, 264);
            this.lblCountSprites.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountSprites.Name = "lblCountSprites";
            this.lblCountSprites.Size = new System.Drawing.Size(13, 13);
            this.lblCountSprites.TabIndex = 18;
            this.lblCountSprites.Text = "0";
            // 
            // TCTabPages
            // 
            this.TCTabPages.Controls.Add(this.tpFromImage);
            this.TCTabPages.Controls.Add(this.tpMirrorRotate);
            this.TCTabPages.Location = new System.Drawing.Point(168, 55);
            this.TCTabPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TCTabPages.Name = "TCTabPages";
            this.TCTabPages.SelectedIndex = 0;
            this.TCTabPages.Size = new System.Drawing.Size(212, 116);
            this.TCTabPages.TabIndex = 5;
            // 
            // tpFromImage
            // 
            this.tpFromImage.Controls.Add(this.cbStartingImage);
            this.tpFromImage.Controls.Add(this.lblStartingImage);
            this.tpFromImage.Controls.Add(this.lblChosenArea);
            this.tpFromImage.Controls.Add(this.tbNumFrames);
            this.tpFromImage.Controls.Add(this.lblFrames);
            this.tpFromImage.Location = new System.Drawing.Point(4, 22);
            this.tpFromImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFromImage.Name = "tpFromImage";
            this.tpFromImage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpFromImage.Size = new System.Drawing.Size(204, 90);
            this.tpFromImage.TabIndex = 0;
            this.tpFromImage.Text = "From Image";
            this.tpFromImage.UseVisualStyleBackColor = true;
            // 
            // tpMirrorRotate
            // 
            this.tpMirrorRotate.Controls.Add(this.cbMirrorH);
            this.tpMirrorRotate.Controls.Add(this.cbMirrorV);
            this.tpMirrorRotate.Controls.Add(this.lblRotationDegrees);
            this.tpMirrorRotate.Controls.Add(this.tbRotation);
            this.tpMirrorRotate.Controls.Add(this.lblWhichAnim);
            this.tpMirrorRotate.Controls.Add(this.cbAnimation);
            this.tpMirrorRotate.Location = new System.Drawing.Point(4, 22);
            this.tpMirrorRotate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMirrorRotate.Name = "tpMirrorRotate";
            this.tpMirrorRotate.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMirrorRotate.Size = new System.Drawing.Size(204, 90);
            this.tpMirrorRotate.TabIndex = 1;
            this.tpMirrorRotate.Text = "Mirror / Rotation";
            this.tpMirrorRotate.UseVisualStyleBackColor = true;
            // 
            // cbMirrorH
            // 
            this.cbMirrorH.AutoSize = true;
            this.cbMirrorH.Location = new System.Drawing.Point(26, 71);
            this.cbMirrorH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMirrorH.Name = "cbMirrorH";
            this.cbMirrorH.Size = new System.Drawing.Size(63, 17);
            this.cbMirrorH.TabIndex = 9;
            this.cbMirrorH.Text = "Mirror H";
            this.cbMirrorH.UseVisualStyleBackColor = true;
            // 
            // cbMirrorV
            // 
            this.cbMirrorV.AutoSize = true;
            this.cbMirrorV.Location = new System.Drawing.Point(111, 71);
            this.cbMirrorV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMirrorV.Name = "cbMirrorV";
            this.cbMirrorV.Size = new System.Drawing.Size(62, 17);
            this.cbMirrorV.TabIndex = 10;
            this.cbMirrorV.Text = "Mirror V";
            this.cbMirrorV.UseVisualStyleBackColor = true;
            // 
            // lblRotationDegrees
            // 
            this.lblRotationDegrees.AutoSize = true;
            this.lblRotationDegrees.Location = new System.Drawing.Point(40, 50);
            this.lblRotationDegrees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotationDegrees.Name = "lblRotationDegrees";
            this.lblRotationDegrees.Size = new System.Drawing.Size(47, 13);
            this.lblRotationDegrees.TabIndex = 3;
            this.lblRotationDegrees.Text = "Degrees";
            // 
            // tbRotation
            // 
            this.tbRotation.Location = new System.Drawing.Point(96, 47);
            this.tbRotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRotation.Name = "tbRotation";
            this.tbRotation.Size = new System.Drawing.Size(76, 20);
            this.tbRotation.TabIndex = 8;
            // 
            // lblWhichAnim
            // 
            this.lblWhichAnim.AutoSize = true;
            this.lblWhichAnim.Location = new System.Drawing.Point(28, 6);
            this.lblWhichAnim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhichAnim.Name = "lblWhichAnim";
            this.lblWhichAnim.Size = new System.Drawing.Size(60, 26);
            this.lblWhichAnim.TabIndex = 1;
            this.lblWhichAnim.Text = "Based Off\r\nAnimation#";
            // 
            // cbAnimation
            // 
            this.cbAnimation.FormattingEnabled = true;
            this.cbAnimation.Location = new System.Drawing.Point(96, 15);
            this.cbAnimation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAnimation.Name = "cbAnimation";
            this.cbAnimation.Size = new System.Drawing.Size(76, 21);
            this.cbAnimation.TabIndex = 7;
            // 
            // lblAnimationNumber
            // 
            this.lblAnimationNumber.AutoSize = true;
            this.lblAnimationNumber.Location = new System.Drawing.Point(32, 20);
            this.lblAnimationNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimationNumber.Name = "lblAnimationNumber";
            this.lblAnimationNumber.Size = new System.Drawing.Size(13, 13);
            this.lblAnimationNumber.TabIndex = 21;
            this.lblAnimationNumber.Text = "0";
            // 
            // lblAnimationFwdBack
            // 
            this.lblAnimationFwdBack.AutoSize = true;
            this.lblAnimationFwdBack.Location = new System.Drawing.Point(4, -3);
            this.lblAnimationFwdBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnimationFwdBack.Name = "lblAnimationFwdBack";
            this.lblAnimationFwdBack.Size = new System.Drawing.Size(56, 13);
            this.lblAnimationFwdBack.TabIndex = 20;
            this.lblAnimationFwdBack.Text = "Animation:";
            // 
            // btnAnimBack
            // 
            this.btnAnimBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnimBack.Location = new System.Drawing.Point(4, 15);
            this.btnAnimBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnimBack.Name = "btnAnimBack";
            this.btnAnimBack.Size = new System.Drawing.Size(24, 19);
            this.btnAnimBack.TabIndex = 16;
            this.btnAnimBack.Text = "<";
            this.btnAnimBack.UseVisualStyleBackColor = true;
            this.btnAnimBack.Click += new System.EventHandler(this.btnAnimBack_Click);
            // 
            // btnAnimFwd
            // 
            this.btnAnimFwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnimFwd.Location = new System.Drawing.Point(72, 15);
            this.btnAnimFwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnimFwd.Name = "btnAnimFwd";
            this.btnAnimFwd.Size = new System.Drawing.Size(24, 19);
            this.btnAnimFwd.TabIndex = 17;
            this.btnAnimFwd.Text = ">";
            this.btnAnimFwd.UseVisualStyleBackColor = true;
            this.btnAnimFwd.Click += new System.EventHandler(this.btnAnimFwd_Click);
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Controls.Add(this.rbMirror);
            this.panelRadioButtons.Controls.Add(this.rbRotation);
            this.panelRadioButtons.Controls.Add(this.rbFromImage);
            this.panelRadioButtons.Location = new System.Drawing.Point(168, 28);
            this.panelRadioButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(208, 22);
            this.panelRadioButtons.TabIndex = 20;
            // 
            // rbMirror
            // 
            this.rbMirror.AutoSize = true;
            this.rbMirror.Location = new System.Drawing.Point(148, 2);
            this.rbMirror.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMirror.Name = "rbMirror";
            this.rbMirror.Size = new System.Drawing.Size(51, 17);
            this.rbMirror.TabIndex = 4;
            this.rbMirror.TabStop = true;
            this.rbMirror.Text = "Mirror";
            this.rbMirror.UseVisualStyleBackColor = true;
            // 
            // rbRotation
            // 
            this.rbRotation.AutoSize = true;
            this.rbRotation.Location = new System.Drawing.Point(90, 2);
            this.rbRotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRotation.Name = "rbRotation";
            this.rbRotation.Size = new System.Drawing.Size(57, 17);
            this.rbRotation.TabIndex = 3;
            this.rbRotation.TabStop = true;
            this.rbRotation.Text = "Rotate";
            this.rbRotation.UseVisualStyleBackColor = true;
            // 
            // rbFromImage
            // 
            this.rbFromImage.AutoSize = true;
            this.rbFromImage.Location = new System.Drawing.Point(10, 2);
            this.rbFromImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFromImage.Name = "rbFromImage";
            this.rbFromImage.Size = new System.Drawing.Size(80, 17);
            this.rbFromImage.TabIndex = 2;
            this.rbFromImage.TabStop = true;
            this.rbFromImage.Text = "From Image";
            this.rbFromImage.UseVisualStyleBackColor = true;
            // 
            // btnNewAnimation
            // 
            this.btnNewAnimation.Location = new System.Drawing.Point(3, 38);
            this.btnNewAnimation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewAnimation.Name = "btnNewAnimation";
            this.btnNewAnimation.Size = new System.Drawing.Size(25, 19);
            this.btnNewAnimation.TabIndex = 21;
            this.btnNewAnimation.Text = "+";
            this.btnNewAnimation.UseVisualStyleBackColor = true;
            this.btnNewAnimation.Click += new System.EventHandler(this.btnNewAnimation_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(384, 25);
            this.pbPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(69, 73);
            this.pbPreview.TabIndex = 22;
            this.pbPreview.TabStop = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(388, 102);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(56, 19);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(274, 254);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 19);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPreviewAnimFwd
            // 
            this.btnPreviewAnimFwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviewAnimFwd.Location = new System.Drawing.Point(421, 126);
            this.btnPreviewAnimFwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreviewAnimFwd.Name = "btnPreviewAnimFwd";
            this.btnPreviewAnimFwd.Size = new System.Drawing.Size(24, 19);
            this.btnPreviewAnimFwd.TabIndex = 15;
            this.btnPreviewAnimFwd.Text = ">";
            this.btnPreviewAnimFwd.UseVisualStyleBackColor = true;
            this.btnPreviewAnimFwd.Click += new System.EventHandler(this.btnPreviewAnimFwd_Click);
            // 
            // btnPreviewAnimBack
            // 
            this.btnPreviewAnimBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviewAnimBack.Location = new System.Drawing.Point(388, 126);
            this.btnPreviewAnimBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreviewAnimBack.Name = "btnPreviewAnimBack";
            this.btnPreviewAnimBack.Size = new System.Drawing.Size(24, 19);
            this.btnPreviewAnimBack.TabIndex = 14;
            this.btnPreviewAnimBack.Text = "<";
            this.btnPreviewAnimBack.UseVisualStyleBackColor = true;
            this.btnPreviewAnimBack.Click += new System.EventHandler(this.btnPreviewAnimBack_Click);
            // 
            // pnlAnimationFWBK
            // 
            this.pnlAnimationFWBK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAnimationFWBK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnimationFWBK.Controls.Add(this.btnDeleteAnim);
            this.pnlAnimationFWBK.Controls.Add(this.lblAnimationNumber);
            this.pnlAnimationFWBK.Controls.Add(this.lblAnimationFwdBack);
            this.pnlAnimationFWBK.Controls.Add(this.btnAnimFwd);
            this.pnlAnimationFWBK.Controls.Add(this.btnAnimBack);
            this.pnlAnimationFWBK.Controls.Add(this.btnNewAnimation);
            this.pnlAnimationFWBK.Location = new System.Drawing.Point(352, 181);
            this.pnlAnimationFWBK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAnimationFWBK.Name = "pnlAnimationFWBK";
            this.pnlAnimationFWBK.Size = new System.Drawing.Size(100, 65);
            this.pnlAnimationFWBK.TabIndex = 27;
            // 
            // btnDeleteAnim
            // 
            this.btnDeleteAnim.Location = new System.Drawing.Point(71, 38);
            this.btnDeleteAnim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAnim.Name = "btnDeleteAnim";
            this.btnDeleteAnim.Size = new System.Drawing.Size(25, 19);
            this.btnDeleteAnim.TabIndex = 22;
            this.btnDeleteAnim.Text = "-";
            this.btnDeleteAnim.UseVisualStyleBackColor = true;
            this.btnDeleteAnim.Click += new System.EventHandler(this.btnDeleteAnim_Click);
            // 
            // btnDelSprite
            // 
            this.btnDelSprite.Location = new System.Drawing.Point(267, 228);
            this.btnDelSprite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelSprite.Name = "btnDelSprite";
            this.btnDelSprite.Size = new System.Drawing.Size(69, 19);
            this.btnDelSprite.TabIndex = 19;
            this.btnDelSprite.Text = "Del Sprite";
            this.btnDelSprite.UseVisualStyleBackColor = true;
            this.btnDelSprite.Click += new System.EventHandler(this.btnDelSprite_Click);
            // 
            // SpriteEntryForm
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(460, 282);
            this.Controls.Add(this.btnDelSprite);
            this.Controls.Add(this.btnPreviewAnimBack);
            this.Controls.Add(this.btnPreviewAnimFwd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.panelRadioButtons);
            this.Controls.Add(this.TCTabPages);
            this.Controls.Add(this.lblCountSprites);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbDefaultSize);
            this.Controls.Add(this.lblDefaultSize);
            this.Controls.Add(this.lblAnimationSpeed);
            this.Controls.Add(this.tbAmimationSpeed);
            this.Controls.Add(this.btnNewSprite);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblSpriteName);
            this.Controls.Add(this.tbSpriteName);
            this.Controls.Add(this.pbImageField);
            this.Controls.Add(this.pnlAnimationFWBK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpriteEntryForm";
            this.Text = "SpriteEntryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpriteEntryForm_FormClosing);
            this.Load += new System.EventHandler(this.SpriteEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageField)).EndInit();
            this.TCTabPages.ResumeLayout(false);
            this.tpFromImage.ResumeLayout(false);
            this.tpFromImage.PerformLayout();
            this.tpMirrorRotate.ResumeLayout(false);
            this.tpMirrorRotate.PerformLayout();
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.pnlAnimationFWBK.ResumeLayout(false);
            this.pnlAnimationFWBK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageField;
        private System.Windows.Forms.ComboBox cbStartingImage;
        private System.Windows.Forms.Label lblStartingImage;
        private System.Windows.Forms.Label lblChosenArea;
        private System.Windows.Forms.TextBox tbNumFrames;
        private System.Windows.Forms.Label lblFrames;
        private System.Windows.Forms.TextBox tbSpriteName;
        private System.Windows.Forms.Label lblSpriteName;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnNewSprite;
        private System.Windows.Forms.TextBox tbAmimationSpeed;
        private System.Windows.Forms.Label lblAnimationSpeed;
        private System.Windows.Forms.Label lblDefaultSize;
        private System.Windows.Forms.TextBox tbDefaultSize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Label lblCountSprites;
        private System.Windows.Forms.TabControl TCTabPages;
        private System.Windows.Forms.TabPage tpFromImage;
        private System.Windows.Forms.TabPage tpMirrorRotate;
        private System.Windows.Forms.Panel panelRadioButtons;
        private System.Windows.Forms.RadioButton rbMirror;
        private System.Windows.Forms.RadioButton rbRotation;
        private System.Windows.Forms.RadioButton rbFromImage;
        private System.Windows.Forms.Button btnNewAnimation;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox cbMirrorH;
        private System.Windows.Forms.CheckBox cbMirrorV;
        private System.Windows.Forms.Label lblRotationDegrees;
        private System.Windows.Forms.TextBox tbRotation;
        private System.Windows.Forms.Label lblWhichAnim;
        private System.Windows.Forms.ComboBox cbAnimation;
        private System.Windows.Forms.Label lblAnimationFwdBack;
        private System.Windows.Forms.Button btnAnimBack;
        private System.Windows.Forms.Button btnAnimFwd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPreviewAnimFwd;
        private System.Windows.Forms.Button btnPreviewAnimBack;
        private System.Windows.Forms.Label lblAnimationNumber;
        private System.Windows.Forms.Panel pnlAnimationFWBK;
        private System.Windows.Forms.Button btnDeleteAnim;
        private System.Windows.Forms.Button btnDelSprite;
    }
}