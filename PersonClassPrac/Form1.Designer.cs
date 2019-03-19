namespace PersonClassPrac
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
            this.btnCreateNewPerson = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtLstPerson = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewPerson
            // 
            this.btnCreateNewPerson.Location = new System.Drawing.Point(105, 102);
            this.btnCreateNewPerson.Name = "btnCreateNewPerson";
            this.btnCreateNewPerson.Size = new System.Drawing.Size(126, 60);
            this.btnCreateNewPerson.TabIndex = 0;
            this.btnCreateNewPerson.Text = "Create New Person";
            this.btnCreateNewPerson.UseVisualStyleBackColor = true;
            this.btnCreateNewPerson.Click += new System.EventHandler(this.BtnCreateNewPerson_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create New Person Profession";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtLstPerson
            // 
            this.txtLstPerson.Location = new System.Drawing.Point(105, 208);
            this.txtLstPerson.Multiline = true;
            this.txtLstPerson.Name = "txtLstPerson";
            this.txtLstPerson.Size = new System.Drawing.Size(209, 190);
            this.txtLstPerson.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 208);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 190);
            this.textBox2.TabIndex = 3;
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(105, 404);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(209, 34);
            this.btnPerson.TabIndex = 4;
            this.btnPerson.Text = "Show Persons";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtLstPerson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateNewPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewPerson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtLstPerson;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPerson;
    }
}

