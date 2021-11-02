
namespace RabbitMqSample
{
    partial class Form1
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
            this.btnConnectRabbitMq = new System.Windows.Forms.Button();
            this.btnCreateExchange = new System.Windows.Forms.Button();
            this.btnCreateQueues = new System.Windows.Forms.Button();
            this.btnBindQueues = new System.Windows.Forms.Button();
            this.txtPublishEmail = new System.Windows.Forms.TextBox();
            this.btnPublishEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublishSms = new System.Windows.Forms.TextBox();
            this.btnPublishSms = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEmailMessages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSmsMessages = new System.Windows.Forms.ListBox();
            this.btnSubscribeEmailQueue = new System.Windows.Forms.Button();
            this.btnSubscribeSmsQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectRabbitMq
            // 
            this.btnConnectRabbitMq.Location = new System.Drawing.Point(12, 12);
            this.btnConnectRabbitMq.Name = "btnConnectRabbitMq";
            this.btnConnectRabbitMq.Size = new System.Drawing.Size(223, 43);
            this.btnConnectRabbitMq.TabIndex = 0;
            this.btnConnectRabbitMq.Text = "Connect RabbitMQ";
            this.btnConnectRabbitMq.UseVisualStyleBackColor = true;
            this.btnConnectRabbitMq.Click += new System.EventHandler(this.btnConnectRabbitMq_Click);
            // 
            // btnCreateExchange
            // 
            this.btnCreateExchange.Location = new System.Drawing.Point(12, 61);
            this.btnCreateExchange.Name = "btnCreateExchange";
            this.btnCreateExchange.Size = new System.Drawing.Size(223, 40);
            this.btnCreateExchange.TabIndex = 1;
            this.btnCreateExchange.Text = "Create Exchange";
            this.btnCreateExchange.UseVisualStyleBackColor = true;
            this.btnCreateExchange.Click += new System.EventHandler(this.btnCreateExchange_Click);
            // 
            // btnCreateQueues
            // 
            this.btnCreateQueues.Location = new System.Drawing.Point(12, 107);
            this.btnCreateQueues.Name = "btnCreateQueues";
            this.btnCreateQueues.Size = new System.Drawing.Size(223, 44);
            this.btnCreateQueues.TabIndex = 2;
            this.btnCreateQueues.Text = "Create Queues";
            this.btnCreateQueues.UseVisualStyleBackColor = true;
            this.btnCreateQueues.Click += new System.EventHandler(this.btnCreateQueues_Click);
            // 
            // btnBindQueues
            // 
            this.btnBindQueues.Location = new System.Drawing.Point(12, 157);
            this.btnBindQueues.Name = "btnBindQueues";
            this.btnBindQueues.Size = new System.Drawing.Size(223, 43);
            this.btnBindQueues.TabIndex = 3;
            this.btnBindQueues.Text = "Bind Queues";
            this.btnBindQueues.UseVisualStyleBackColor = true;
            this.btnBindQueues.Click += new System.EventHandler(this.btnBindQueues_Click);
            // 
            // txtPublishEmail
            // 
            this.txtPublishEmail.Location = new System.Drawing.Point(12, 244);
            this.txtPublishEmail.Name = "txtPublishEmail";
            this.txtPublishEmail.Size = new System.Drawing.Size(401, 22);
            this.txtPublishEmail.TabIndex = 4;
            // 
            // btnPublishEmail
            // 
            this.btnPublishEmail.Location = new System.Drawing.Point(264, 273);
            this.btnPublishEmail.Name = "btnPublishEmail";
            this.btnPublishEmail.Size = new System.Drawing.Size(149, 36);
            this.btnPublishEmail.TabIndex = 5;
            this.btnPublishEmail.Text = "Publish Email";
            this.btnPublishEmail.UseVisualStyleBackColor = true;
            this.btnPublishEmail.Click += new System.EventHandler(this.btnPublishEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Publish Email";
            // 
            // txtPublishSms
            // 
            this.txtPublishSms.Location = new System.Drawing.Point(12, 346);
            this.txtPublishSms.Name = "txtPublishSms";
            this.txtPublishSms.Size = new System.Drawing.Size(401, 22);
            this.txtPublishSms.TabIndex = 7;
            // 
            // btnPublishSms
            // 
            this.btnPublishSms.Location = new System.Drawing.Point(264, 375);
            this.btnPublishSms.Name = "btnPublishSms";
            this.btnPublishSms.Size = new System.Drawing.Size(149, 36);
            this.btnPublishSms.TabIndex = 8;
            this.btnPublishSms.Text = "Publish SMS";
            this.btnPublishSms.UseVisualStyleBackColor = true;
            this.btnPublishSms.Click += new System.EventHandler(this.btnPublishSms_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Publish SMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email Messages";
            // 
            // lstEmailMessages
            // 
            this.lstEmailMessages.FormattingEnabled = true;
            this.lstEmailMessages.ItemHeight = 16;
            this.lstEmailMessages.Location = new System.Drawing.Point(544, 32);
            this.lstEmailMessages.Name = "lstEmailMessages";
            this.lstEmailMessages.Size = new System.Drawing.Size(486, 148);
            this.lstEmailMessages.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "SMS Messages";
            // 
            // lstSmsMessages
            // 
            this.lstSmsMessages.FormattingEnabled = true;
            this.lstSmsMessages.ItemHeight = 16;
            this.lstSmsMessages.Location = new System.Drawing.Point(544, 224);
            this.lstSmsMessages.Name = "lstSmsMessages";
            this.lstSmsMessages.Size = new System.Drawing.Size(486, 148);
            this.lstSmsMessages.TabIndex = 13;
            // 
            // btnSubscribeEmailQueue
            // 
            this.btnSubscribeEmailQueue.Location = new System.Drawing.Point(544, 399);
            this.btnSubscribeEmailQueue.Name = "btnSubscribeEmailQueue";
            this.btnSubscribeEmailQueue.Size = new System.Drawing.Size(199, 39);
            this.btnSubscribeEmailQueue.TabIndex = 14;
            this.btnSubscribeEmailQueue.Text = "Subscribe Email Queue";
            this.btnSubscribeEmailQueue.UseVisualStyleBackColor = true;
            this.btnSubscribeEmailQueue.Click += new System.EventHandler(this.btnSubscribeEmailQueue_Click);
            // 
            // btnSubscribeSmsQueue
            // 
            this.btnSubscribeSmsQueue.Location = new System.Drawing.Point(749, 399);
            this.btnSubscribeSmsQueue.Name = "btnSubscribeSmsQueue";
            this.btnSubscribeSmsQueue.Size = new System.Drawing.Size(199, 39);
            this.btnSubscribeSmsQueue.TabIndex = 15;
            this.btnSubscribeSmsQueue.Text = "Subscribe SMS Queue";
            this.btnSubscribeSmsQueue.UseVisualStyleBackColor = true;
            this.btnSubscribeSmsQueue.Click += new System.EventHandler(this.btnSubscribeSmsQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.btnSubscribeSmsQueue);
            this.Controls.Add(this.btnSubscribeEmailQueue);
            this.Controls.Add(this.lstSmsMessages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstEmailMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPublishSms);
            this.Controls.Add(this.txtPublishSms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPublishEmail);
            this.Controls.Add(this.txtPublishEmail);
            this.Controls.Add(this.btnBindQueues);
            this.Controls.Add(this.btnCreateQueues);
            this.Controls.Add(this.btnCreateExchange);
            this.Controls.Add(this.btnConnectRabbitMq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectRabbitMq;
        private System.Windows.Forms.Button btnCreateExchange;
        private System.Windows.Forms.Button btnCreateQueues;
        private System.Windows.Forms.Button btnBindQueues;
        private System.Windows.Forms.TextBox txtPublishEmail;
        private System.Windows.Forms.Button btnPublishEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublishSms;
        private System.Windows.Forms.Button btnPublishSms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEmailMessages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSmsMessages;
        private System.Windows.Forms.Button btnSubscribeEmailQueue;
        private System.Windows.Forms.Button btnSubscribeSmsQueue;
    }
}

