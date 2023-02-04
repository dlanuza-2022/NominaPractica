using SpreadsheetLight;
using System.Data;
namespace NominaPractica
{
    public partial class Form1 : Form
    {

        int contador = 1;
        const string pathFile = @"F:\DORIAN DATA\Programacion 2\Visual Studio Workspace\miLista.xlsx";

        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, lastName, post;
            int noInss;
            decimal hourlyWage;
            decimal overtime, regularHours;
            int tenure;

            decimal monthlyWage, overtimeWage, tenureWage;

            decimal totalRevenue;
            decimal employeeInss;
            decimal employeeIR;
            decimal totalDeductions;
            decimal netToGet;
            decimal managmentInss;
            decimal inatec;
            decimal vacations;
            decimal thirteenthMonth;


            if(String.IsNullOrEmpty(txtHourlyWage.Text) || String.IsNullOrEmpty(txtLastName.Text)  
                || String.IsNullOrEmpty(txtName.Text) ||  String.IsNullOrEmpty(txtNoInss.Text) || String.IsNullOrEmpty(txtOvertime.Text) 
                || String.IsNullOrEmpty(txtPost.Text) || String.IsNullOrEmpty(txtRegularHours.Text) || String.IsNullOrEmpty(txtTenure.Text) ) 
            {

                MessageBox.Show("Advertencia! Todas las celdas deben ser rellenadas.");


            }
            else
            {
                try
                {
                    noInss = Convert.ToInt32(txtNoInss.Text);
                    name = txtName.Text.ToString().Trim();
                    lastName = txtLastName.Text.ToString().Trim();

                    post = txtPost.Text.ToString().Trim();

                    hourlyWage = Convert.ToDecimal(txtHourlyWage.Text);
                    regularHours = Convert.ToDecimal(txtRegularHours.Text);
                    overtime = Convert.ToDecimal(txtRegularHours.Text);

                    tenure = Convert.ToInt32(txtTenure.Text);

                    monthlyWage = calcularSalarioMensual(hourlyWage, regularHours);

                    overtimeWage = calcularSalarioHorasExtras(monthlyWage, overtime);

                    tenureWage = Convert.ToDecimal(calcularSalarioAntiguedad(tenure));

                    totalRevenue = monthlyWage + overtimeWage + tenureWage;


                    employeeInss = calcularInssLaboral(totalRevenue);

                    employeeIR = calcularIR(totalRevenue, employeeInss);

                    totalDeductions = employeeIR + employeeInss;

                    netToGet = totalRevenue - totalDeductions;

                    managmentInss = calcularInssLaboral(totalRevenue);

                    inatec = calcularInatec(totalRevenue);

                    vacations = calcularVacaciones(monthlyWage);

                    thirteenthMonth = calcularTreceavoMes(monthlyWage);

                    string[] datos1 = new string[9];
                    datos1[0] = contador.ToString();
                    datos1[1] = noInss.ToString();
                    datos1[2] = name + " " + lastName;
                    datos1[3] = post;
                    datos1[4] = monthlyWage.ToString();
                    datos1[5] = overtime.ToString();
                    datos1[6] = overtimeWage.ToString();
                    datos1[7] = tenureWage.ToString();
                    datos1[8] = totalRevenue.ToString();
                    miTabla1.Rows.Add(datos1);





                    string[] datos2 = new string[9];
                    datos2[0] = contador.ToString();
                    datos2[1] = employeeInss.ToString();
                    datos2[2] = employeeIR.ToString();
                    datos2[3] = totalDeductions.ToString();
                    datos2[4] = netToGet.ToString();
                    datos2[5] = managmentInss.ToString();
                    datos2[6] = inatec.ToString();
                    datos2[7] = vacations.ToString();
                    datos2[8] = thirteenthMonth.ToString();        
                    miTabla2.Rows.Add(datos2);

                    contador++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show("Valide los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }






        }


        public void limpiarCeldas()
        {
            this.txtHourlyWage.Text = null;
            this.txtLastName.Text = null;
            this.txtName.Text = null;
            this.txtNoInss.Text = null;
            this.txtOvertime.Text = null;
            this.txtPost.Text = null;
            this.txtRegularHours.Text = null;
            this.txtTenure.Text = null;


        }

        public decimal calcularSalarioMensual(decimal wage, decimal regularHorus)
        {
            decimal monthlyWage = wage * regularHorus;

            return monthlyWage;
        }



        public decimal calcularSalarioHorasExtras(decimal monthlyWage, decimal overtime)
        {
            decimal factor = (360 / 12) * 8;

            decimal extraHourRate = (monthlyWage / factor) * 2;

            decimal overtimeWage = extraHourRate * overtime;

            return overtimeWage;

        }


        public decimal calcularInssLaboral(decimal totalRevenue)
        {
            decimal employeeInss, rate;

            rate = (decimal)0.07;
            employeeInss = totalRevenue * rate;

            return employeeInss;
        }




        public decimal calcularIR(decimal totalRevenue, decimal employeeInss) 
        {
            //deductible
            decimal taxableIncome;
            decimal yearlyWage;
            double aplicableRate;
            decimal yearlyWageWithoutDeductible;
            decimal baseTax;
            decimal anualIR;


            decimal salariosindeducible;

            decimal deductible;
            taxableIncome = totalRevenue - employeeInss;

            yearlyWage = taxableIncome * 12;


            if(yearlyWage >= 1 && yearlyWage <= 100000)
            {
             
                baseTax = 0;
                deductible = 0;
                aplicableRate = 0;

                salariosindeducible = yearlyWage - deductible;


                anualIR = (salariosindeducible * (decimal) aplicableRate) + baseTax;

                return anualIR / 12;


            }else if (yearlyWage >= 100001 && yearlyWage <= 200000)
            {
                
                baseTax = 0;
                deductible = 100000;
                aplicableRate = 0.15;

                salariosindeducible = yearlyWage - deductible;

                anualIR = (salariosindeducible * (decimal) aplicableRate) + baseTax;

                return anualIR / 12;



            }
            else if ( yearlyWage >= 200001 && yearlyWage <= 300000)
            {
                baseTax = 15000;
                deductible = 200000;
                aplicableRate = 0.20;

                salariosindeducible = yearlyWage - deductible;
                anualIR = (salariosindeducible * (decimal) aplicableRate) + baseTax;

                return anualIR / 12;

            }
            else if(yearlyWage >= 300001 && yearlyWage <= 500000)
            {
                baseTax = 45000;
                deductible = 300000;
                aplicableRate = 0.25;

                salariosindeducible = yearlyWage - deductible;
                anualIR = (salariosindeducible * (decimal) aplicableRate) + baseTax;

                return anualIR / 12;
            }
            else if (yearlyWage >= 500001)
            {
                
                baseTax = 45000;
                deductible = 500000;
                aplicableRate = 0.30;

                salariosindeducible = yearlyWage - deductible;

                anualIR = (salariosindeducible * (decimal) aplicableRate) + baseTax;

                return anualIR / 12;

            }
            else
            {
                return 0;
            }


        }



        public decimal calcularInssPatronal(decimal totalRevenue)
        {
            decimal managmentInss;
            managmentInss = totalRevenue * 0.225M;
            return managmentInss;
        }




        public decimal calcularInatec(decimal totalRevenue)
        {
            decimal inatec;
            inatec = totalRevenue * 0.02M;
            return inatec;
        }



        public decimal calcularTreceavoMes(decimal monthlyWage)
        {
            return monthlyWage * 0.08333M;
        }


        public decimal calcularVacaciones(decimal monthlyWage)
        {
            return monthlyWage * (1 / 12);
        }

        public decimal calcularSalarioAntiguedad(int tenure)
        {
            switch(tenure)
            {
                case 0:
                    return 0.0M;
                   
                case 1:
                    return 0.03M;
                   
                case 2:
                    return 0.05M;
                 
                case 3:
                    return 0.07M;
                 
                case 4:
                    return 0.09M;
               
                case 5:
                    return 0.10M;
                
                case 6:
                    return 0.11M;
                  
                case 7:
                    return 0.12M;
                  
                case 8:
                    return 0.13M;
              
                case 9:
                    return 0.14M;
                  
                case 10:
                    return 0.15M;
                 
                case 11:
                    return 0.155M;
                   
                case 12:
                    return 0.16M;
                 
                case 13:
                    return 0.165M;
                   
                case 14:
                    return 0.17M;
                   
                case 15:
                    return 0.175M;
                 
                case 16:
                    return 0.18M;
                   
                case 17:
                    return 0.185M; 


                case 18:
                    return 0.19M;
                  
                case 19:
                    return 0.195M;
                    
                case 20:
                    return 0.20M;
                  
                default:
                    return 0;
          


            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            limpiarCeldas();
            btnAdd.Enabled = true;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(txtRowsNumber);

            try
            {
                miTabla1.Rows.RemoveAt(row - 1);
                miTabla2.Rows.RemoveAt(row - 1);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ya no hay fila");

            }
            finally
            {
                txtRowsNumber.Text = null;
            }

        }

        private void btnCleanTable_Click(object sender, EventArgs e)
        {
            int fila = miTabla1.RowCount;

            for(int i = fila - 1; i >= 0; i--)
            {
                miTabla1.Rows.RemoveAt(i);
                miTabla2.Rows.RemoveAt(i);
            }

        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int fila = miTabla1.RowCount;

            decimal totalSalarioMensual = 0, totalIngresoHorasExtra = 0, totalIngresoAntiguedad = 0, totalIngresoTotal = 0,
                totalInssLaboral = 0, totalIR = 0, totalDeducciones = 0, totalNetoARecibir = 0, totalInssPatronal = 0, totalInatec = 0,
                totalVacaciones = 0, totalTreceavoMes = 0;

            for(int i = 0; i < fila; i++)
            {
                totalSalarioMensual += Convert.ToDecimal(miTabla1.Rows[i].Cells[4].Value);
                totalIngresoHorasExtra += Convert.ToDecimal(miTabla1.Rows[i].Cells[6].Value);
                totalIngresoAntiguedad += Convert.ToDecimal(miTabla1.Rows[i].Cells[7].Value);
                totalIngresoTotal += Convert.ToDecimal(miTabla1.Rows[i].Cells[8].Value);

                totalInssLaboral += Convert.ToDecimal(miTabla2.Rows[i].Cells[1].Value);
                totalIR += Convert.ToDecimal(miTabla2.Rows[i].Cells[2].Value);
                totalDeducciones += Convert.ToDecimal(miTabla2.Rows[i].Cells[3].Value);
                totalNetoARecibir += Convert.ToDecimal(miTabla2.Rows[i].Cells[4].Value);
                totalInssPatronal += Convert.ToDecimal(miTabla2.Rows[i].Cells[5].Value);
                totalInatec += Convert.ToDecimal(miTabla2.Rows[i].Cells[6].Value);
                totalVacaciones += Convert.ToDecimal(miTabla2.Rows[i].Cells[7].Value);
                totalTreceavoMes += Convert.ToDecimal(miTabla2.Rows[i].Cells[8].Value);

            }

            lbl_TotalSalarioMensual.Text = totalSalarioMensual.ToString();
            lbl_TotalHorasExtras.Text = totalIngresoHorasExtra.ToString();
            lbl_TotalAntiguedad.Text = totalIngresoAntiguedad.ToString();
            lbl_TotalIngresoTotal.Text = totalIngresoTotal.ToString();

            lbl_TotalInssLaboral.Text = totalInssLaboral.ToString();
            lbl_TotalIR.Text = totalIR.ToString();
            lbl_TotalDeducciones.Text = totalDeducciones.ToString();
            lbl_TotalNetoRecibir.Text = totalNetoARecibir.ToString();
            lbl_TotalInssPatronal.Text = totalInssLaboral.ToString();
            lbl_TotalInatec.Text = totalInatec.ToString();
            lbl_TotalVacaciones.Text = totalVacaciones.ToString();
            lbl_TreceavoMes.Text = totalTreceavoMes.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {

           /*Codigo para guardar*/
            SLDocument oSLDocument = new SLDocument();
            DataTable table = new DataTable();

            table.Columns.Add("No.",typeof(int));
            table.Columns.Add("No. Inss", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cargo", typeof(string));
            table.Columns.Add("Salario mensual", typeof(decimal));
            table.Columns.Add("Horas Extras", typeof(decimal));
            table.Columns.Add("Ingreso por horas extras", typeof(decimal));
            table.Columns.Add("Antigüedad", typeof(decimal));
            table.Columns.Add("Ingreso total", typeof(decimal));
            table.Columns.Add("Inss laboral", typeof(decimal));
            table.Columns.Add("IR", typeof(decimal));
            table.Columns.Add("Total deducciones", typeof(decimal));
            table.Columns.Add("Neto a recibir", typeof(decimal));
            table.Columns.Add("Inss patronal", typeof(decimal));
            table.Columns.Add("INATEC", typeof(decimal));
            table.Columns.Add("Vacaciones", typeof(decimal));
            table.Columns.Add("Treceavo mes", typeof(decimal));

            int fila = miTabla1.RowCount;

            for(int i = 0; i < fila; i++)
            {
                table.Rows.Add(Convert.ToInt32(miTabla1.Rows[i].Cells[0].Value) , Convert.ToInt32(miTabla1.Rows[i].Cells[1]),
                    Convert.ToString(miTabla1.Rows[i].Cells[2].Value), Convert.ToString(miTabla1.Rows[i].Cells[3]),
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[4]), Convert.ToDecimal(miTabla1.Rows[i].Cells[5]), 
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[6]), Convert.ToDecimal(miTabla1.Rows[i].Cells[7]), 
                    Convert.ToDecimal(miTabla1.Rows[i].Cells[8]), Convert.ToDecimal(miTabla2.Rows[i].Cells[1]),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[2]), Convert.ToDecimal(miTabla2.Rows[i].Cells[3]), 
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[4]), Convert.ToDecimal(miTabla2.Rows[i].Cells[5]),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[6]), Convert.ToDecimal(miTabla2.Rows[i].Cells[7]),
                    Convert.ToDecimal(miTabla2.Rows[i].Cells[8])
                    );


            }

            oSLDocument.ImportDataTable(1, 1, table, true);

            oSLDocument.SaveAs(pathFile);


        }

