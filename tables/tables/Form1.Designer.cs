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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("3/4\"– 54\" IPS and 3\" – 30\" DIPS .");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Measurements", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ASTM A536, GR 65/45/12");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Material", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Convoluted Type, Ductile Iron, 150 lb. Drilling");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Standard", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Red Oxide Primer");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Finish", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.gfProducts = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gfProducts
            // 
            this.gfProducts.DisplayMember = "select product";
            this.gfProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gfProducts.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gfProducts.FormattingEnabled = true;
            this.gfProducts.Items.AddRange(new object[] {
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
            this.gfProducts.Location = new System.Drawing.Point(12, 12);
            this.gfProducts.Name = "gfProducts";
            this.gfProducts.Size = new System.Drawing.Size(441, 25);
            this.gfProducts.TabIndex = 0;
            this.gfProducts.Tag = "select product";
            this.gfProducts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            treeNode9.Name = "Node4";
            treeNode9.Text = "3/4\"– 54\" IPS and 3\" – 30\" DIPS .";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Measurements";
            treeNode11.Name = "Node5";
            treeNode11.Text = "ASTM A536, GR 65/45/12";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Material";
            treeNode13.Name = "Node6";
            treeNode13.Text = "Convoluted Type, Ductile Iron, 150 lb. Drilling";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Standard";
            treeNode15.Name = "Node7";
            treeNode15.Text = "Red Oxide Primer";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Finish";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12,
            treeNode14,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(441, 83);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gfProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Select;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox gfProducts;
        private System.Windows.Forms.TreeView treeView1;
    }
}

