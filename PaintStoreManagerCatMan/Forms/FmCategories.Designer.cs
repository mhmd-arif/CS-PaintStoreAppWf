
namespace PaintStoreManagerCatMan.Forms
{
    partial class FmCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCategories));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties49 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties50 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties51 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties52 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties53 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties54 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties55 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties56 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties57 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties58 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties59 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties60 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Cate = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.TB_SearchCate = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TB_Category = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TB_CateDesc = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Clear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn_Update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.paintStoreDBDataSet = new PaintStoreManagerCatMan.PaintStoreDBDataSet();
            this.tblCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoriesTableAdapter = new PaintStoreManagerCatMan.PaintStoreDBDataSetTableAdapters.TblCategoriesTableAdapter();
            this.tblCategoriesDataSet = new PaintStoreManagerCatMan.TblCategoriesDataSet();
            this.tblCategoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblCategoriesTableAdapter1 = new PaintStoreManagerCatMan.TblCategoriesDataSetTableAdapters.TblCategoriesTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.DGV_Cate);
            this.panel1.Controls.Add(this.TB_SearchCate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 542);
            this.panel1.TabIndex = 0;
            // 
            // DGV_Cate
            // 
            this.DGV_Cate.AllowCustomTheming = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.DGV_Cate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_Cate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Cate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGV_Cate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Cate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Cate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Cate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_Cate.ColumnHeadersHeight = 40;
            this.DGV_Cate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGV_Cate.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGV_Cate.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGV_Cate.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_Cate.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGV_Cate.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Cate.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGV_Cate.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGV_Cate.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DGV_Cate.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGV_Cate.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Cate.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGV_Cate.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Cate.CurrentTheme.Name = null;
            this.DGV_Cate.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV_Cate.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGV_Cate.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV_Cate.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGV_Cate.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Cate.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_Cate.EnableHeadersVisualStyles = false;
            this.DGV_Cate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGV_Cate.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGV_Cate.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGV_Cate.HeaderForeColor = System.Drawing.Color.White;
            this.DGV_Cate.Location = new System.Drawing.Point(25, 79);
            this.DGV_Cate.Name = "DGV_Cate";
            this.DGV_Cate.RowHeadersVisible = false;
            this.DGV_Cate.RowTemplate.Height = 40;
            this.DGV_Cate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Cate.Size = new System.Drawing.Size(579, 451);
            this.DGV_Cate.TabIndex = 2;
            this.DGV_Cate.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DGV_Cate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Cate_CellContentClick);
            // 
            // TB_SearchCate
            // 
            this.TB_SearchCate.AcceptsReturn = false;
            this.TB_SearchCate.AcceptsTab = false;
            this.TB_SearchCate.AnimationSpeed = 200;
            this.TB_SearchCate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TB_SearchCate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TB_SearchCate.BackColor = System.Drawing.Color.Transparent;
            this.TB_SearchCate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TB_SearchCate.BackgroundImage")));
            this.TB_SearchCate.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TB_SearchCate.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TB_SearchCate.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TB_SearchCate.BorderColorIdle = System.Drawing.Color.Silver;
            this.TB_SearchCate.BorderRadius = 1;
            this.TB_SearchCate.BorderThickness = 1;
            this.TB_SearchCate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TB_SearchCate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SearchCate.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TB_SearchCate.DefaultText = "";
            this.TB_SearchCate.FillColor = System.Drawing.Color.White;
            this.TB_SearchCate.HideSelection = true;
            this.TB_SearchCate.IconLeft = null;
            this.TB_SearchCate.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SearchCate.IconPadding = 10;
            this.TB_SearchCate.IconRight = null;
            this.TB_SearchCate.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SearchCate.Lines = new string[0];
            this.TB_SearchCate.Location = new System.Drawing.Point(25, 25);
            this.TB_SearchCate.MaxLength = 32767;
            this.TB_SearchCate.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_SearchCate.Modified = false;
            this.TB_SearchCate.Multiline = false;
            this.TB_SearchCate.Name = "TB_SearchCate";
            stateProperties49.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties49.FillColor = System.Drawing.Color.Empty;
            stateProperties49.ForeColor = System.Drawing.Color.Empty;
            stateProperties49.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_SearchCate.OnActiveState = stateProperties49;
            stateProperties50.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties50.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties50.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TB_SearchCate.OnDisabledState = stateProperties50;
            stateProperties51.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties51.FillColor = System.Drawing.Color.Empty;
            stateProperties51.ForeColor = System.Drawing.Color.Empty;
            stateProperties51.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_SearchCate.OnHoverState = stateProperties51;
            stateProperties52.BorderColor = System.Drawing.Color.Silver;
            stateProperties52.FillColor = System.Drawing.Color.White;
            stateProperties52.ForeColor = System.Drawing.Color.Empty;
            stateProperties52.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_SearchCate.OnIdleState = stateProperties52;
            this.TB_SearchCate.Padding = new System.Windows.Forms.Padding(3);
            this.TB_SearchCate.PasswordChar = '\0';
            this.TB_SearchCate.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TB_SearchCate.PlaceholderText = "Search Category";
            this.TB_SearchCate.ReadOnly = false;
            this.TB_SearchCate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_SearchCate.SelectedText = "";
            this.TB_SearchCate.SelectionLength = 0;
            this.TB_SearchCate.SelectionStart = 0;
            this.TB_SearchCate.ShortcutsEnabled = true;
            this.TB_SearchCate.Size = new System.Drawing.Size(579, 37);
            this.TB_SearchCate.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TB_SearchCate.TabIndex = 1;
            this.TB_SearchCate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TB_SearchCate.TextMarginBottom = 0;
            this.TB_SearchCate.TextMarginLeft = 3;
            this.TB_SearchCate.TextMarginTop = 0;
            this.TB_SearchCate.TextPlaceholder = "Search Category";
            this.TB_SearchCate.UseSystemPasswordChar = false;
            this.TB_SearchCate.WordWrap = true;
            this.TB_SearchCate.TextChange += new System.EventHandler(this.TB_SearchCate_TextChange);
            // 
            // TB_Category
            // 
            this.TB_Category.AcceptsReturn = false;
            this.TB_Category.AcceptsTab = false;
            this.TB_Category.AnimationSpeed = 200;
            this.TB_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TB_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TB_Category.BackColor = System.Drawing.Color.Transparent;
            this.TB_Category.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TB_Category.BackgroundImage")));
            this.TB_Category.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TB_Category.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TB_Category.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TB_Category.BorderColorIdle = System.Drawing.Color.Silver;
            this.TB_Category.BorderRadius = 1;
            this.TB_Category.BorderThickness = 1;
            this.TB_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TB_Category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Category.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TB_Category.DefaultText = "";
            this.TB_Category.FillColor = System.Drawing.Color.White;
            this.TB_Category.HideSelection = true;
            this.TB_Category.IconLeft = null;
            this.TB_Category.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Category.IconPadding = 10;
            this.TB_Category.IconRight = null;
            this.TB_Category.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Category.Lines = new string[0];
            this.TB_Category.Location = new System.Drawing.Point(688, 110);
            this.TB_Category.MaxLength = 32767;
            this.TB_Category.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_Category.Modified = false;
            this.TB_Category.Multiline = false;
            this.TB_Category.Name = "TB_Category";
            stateProperties53.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties53.FillColor = System.Drawing.Color.Empty;
            stateProperties53.ForeColor = System.Drawing.Color.Empty;
            stateProperties53.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_Category.OnActiveState = stateProperties53;
            stateProperties54.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties54.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties54.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TB_Category.OnDisabledState = stateProperties54;
            stateProperties55.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties55.FillColor = System.Drawing.Color.Empty;
            stateProperties55.ForeColor = System.Drawing.Color.Empty;
            stateProperties55.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_Category.OnHoverState = stateProperties55;
            stateProperties56.BorderColor = System.Drawing.Color.Silver;
            stateProperties56.FillColor = System.Drawing.Color.White;
            stateProperties56.ForeColor = System.Drawing.Color.Empty;
            stateProperties56.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_Category.OnIdleState = stateProperties56;
            this.TB_Category.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Category.PasswordChar = '\0';
            this.TB_Category.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TB_Category.PlaceholderText = "Category";
            this.TB_Category.ReadOnly = false;
            this.TB_Category.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_Category.SelectedText = "";
            this.TB_Category.SelectionLength = 0;
            this.TB_Category.SelectionStart = 0;
            this.TB_Category.ShortcutsEnabled = true;
            this.TB_Category.Size = new System.Drawing.Size(340, 37);
            this.TB_Category.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TB_Category.TabIndex = 1;
            this.TB_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TB_Category.TextMarginBottom = 0;
            this.TB_Category.TextMarginLeft = 3;
            this.TB_Category.TextMarginTop = 0;
            this.TB_Category.TextPlaceholder = "Category";
            this.TB_Category.UseSystemPasswordChar = false;
            this.TB_Category.WordWrap = true;
            // 
            // TB_CateDesc
            // 
            this.TB_CateDesc.AcceptsReturn = false;
            this.TB_CateDesc.AcceptsTab = false;
            this.TB_CateDesc.AnimationSpeed = 200;
            this.TB_CateDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TB_CateDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TB_CateDesc.BackColor = System.Drawing.Color.Transparent;
            this.TB_CateDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TB_CateDesc.BackgroundImage")));
            this.TB_CateDesc.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TB_CateDesc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TB_CateDesc.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TB_CateDesc.BorderColorIdle = System.Drawing.Color.Silver;
            this.TB_CateDesc.BorderRadius = 1;
            this.TB_CateDesc.BorderThickness = 1;
            this.TB_CateDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TB_CateDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_CateDesc.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TB_CateDesc.DefaultText = "";
            this.TB_CateDesc.FillColor = System.Drawing.Color.White;
            this.TB_CateDesc.HideSelection = true;
            this.TB_CateDesc.IconLeft = null;
            this.TB_CateDesc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_CateDesc.IconPadding = 10;
            this.TB_CateDesc.IconRight = null;
            this.TB_CateDesc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_CateDesc.Lines = new string[0];
            this.TB_CateDesc.Location = new System.Drawing.Point(688, 203);
            this.TB_CateDesc.MaxLength = 32767;
            this.TB_CateDesc.MinimumSize = new System.Drawing.Size(1, 1);
            this.TB_CateDesc.Modified = false;
            this.TB_CateDesc.Multiline = true;
            this.TB_CateDesc.Name = "TB_CateDesc";
            stateProperties57.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties57.FillColor = System.Drawing.Color.Empty;
            stateProperties57.ForeColor = System.Drawing.Color.Empty;
            stateProperties57.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_CateDesc.OnActiveState = stateProperties57;
            stateProperties58.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties58.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties58.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TB_CateDesc.OnDisabledState = stateProperties58;
            stateProperties59.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties59.FillColor = System.Drawing.Color.Empty;
            stateProperties59.ForeColor = System.Drawing.Color.Empty;
            stateProperties59.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_CateDesc.OnHoverState = stateProperties59;
            stateProperties60.BorderColor = System.Drawing.Color.Silver;
            stateProperties60.FillColor = System.Drawing.Color.White;
            stateProperties60.ForeColor = System.Drawing.Color.Empty;
            stateProperties60.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TB_CateDesc.OnIdleState = stateProperties60;
            this.TB_CateDesc.Padding = new System.Windows.Forms.Padding(3);
            this.TB_CateDesc.PasswordChar = '\0';
            this.TB_CateDesc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TB_CateDesc.PlaceholderText = "Category Descripton";
            this.TB_CateDesc.ReadOnly = false;
            this.TB_CateDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_CateDesc.SelectedText = "";
            this.TB_CateDesc.SelectionLength = 0;
            this.TB_CateDesc.SelectionStart = 0;
            this.TB_CateDesc.ShortcutsEnabled = true;
            this.TB_CateDesc.Size = new System.Drawing.Size(340, 123);
            this.TB_CateDesc.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TB_CateDesc.TabIndex = 2;
            this.TB_CateDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TB_CateDesc.TextMarginBottom = 0;
            this.TB_CateDesc.TextMarginLeft = 3;
            this.TB_CateDesc.TextMarginTop = 0;
            this.TB_CateDesc.TextPlaceholder = "Category Descripton";
            this.TB_CateDesc.UseSystemPasswordChar = false;
            this.TB_CateDesc.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(688, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(688, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripton";
            // 
            // Btn_Add
            // 
            this.Btn_Add.ActiveBorderThickness = 1;
            this.Btn_Add.ActiveCornerRadius = 20;
            this.Btn_Add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Add.BackgroundImage")));
            this.Btn_Add.ButtonText = "ADD";
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.IdleBorderThickness = 1;
            this.Btn_Add.IdleCornerRadius = 20;
            this.Btn_Add.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.Btn_Add.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Add.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.Btn_Add.Location = new System.Drawing.Point(739, 409);
            this.Btn_Add.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(234, 51);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.AllowAnimations = true;
            this.Btn_Clear.AllowMouseEffects = true;
            this.Btn_Clear.AllowToggling = false;
            this.Btn_Clear.AnimationSpeed = 200;
            this.Btn_Clear.AutoGenerateColors = false;
            this.Btn_Clear.AutoRoundBorders = false;
            this.Btn_Clear.AutoSizeLeftIcon = true;
            this.Btn_Clear.AutoSizeRightIcon = true;
            this.Btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Clear.BackColor1 = System.Drawing.Color.Red;
            this.Btn_Clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.BackgroundImage")));
            this.Btn_Clear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Clear.ButtonText = "Clear";
            this.Btn_Clear.ButtonTextMarginLeft = 0;
            this.Btn_Clear.ColorContrastOnClick = 45;
            this.Btn_Clear.ColorContrastOnHover = 45;
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Btn_Clear.CustomizableEdges = borderEdges5;
            this.Btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Clear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Clear.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Clear.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Clear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Clear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Clear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn_Clear.IconMarginLeft = 11;
            this.Btn_Clear.IconPadding = 10;
            this.Btn_Clear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Clear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Clear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn_Clear.IconSize = 25;
            this.Btn_Clear.IdleBorderColor = System.Drawing.Color.Red;
            this.Btn_Clear.IdleBorderRadius = 1;
            this.Btn_Clear.IdleBorderThickness = 1;
            this.Btn_Clear.IdleFillColor = System.Drawing.Color.Red;
            this.Btn_Clear.IdleIconLeftImage = null;
            this.Btn_Clear.IdleIconRightImage = null;
            this.Btn_Clear.IndicateFocus = false;
            this.Btn_Clear.Location = new System.Drawing.Point(946, 332);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn_Clear.OnDisabledState.BorderRadius = 1;
            this.Btn_Clear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Clear.OnDisabledState.BorderThickness = 1;
            this.Btn_Clear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn_Clear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn_Clear.OnDisabledState.IconLeftImage = null;
            this.Btn_Clear.OnDisabledState.IconRightImage = null;
            this.Btn_Clear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Clear.onHoverState.BorderRadius = 1;
            this.Btn_Clear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Clear.onHoverState.BorderThickness = 1;
            this.Btn_Clear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Btn_Clear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.onHoverState.IconLeftImage = null;
            this.Btn_Clear.onHoverState.IconRightImage = null;
            this.Btn_Clear.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.Btn_Clear.OnIdleState.BorderRadius = 1;
            this.Btn_Clear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Clear.OnIdleState.BorderThickness = 1;
            this.Btn_Clear.OnIdleState.FillColor = System.Drawing.Color.Red;
            this.Btn_Clear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.OnIdleState.IconLeftImage = null;
            this.Btn_Clear.OnIdleState.IconRightImage = null;
            this.Btn_Clear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Clear.OnPressedState.BorderRadius = 1;
            this.Btn_Clear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn_Clear.OnPressedState.BorderThickness = 1;
            this.Btn_Clear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Btn_Clear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.OnPressedState.IconLeftImage = null;
            this.Btn_Clear.OnPressedState.IconRightImage = null;
            this.Btn_Clear.Size = new System.Drawing.Size(82, 28);
            this.Btn_Clear.TabIndex = 8;
            this.Btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Clear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Clear.TextMarginLeft = 0;
            this.Btn_Clear.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn_Clear.UseDefaultRadiusAndThickness = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.ActiveBorderThickness = 1;
            this.Btn_Update.ActiveCornerRadius = 20;
            this.Btn_Update.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Update.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Update.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Update.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Update.BackgroundImage")));
            this.Btn_Update.ButtonText = "UPDATE";
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Update.IdleBorderThickness = 1;
            this.Btn_Update.IdleCornerRadius = 20;
            this.Btn_Update.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.Btn_Update.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Update.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.Btn_Update.Location = new System.Drawing.Point(672, 470);
            this.Btn_Update.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(172, 51);
            this.Btn_Update.TabIndex = 9;
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.ActiveBorderThickness = 1;
            this.Btn_Delete.ActiveCornerRadius = 20;
            this.Btn_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.BackgroundImage")));
            this.Btn_Delete.ButtonText = "DELETE";
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Delete.IdleBorderThickness = 1;
            this.Btn_Delete.IdleCornerRadius = 20;
            this.Btn_Delete.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.Btn_Delete.IdleForecolor = System.Drawing.Color.White;
            this.Btn_Delete.IdleLineColor = System.Drawing.Color.DarkOrange;
            this.Btn_Delete.Location = new System.Drawing.Point(865, 470);
            this.Btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(172, 51);
            this.Btn_Delete.TabIndex = 10;
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // paintStoreDBDataSet
            // 
            this.paintStoreDBDataSet.DataSetName = "PaintStoreDBDataSet";
            this.paintStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoriesBindingSource
            // 
            this.tblCategoriesBindingSource.DataMember = "TblCategories";
            this.tblCategoriesBindingSource.DataSource = this.paintStoreDBDataSet;
            // 
            // tblCategoriesTableAdapter
            // 
            this.tblCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tblCategoriesDataSet
            // 
            this.tblCategoriesDataSet.DataSetName = "TblCategoriesDataSet";
            this.tblCategoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCategoriesBindingSource1
            // 
            this.tblCategoriesBindingSource1.DataMember = "TblCategories";
            this.tblCategoriesBindingSource1.DataSource = this.tblCategoriesDataSet;
            // 
            // tblCategoriesTableAdapter1
            // 
            this.tblCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 30.45685F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CateName";
            this.Column2.FillWeight = 134.7716F;
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CateDesc";
            this.Column3.FillWeight = 134.7716F;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // FmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 542);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CateDesc);
            this.Controls.Add(this.TB_Category);
            this.Controls.Add(this.panel1);
            this.Name = "FmCategories";
            this.Text = "Categories Management";
            this.Load += new System.EventHandler(this.FmCategories_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox TB_SearchCate;
        private Bunifu.UI.WinForms.BunifuTextBox TB_Category;
        private Bunifu.UI.WinForms.BunifuTextBox TB_CateDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Add;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn_Clear;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Update;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Delete;
        private PaintStoreDBDataSet paintStoreDBDataSet;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource;
        private PaintStoreDBDataSetTableAdapters.TblCategoriesTableAdapter tblCategoriesTableAdapter;
        private TblCategoriesDataSet tblCategoriesDataSet;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource1;
        private TblCategoriesDataSetTableAdapters.TblCategoriesTableAdapter tblCategoriesTableAdapter1;
        private Bunifu.UI.WinForms.BunifuDataGridView DGV_Cate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}