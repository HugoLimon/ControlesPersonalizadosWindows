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
            inicializaCalendario();
        }

        #region Properties
        Color HoverColorButtoms = Color.White;
        [Description("Cambia el color de la barra superior"), Category("Style")]
        public Color backGroundColorBar
        {
            get { return panelBar.BackColor; }
            set { panelBar.BackColor = value; }
        }
        [Description("Cambia el color del título de barra superior"), Category("Style")]
        public Color foreColorBar
        {
            get { return lblCurrentDate.ForeColor; }
            set { lblCurrentDate.ForeColor = value; }
        }
        [Description("Cambia el color del año actual de barra superior"), Category("Style")]
        public Color foreColorYearBar
        {
            get { return lblYear.ForeColor; }
            set { lblYear.ForeColor = value; }
        }
        [Description("Cambia el color del borde"), Category("Style")]
        public Color borderColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Description("Cambia el color de los botones inferiores"), Category("Style")]
        public Color ForeColorActiveBottomButtoms
        {
            get { return btnOK.ForeColor; }
            set
            {
                btnOK.ForeColor = value;
                btnCancel.ForeColor = value;
            }
        }
        [Description("Cambia el color de los botones inferiores, cuando el maouse esta sobre los botones"), Category("Style")]
        public Color ForeColorHoverBottomButtoms
        {
            get { return HoverColorButtoms; }
            set
            {
                HoverColorButtoms = value;
                HoverColorButtoms = value;
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
        public EventHandler clickOK
        {
            set
            {
                btnOK.Click += value;
            }
        }
        [Description("Agrega un evento al boton de cancelar"), Category("Style")]
        public EventHandler clickCancel
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
        public bool BackToDay
        {
            get { return backToDay; }
            set
            {

                backToDay = value;
                lstDiasSeleccionados.Clear();
                inicializaCalendario();
            }
        }

        public List<DateTime> selectedDays
        {
            get { return lstDiasSeleccionados; }
        }
        #endregion

        private void inicializaCalendario()
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
                    if(FechaIterada.DayOfWeek.ToString().Substring(0,2) == obtenDiaDelaSemanaEspanol(j) || FechaIterada.DayOfWeek.ToString().Substring(0, 2) == obtenDiaDelaSemanaIngles(j))
                    {
                        DiaIterado = new Label();
                        DiaIterado.Tag = FechaIterada;
                        DiaIterado.TextAlign = ContentAlignment.MiddleCenter;
                        DiaIterado.Dock = DockStyle.Fill;
                        DiaIterado.ForeColor = Color.FromArgb(255, 80, 80, 80);
                        DiaIterado.Margin = new Padding(0, 0, 0, 0);
                        DiaIterado.Click += seleccionaDia;
                        DiaIterado.BackColor = Color.Transparent;
                        if (lstDiasSeleccionados.Contains(FechaIterada))
                        {
                            DiaIterado.BackColor = Color.FromArgb(255, 255, 167, 38);
                            DiaIterado.ForeColor = Color.White;
                        }
                        else if (FechaIterada.ToShortDateString() ==FechaActual.ToShortDateString() )
                        {
                            DiaIterado.BackColor = Color.FromArgb(200, 33,150,254);
                            DiaIterado.ForeColor = Color.White;
                        }else if(fechaCalendario.Month!=FechaIterada.Month)
                        {
                            DiaIterado.BackColor = Color.LightGray;
                            DiaIterado.ForeColor = Color.White;
                        }else if(FechaActual>FechaIterada)
                        {
                            DiaIterado.BackColor = Color.LightGray;
                            DiaIterado.ForeColor = Color.LightSlateGray;
                        }
                         
                        DiaIterado.Text = FechaIterada.Day.ToString();
                        tabDays.Controls.Add(DiaIterado, j, i);
                        FechaIterada=FechaIterada.AddDays(1);
                    }
                }
            }

        }
        public void limpiaCalendario()
        {

            lstDiasSeleccionados.Clear();
            DateTime FechaIterada;
            foreach (Control _c in tabDays.Controls)
            {
                FechaIterada = (DateTime)_c.Tag;
                if (FechaIterada.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    _c.BackColor = Color.FromArgb(200, 33, 150, 254);
                    _c.ForeColor = Color.White;
                }
                else if (fechaCalendario.Month != FechaIterada.Month)
                {
                    _c.BackColor = Color.LightGray;
                    _c.ForeColor = Color.White;
                }
                else if (DateTime.Now > FechaIterada)
                {
                    _c.BackColor = Color.LightGray;
                    _c.ForeColor = Color.LightSlateGray;
                }
                else
                {
                    _c.ForeColor = Color.FromArgb(255, 80, 80, 80);
                    _c.BackColor = Color.Transparent;
                }
            }
            tabDays.Refresh();

        }
        private void seleccionaDia(object obj, EventArgs e )
        {
            if(!multiDateSelecter)
                limpiaCalendario();
            Label diaSeleccionado = (Label)obj;
            DateTime tag = (DateTime)(diaSeleccionado.Tag);
            DateTime fechaActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (backToDay||fechaActual<=tag)
            {
                if (lstDiasSeleccionados.Contains(tag))
                {
                    lstDiasSeleccionados.Remove(tag);
                    if(DateTime.Now.Day == tag.Day)
                    {
                        diaSeleccionado.BackColor = Color.FromArgb(200, 33, 150, 254);
                        diaSeleccionado.ForeColor = Color.White;
                    }
                    else
                    {
                        if(fechaCalendario.Month<tag.Month)
                        {
                            diaSeleccionado.BackColor = Color.LightGray;
                            diaSeleccionado.ForeColor = Color.White;
                        }
                        else
                        {
                            diaSeleccionado.BackColor = Color.Transparent;
                            diaSeleccionado.ForeColor = Color.FromArgb(255, 80, 80, 80);
                        }
                        
                    }
                }
                else
                {
                    if(multiDateSelecter)
                    {
                        lstDiasSeleccionados.Add((DateTime)(diaSeleccionado.Tag));
                        diaSeleccionado.BackColor = Color.FromArgb(255, 255, 167, 38);
                        diaSeleccionado.ForeColor = Color.FromArgb(255, 80, 80, 80);
                    }
                    else
                    {
                        
                        lstDiasSeleccionados.Add((DateTime)(diaSeleccionado.Tag));
                        diaSeleccionado.BackColor = Color.FromArgb(255, 255, 167, 38);
                        diaSeleccionado.ForeColor = Color.FromArgb(255, 80, 80, 80);
                    }
                }
            }
        }
        private string obtenDiaDelaSemanaEspanol(int index)
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
        private string obtenDiaDelaSemanaIngles(int index)
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
        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.ForeColor = HoverColorButtoms;
        }
        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.ForeColor = Color.FromArgb(255 , 33, 150, 254);
        }
        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.ForeColor = HoverColorButtoms;
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.FromArgb(255, 33, 150, 254);
        }
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            
            fechaCalendario = fechaCalendario.AddMonths(1);
            inicializaCalendario();
            System.Globalization.DateTimeFormatInfo fechaFormat = new System.Globalization.DateTimeFormatInfo();
            lblMonthYear.Text = string.Format("{0} {1}", fechaFormat.GetMonthName(fechaCalendario.Month), fechaCalendario.Year);
        }
        private void btnBackMonth_Click(object sender, EventArgs e)
        {
            if(DateTime.Now<fechaCalendario || backToDay)
            {
                
                fechaCalendario = fechaCalendario.AddMonths(-1);
                inicializaCalendario();
                System.Globalization.DateTimeFormatInfo fechaFormat = new System.Globalization.DateTimeFormatInfo();
                lblMonthYear.Text = string.Format("{0} {1}", fechaFormat.GetMonthName(fechaCalendario.Month), fechaCalendario.Year);
            }
        }
        private void lblCurrentDate_Click(object sender, EventArgs e)
        {
            fechaCalendario = DateTime.Now;
            inicializaCalendario();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstDiasSeleccionados.Clear();
            inicializaCalendario();
        }

        private void btnBackMonth_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