        private void button3_Click(object sender, EventArgs e)
        {
           // List < ObjetoaAgregar > = List = new List<ObjetoaAgregar>();
            int iRow = 2;
            SLDocument miArchivo = new SLDocument(pathFile);

            while (!string.IsNullOrEmpty(miArchivo.GetCellValueAsString(iRow, 1)))
            {
                int No, noInss;
                String nombre, cargo;
                decimal salarioMensual, horasExtras, ingresoHorasExtras, ingresoAntiguedad, ingresoTotal,
                    inssLaboral, IR, totalDeducciones, netoARecibir, inssPatronal, inatec, vacaciones,
                    treceavoMes;

                No = miArchivo.GetCellValueAsInt32(iRow, 1);
                noInss = miArchivo.GetCellValueAsInt32(iRow, 2);
                nombre = miArchivo.GetCellValueAsString(iRow, 3);
                cargo = miArchivo.GetCellValueAsString(iRow, 4);
                salarioMensual = miArchivo.GetCellValueAsDecimal(iRow, 5);
                horasExtras = miArchivo.GetCellValueAsDecimal(iRow, 6);
                ingresoHorasExtras = miArchivo.GetCellValueAsDecimal(iRow, 7);
                ingresoAntiguedad = miArchivo.GetCellValueAsDecimal(iRow, 8);
                ingresoTotal = miArchivo.GetCellValueAsDecimal(iRow, 9);
                inssLaboral = miArchivo.GetCellValueAsDecimal(iRow, 10);
                IR = miArchivo.GetCellValueAsDecimal(iRow, 11);
                totalDeducciones = miArchivo.GetCellValueAsDecimal(iRow, 12);
                netoARecibir = miArchivo.GetCellValueAsDecimal(iRow, 13);
                inssPatronal = miArchivo.GetCellValueAsDecimal(iRow, 14);
                inatec = miArchivo.GetCellValueAsDecimal(iRow, 15);
                vacaciones = miArchivo.GetCellValueAsDecimal(iRow, 16);
                treceavoMes = miArchivo.GetCellValueAsDecimal(iRow, 17);

                //List.add(objetoPersona);

                iRow++;
            }

            //miTabla1.DataSource = List;
            //miTabla2.DataSource = List;



            /*Se debe construir un objeto usando POO*/
        }
    }
}