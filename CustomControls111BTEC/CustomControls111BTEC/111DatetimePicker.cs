using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls111BTEC
{
    public partial class _111DatetimePicker : UserControl
    {
        List<DateTime> lstDiasSeleccionados = new List<DateTime>();
        DateTime fechaCalendario = DateTime.Now;
        bool multiDateSelecter = true;
        bool backToDay = false;
        Delegate clickBtnOK;

        
        
        
        public _111DatetimePicker()
        {
            InitializeComponent();
            
            System.Globalization.DateTimeFormatInfo fechaFormat = new System.Globalization.DateTimeFormatInfo();
            lblMonthYear.Text = string.Format("{0} {1}", fechaFormat.GetMonthName(fechaCalendario.Month), fechaCalendario.Year);
            lblCurrentDate.Text = string.Format("{0}, {1} {2}", fechaCalendario.DayOfWeek.ToString().Substring(0, 3), fechaFormat.GetMonthName(fechaCalendario.Month).ToString().Substring(0, 3), fechaCalendario.Year);
            InicializaCalendario();
        }

        #region Properties
        Color backColorMesh = Color.WhiteSmoke;
        Color backColorToday = Color.FromArgb(255, 33, 150, 254);
        Color foreColorToday = Color.WhiteSmoke;
        Color backColorSelected = Color.FromArgb(255, 255, 167, 38);
        Color foreColorSelected = Color.WhiteSmoke;
        Color backColorPreviousDays = Color.LightGray;
        Color foreColorPreviousDays = Color.WhiteSmoke;
        Color backColorUnselected = Color.Transparent;
        Color foreColorUnselected = Color.Gray;
        Color backColorDiferentMonth = Color.Transparent;
        Color foreColorDiferentMonth = Color.Gray;

        Color foreColorActiveButtoms = Color.FromArgb (33, 150, 254);
        Color foreColorHoverButtoms = Color.White;


        #region Colores de malla
        [Description("Color de fondo de malla de días"), Category("Style")]
        public Color BackColorMesh
        {
            get { return backColorMesh; }
            set
            {
                backColorMesh = value;
                tabDays.BackColor = backColorMesh;
            }
        }
        [Description("Cambia el color del fondo del día actual"), Category("Style")]
        public Color BackColorToday
        {
            get { return backColorToday; }
            set { backColorToday = value; }
        }
        [Description("Cambia el color de la letra del día actual"), Category("Style")]
        public Color ForeColorToday
        {
            get { return foreColorToday; }
            set { foreColorToday = value; }
        }
        [Description("Cambia el color de fondo del día seleccionado"), Category("Style")]
        public Color BackColorSelected
        {
            get { return backColorSelected; }
            set { backColorSelected = value; }
        }
        [Description("Cambia el color de la letra del día seleccionado"), Category("Style")]
        public Color ForeColorSelected
        {
            get { return foreColorSelected; }
            set { foreColorSelected = value; }
        }
        [Description("Cambia el color de fondo de día anteriores"), Category("Style")]
        public Color BackColorPreviousDays
        {
            get { return backColorPreviousDays; }
            set { backColorPreviousDays = value; }
        }
        [Description("Cambia el color de la letra de día anteriores"), Category("Style")]
        public Color ForeColorPreviousDays
        {
            get { return foreColorPreviousDays; }
            set { foreColorPreviousDays = value; }
        }
        [Description("Cambia el color de fondo del día no seleccionado"), Category("Style")]
        public Color BackColorUnselected
        {
            get { return backColorUnselected; }
            set { backColorUnselected = value; }
        }
        [Description("Cambia el color de la letra del día no seleccionado"), Category("Style")]
        public Color ForeColorUnselected
        {
            get { return foreColorUnselected; }
            set { foreColorUnselected = value; }
        }
        [Description("Cambia el color de fondo de día de otro mes"), Category("Style")]
        public Color BackColorDiferentMonth
        {
            get { return backColorDiferentMonth; }
            set { backColorDiferentMonth = value; }
        }
        [Description("Cambia el color de la letra del día de otro mes"), Category("Style")]
        public Color ForeColorDiferentMonth
        {
            get { return foreColorDiferentMonth; }
            set { foreColorDiferentMonth = value; }
        }

        #endregion
        [Description("Cambia el color del texto de barra para cambiar de mes"), Category("Style")]
        public Color ForeColorTextMonthYear
        {
            get { return lblMonthYear.ForeColor; }
            set { lblMonthYear.ForeColor = value; }
        }
        [Description("Cambia el color de la barra superior"), Category("Style")]
        public Color backGroundColorBar
        {
            get { return panelBar.BackColor; }
            set { panelBar.BackColor = value; }
        }        
        [Description("Cambia el color del título de barra superior"), Category("Style")]
        public Color ForeColorBar
        {
            get { return lblCurrentDate.ForeColor; }
            set { lblCurrentDate.ForeColor = value; }
        }
        [Description("Cambia el color del año actual de barra superior"), Category("Style")]
        public Color ForeColorYearBar
        {
            get { return lblYear.ForeColor; }
            set { lblYear.ForeColor = value; }
        }
        [Description("Cambia el color del borde"), Category("Style")]
        public Color BorderColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Description("Cambia el color de los botones inferiores"), Category("Style")]
        public Color ForeColorActiveBottomButtoms
        {
            get { return foreColorActiveButtoms; }
            set
            {
                foreColorActiveButtoms = value;
                btnCancel.ForeColor = foreColorActiveButtoms;
            }
        }
        [Description("Cambia el color de los botones inferiores, cuando el maouse esta sobre los botones"), Category("Style")]
        public Color ForeColorHoverBottomButtoms
        {
            get { return foreColorHoverButtoms; }
            set
            {
                foreColorHoverButtoms = value;
                
            }
        }
        [Description("Permite seleccionar más de una fecha a la vez"), Category("Style")]
        public bool MultiDateSelecter
        {
            get { return multiDateSelecter; }
            set
            {
                multiDateSelecter = value;
            }
        }
        [Description("Agrega un evento al boton OK"), Category("Style")]
        public EventHandler ClickOK
        {
            set
            {
                btnOK.Click += value;
            }
        }
        [Description("Agrega un evento al boton de cancelar"), Category("Style")]
        public EventHandler ClickCancel
        {
            set
            {
                btnCancel.Click += value;
            }
        }
        [Description("Activa el panel para seleccionar la hora"), Category("Data")]
        public bool AllowTimePicker
        {
            get { return panelHora.Visible;  }
            set
            {

                panelHora.Visible = value;
                
            }
        }
        [Description("Valiable para seleccionar fechas anteriores al día actual"), Category("Data")]
        public bool AllowPreviousDays
        {
            get { return backToDay; }
            set
            {

                backToDay = value;
                lstDiasSeleccionados.Clear();
                InicializaCalendario();
            }
        }
        public List<DateTime> SelectedDays
        {
            get { return lstDiasSeleccionados; }
        }

        #endregion

        private void InicializaCalendario()
        {
            tabDays.Controls.Clear();
            DateTime FechaActual = DateTime.Now;
            string diaSemanaActual = DateTime.Now.DayOfWeek.ToString();
            DateTime FechaIterada = new DateTime(fechaCalendario.Year, fechaCalendario.Month, 1);

            Label DiaIterado;
            
            string str = FechaIterada.DayOfWeek.ToString().Substring(0, 2);
            for (int i=0; i < 6; i++) // Iteramos los renglones 6 semanas 
            {
                for(int j=0; j<7; j++) // Iteramos las columnas (Días de la semana)
                {
                    if(FechaIterada.DayOfWeek.ToString().Substring(0,2) == ObtenDiaDelaSemanaEspanol(j) || FechaIterada.DayOfWeek.ToString().Substring(0, 2) == ObtenDiaDelaSemanaIngles(j))
                    {
                        DiaIterado = new Label();
                        DiaIterado.Tag = FechaIterada;
                        DiaIterado.TextAlign = ContentAlignment.MiddleCenter;
                        DiaIterado.Dock = DockStyle.Fill;
                        DiaIterado.ForeColor = Color.FromArgb(255, 80, 80, 80);
                        DiaIterado.Margin = new Padding(1, 1, 1, 1);
                        DiaIterado.Click += SeleccionaDia;
                        DiaIterado.BackColor = Color.Transparent;

                        SetColorDays(DiaIterado);                     
                        DiaIterado.Text = FechaIterada.Day.ToString();
                        tabDays.Controls.Add(DiaIterado, j, i);
                        FechaIterada=FechaIterada.AddDays(1);
                    }
                }
            }

        }
        public void LimpiaCalendario()
        {

            lstDiasSeleccionados.Clear();
            DateTime FechaIterada;
            foreach (Control _c in tabDays.Controls)
            {
                SetColorDays(_c);                
            }
            tabDays.Refresh();

        }
        private void SeleccionaDia(object obj, EventArgs e )
        {
            if(!multiDateSelecter)
                LimpiaCalendario();
            Label diaSeleccionado = (Label)obj;
            DateTime tag = (DateTime)(diaSeleccionado.Tag);
            DateTime fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (backToDay||fechaActual<=tag)
            {
                if (lstDiasSeleccionados.Contains(tag))
                {
                    lstDiasSeleccionados.Remove(tag);
                    SetColorDays(diaSeleccionado);                  
                }
                else
                {
                    lstDiasSeleccionados.Add((DateTime)(diaSeleccionado.Tag));
                }
                SetColorDays(diaSeleccionado);
            }
        }       
        private void SetColorDays(Control _dia)
        {
            DateTime _dateControl=(DateTime)_dia.Tag;
            //dia seleccionado
            if (lstDiasSeleccionados.Contains(_dateControl))
            {
                _dia.BackColor = backColorSelected;
                _dia.ForeColor = foreColorSelected;
            } //Día actual 
            else if (_dateControl.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                _dia.BackColor = backColorToday;
                _dia.ForeColor = foreColorToday;
            } //Día diferente al mes actual
            else if (fechaCalendario.Month != _dateControl.Month)
            {
                _dia.BackColor = backColorDiferentMonth;
                _dia.ForeColor = foreColorDiferentMonth;
            }//Día del mes actual y anterior a la fecha del día actual
            else if (_dateControl< DateTime.Now)
            {
                _dia.BackColor = backColorPreviousDays;
                _dia.ForeColor = foreColorPreviousDays;
            }
            else //Sin selección
            {
                _dia.BackColor = backColorUnselected;
                _dia.ForeColor = foreColorUnselected;
            }
        }
        
        private void BtnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.ForeColor = foreColorHoverButtoms;
        }
        private void BtnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.ForeColor = foreColorActiveButtoms;
        }
        private void BtnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.ForeColor = foreColorHoverButtoms;
        }
        private void BtnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = foreColorActiveButtoms;
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            
            fechaCalendario = fechaCalendario.AddMonths(1);
            InicializaCalendario();
            System.Globalization.DateTimeFormatInfo fechaFormat = new System.Globalization.DateTimeFormatInfo();
            lblMonthYear.Text = string.Format("{0} {1}", fechaFormat.GetMonthName(fechaCalendario.Month), fechaCalendario.Year);
        }
        private void BtnBackMonth_Click(object sender, EventArgs e)
        {
            if(DateTime.Now<fechaCalendario || backToDay)
            {
                
                fechaCalendario = fechaCalendario.AddMonths(-1);
                InicializaCalendario();
                System.Globalization.DateTimeFormatInfo fechaFormat = new System.Globalization.DateTimeFormatInfo();
                lblMonthYear.Text = string.Format("{0} {1}", fechaFormat.GetMonthName(fechaCalendario.Month), fechaCalendario.Year);
            }
        }
        private void LblCurrentDate_Click(object sender, EventArgs e)
        {
            fechaCalendario = DateTime.Now;
            InicializaCalendario();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            lstDiasSeleccionados.Clear();
            InicializaCalendario();
        }

        private string ObtenDiaDelaSemanaEspanol(int index)
        {
            switch (index)
            {
                case 0: return "Lu";

                case 1: return "Ma";

                case 2:
                    return "Mi";

                case 3:
                    return "Ju";

                case 4:
                    return "Vi";

                case 5:
                    return "Sa";

                default:
                    return "Do";
            }
        }
        private string ObtenDiaDelaSemanaIngles(int index)
        {
            switch (index)
            {
                case 0: return "Mo";

                case 1: return "Tu";

                case 2:
                    return "We";

                case 3:
                    return "Th";

                case 4:
                    return "Fr";

                case 5:
                    return "Sa";

                default:
                    return "Su";
            }
        }

    }
}
