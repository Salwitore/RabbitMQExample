namespace RabbitMQProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.cmbBoxDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBindRoutingKey = new System.Windows.Forms.TextBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.cmbBoxBindDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.useCounter = new System.Windows.Forms.CheckBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(121, 29);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(225, 23);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "amqp://guest:guest@localhost:5672";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(352, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.buttonConnectClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Declare Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Queue Name";
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(114, 167);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(164, 23);
            this.txtDeclareQueueName.TabIndex = 6;
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.Location = new System.Drawing.Point(203, 138);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDeclareQueue.TabIndex = 7;
            this.btnDeclareQueue.Text = "Declare";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.buttonDeclareQueueClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Declare Exchange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Type";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(375, 138);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(201, 23);
            this.txtDeclareExchangeName.TabIndex = 11;
            // 
            // cmbBoxDeclareExchangeType
            // 
            this.cmbBoxDeclareExchangeType.FormattingEnabled = true;
            this.cmbBoxDeclareExchangeType.Location = new System.Drawing.Point(375, 175);
            this.cmbBoxDeclareExchangeType.Name = "cmbBoxDeclareExchangeType";
            this.cmbBoxDeclareExchangeType.Size = new System.Drawing.Size(201, 23);
            this.cmbBoxDeclareExchangeType.TabIndex = 12;
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(375, 215);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(201, 23);
            this.btnDeclareExchange.TabIndex = 13;
            this.btnDeclareExchange.Text = "Declare";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.buttonDeclareExchangeClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bind Queue  &&  Exchange";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Routing Key";
            // 
            // txtBindRoutingKey
            // 
            this.txtBindRoutingKey.Location = new System.Drawing.Point(263, 286);
            this.txtBindRoutingKey.Name = "txtBindRoutingKey";
            this.txtBindRoutingKey.Size = new System.Drawing.Size(181, 23);
            this.txtBindRoutingKey.TabIndex = 16;
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.Location = new System.Drawing.Point(185, 315);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(259, 29);
            this.btnBindQueue.TabIndex = 17;
            this.btnBindQueue.Text = "Bind Queue";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.buttonBindQueueClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Queue / Exchange Declere &&  Bind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Exchange Name/Type";
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(242, 356);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(165, 23);
            this.txtExchangeName.TabIndex = 21;
            // 
            // cmbBoxBindDeclareExchangeType
            // 
            this.cmbBoxBindDeclareExchangeType.FormattingEnabled = true;
            this.cmbBoxBindDeclareExchangeType.Location = new System.Drawing.Point(413, 356);
            this.cmbBoxBindDeclareExchangeType.Name = "cmbBoxBindDeclareExchangeType";
            this.cmbBoxBindDeclareExchangeType.Size = new System.Drawing.Size(99, 23);
            this.cmbBoxBindDeclareExchangeType.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Routing Key";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(242, 388);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(270, 23);
            this.txtRoutingKey.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(114, 447);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(398, 80);
            this.txtMessage.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Repeat";
            // 
            // numericRepeatCount
            // 
            this.numericRepeatCount.Location = new System.Drawing.Point(114, 548);
            this.numericRepeatCount.Name = "numericRepeatCount";
            this.numericRepeatCount.Size = new System.Drawing.Size(120, 23);
            this.numericRepeatCount.TabIndex = 29;
            this.numericRepeatCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // useCounter
            // 
            this.useCounter.AutoSize = true;
            this.useCounter.Location = new System.Drawing.Point(253, 553);
            this.useCounter.Name = "useCounter";
            this.useCounter.Size = new System.Drawing.Size(91, 19);
            this.useCounter.TabIndex = 30;
            this.useCounter.Text = "Use Counter";
            this.useCounter.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(387, 538);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(125, 34);
            this.btnPublish.TabIndex = 31;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.buttonPublishClick);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(12, 609);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(564, 105);
            this.txtLog.TabIndex = 32;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(3, 737);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(104, 15);
            this.lblConnectionStatus.TabIndex = 33;
            this.lblConnectionStatus.Text = "Connection State: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 751);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.useCounter);
            this.Controls.Add(this.numericRepeatCount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRoutingKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbBoxBindDeclareExchangeType);
            this.Controls.Add(this.txtExchangeName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBindQueue);
            this.Controls.Add(this.txtBindRoutingKey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeclareExchange);
            this.Controls.Add(this.cmbBoxDeclareExchangeType);
            this.Controls.Add(this.txtDeclareExchangeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeclareQueue);
            this.Controls.Add(this.txtDeclareQueueName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtConnectionString;
        private Label label1;
        private Button btnConnect;
        private Label label3;
        private Label label4;
        private TextBox txtDeclareQueueName;
        private Button btnDeclareQueue;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDeclareExchangeName;
        private ComboBox cmbBoxDeclareExchangeType;
        private Button btnDeclareExchange;
        private Label label8;
        private Label label9;
        private TextBox txtBindRoutingKey;
        private Button btnBindQueue;
        private Label label2;
        private Label label10;
        private TextBox txtExchangeName;
        private ComboBox cmbBoxBindDeclareExchangeType;
        private Label label11;
        private TextBox txtRoutingKey;
        private Label label12;
        private TextBox txtMessage;
        private Label label13;
        private NumericUpDown numericRepeatCount;
        private CheckBox useCounter;
        private Button btnPublish;
        private TextBox txtLog;
        private Label lblConnectionStatus;
    }
}