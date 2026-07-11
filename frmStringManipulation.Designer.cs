namespace Project_29___String_Manipulation_Form__
{
    partial class frmStringManipulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStringManipulation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtCharacters = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnToLower = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnTrimStart = new System.Windows.Forms.Button();
            this.btnTrimEnd = new System.Windows.Forms.Button();
            this.btnRemoveSpaces = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.bttnReplaceFirst = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGetSubstring = new System.Windows.Forms.Button();
            this.txtFirstWord = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLastWord = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCopyOutput = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnAsInputCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 57.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Manipulation Form";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1085, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1085, 146);
            this.label3.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(12, 122);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(350, 115);
            this.txtInput.TabIndex = 3;
            this.txtInput.WordWrap = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtCharacters
            // 
            this.txtCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacters.Location = new System.Drawing.Point(550, 206);
            this.txtCharacters.Name = "txtCharacters";
            this.txtCharacters.ReadOnly = true;
            this.txtCharacters.Size = new System.Drawing.Size(72, 38);
            this.txtCharacters.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Characters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(651, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Words";
            // 
            // txtWords
            // 
            this.txtWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWords.Location = new System.Drawing.Point(763, 203);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.Size = new System.Drawing.Size(72, 38);
            this.txtWords.TabIndex = 8;
            // 
            // btnClearInput
            // 
            this.btnClearInput.BackColor = System.Drawing.Color.Green;
            this.btnClearInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(901, 201);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(165, 40);
            this.btnClearInput.TabIndex = 10;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = false;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 70);
            this.label7.TabIndex = 11;
            this.label7.Text = "Case Operations";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1085, 70);
            this.label8.TabIndex = 12;
            // 
            // btnToUpper
            // 
            this.btnToUpper.BackColor = System.Drawing.Color.Black;
            this.btnToUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToUpper.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnToUpper.FlatAppearance.BorderSize = 5;
            this.btnToUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToUpper.ForeColor = System.Drawing.Color.White;
            this.btnToUpper.Location = new System.Drawing.Point(282, 303);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(165, 50);
            this.btnToUpper.TabIndex = 13;
            this.btnToUpper.Tag = "ToUpper";
            this.btnToUpper.Text = "To Upper";
            this.btnToUpper.UseVisualStyleBackColor = false;
            this.btnToUpper.Click += new System.EventHandler(this.btnCaseOperations_Click);
            // 
            // btnToLower
            // 
            this.btnToLower.BackColor = System.Drawing.Color.Black;
            this.btnToLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToLower.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnToLower.FlatAppearance.BorderSize = 5;
            this.btnToLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLower.ForeColor = System.Drawing.Color.White;
            this.btnToLower.Location = new System.Drawing.Point(598, 303);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(165, 50);
            this.btnToLower.TabIndex = 14;
            this.btnToLower.Tag = "ToLower";
            this.btnToLower.Text = "To Lower";
            this.btnToLower.UseVisualStyleBackColor = false;
            this.btnToLower.Click += new System.EventHandler(this.btnCaseOperations_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1085, 35);
            this.label9.TabIndex = 17;
            this.label9.Text = "Transform";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1085, 137);
            this.label10.TabIndex = 18;
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.Color.Black;
            this.btnTrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrim.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTrim.FlatAppearance.BorderSize = 5;
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrim.ForeColor = System.Drawing.Color.White;
            this.btnTrim.Location = new System.Drawing.Point(22, 447);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(206, 45);
            this.btnTrim.TabIndex = 19;
            this.btnTrim.Tag = "Trim";
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTransformations_Click);
            // 
            // btnTrimStart
            // 
            this.btnTrimStart.BackColor = System.Drawing.Color.Black;
            this.btnTrimStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimStart.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTrimStart.FlatAppearance.BorderSize = 5;
            this.btnTrimStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrimStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimStart.ForeColor = System.Drawing.Color.White;
            this.btnTrimStart.Location = new System.Drawing.Point(305, 447);
            this.btnTrimStart.Name = "btnTrimStart";
            this.btnTrimStart.Size = new System.Drawing.Size(206, 45);
            this.btnTrimStart.TabIndex = 20;
            this.btnTrimStart.Tag = "TrimStart";
            this.btnTrimStart.Text = "Trim Start";
            this.btnTrimStart.UseVisualStyleBackColor = false;
            this.btnTrimStart.Click += new System.EventHandler(this.btnTransformations_Click);
            // 
            // btnTrimEnd
            // 
            this.btnTrimEnd.BackColor = System.Drawing.Color.Black;
            this.btnTrimEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimEnd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnTrimEnd.FlatAppearance.BorderSize = 5;
            this.btnTrimEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrimEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrimEnd.ForeColor = System.Drawing.Color.White;
            this.btnTrimEnd.Location = new System.Drawing.Point(588, 447);
            this.btnTrimEnd.Name = "btnTrimEnd";
            this.btnTrimEnd.Size = new System.Drawing.Size(206, 45);
            this.btnTrimEnd.TabIndex = 21;
            this.btnTrimEnd.Tag = "TrimEnd";
            this.btnTrimEnd.Text = "Trim End";
            this.btnTrimEnd.UseVisualStyleBackColor = false;
            this.btnTrimEnd.Click += new System.EventHandler(this.btnTransformations_Click);
            // 
            // btnRemoveSpaces
            // 
            this.btnRemoveSpaces.BackColor = System.Drawing.Color.Black;
            this.btnRemoveSpaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSpaces.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemoveSpaces.FlatAppearance.BorderSize = 5;
            this.btnRemoveSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSpaces.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSpaces.Location = new System.Drawing.Point(871, 447);
            this.btnRemoveSpaces.Name = "btnRemoveSpaces";
            this.btnRemoveSpaces.Size = new System.Drawing.Size(206, 45);
            this.btnRemoveSpaces.TabIndex = 23;
            this.btnRemoveSpaces.Tag = "RemoveSpaces";
            this.btnRemoveSpaces.Text = "Remove Spaces";
            this.btnRemoveSpaces.UseVisualStyleBackColor = false;
            this.btnRemoveSpaces.Click += new System.EventHandler(this.btnTransformations_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "Find";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(93, 517);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(188, 38);
            this.txtFind.TabIndex = 25;
            this.txtFind.WordWrap = false;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplaceWith.Location = new System.Drawing.Point(496, 514);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(188, 38);
            this.txtReplaceWith.TabIndex = 27;
            this.txtReplaceWith.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(308, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 31);
            this.label12.TabIndex = 26;
            this.label12.Text = "Replace with";
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.BackColor = System.Drawing.Color.Maroon;
            this.btnReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplaceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceAll.ForeColor = System.Drawing.Color.White;
            this.btnReplaceAll.Location = new System.Drawing.Point(710, 508);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(173, 40);
            this.btnReplaceAll.TabIndex = 28;
            this.btnReplaceAll.Tag = "ReplaceAll";
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = false;
            this.btnReplaceAll.Click += new System.EventHandler(this.bttnReplace_Click);
            // 
            // bttnReplaceFirst
            // 
            this.bttnReplaceFirst.BackColor = System.Drawing.Color.Black;
            this.bttnReplaceFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReplaceFirst.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bttnReplaceFirst.FlatAppearance.BorderSize = 4;
            this.bttnReplaceFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReplaceFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReplaceFirst.ForeColor = System.Drawing.Color.White;
            this.bttnReplaceFirst.Location = new System.Drawing.Point(889, 508);
            this.bttnReplaceFirst.Name = "bttnReplaceFirst";
            this.bttnReplaceFirst.Size = new System.Drawing.Size(177, 40);
            this.bttnReplaceFirst.TabIndex = 29;
            this.bttnReplaceFirst.Tag = "ReplaceFirst";
            this.bttnReplaceFirst.Text = "Replace First";
            this.bttnReplaceFirst.UseVisualStyleBackColor = false;
            this.bttnReplaceFirst.Click += new System.EventHandler(this.bttnReplace_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(5, 606);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 62);
            this.label13.TabIndex = 30;
            this.label13.Text = "Extract";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(5, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1085, 62);
            this.label14.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(223, 621);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 31);
            this.label15.TabIndex = 32;
            this.label15.Text = "Start";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartIndex.Location = new System.Drawing.Point(374, 622);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(89, 38);
            this.txtStartIndex.TabIndex = 35;
            this.txtStartIndex.WordWrap = false;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(714, 622);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(89, 38);
            this.txtLength.TabIndex = 37;
            this.txtLength.WordWrap = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(537, 622);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 31);
            this.label17.TabIndex = 36;
            this.label17.Text = "Length";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.RoyalBlue;
            this.label18.Font = new System.Drawing.Font("Microsoft Uighur", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(3, 701);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 119);
            this.label18.TabIndex = 38;
            this.label18.Text = "Output";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 702);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1085, 119);
            this.label19.TabIndex = 39;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(191, 716);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(350, 104);
            this.txtOutput.TabIndex = 40;
            this.txtOutput.WordWrap = false;
            // 
            // btnGetSubstring
            // 
            this.btnGetSubstring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGetSubstring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSubstring.ForeColor = System.Drawing.Color.White;
            this.btnGetSubstring.Location = new System.Drawing.Point(877, 618);
            this.btnGetSubstring.Name = "btnGetSubstring";
            this.btnGetSubstring.Size = new System.Drawing.Size(175, 40);
            this.btnGetSubstring.TabIndex = 41;
            this.btnGetSubstring.Text = "Get Substring";
            this.btnGetSubstring.UseVisualStyleBackColor = false;
            this.btnGetSubstring.Click += new System.EventHandler(this.btnGetSubstring_Click);
            // 
            // txtFirstWord
            // 
            this.txtFirstWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstWord.Location = new System.Drawing.Point(540, 125);
            this.txtFirstWord.Name = "txtFirstWord";
            this.txtFirstWord.ReadOnly = true;
            this.txtFirstWord.Size = new System.Drawing.Size(153, 38);
            this.txtFirstWord.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(377, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 31);
            this.label20.TabIndex = 42;
            this.label20.Text = "First word";
            // 
            // txtLastWord
            // 
            this.txtLastWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastWord.Location = new System.Drawing.Point(898, 122);
            this.txtLastWord.Name = "txtLastWord";
            this.txtLastWord.ReadOnly = true;
            this.txtLastWord.Size = new System.Drawing.Size(153, 38);
            this.txtLastWord.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(738, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 31);
            this.label21.TabIndex = 44;
            this.label21.Text = "Last word";
            // 
            // btnCopyOutput
            // 
            this.btnCopyOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopyOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyOutput.ForeColor = System.Drawing.Color.White;
            this.btnCopyOutput.Location = new System.Drawing.Point(547, 743);
            this.btnCopyOutput.Name = "btnCopyOutput";
            this.btnCopyOutput.Size = new System.Drawing.Size(175, 40);
            this.btnCopyOutput.TabIndex = 46;
            this.btnCopyOutput.Tag = "CopyOutput";
            this.btnCopyOutput.Text = "Copy Output";
            this.btnCopyOutput.UseVisualStyleBackColor = false;
            this.btnCopyOutput.Click += new System.EventHandler(this.btnOutputOperations_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutput.ForeColor = System.Drawing.Color.White;
            this.btnClearOutput.Location = new System.Drawing.Point(723, 741);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(175, 40);
            this.btnClearOutput.TabIndex = 47;
            this.btnClearOutput.Tag = "ClearOutput";
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = false;
            this.btnClearOutput.Click += new System.EventHandler(this.btnOutputOperations_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(904, 741);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(175, 40);
            this.btnClearAll.TabIndex = 48;
            this.btnClearAll.Tag = "ClearAll";
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnOutputOperations_Click);
            // 
            // btnAsInputCase
            // 
            this.btnAsInputCase.BackColor = System.Drawing.Color.Black;
            this.btnAsInputCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsInputCase.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAsInputCase.FlatAppearance.BorderSize = 5;
            this.btnAsInputCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsInputCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsInputCase.ForeColor = System.Drawing.Color.White;
            this.btnAsInputCase.Location = new System.Drawing.Point(914, 303);
            this.btnAsInputCase.Name = "btnAsInputCase";
            this.btnAsInputCase.Size = new System.Drawing.Size(165, 50);
            this.btnAsInputCase.TabIndex = 49;
            this.btnAsInputCase.Tag = "AsInput";
            this.btnAsInputCase.Text = "As Input";
            this.btnAsInputCase.UseVisualStyleBackColor = false;
            this.btnAsInputCase.Click += new System.EventHandler(this.btnCaseOperations_Click);
            // 
            // frmStringManipulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1091, 845);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAsInputCase);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnCopyOutput);
            this.Controls.Add(this.txtLastWord);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtFirstWord);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnGetSubstring);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bttnReplaceFirst);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRemoveSpaces);
            this.Controls.Add(this.btnTrimEnd);
            this.Controls.Add(this.btnTrimStart);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCharacters);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStringManipulation";
            this.Text = " String Manipulation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtCharacters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnTrimStart;
        private System.Windows.Forms.Button btnTrimEnd;
        private System.Windows.Forms.Button btnRemoveSpaces;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button bttnReplaceFirst;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGetSubstring;
        private System.Windows.Forms.TextBox txtFirstWord;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLastWord;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCopyOutput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnAsInputCase;
    }
}

