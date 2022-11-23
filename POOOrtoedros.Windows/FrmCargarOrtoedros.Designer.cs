
namespace POOOrtoedros.Windows
{
    partial class FrmCargarOrtoedros
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
            this.ColorRellenoComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxAristaC = new System.Windows.Forms.TextBox();
            this.textBoxAristaB = new System.Windows.Forms.TextBox();
            this.textBoxAristaA = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorRellenoComboBox
            // 
            this.ColorRellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorRellenoComboBox.FormattingEnabled = true;
            this.ColorRellenoComboBox.Location = new System.Drawing.Point(120, 140);
            this.ColorRellenoComboBox.Name = "ColorRellenoComboBox";
            this.ColorRellenoComboBox.Size = new System.Drawing.Size(279, 21);
            this.ColorRellenoComboBox.TabIndex = 67;
            // 
            // textBoxAristaC
            // 
            this.textBoxAristaC.Location = new System.Drawing.Point(120, 83);
            this.textBoxAristaC.MaxLength = 50;
            this.textBoxAristaC.Name = "textBoxAristaC";
            this.textBoxAristaC.Size = new System.Drawing.Size(279, 20);
            this.textBoxAristaC.TabIndex = 55;
            // 
            // textBoxAristaB
            // 
            this.textBoxAristaB.Location = new System.Drawing.Point(120, 54);
            this.textBoxAristaB.MaxLength = 50;
            this.textBoxAristaB.Name = "textBoxAristaB";
            this.textBoxAristaB.Size = new System.Drawing.Size(279, 20);
            this.textBoxAristaB.TabIndex = 54;
            // 
            // textBoxAristaA
            // 
            this.textBoxAristaA.Location = new System.Drawing.Point(120, 26);
            this.textBoxAristaA.MaxLength = 8;
            this.textBoxAristaA.Name = "textBoxAristaA";
            this.textBoxAristaA.Size = new System.Drawing.Size(279, 20);
            this.textBoxAristaA.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(282, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(56, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 58;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Color Relleno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Arista C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Arista A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Arista B:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCargarOrtoedros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 281);
            this.Controls.Add(this.ColorRellenoComboBox);
            this.Controls.Add(this.textBoxAristaC);
            this.Controls.Add(this.textBoxAristaB);
            this.Controls.Add(this.textBoxAristaA);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FrmCargarOrtoedros";
            this.Text = "FrmCargarOrtoedros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorRellenoComboBox;
        private System.Windows.Forms.TextBox textBoxAristaC;
        private System.Windows.Forms.TextBox textBoxAristaB;
        private System.Windows.Forms.TextBox textBoxAristaA;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}