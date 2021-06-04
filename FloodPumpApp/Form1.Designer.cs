
namespace FloodPumpApp
{
    partial class MainForm
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
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.label_runtime = new System.Windows.Forms.Label();
            this.label_runrate = new System.Windows.Forms.Label();
            this.label_downtime = new System.Windows.Forms.Label();
            this.label_downrate = new System.Windows.Forms.Label();
            this.label_counter = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textbox_ip = new System.Windows.Forms.TextBox();
            this.textbox_port = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_connection = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ip
            // 
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ip.ForeColor = System.Drawing.Color.White;
            this.label_ip.Location = new System.Drawing.Point(39, 109);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(28, 25);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.BackColor = System.Drawing.Color.Transparent;
            this.label_port.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_port.ForeColor = System.Drawing.Color.White;
            this.label_port.Location = new System.Drawing.Point(39, 149);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(48, 25);
            this.label_port.TabIndex = 1;
            this.label_port.Text = "Port";
            // 
            // label_runtime
            // 
            this.label_runtime.BackColor = System.Drawing.Color.Transparent;
            this.label_runtime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_runtime.ForeColor = System.Drawing.Color.White;
            this.label_runtime.Location = new System.Drawing.Point(117, 280);
            this.label_runtime.Name = "label_runtime";
            this.label_runtime.Size = new System.Drawing.Size(133, 51);
            this.label_runtime.TabIndex = 2;
            this.label_runtime.Text = "-";
            this.label_runtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_runrate
            // 
            this.label_runrate.BackColor = System.Drawing.Color.Transparent;
            this.label_runrate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_runrate.ForeColor = System.Drawing.Color.White;
            this.label_runrate.Location = new System.Drawing.Point(117, 331);
            this.label_runrate.Name = "label_runrate";
            this.label_runrate.Size = new System.Drawing.Size(133, 51);
            this.label_runrate.TabIndex = 3;
            this.label_runrate.Text = "-";
            this.label_runrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_downtime
            // 
            this.label_downtime.BackColor = System.Drawing.Color.Transparent;
            this.label_downtime.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_downtime.ForeColor = System.Drawing.Color.White;
            this.label_downtime.Location = new System.Drawing.Point(333, 280);
            this.label_downtime.Name = "label_downtime";
            this.label_downtime.Size = new System.Drawing.Size(133, 51);
            this.label_downtime.TabIndex = 4;
            this.label_downtime.Text = "-";
            this.label_downtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_downrate
            // 
            this.label_downrate.BackColor = System.Drawing.Color.Transparent;
            this.label_downrate.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_downrate.ForeColor = System.Drawing.Color.White;
            this.label_downrate.Location = new System.Drawing.Point(333, 331);
            this.label_downrate.Name = "label_downrate";
            this.label_downrate.Size = new System.Drawing.Size(133, 51);
            this.label_downrate.TabIndex = 5;
            this.label_downrate.Text = "-";
            this.label_downrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_counter
            // 
            this.label_counter.BackColor = System.Drawing.Color.Transparent;
            this.label_counter.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_counter.ForeColor = System.Drawing.Color.White;
            this.label_counter.Location = new System.Drawing.Point(578, 340);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(133, 51);
            this.label_counter.TabIndex = 6;
            this.label_counter.Text = "-";
            this.label_counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_state
            // 
            this.label_state.BackColor = System.Drawing.Color.Transparent;
            this.label_state.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_state.ForeColor = System.Drawing.Color.White;
            this.label_state.Location = new System.Drawing.Point(496, 280);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(215, 51);
            this.label_state.TabIndex = 7;
            this.label_state.Text = "-";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            // 
            // textbox_ip
            // 
            this.textbox_ip.Location = new System.Drawing.Point(117, 111);
            this.textbox_ip.Name = "textbox_ip";
            this.textbox_ip.Size = new System.Drawing.Size(95, 23);
            this.textbox_ip.TabIndex = 8;
            // 
            // textbox_port
            // 
            this.textbox_port.Location = new System.Drawing.Point(117, 149);
            this.textbox_port.Name = "textbox_port";
            this.textbox_port.Size = new System.Drawing.Size(95, 23);
            this.textbox_port.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FloodPumpApp.Properties.Resources.pump00;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::FloodPumpApp.Properties.Resources.pump00;
            this.pictureBox1.Location = new System.Drawing.Point(496, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 168);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            // 
            // button_connection
            // 
            this.button_connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.button_connection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connection.FlatAppearance.BorderSize = 0;
            this.button_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connection.Location = new System.Drawing.Point(39, 184);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(173, 33);
            this.button_connection.TabIndex = 0;
            this.button_connection.Text = "이더넷 연결";
            this.button_connection.UseVisualStyleBackColor = false;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.button_stop.FlatAppearance.BorderSize = 0;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop.Location = new System.Drawing.Point(358, 111);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(98, 38);
            this.button_stop.TabIndex = 12;
            this.button_stop.Text = "비상 정지";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_run
            // 
            this.button_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.button_run.FlatAppearance.BorderSize = 0;
            this.button_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_run.Location = new System.Drawing.Point(243, 111);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(98, 38);
            this.button_run.TabIndex = 10;
            this.button_run.Text = "가동 시작";
            this.button_run.UseVisualStyleBackColor = false;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_down
            // 
            this.button_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.button_down.FlatAppearance.BorderSize = 0;
            this.button_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_down.Location = new System.Drawing.Point(243, 169);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(98, 38);
            this.button_down.TabIndex = 11;
            this.button_down.Text = "비가동 시작";
            this.button_down.UseVisualStyleBackColor = false;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(84)))), ((int)(((byte)(144)))));
            this.button_reset.FlatAppearance.BorderSize = 0;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Location = new System.Drawing.Point(358, 169);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(98, 38);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "데이터 리셋";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FloodPumpApp.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(726, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_connection);
            this.Controls.Add(this.textbox_port);
            this.Controls.Add(this.textbox_ip);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.label_downrate);
            this.Controls.Add(this.label_downtime);
            this.Controls.Add(this.label_runrate);
            this.Controls.Add(this.label_runtime);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Text = "FloodPump";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Label label_runtime;
        private System.Windows.Forms.Label label_runrate;
        private System.Windows.Forms.Label label_downtime;
        private System.Windows.Forms.Label label_downrate;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.Label label_state;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textbox_ip;
        private System.Windows.Forms.TextBox textbox_port;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_reset;
    }
}

