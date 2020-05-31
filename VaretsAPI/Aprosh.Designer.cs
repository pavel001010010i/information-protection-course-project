namespace VaretsAPI
{
    partial class Aprosh
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aprosh));
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDecryptText = new System.Windows.Forms.Label();
            this.CBForZeroSpacing = new System.Windows.Forms.ComboBox();
            this.CBForSingleSpacing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBForFormatExpport = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelPathSaveFile = new System.Windows.Forms.Label();
            this.TBForMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelForCountSymbol = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBForCheckColor = new System.Windows.Forms.ComboBox();
            this.butForViewFile = new System.Windows.Forms.Button();
            this.labelForStatusScritiya = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 457);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(238, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "Скрыть информацию";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(12, 120);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 48);
            this.button8.TabIndex = 7;
            this.button8.Text = "Выбрать\r\nдокумент";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Path";
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(509, 457);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(238, 48);
            this.button9.TabIndex = 9;
            this.button9.Text = "Извлечь информацию";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сокрытие информации с помощью параметра \"Апрош\"";
            // 
            // labelDecryptText
            // 
            this.labelDecryptText.AutoSize = true;
            this.labelDecryptText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecryptText.Location = new System.Drawing.Point(15, 433);
            this.labelDecryptText.Name = "labelDecryptText";
            this.labelDecryptText.Size = new System.Drawing.Size(14, 21);
            this.labelDecryptText.TabIndex = 12;
            this.labelDecryptText.Text = " ";
            // 
            // CBForZeroSpacing
            // 
            this.CBForZeroSpacing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForZeroSpacing.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBForZeroSpacing.FormattingEnabled = true;
            this.CBForZeroSpacing.Location = new System.Drawing.Point(224, 204);
            this.CBForZeroSpacing.Name = "CBForZeroSpacing";
            this.CBForZeroSpacing.Size = new System.Drawing.Size(51, 25);
            this.CBForZeroSpacing.TabIndex = 13;
            this.CBForZeroSpacing.SelectedIndexChanged += new System.EventHandler(this.comboBoxForSpacing_SelectedIndexChanged);
            // 
            // CBForSingleSpacing
            // 
            this.CBForSingleSpacing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForSingleSpacing.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBForSingleSpacing.FormattingEnabled = true;
            this.CBForSingleSpacing.Location = new System.Drawing.Point(224, 229);
            this.CBForSingleSpacing.Name = "CBForSingleSpacing";
            this.CBForSingleSpacing.Size = new System.Drawing.Size(51, 25);
            this.CBForSingleSpacing.TabIndex = 14;
            this.CBForSingleSpacing.SelectedIndexChanged += new System.EventHandler(this.CBForSingleSpacing_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Нулевого бита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Единичного бита";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Выберите значение апроша для:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(358, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 42);
            this.label6.TabIndex = 18;
            this.label6.Text = "Формат для сохранения документа \r\nсодержащего скрытую информацию: ";
            // 
            // CBForFormatExpport
            // 
            this.CBForFormatExpport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForFormatExpport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBForFormatExpport.FormattingEnabled = true;
            this.CBForFormatExpport.Location = new System.Drawing.Point(679, 199);
            this.CBForFormatExpport.Name = "CBForFormatExpport";
            this.CBForFormatExpport.Size = new System.Drawing.Size(68, 25);
            this.CBForFormatExpport.TabIndex = 19;
            this.CBForFormatExpport.SelectedIndexChanged += new System.EventHandler(this.CDForFormatExpport_SelectedIndexChanged);
            // 
            // labelPathSaveFile
            // 
            this.labelPathSaveFile.AutoSize = true;
            this.labelPathSaveFile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathSaveFile.Location = new System.Drawing.Point(173, 147);
            this.labelPathSaveFile.Name = "labelPathSaveFile";
            this.labelPathSaveFile.Size = new System.Drawing.Size(47, 21);
            this.labelPathSaveFile.TabIndex = 21;
            this.labelPathSaveFile.Text = "Path";
            // 
            // TBForMessage
            // 
            this.TBForMessage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBForMessage.Location = new System.Drawing.Point(12, 384);
            this.TBForMessage.Multiline = true;
            this.TBForMessage.Name = "TBForMessage";
            this.TBForMessage.Size = new System.Drawing.Size(735, 46);
            this.TBForMessage.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Введите сообщение";
            // 
            // labelForCountSymbol
            // 
            this.labelForCountSymbol.AutoSize = true;
            this.labelForCountSymbol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForCountSymbol.Location = new System.Drawing.Point(358, 360);
            this.labelForCountSymbol.Name = "labelForCountSymbol";
            this.labelForCountSymbol.Size = new System.Drawing.Size(0, 21);
            this.labelForCountSymbol.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(358, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 42);
            this.label8.TabIndex = 25;
            this.label8.Text = "Подсветка символов, содержащих \r\nскрытую информацию";
            // 
            // CBForCheckColor
            // 
            this.CBForCheckColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBForCheckColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBForCheckColor.FormattingEnabled = true;
            this.CBForCheckColor.Location = new System.Drawing.Point(679, 250);
            this.CBForCheckColor.Name = "CBForCheckColor";
            this.CBForCheckColor.Size = new System.Drawing.Size(68, 25);
            this.CBForCheckColor.TabIndex = 26;
            this.CBForCheckColor.SelectedIndexChanged += new System.EventHandler(this.CBForCheckColor_SelectedIndexChanged);
            // 
            // butForViewFile
            // 
            this.butForViewFile.AutoSize = true;
            this.butForViewFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butForViewFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butForViewFile.Location = new System.Drawing.Point(256, 457);
            this.butForViewFile.Name = "butForViewFile";
            this.butForViewFile.Size = new System.Drawing.Size(247, 48);
            this.butForViewFile.TabIndex = 27;
            this.butForViewFile.Text = "Открыть файл содержащий\r\nскрытую информацию";
            this.butForViewFile.UseVisualStyleBackColor = true;
            this.butForViewFile.Click += new System.EventHandler(this.butForViewFile_Click);
            // 
            // labelForStatusScritiya
            // 
            this.labelForStatusScritiya.AutoSize = true;
            this.labelForStatusScritiya.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForStatusScritiya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelForStatusScritiya.Location = new System.Drawing.Point(173, 322);
            this.labelForStatusScritiya.Name = "labelForStatusScritiya";
            this.labelForStatusScritiya.Size = new System.Drawing.Size(16, 24);
            this.labelForStatusScritiya.TabIndex = 28;
            this.labelForStatusScritiya.Text = " ";
            // 
            // Aprosh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 513);
            this.Controls.Add(this.labelForStatusScritiya);
            this.Controls.Add(this.butForViewFile);
            this.Controls.Add(this.CBForCheckColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelForCountSymbol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBForMessage);
            this.Controls.Add(this.labelPathSaveFile);
            this.Controls.Add(this.CBForFormatExpport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBForSingleSpacing);
            this.Controls.Add(this.CBForZeroSpacing);
            this.Controls.Add(this.labelDecryptText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aprosh";
            this.ShowIcon = false;
            this.Text = "VaretsAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDecryptText;
        private System.Windows.Forms.ComboBox CBForZeroSpacing;
        private System.Windows.Forms.ComboBox CBForSingleSpacing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBForFormatExpport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelPathSaveFile;
        private System.Windows.Forms.TextBox TBForMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelForCountSymbol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBForCheckColor;
        private System.Windows.Forms.Button butForViewFile;
        private System.Windows.Forms.Label labelForStatusScritiya;
    }
}

