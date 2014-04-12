namespace IrcClientDemoCS
{
    partial class Raffle
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
            this.components = new System.ComponentModel.Container();
            this.btnRaffle = new System.Windows.Forms.Button();
            this.timerFPS = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRaffle
            // 
            this.btnRaffle.Location = new System.Drawing.Point(262, 321);
            this.btnRaffle.Name = "btnRaffle";
            this.btnRaffle.Size = new System.Drawing.Size(159, 23);
            this.btnRaffle.TabIndex = 0;
            this.btnRaffle.Text = "Choose Winner!";
            this.btnRaffle.UseVisualStyleBackColor = true;
            this.btnRaffle.Click += new System.EventHandler(this.btnRaffle_Click);
            // 
            // Raffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 356);
            this.Controls.Add(this.btnRaffle);
            this.Name = "Raffle";
            this.Text = "Raffle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRaffle;
        private System.Windows.Forms.Timer timerFPS;
    }
}