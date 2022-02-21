using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Labs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.func = new System.Windows.Forms.Label();
            this.aBoundLabel = new System.Windows.Forms.Label();
            this.bBoundLabel = new System.Windows.Forms.Label();
            this.epsBoundLabel = new System.Windows.Forms.Label();
            this.aBoundValue = new System.Windows.Forms.TextBox();
            this.bBoundValue = new System.Windows.Forms.TextBox();
            this.epsBoundValue = new System.Windows.Forms.TextBox();
            this.findRootsButton = new System.Windows.Forms.Button();
            this.roots = new System.Windows.Forms.DataGridView();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roots)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Location = new System.Drawing.Point(22, 43);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(600, 382);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // func
            // 
            this.func.AutoSize = true;
            this.func.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func.Location = new System.Drawing.Point(259, 9);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(210, 31);
            this.func.TabIndex = 1;
            this.func.Text = "sin(x)^(0.5) - 0.5";
            // 
            // aBoundLabel
            // 
            this.aBoundLabel.AutoSize = true;
            this.aBoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aBoundLabel.Location = new System.Drawing.Point(31, 465);
            this.aBoundLabel.Name = "aBoundLabel";
            this.aBoundLabel.Size = new System.Drawing.Size(33, 18);
            this.aBoundLabel.TabIndex = 2;
            this.aBoundLabel.Text = "a = ";
            // 
            // bBoundLabel
            // 
            this.bBoundLabel.AutoSize = true;
            this.bBoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBoundLabel.Location = new System.Drawing.Point(295, 466);
            this.bBoundLabel.Name = "bBoundLabel";
            this.bBoundLabel.Size = new System.Drawing.Size(33, 18);
            this.bBoundLabel.TabIndex = 4;
            this.bBoundLabel.Text = "b = ";
            // 
            // epsBoundLabel
            // 
            this.epsBoundLabel.AutoSize = true;
            this.epsBoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsBoundLabel.Location = new System.Drawing.Point(540, 465);
            this.epsBoundLabel.Name = "epsBoundLabel";
            this.epsBoundLabel.Size = new System.Drawing.Size(49, 18);
            this.epsBoundLabel.TabIndex = 5;
            this.epsBoundLabel.Text = "eps = ";
            // 
            // aBoundValue
            // 
            this.aBoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aBoundValue.Location = new System.Drawing.Point(70, 463);
            this.aBoundValue.Name = "aBoundValue";
            this.aBoundValue.Size = new System.Drawing.Size(123, 24);
            this.aBoundValue.TabIndex = 6;
            this.aBoundValue.TextChanged += new System.EventHandler(this.aBoundValue_TextChanged);
            // 
            // bBoundValue
            // 
            this.bBoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBoundValue.Location = new System.Drawing.Point(334, 463);
            this.bBoundValue.Name = "bBoundValue";
            this.bBoundValue.Size = new System.Drawing.Size(123, 24);
            this.bBoundValue.TabIndex = 7;
            this.bBoundValue.TextChanged += new System.EventHandler(this.bBoundValue_TextChanged);
            // 
            // epsBoundValue
            // 
            this.epsBoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsBoundValue.Location = new System.Drawing.Point(595, 462);
            this.epsBoundValue.Name = "epsBoundValue";
            this.epsBoundValue.Size = new System.Drawing.Size(123, 24);
            this.epsBoundValue.TabIndex = 8;
            this.epsBoundValue.TextChanged += new System.EventHandler(this.epsBoundValue_TextChanged);
            // 
            // findRootsButton
            // 
            this.findRootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findRootsButton.Location = new System.Drawing.Point(759, 19);
            this.findRootsButton.Name = "findRootsButton";
            this.findRootsButton.Size = new System.Drawing.Size(126, 34);
            this.findRootsButton.TabIndex = 9;
            this.findRootsButton.Text = "Найти корни";
            this.findRootsButton.UseVisualStyleBackColor = true;
            this.findRootsButton.Click += new System.EventHandler(this.findRootsButton_Click);
            // 
            // roots
            // 
            this.roots.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.roots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.roots.Location = new System.Drawing.Point(628, 59);
            this.roots.Name = "roots";
            this.roots.Size = new System.Drawing.Size(361, 296);
            this.roots.TabIndex = 10;
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildGraphButton.Location = new System.Drawing.Point(730, 391);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(155, 34);
            this.buildGraphButton.TabIndex = 11;
            this.buildGraphButton.Text = "Построить график";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            this.buildGraphButton.Click += new System.EventHandler(this.buildGraphButton_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Уточняемый корень";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Уточненный корень";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "| f(уточненный корень) |";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 502);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.roots);
            this.Controls.Add(this.findRootsButton);
            this.Controls.Add(this.epsBoundValue);
            this.Controls.Add(this.bBoundValue);
            this.Controls.Add(this.aBoundValue);
            this.Controls.Add(this.epsBoundLabel);
            this.Controls.Add(this.bBoundLabel);
            this.Controls.Add(this.aBoundLabel);
            this.Controls.Add(this.func);
            this.Controls.Add(this.graph);
            this.Name = "MainForm";
            this.Text = "Численные методы";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart graph;
        private Label func;
        private Label aBoundLabel;
        private Label bBoundLabel;
        private Label epsBoundLabel;
        private TextBox aBoundValue;
        private TextBox bBoundValue;
        private TextBox epsBoundValue;
        private Button findRootsButton;
        private DataGridView roots;
        private Button buildGraphButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}

