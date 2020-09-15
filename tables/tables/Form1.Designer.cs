namespace tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("3/4\"– 54\" IPS and 3\" – 30\" DIPS .");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Measurements", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ASTM A536, GR 65/45/12");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Material", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Convoluted Type, Ductile Iron, 150 lb. Drilling");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Standard", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Red Oxide Primer");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Finish", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "select product";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HDPE Pipe (IPPI Design-Flow®)",
            "Conventional PE Fusion Fittings",
            "Electrofusion Fittings & Equipment",
            "Conventional PE Fusion Equipment",
            "Factory Mutual Approved Products",
            "Meter Connection Products",
            "Risers & Transitions",
            "Steel Mechanical Fittings",
            "Flange Insulation Products",
            " "});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(441, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "select product";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 157);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 206);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "3/4\"– 54\" IPS and 3\" – 30\" DIPS .";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Measurements";
            treeNode3.Name = "Node5";
            treeNode3.Text = "ASTM A536, GR 65/45/12";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Material";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Convoluted Type, Ductile Iron, 150 lb. Drilling";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Standard";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Red Oxide Primer";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Finish";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(441, 83);
            this.treeView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

