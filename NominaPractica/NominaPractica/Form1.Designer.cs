namespace NominaPractica
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
            this.miTabla1 = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNoInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRevenueOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miTabla2 = new System.Windows.Forms.DataGridView();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmployeeInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNetToGet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnManagmentInss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnINATEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVacations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column13thMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNoInss = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblTenure = new System.Windows.Forms.Label();
            this.txtNoInss = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtHourlyWage = new System.Windows.Forms.TextBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.txtTenure = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegularHours = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotalSalarioMensual = new System.Windows.Forms.Label();
            this.lblTotalIngresoHorasExtras = new System.Windows.Forms.Label();
            this.lblTotalIngresoTotal = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnCleanTable = new System.Windows.Forms.Button();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTotalInssLaboral = new System.Windows.Forms.Label();
            this.lblTotalIR = new System.Windows.Forms.Label();
            this.lblTotalDeducciones = new System.Windows.Forms.Label();
            this.lblTotalNetoRecibir = new System.Windows.Forms.Label();
            this.lblTotalInssPatronal = new System.Windows.Forms.Label();
            this.lblTotalINATEC = new System.Windows.Forms.Label();
            this.lblTotalVacaciones = new System.Windows.Forms.Label();
            this.lblTotalTreceavoMes = new System.Windows.Forms.Label();
            this.lbl_TotalSalarioMensual = new System.Windows.Forms.Label();
            this.lblIngresoAntiguedad = new System.Windows.Forms.Label();
            this.lbl_TotalHorasExtras = new System.Windows.Forms.Label();
            this.lbl_TotalAntiguedad = new System.Windows.Forms.Label();
            this.lbl_TotalIngresoTotal = new System.Windows.Forms.Label();
            this.lbl_TotalInssLaboral = new System.Windows.Forms.Label();
            this.lbl_TotalIR = new System.Windows.Forms.Label();
            this.lbl_TotalDeducciones = new System.Windows.Forms.Label();
            this.lbl_TotalNetoRecibir = new System.Windows.Forms.Label();
            this.lbl_TotalInssPatronal = new System.Windows.Forms.Label();
            this.lbl_TotalInatec = new System.Windows.Forms.Label();
            this.lbl_TotalVacaciones = new System.Windows.Forms.Label();
            this.lbl_TreceavoMes = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtRowsNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // miTabla1
            // 
            this.miTabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnNoInss,
            this.columnNombre,
            this.columnJob,
            this.columnSalary,
            this.columnOvertime,
            this.columnRevenueOvertime,
            this.columnTenure,
            this.columnTotalRevenue});
            this.miTabla1.Location = new System.Drawing.Point(27, 171);
            this.miTabla1.Name = "miTabla1";
            this.miTabla1.RowTemplate.Height = 25;
            this.miTabla1.Size = new System.Drawing.Size(942, 237);
            this.miTabla1.TabIndex = 0;
            // 
            // columnNumber
            // 
            this.columnNumber.Frozen = true;
            this.columnNumber.HeaderText = "No.";
            this.columnNumber.Name = "columnNumber";
            // 
            // columnNoInss
            // 
            this.columnNoInss.Frozen = true;
            this.columnNoInss.HeaderText = "No. Inss";
            this.columnNoInss.Name = "columnNoInss";
            // 
            // columnNombre
            // 
            this.columnNombre.Frozen = true;
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            // 
            // columnJob
            // 
            this.columnJob.Frozen = true;
            this.columnJob.HeaderText = "Cargo";
            this.columnJob.Name = "columnJob";
            // 
            // columnSalary
            // 
            this.columnSalary.Frozen = true;
            this.columnSalary.HeaderText = "Salario mensual";
            this.columnSalary.Name = "columnSalary";
            // 
            // columnOvertime
            // 
            this.columnOvertime.Frozen = true;
            this.columnOvertime.HeaderText = "Horas extras";
            this.columnOvertime.Name = "columnOvertime";
            // 
            // columnRevenueOvertime
            // 
            this.columnRevenueOvertime.Frozen = true;
            this.columnRevenueOvertime.HeaderText = "Ingreso por horas extras";
            this.columnRevenueOvertime.Name = "columnRevenueOvertime";
            // 
            // columnTenure
            // 
            this.columnTenure.Frozen = true;
            this.columnTenure.HeaderText = "Antigüedad";
            this.columnTenure.Name = "columnTenure";
            // 
            // columnTotalRevenue
            // 
            this.columnTotalRevenue.Frozen = true;
            this.columnTotalRevenue.HeaderText = "Ingreso total";
            this.columnTotalRevenue.Name = "columnTotalRevenue";
            // 
            // miTabla2
            // 
            this.miTabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miTabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNo,
            this.columnEmployeeInss,
            this.columnIR,
            this.columnTotalDeduction,
            this.columnNetToGet,
            this.columnManagmentInss,
            this.columnINATEC,
            this.columnVacations,
            this.column13thMonth});
            this.miTabla2.Location = new System.Drawing.Point(27, 403);
            this.miTabla2.Name = "miTabla2";
            this.miTabla2.RowTemplate.Height = 25;
            this.miTabla2.Size = new System.Drawing.Size(942, 252);
            this.miTabla2.TabIndex = 1;
            // 
            // columnNo
            // 
            this.columnNo.Frozen = true;
            this.columnNo.HeaderText = "No.";
            this.columnNo.Name = "columnNo";
            // 
            // columnEmployeeInss
            // 
            this.columnEmployeeInss.Frozen = true;
            this.columnEmployeeInss.HeaderText = "Inss Laboral";
            this.columnEmployeeInss.Name = "columnEmployeeInss";
            // 
            // columnIR
            // 
            this.columnIR.Frozen = true;
            this.columnIR.HeaderText = "IR";
            this.columnIR.Name = "columnIR";
            // 
            // columnTotalDeduction
            // 
            this.columnTotalDeduction.Frozen = true;
            this.columnTotalDeduction.HeaderText = "Total deducciones";
            this.columnTotalDeduction.Name = "columnTotalDeduction";
            // 
            // columnNetToGet
            // 
            this.columnNetToGet.Frozen = true;
            this.columnNetToGet.HeaderText = "Neto a recibir";
            this.columnNetToGet.Name = "columnNetToGet";
            // 
            // columnManagmentInss
            // 
            this.columnManagmentInss.Frozen = true;
            this.columnManagmentInss.HeaderText = "Inss patronal";
            this.columnManagmentInss.Name = "columnManagmentInss";
            // 
            // columnINATEC
            // 
            this.columnINATEC.Frozen = true;
            this.columnINATEC.HeaderText = "INATEC";
            this.columnINATEC.Name = "columnINATEC";
            // 
            // columnVacations
            // 
            this.columnVacations.Frozen = true;
            this.columnVacations.HeaderText = "Vacaciones";
            this.columnVacations.Name = "columnVacations";
            // 
            // column13thMonth
            // 
            this.column13thMonth.Frozen = true;
            this.column13thMonth.HeaderText = "Treceavo mes";
            this.column13thMonth.Name = "column13thMonth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(47, 105);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido:";
            // 
            // lblNoInss
            // 
            this.lblNoInss.AutoSize = true;
            this.lblNoInss.Location = new System.Drawing.Point(47, 27);
            this.lblNoInss.Name = "lblNoInss";
            this.lblNoInss.Size = new System.Drawing.Size(49, 15);
            this.lblNoInss.TabIndex = 4;
            this.lblNoInss.Text = "No. Inss";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(47, 145);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 15);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Cargo:";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(314, 24);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(93, 15);
            this.lblHourlyWage.TabIndex = 6;
            this.lblHourlyWage.Text = "Salario por hora:";
            // 
            // lblOvertime
            // 
            this.lblOvertime.AutoSize = true;
            this.lblOvertime.Location = new System.Drawing.Point(315, 101);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(70, 15);
            this.lblOvertime.TabIndex = 7;
            this.lblOvertime.Text = "Horas extra:\r\n";
            // 
            // lblTenure
            // 
            this.lblTenure.AutoSize = true;
            this.lblTenure.Location = new System.Drawing.Point(309, 134);
            this.lblTenure.Name = "lblTenure";
            this.lblTenure.Size = new System.Drawing.Size(72, 15);
            this.lblTenure.TabIndex = 8;
            this.lblTenure.Text = "Antiguedad:";
            // 
            // txtNoInss
            // 
            this.txtNoInss.Location = new System.Drawing.Point(107, 24);
            this.txtNoInss.Name = "txtNoInss";
            this.txtNoInss.Size = new System.Drawing.Size(174, 23);
            this.txtNoInss.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 23);
            this.txtName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 23);
            this.txtLastName.TabIndex = 11;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(107, 142);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(174, 23);
            this.txtPost.TabIndex = 12;
            // 
            // txtHourlyWage
            // 
            this.txtHourlyWage.Location = new System.Drawing.Point(411, 23);
            this.txtHourlyWage.Name = "txtHourlyWage";
            this.txtHourlyWage.Size = new System.Drawing.Size(143, 23);
            this.txtHourlyWage.TabIndex = 13;
            // 
            // txtOvertime
            // 
            this.txtOvertime.Location = new System.Drawing.Point(411, 96);
            this.txtOvertime.Name = "txtOvertime";
            this.txtOvertime.Size = new System.Drawing.Size(143, 23);
            this.txtOvertime.TabIndex = 14;
            // 
            // txtTenure
            // 
            this.txtTenure.Location = new System.Drawing.Point(411, 131);
            this.txtTenure.Name = "txtTenure";
            this.txtTenure.Size = new System.Drawing.Size(143, 23);
            this.txtTenure.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Horas regulares:";
            // 
            // txtRegularHours
            // 
            this.txtRegularHours.Location = new System.Drawing.Point(411, 57);
            this.txtRegularHours.Name = "txtRegularHours";
            this.txtRegularHours.Size = new System.Drawing.Size(143, 23);
            this.txtRegularHours.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 26);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalSalarioMensual
            // 
            this.lblTotalSalarioMensual.AutoSize = true;
            this.lblTotalSalarioMensual.Location = new System.Drawing.Point(27, 671);
            this.lblTotalSalarioMensual.Name = "lblTotalSalarioMensual";
            this.lblTotalSalarioMensual.Size = new System.Drawing.Size(121, 15);
            this.lblTotalSalarioMensual.TabIndex = 19;
            this.lblTotalSalarioMensual.Text = "Total Salario mensual:";
            // 
            // lblTotalIngresoHorasExtras
            // 
            this.lblTotalIngresoHorasExtras.AutoSize = true;
            this.lblTotalIngresoHorasExtras.Location = new System.Drawing.Point(27, 697);
            this.lblTotalIngresoHorasExtras.Name = "lblTotalIngresoHorasExtras";
            this.lblTotalIngresoHorasExtras.Size = new System.Drawing.Size(164, 15);
            this.lblTotalIngresoHorasExtras.TabIndex = 20;
            this.lblTotalIngresoHorasExtras.Text = "Total Ingreso por horas extras:";
            // 
            // lblTotalIngresoTotal
            // 
            this.lblTotalIngresoTotal.AutoSize = true;
            this.lblTotalIngresoTotal.Location = new System.Drawing.Point(281, 671);
            this.lblTotalIngresoTotal.Name = "lblTotalIngresoTotal";
            this.lblTotalIngresoTotal.Size = new System.Drawing.Size(104, 15);
            this.lblTotalIngresoTotal.TabIndex = 21;
            this.lblTotalIngresoTotal.Text = "Total Ingreso total:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(579, 53);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(127, 27);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(579, 90);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(80, 26);
            this.btnDeleteRow.TabIndex = 23;
            this.btnDeleteRow.Text = "Eliminar fila";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnCleanTable
            // 
            this.btnCleanTable.Location = new System.Drawing.Point(579, 124);
            this.btnCleanTable.Name = "btnCleanTable";
            this.btnCleanTable.Size = new System.Drawing.Size(127, 25);
            this.btnCleanTable.TabIndex = 24;
            this.btnCleanTable.Text = "Eliminar tabla";
            this.btnCleanTable.UseVisualStyleBackColor = true;
            this.btnCleanTable.Click += new System.EventHandler(this.btnCleanTable_Click);
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(733, 22);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(110, 25);
            this.btnCalculateTotal.TabIndex = 25;
            this.btnCalculateTotal.Text = "Calcular totales";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 26);
            this.button2.TabIndex = 26;
            this.button2.Text = "Guardar en Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(733, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 27);
            this.button3.TabIndex = 27;
            this.button3.Text = "Cargar tabla de Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotalInssLaboral
            // 
            this.lblTotalInssLaboral.AutoSize = true;
            this.lblTotalInssLaboral.Location = new System.Drawing.Point(281, 697);
            this.lblTotalInssLaboral.Name = "lblTotalInssLaboral";
            this.lblTotalInssLaboral.Size = new System.Drawing.Size(100, 15);
            this.lblTotalInssLaboral.TabIndex = 28;
            this.lblTotalInssLaboral.Text = "Total Inss Laboral:";
            // 
            // lblTotalIR
            // 
            this.lblTotalIR.AutoSize = true;
            this.lblTotalIR.Location = new System.Drawing.Point(281, 725);
            this.lblTotalIR.Name = "lblTotalIR";
            this.lblTotalIR.Size = new System.Drawing.Size(48, 15);
            this.lblTotalIR.TabIndex = 29;
            this.lblTotalIR.Text = "Total IR:";
            // 
            // lblTotalDeducciones
            // 
            this.lblTotalDeducciones.AutoSize = true;
            this.lblTotalDeducciones.Location = new System.Drawing.Point(518, 671);
            this.lblTotalDeducciones.Name = "lblTotalDeducciones";
            this.lblTotalDeducciones.Size = new System.Drawing.Size(133, 15);
            this.lblTotalDeducciones.TabIndex = 30;
            this.lblTotalDeducciones.Text = "Total Total deducciones:";
            // 
            // lblTotalNetoRecibir
            // 
            this.lblTotalNetoRecibir.AutoSize = true;
            this.lblTotalNetoRecibir.Location = new System.Drawing.Point(518, 697);
            this.lblTotalNetoRecibir.Name = "lblTotalNetoRecibir";
            this.lblTotalNetoRecibir.Size = new System.Drawing.Size(112, 15);
            this.lblTotalNetoRecibir.TabIndex = 31;
            this.lblTotalNetoRecibir.Text = "Total Neto a Recibir:";
            // 
            // lblTotalInssPatronal
            // 
            this.lblTotalInssPatronal.AutoSize = true;
            this.lblTotalInssPatronal.Location = new System.Drawing.Point(518, 725);
            this.lblTotalInssPatronal.Name = "lblTotalInssPatronal";
            this.lblTotalInssPatronal.Size = new System.Drawing.Size(105, 15);
            this.lblTotalInssPatronal.TabIndex = 32;
            this.lblTotalInssPatronal.Text = "Total Inss patronal:";
            // 
            // lblTotalINATEC
            // 
            this.lblTotalINATEC.AutoSize = true;
            this.lblTotalINATEC.Location = new System.Drawing.Point(738, 671);
            this.lblTotalINATEC.Name = "lblTotalINATEC";
            this.lblTotalINATEC.Size = new System.Drawing.Size(77, 15);
            this.lblTotalINATEC.TabIndex = 33;
            this.lblTotalINATEC.Text = "Total INATEC:";
            // 
            // lblTotalVacaciones
            // 
            this.lblTotalVacaciones.AutoSize = true;
            this.lblTotalVacaciones.Location = new System.Drawing.Point(738, 697);
            this.lblTotalVacaciones.Name = "lblTotalVacaciones";
            this.lblTotalVacaciones.Size = new System.Drawing.Size(96, 15);
            this.lblTotalVacaciones.TabIndex = 34;
            this.lblTotalVacaciones.Text = "Total Vacaciones:";
            // 
            // lblTotalTreceavoMes
            // 
            this.lblTotalTreceavoMes.AutoSize = true;
            this.lblTotalTreceavoMes.Location = new System.Drawing.Point(738, 725);
            this.lblTotalTreceavoMes.Name = "lblTotalTreceavoMes";
            this.lblTotalTreceavoMes.Size = new System.Drawing.Size(109, 15);
            this.lblTotalTreceavoMes.TabIndex = 35;
            this.lblTotalTreceavoMes.Text = "Total Treceavo mes:";
            // 
            // lbl_TotalSalarioMensual
            // 
            this.lbl_TotalSalarioMensual.AutoSize = true;
            this.lbl_TotalSalarioMensual.Location = new System.Drawing.Point(169, 671);
            this.lbl_TotalSalarioMensual.Name = "lbl_TotalSalarioMensual";
            this.lbl_TotalSalarioMensual.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalSalarioMensual.TabIndex = 36;
            this.lbl_TotalSalarioMensual.Text = "label2";
            // 
            // lblIngresoAntiguedad
            // 
            this.lblIngresoAntiguedad.AutoSize = true;
            this.lblIngresoAntiguedad.Location = new System.Drawing.Point(27, 725);
            this.lblIngresoAntiguedad.Name = "lblIngresoAntiguedad";
            this.lblIngresoAntiguedad.Size = new System.Drawing.Size(161, 15);
            this.lblIngresoAntiguedad.TabIndex = 37;
            this.lblIngresoAntiguedad.Text = "Total Ingreso por antiguedad:";
            // 
            // lbl_TotalHorasExtras
            // 
            this.lbl_TotalHorasExtras.AutoSize = true;
            this.lbl_TotalHorasExtras.Location = new System.Drawing.Point(206, 697);
            this.lbl_TotalHorasExtras.Name = "lbl_TotalHorasExtras";
            this.lbl_TotalHorasExtras.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalHorasExtras.TabIndex = 38;
            this.lbl_TotalHorasExtras.Text = "label3";
            // 
            // lbl_TotalAntiguedad
            // 
            this.lbl_TotalAntiguedad.AutoSize = true;
            this.lbl_TotalAntiguedad.Location = new System.Drawing.Point(201, 726);
            this.lbl_TotalAntiguedad.Name = "lbl_TotalAntiguedad";
            this.lbl_TotalAntiguedad.Size = new System.Drawing.Size(44, 15);
            this.lbl_TotalAntiguedad.TabIndex = 39;
            this.lbl_TotalAntiguedad.Text = "label13";
            // 
            // lbl_TotalIngresoTotal
            // 
            this.lbl_TotalIngresoTotal.AutoSize = true;
            this.lbl_TotalIngresoTotal.Location = new System.Drawing.Point(400, 673);
            this.lbl_TotalIngresoTotal.Name = "lbl_TotalIngresoTotal";
            this.lbl_TotalIngresoTotal.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalIngresoTotal.TabIndex = 40;
            this.lbl_TotalIngresoTotal.Text = "label4";
            // 
            // lbl_TotalInssLaboral
            // 
            this.lbl_TotalInssLaboral.AutoSize = true;
            this.lbl_TotalInssLaboral.Location = new System.Drawing.Point(400, 697);
            this.lbl_TotalInssLaboral.Name = "lbl_TotalInssLaboral";
            this.lbl_TotalInssLaboral.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalInssLaboral.TabIndex = 41;
            this.lbl_TotalInssLaboral.Text = "label5";
            // 
            // lbl_TotalIR
            // 
            this.lbl_TotalIR.AutoSize = true;
            this.lbl_TotalIR.Location = new System.Drawing.Point(344, 722);
            this.lbl_TotalIR.Name = "lbl_TotalIR";
            this.lbl_TotalIR.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalIR.TabIndex = 42;
            this.lbl_TotalIR.Text = "label6";
            // 
            // lbl_TotalDeducciones
            // 
            this.lbl_TotalDeducciones.AutoSize = true;
            this.lbl_TotalDeducciones.Location = new System.Drawing.Point(658, 670);
            this.lbl_TotalDeducciones.Name = "lbl_TotalDeducciones";
            this.lbl_TotalDeducciones.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalDeducciones.TabIndex = 43;
            this.lbl_TotalDeducciones.Text = "label7";
            // 
            // lbl_TotalNetoRecibir
            // 
            this.lbl_TotalNetoRecibir.AutoSize = true;
            this.lbl_TotalNetoRecibir.Location = new System.Drawing.Point(635, 695);
            this.lbl_TotalNetoRecibir.Name = "lbl_TotalNetoRecibir";
            this.lbl_TotalNetoRecibir.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalNetoRecibir.TabIndex = 44;
            this.lbl_TotalNetoRecibir.Text = "label8";
            // 
            // lbl_TotalInssPatronal
            // 
            this.lbl_TotalInssPatronal.AutoSize = true;
            this.lbl_TotalInssPatronal.Location = new System.Drawing.Point(636, 730);
            this.lbl_TotalInssPatronal.Name = "lbl_TotalInssPatronal";
            this.lbl_TotalInssPatronal.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalInssPatronal.TabIndex = 45;
            this.lbl_TotalInssPatronal.Text = "label9";
            // 
            // lbl_TotalInatec
            // 
            this.lbl_TotalInatec.AutoSize = true;
            this.lbl_TotalInatec.Location = new System.Drawing.Point(828, 670);
            this.lbl_TotalInatec.Name = "lbl_TotalInatec";
            this.lbl_TotalInatec.Size = new System.Drawing.Size(44, 15);
            this.lbl_TotalInatec.TabIndex = 46;
            this.lbl_TotalInatec.Text = "label10";
            // 
            // lbl_TotalVacaciones
            // 
            this.lbl_TotalVacaciones.AutoSize = true;
            this.lbl_TotalVacaciones.Location = new System.Drawing.Point(842, 698);
            this.lbl_TotalVacaciones.Name = "lbl_TotalVacaciones";
            this.lbl_TotalVacaciones.Size = new System.Drawing.Size(44, 15);
            this.lbl_TotalVacaciones.TabIndex = 47;
            this.lbl_TotalVacaciones.Text = "label11";
            // 
            // lbl_TreceavoMes
            // 
            this.lbl_TreceavoMes.AutoSize = true;
            this.lbl_TreceavoMes.Location = new System.Drawing.Point(857, 727);
            this.lbl_TreceavoMes.Name = "lbl_TreceavoMes";
            this.lbl_TreceavoMes.Size = new System.Drawing.Size(44, 15);
            this.lbl_TreceavoMes.TabIndex = 48;
            this.lbl_TreceavoMes.Text = "label12";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(733, 140);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(62, 15);
            this.lblPath.TabIndex = 49;
            this.lblPath.Text = "Directorio:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(792, 137);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(177, 23);
            this.txtPath.TabIndex = 50;
            // 
            // txtRowsNumber
            // 
            this.txtRowsNumber.Location = new System.Drawing.Point(665, 90);
            this.txtRowsNumber.Name = "txtRowsNumber";
            this.txtRowsNumber.Size = new System.Drawing.Size(41, 23);
            this.txtRowsNumber.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 749);
            this.Controls.Add(this.txtRowsNumber);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lbl_TreceavoMes);
            this.Controls.Add(this.lbl_TotalVacaciones);
            this.Controls.Add(this.lbl_TotalInatec);
            this.Controls.Add(this.lbl_TotalInssPatronal);
            this.Controls.Add(this.lbl_TotalNetoRecibir);
            this.Controls.Add(this.lbl_TotalDeducciones);
            this.Controls.Add(this.lbl_TotalIR);
            this.Controls.Add(this.lbl_TotalInssLaboral);
            this.Controls.Add(this.lbl_TotalIngresoTotal);
            this.Controls.Add(this.lbl_TotalAntiguedad);
            this.Controls.Add(this.lbl_TotalHorasExtras);
            this.Controls.Add(this.lblIngresoAntiguedad);
            this.Controls.Add(this.lbl_TotalSalarioMensual);
            this.Controls.Add(this.lblTotalTreceavoMes);
            this.Controls.Add(this.lblTotalVacaciones);
            this.Controls.Add(this.lblTotalINATEC);
            this.Controls.Add(this.lblTotalInssPatronal);
            this.Controls.Add(this.lblTotalNetoRecibir);
            this.Controls.Add(this.lblTotalDeducciones);
            this.Controls.Add(this.lblTotalIR);
            this.Controls.Add(this.lblTotalInssLaboral);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculateTotal);
            this.Controls.Add(this.btnCleanTable);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblTotalIngresoTotal);
            this.Controls.Add(this.lblTotalIngresoHorasExtras);
            this.Controls.Add(this.lblTotalSalarioMensual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRegularHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenure);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.txtHourlyWage);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNoInss);
            this.Controls.Add(this.lblTenure);
            this.Controls.Add(this.lblOvertime);
            this.Controls.Add(this.lblHourlyWage);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblNoInss);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.miTabla2);
            this.Controls.Add(this.miTabla1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nomina Mensual";
            ((System.ComponentModel.ISupportInitialize)(this.miTabla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miTabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView miTabla1;
        private DataGridViewTextBoxColumn columnNumber;
        private DataGridViewTextBoxColumn columnNoInss;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnJob;
        private DataGridViewTextBoxColumn columnSalary;
        private DataGridViewTextBoxColumn columnOvertime;
        private DataGridViewTextBoxColumn columnRevenueOvertime;
        private DataGridViewTextBoxColumn columnTenure;
        private DataGridViewTextBoxColumn columnTotalRevenue;
        private DataGridView miTabla2;
        private DataGridViewTextBoxColumn columnNo;
        private DataGridViewTextBoxColumn columnEmployeeInss;
        private DataGridViewTextBoxColumn columnIR;
        private DataGridViewTextBoxColumn columnTotalDeduction;
        private DataGridViewTextBoxColumn columnNetToGet;
        private DataGridViewTextBoxColumn columnManagmentInss;
        private DataGridViewTextBoxColumn columnINATEC;
        private DataGridViewTextBoxColumn columnVacations;
        private DataGridViewTextBoxColumn column13thMonth;
        private Label lblName;
        private Label lblLastName;
        private Label lblNoInss;
        private Label lblJob;
        private Label lblHourlyWage;
        private Label lblOvertime;
        private Label lblTenure;
        private TextBox txtNoInss;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPost;
        private TextBox txtHourlyWage;
        private TextBox txtOvertime;
        private TextBox txtTenure;
        private Label label1;
        private TextBox txtRegularHours;
        private Button btnAdd;
        private Label lblTotalSalarioMensual;
        private Label lblTotalIngresoHorasExtras;
        private Label lblTotalIngresoTotal;
        private Button btnNew;
        private Button btnDeleteRow;
        private Button btnCleanTable;
        private Button btnCalculateTotal;
        private Button button2;
        private Button button3;
        private Label lblTotalInssLaboral;
        private Label lblTotalIR;
        private Label lblTotalDeducciones;
        private Label lblTotalNetoRecibir;
        private Label lblTotalInssPatronal;
        private Label lblTotalINATEC;
        private Label lblTotalVacaciones;
        private Label lblTotalTreceavoMes;
        private Label lbl_TotalSalarioMensual;
        private Label lblIngresoAntiguedad;
        private Label lbl_TotalHorasExtras;
        private Label lbl_TotalAntiguedad;
        private Label lbl_TotalIngresoTotal;
        private Label lbl_TotalInssLaboral;
        private Label lbl_TotalIR;
        private Label lbl_TotalDeducciones;
        private Label lbl_TotalNetoRecibir;
        private Label lbl_TotalInssPatronal;
        private Label lbl_TotalInatec;
        private Label lbl_TotalVacaciones;
        private Label lbl_TreceavoMes;
        private Label lblPath;
        private TextBox txtPath;
        private TextBox txtRowsNumber;
    }
}